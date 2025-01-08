using Bimser.CSP.FormControls.Api;
using Bimser.CSP.FormControls.Utils;
using Bimser.CSP.FormMigrator;
using Bimser.CSP.Migrator;
using Bimser.CSP.Workflow.Runtime.Extensions;
using Bimser.CSP.Workflow.Runtime.Services;
using Bimser.Framework.AspNetCore;
using Bimser.Framework.AspNetCore.Authentication;
using Bimser.Framework.Configuration;
using Bimser.Framework.Json;
using Bimser.Microservices.SystemConfigurationEntities;
using Bimser.Scheduler.Common;
using Bimser.Scheduler.Common.Extensions;
using Bimser.Scheduler.Common.Interfaces;
using Bimser.Scheduler.Service;
using Bimser.Synergy.Entities.Studio.Common;
using Bimser.Synergy.Entities.Workflow.Runtime.Options;
using DevExpress.AspNetCore;
using DevExpress.XtraReports.Web.Extensions;
using FluentMigrator.Runner;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using WorkflowCore.Interface;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;
using System.Collections.Generic;
using System.Linq;
using WorkflowCore.Primitives;

namespace FazlaMesaiSureciYK
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDevExpressControls();
            services.AddScoped<ReportStorageWebExtension, ReportStorageExtension>();
            services.AddSingleton<DevExpress.XtraReports.Web.WebDocumentViewer.IWebDocumentViewerExceptionHandler, CustomWebDocumentViewerExceptionHandler>();

            string mcsEnabledStr = Environment.GetEnvironmentVariable("MCS_ENABLED");
            if (string.IsNullOrWhiteSpace(mcsEnabledStr) || !(mcsEnabledStr.Equals("0") || mcsEnabledStr.Equals("false", StringComparison.InvariantCultureIgnoreCase)))
            {
                services.AddHostedService<MemoryControlService>();
            }

            services
                .AddSingleton(Configuration)
                .AddControllers(options =>
                {
                    options.AllowEmptyInputInBodyModelBinding = true;
                })
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.DateParseHandling = Newtonsoft.Json.DateParseHandling.DateTimeOffset;
                    options.SerializerSettings.Converters.Insert(0, new BimserDateTimeConverter());
                    options.SerializerSettings.Converters.Add(new DataFieldConverter());
                    options.SerializerSettings.ContractResolver = IgnorePropertyContractResolver.Instance.Value;
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.MaxDepth = 100;
                    options.SerializerSettings.Error = (object sender, ErrorEventArgs args) =>
                    {
                        Console.WriteLine(args.ErrorContext.Error.ToString());
                        throw new Bimser.Framework.BimserException(Bimser.Framework.Constants.ErrorCodes.FrameworkAspNetGeneralError, args.ErrorContext.Error.Message, args.ErrorContext.Error);
                    };
                });

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .SetIsOriginAllowed((host) => true)
                    );
            });

            // services.AddSwaggerGen(c =>
            // {
            //     c.SwaggerDoc("v1", new OpenApiInfo { Title = "Bimser.CSP.WebAPITemplate", Version = "v1" });
            // });
            // 
            // services.ConfigureSwaggerGen(options =>
            // {
            //     options.CustomSchemaIds(x => x.FullName);
            // });

            // workflow object registrations
            services
                .AddRuntimeOptions()
                .AddRuntimeCodingLayers()
                .AddRuntimeSteps()
                .AddRuntimeHelpers()
                .AddRepositories();

            // workflow engine registration
            services.AddWorkflow();

            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = BimserBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = BimserBearerDefaults.AuthenticationScheme;
                })
                .AddBimserBearer();

            services.AddScheduler();

            // build Service Provider
            return services.AddBimser<StartupModule>(options => { });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, IHostApplicationLifetime applicationLifetime)
        {
            app.UseBimser();
            app.UseDevExpressControls();
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.ExpressionsAdvanced;
            app.UseBimserWorkflow();

            //Scheduler default service
        app.UseScheduler((o) => o.Id = SchedulerHelper.GetDefaultSchedulerName("FazlaMesaiSureciYK"));

            // wwwroot static files
            app.UseStaticFiles();

            // asset static files
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"asset")),
                RequestPath = new PathString("/asset")
            });
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"asset")),
            RequestPath = new PathString("/apps/FazlaMesaiSureciYK/latest/asset")
            });

            // dist static files
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"dist")),
                RequestPath = new PathString("/dist")
            });
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"dist")),
            RequestPath = new PathString("/apps/FazlaMesaiSureciYK/latest/dist")
            });

            // swagger config
            // app.UseSwagger(c =>
            // {
            //     c.RouteTemplate = "swagger/{documentName}/swagger.json";
            //     c.PreSerializeFilters.Add((swaggerDoc, httpRequest) =>
            //     {
            //         string proxyPath = GetProxyPath();
            //         if (string.IsNullOrWhiteSpace(proxyPath) || !httpRequest.Headers.ContainsKey("X-Forwarded-Host")) return;
            // 
            //         var serverUrl = $"{httpRequest.Headers["X-Forwarded-Proto"]}://{httpRequest.Headers["X-Forwarded-Host"]}/{proxyPath}";
            //         swaggerDoc.Servers = new List<OpenApiServer> { new OpenApiServer { Url = serverUrl } };
            //     });
            // });
            // app.UseSwaggerUI(c =>
            // {
        //     c.SwaggerEndpoint("v1/swagger.json", "Bimser.Synergy.FazlaMesaiSureciYK.API.Swagger v1");
            //     c.RoutePrefix = "swagger";
            // });            

            app.Use(next => context =>
            {
                context.Request.EnableBuffering();
                return next(context);
            });

            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // start Workflow Host
            var workflowHost = app.ApplicationServices.GetRequiredService<IWorkflowHost>();
            workflowHost.Start();

            // start form migrations
            applicationLifetime.ApplicationStarted.Register(() => StartFormMigrations());

            // start form compatibility migrations
            applicationLifetime.ApplicationStarted.Register(() => StartCompatibilityMigrations());

            // start schedules
            applicationLifetime.ApplicationStarted.Register(() => StartSchedules(app.ApplicationServices));

            //start White Arguments
            applicationLifetime.ApplicationStarted.Register(() => StartWriteArgument());
        }

        private void StartWriteArgument()
        {
            Console.WriteLine(ArgumentExtensions.WriteArguments("e"));
        }

        private void StartFormMigrations()
        {
            try
            {
                DbProviderType providerType = ConfigurationHelper.GetDatabaseProviderType();
                DataConfiguration configuration = ConfigurationHelper.GetDatabaseConfiguration();

                // get definition files on /definitions directory
                string definitionFolder = Path.Combine(Directory.GetCurrentDirectory(), "migrations");
                DirectoryInfo directoryInfo = new DirectoryInfo(definitionFolder);

                StringBuilder logBuilder = new StringBuilder();
                foreach (var definitionFile in directoryInfo.GetFiles("*.json"))
                {
                    try
                    {
                        string migrationContent = File.ReadAllText(definitionFile.FullName);

                        if (string.IsNullOrEmpty(migrationContent) || migrationContent == "{}")
                            continue;

                        eBAFormMigrator migrator = eBAFormMigrator.FromJson(migrationContent);

                        IServiceProvider provider = ServiceProviderFactory.Create(providerType, configuration.ConnectionString);

                        migrator.Migrate(provider);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        AddLog(logBuilder, ex);
                    }
                }

                WriteLogToFile($"{Guid.NewGuid()}_formmigrations.log", logBuilder);

                // run custom fluent migration codes
                StartCustomMigrations(providerType, configuration);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void StartCustomMigrations(DbProviderType providerType, DataConfiguration configuration)
        {
            // get current assembly for scanning migration codes
            var assembly = Assembly.GetExecutingAssembly();

            // get service provider for fluent migrator
            IServiceProvider provider = ServiceProviderFactory.Create(providerType, configuration.ConnectionString, assembly);

            // get migration runner instance
            var runner = (MigrationRunner)provider.GetRequiredService<IMigrationRunner>();

            // check that active migrations on assembly
            // fluent migrator is throwing an exception if there is no active migration code in assembly
            try
            {
                _ = runner.MigrationLoader.LoadMigrations();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Exception]-[StartCustomMigrations]-[{ex.Message}]");
                return;
            }

            // run all migrations
            runner.MigrateUp();
        }

        private void StartCompatibilityMigrations()
        {
            try
            {
                DbProviderType providerType = ConfigurationHelper.GetDatabaseProviderType();
                DataConfiguration configuration = ConfigurationHelper.GetDatabaseConfiguration();

                string definitionFolder = Path.Combine(Directory.GetCurrentDirectory(), "migrations/compatibility");
                DirectoryInfo directoryInfo = new DirectoryInfo(definitionFolder);

                var projectOptions = JsonConvert.DeserializeObject<ProjectMeta>(Environment.GetEnvironmentVariable("PROJECT_OPTIONS"));

                StringBuilder logBuilder = new StringBuilder();
                foreach (var definitionFile in directoryInfo.GetFiles("*.json"))
                {
                    try
                    {
                        string migrationContent = File.ReadAllText(definitionFile.FullName);

                        if (string.IsNullOrEmpty(migrationContent) || migrationContent == "{}")
                            continue;

                        eBAFormMigrator migrator = eBAFormMigrator.FromJson("{}");

                        IServiceProvider provider = ServiceProviderFactory.Create(providerType, configuration.ConnectionString);

                        migrator.FormCompatibilityMigrate(provider, migrationContent, projectOptions.Id);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        AddLog(logBuilder, ex);
                    }
                }

                WriteLogToFile($"{Guid.NewGuid()}_formcompatibilitymigrations.log", logBuilder);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void StartSchedules(IServiceProvider serviceProvider)
        {
            try
            {
                var schedulerConfiguration = serviceProvider.GetService<ISchedulerConfiguration>();
                var schedulerFactory = serviceProvider.GetService<ISchedulerFactory>();

                if (schedulerConfiguration.EnableVersioning)
                    schedulerFactory.UpgradeScheduleVersions();

                // start schedule service for workflow schedules
                SchedulerService workflowSchedulerService = schedulerFactory.GetScheduler("$WorkflowScheduler");
                workflowSchedulerService.Start().Wait();

                // get definition files on /definitions directory
                string definitionFolder = Path.Combine(Directory.GetCurrentDirectory(), "migrations/schedules");
                DirectoryInfo directoryInfo = new DirectoryInfo(definitionFolder);

                // Get the current definition files
                var currentDefinitionFiles = directoryInfo.GetFiles("*.sch").ToList();

                List<string> publishedSchedulerIds = schedulerFactory.GetAllSchedulersAsync().Result.ToList();

                List<string> definitionSchedulerIds = new();
                foreach (var definitionFile in currentDefinitionFiles)
                {
                    string schedulerContent = File.ReadAllText(definitionFile.FullName);
                    var schedule = JsonConvert.DeserializeObject<SchedulerCompilerItem>(schedulerContent);

                    SchedulerService schedulerService = schedulerFactory.GetScheduler($"{schedule.Id}", schedulerConfiguration.EnableVersioning);
                    schedulerService.SyncCalendars(schedule.Calendars).Wait();
                    schedulerService.SyncJobs(schedule.Jobs).Wait();
                    schedulerService.Start().Wait();

                    string modifiedSchedulerContent = JsonConvert.SerializeObject(schedule, Formatting.Indented);
                    File.WriteAllText(definitionFile.FullName, modifiedSchedulerContent);

                    definitionSchedulerIds.Add(schedule.Id);

                    Console.WriteLine($"[{DateTimeOffset.Now}] {definitionFile.Name} Scheduler service started.");
                }

                var notInDefinitionSchedulerIds = publishedSchedulerIds
                                                            .Where(publishedId => !definitionSchedulerIds.Contains(publishedId))
                                                            .ToList();

                foreach (var notInDefinitionSchedulerId in notInDefinitionSchedulerIds)
                {
                    SchedulerService schedulerService = schedulerFactory.GetScheduler($"{notInDefinitionSchedulerId}", schedulerConfiguration.EnableVersioning);
                    var allJobKeys = new HashSet<Quartz.JobKey>(schedulerService.GetAllJobKeysAsync().Result);

                    foreach (var jobKey in allJobKeys)
                    {
                        schedulerService.Scheduler.DeleteJob(jobKey).Wait();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private string GetProxyPath()
        {
            try
            {
                var agentId = Environment.GetEnvironmentVariable("AGENT_ID");
                var projectOptionsJson = Environment.GetEnvironmentVariable("PROJECT_OPTIONS");
                var projectOptions = projectOptionsJson.ToObject<ProjectOptions>();
                if (string.IsNullOrWhiteSpace(agentId) || string.IsNullOrWhiteSpace(projectOptionsJson))
                    return null;

                var basePath = $"{agentId}/deployagent/apps";

                basePath += $"/{projectOptions.Name}/{projectOptions.PackageVersion}";
                return basePath;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToJsonString());
                return null;
            }
        }

        private void AddLog(StringBuilder logBuilder, Exception ex)
        {
            try
            {
                logBuilder.AppendLine($"Exception message: {ex.Message}");
                logBuilder.AppendLine($"Exception stack trace: {ex.StackTrace}");
                logBuilder.AppendLine($"Exception source: {ex.Source}");
                logBuilder.AppendLine($"Exception: {ex}");
                logBuilder.AppendLine($"####################################################");
                logBuilder.AppendLine("");
            }
            catch
            {
            }
        }

        private void WriteLogToFile(string fileName, StringBuilder logs)
        {
            try
            {
                if (logs?.Length <= 0) return;

                File.WriteAllText(fileName, logs.ToString());
            }
            catch
            {
            }
        }
    }
}