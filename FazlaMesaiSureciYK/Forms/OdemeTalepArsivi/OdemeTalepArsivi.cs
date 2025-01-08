using Bimser.CSP.FormControls.Controls;
using Bimser.CSP.FormControls.Events;
using Bimser.CSP.Runtime.Common.Extensions;
using Bimser.Synergy.Entities.Shared.Business.Objects;
using Bimser.Synergy.ServiceAPI;
using Bimser.Synergy.ServiceAPI.Models.Authentication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FazlaMesaiSureciYK.Forms
{

    public partial class OdemeTalepArsivi
    {

        void dgOdemeTalepArsivi_OnToolbarButtonClick(object sender, ToolbarButtonClickEventArgs e)
        {
            var serviceApi = GetServiceApiInstance(Session);
            var data = dgOdemeTalepArsivi.SelectedRowsData;
            var userIdGroup = data.GroupBy(m => m["userId"]).ToDictionary(group => group.Key, group => group.ToList());
           

            foreach (var tasks in userIdGroup)
            {
                var user = Convert.ToInt64(tasks.Key);
                List<long> documentIds = tasks.Value.Select(s => Convert.ToInt64(s["documentId"])).ToList<long>();

                var subflow = serviceApi.WorkflowManager.Create(ProjectName, "OdemeAkisi", 0).Result;
                subflow.Variables["varDocumentIds"] = JsonConvert.SerializeObject(documentIds);
                subflow.Variables["varUserId"] = user;
                subflow.Variables["varOdemeTalepTuru"] = e.Name;
                subflow.StartingEvent = subflow.Events[4];
                var workflowSaveResult = subflow.SaveAndContinue().Result;
                

                foreach (long documentId in documentIds)
                {
                    var formInstance = serviceApi.FormManager.Create(ProjectName, "FazlaMesaiFormu", documentId).Result;
                    if (formInstance.Controls["removeValue"] != null)
                    {
                        formInstance.Controls["removeValue"].Value = true;
                    }
                    var formSaveResult = formInstance.Save().Result;
                }
            }


            string message = e.Name == "OdemeTalepEt" ? "Ödeme Talebiniz İşleme Alınmıştır." : "İptal Talebiniz İşleme Alınmıştır.";
            ShowMessage("Bilgilendirme", message, Bimser.CSP.FormControls.RuleManager.AlertType.Success);

            dgOdemeTalepArsivi.Reload();

        }

        internal static ServiceAPI GetServiceApiInstance(UserSession session, string webInterfaceUrl = null)
        {
            var credentials = GetTokenCredential(session);
            return new ServiceAPI(credentials, webInterfaceUrl ??
            WebInterfaceUrl);
        }

        internal static LoginWithTokenAuthenticationParameters
                GetTokenCredential(UserSession session)
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
                    string envVar =
                    Environment.GetEnvironmentVariable("HTTP_CLIENT_OPTIONS");
                    _httpClientOptions = JsonConvert.DeserializeObject<HttpClientOptions>(envVar);
                }

                return _httpClientOptions.WebInterfaceUrl;
            }
        }

    }
}