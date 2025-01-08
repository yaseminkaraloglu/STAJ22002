using Bimser.CSP.DataSource;
using Bimser.CSP.FormControls.Modules;
using Bimser.Framework.AspNetCore;
using Bimser.Framework.Logging;
using Bimser.Framework.Modules;
using Bimser.Framework.Serilog;
using Bimser.Synergy.Core.Modules;
using Bimser.Synergy.DataAccess.Modules;
using Bimser.Synergy.ServiceAPI.Models;
using Castle.MicroKernel.Registration;

namespace FazlaMesaiSureciYK
{
    [DependsOn(typeof(BimserAspNetCoreModule),
               typeof(SynergyDataAccessModule),
               typeof(FormControlsModule),
               typeof(DataSourceModule),
               typeof(BimserSerilogModule),
               typeof(ServiceAPIModule),
               typeof(SynergyCoreModule))]
    public class StartupModule : BimserModule
    {
        public override void Initialize()
        {
            CreateAndRegisterLogger();
        }

        protected virtual void CreateAndRegisterLogger()
        {
            var loggerFactory = IocManager.Resolve<ILoggerFactory>();
            var logger = loggerFactory.Create("Logger", "default");

            IocManager.IocContainer.Register(Component.For<ILogger>().Named("Logger").LifestyleSingleton()
                                                               .Instance(logger));
        }
    }
}