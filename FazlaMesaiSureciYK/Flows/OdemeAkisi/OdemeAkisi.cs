using Bimser.Synergy.Entities.Shared.Business.Objects;
using Bimser.Synergy.Entities.Workflow.EventArguments;
using Bimser.Synergy.ServiceAPI;
using Bimser.Synergy.ServiceAPI.Models.Authentication;
using Bimser.Synergy.ServiceAPI.Models.Form;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Bimser.CSP.Runtime.Common.Extensions;


namespace FazlaMesaiSureciYK.Flows
{
    public partial class OdemeAkisi
    {
        public void Function1_Execute(object sender, OnExecuteEventArguments args)
        {
            var serviceApi = GetServiceApiInstance(_workflowData.Context);
            List<long> documents = JsonConvert.DeserializeObject<List<long>>(varDocumentIds.Value.ToString());

            GridData gd = GridData.FromControl(Document1.Controls["dgMesaiBilgi"]);
            gd.Rows.Clear();
            

            double totalOvertime = 0.0;

            foreach (var documentId in documents)
            {
                var formInstance = serviceApi.FormManager.Create(_workflowData.General.ProjectName, "FazlaMesaiFormu", documentId).Result;
                var overtimeDuration = formInstance.Controls["nbFazlaMesaiSuresi"].Value;
                var b= new GridDataRow();
                b.Cells.Add(new GridDataRowCell(formInstance.Controls["umTalepEden"].Value, "umTalepEden"));
                b.Cells.Add(new GridDataRowCell(formInstance.Controls["umDepartman"].Value, "umDepartman"));
                b.Cells.Add(new GridDataRowCell(formInstance.Controls["umUnvan"].Value, "umUnvan"));
                b.Cells.Add(new GridDataRowCell(formInstance.Controls["dtTarih"].Value, "dtTarih"));
                b.Cells.Add(new GridDataRowCell(formInstance.Controls["tpBaslangicSaati"].Value, "tpBaslangicSaati"));
                b.Cells.Add(new GridDataRowCell(formInstance.Controls["tpBitisSaati"].Value, "tpBitisSaati"));
                b.Cells.Add(new GridDataRowCell(overtimeDuration, "nbFazlaMesaiSuresi"));

                gd.Rows.Add(b);

                
                if (!string.IsNullOrEmpty(overtimeDuration?.ToString()))
                {
                    var overtimeValue = overtimeDuration.ToString().Split('(')[0];
                    if (double.TryParse(overtimeValue, System.Globalization.CultureInfo.InvariantCulture, out double overtime))
                    {
                        totalOvertime += overtime;
                    }
                }
                

            }
            
            Document1.Controls["nbToplamFazlaMesai"].Value = totalOvertime.ToString(System.Globalization.CultureInfo.InvariantCulture);
            

            FormData formData = new FormData();
            formData.ControlValues.Add("dgMesaiBilgi", JsonConvert.SerializeObject(gd));
            Document1.FormInstance.MergeData(formData.ControlValues);
            var documentSaveResult = Document1.SaveDocument().Result;

        }

        internal static ServiceAPI GetServiceApiInstance(Context session, string webInterfaceUrl = null)
        {
            var credentials = GetTokenCredential(session);
            return new ServiceAPI(credentials, webInterfaceUrl ?? WebInterfaceUrl);
        }

        internal static LoginWithTokenAuthenticationParameters GetTokenCredential(Context session)
        {
            return new LoginWithTokenAuthenticationParameters()
            {
                DomainAddress = WebInterfaceUrl,
                Token = session.Token,
                EncryptedData = session.EncryptedData,
                Language = session.Language
            };
        }
        internal static HttpClientOptions _httpClientOptions;
        internal static string WebInterfaceUrl
        {
            get
            {
                if (_httpClientOptions == null)
                {
                    string envVar = Environment.GetEnvironmentVariable("HTTP_CLIENT_OPTIONS");
                    _httpClientOptions = JsonConvert.DeserializeObject<HttpClientOptions>(envVar);
                }

                return _httpClientOptions.WebInterfaceUrl;
            }
        }
    }
}
