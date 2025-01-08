using Bimser.Synergy.Entities.Shared.Business.Objects;
using Bimser.Synergy.Entities.Workflow.EventArguments;
using Bimser.Synergy.ServiceAPI;
using Bimser.Synergy.ServiceAPI.Models.Authentication;
using Bimser.Synergy.ServiceAPI.Models.Form;
using Newtonsoft.Json;
using System;

namespace EgitimTalepDegerlendirmeSureci.Flows
{
    public partial class FlowEgitimAnket
    {

		public void Function1_Execute(object sender, OnExecuteEventArguments args)
		{
         var serviceApi = GetServiceApiInstance(_workflowData.Context);
      
         var formInstance = serviceApi.FormManager.Create(_workflowData.General.ProjectName, "FormEgitimPlanlama", Convert.ToInt64(mainDocumentId.Value) ).Result;
      
         var egitimAdi = formInstance.Controls["cbxEgitimAdi"].Value;
         var egitmen = formInstance.Controls["tbxEgitmen"].Value;
         var baslangicTarihi = formInstance.Controls["dtBaslangicTarihi"].Value;
         var bitisTarihi = formInstance.Controls["dtBitisTarihi"].Value;
         var egitimYeri = formInstance.Controls["tbxEgitimYeri"].Value;

         GridData dg = GridData.FromControl(formInstance.Controls["dgKatilimcilar"]);
         //var katilimcidg = dg.Rows.Find(row => row.Cells.Find(cell => cell.Name == "USERID").Value == Katilimci.Value);
         var fullName = dg.Rows.Find(row => row.Cells.Find(cell => cell.Name == "FULLNAME").Value == Katilimci.Value);
         var profession = dg.Rows.Find(row => row.Cells.Find(cell => cell.Name == "PROFESSION").Value == Katilimci.Value);


         docEgitimAnket.Controls["tbxKatilimciAnket"].Value = fullName;
         docEgitimAnket.Controls["tbxUnvanAnket"].Value = profession;
         docEgitimAnket.Controls["tbxEgitimAdiAnket"].Value = egitimAdi;
         docEgitimAnket.Controls["tbxEgitmenAnket"].Value = egitmen;
         docEgitimAnket.Controls["dtEgitimBasTarihAnket"].Value = baslangicTarihi;
         docEgitimAnket.Controls["dtEgitimBitTarihAnket"].Value = bitisTarihi;
         docEgitimAnket.Controls["tbxEgitimYeriAnket"].Value = egitimYeri;

         var saveResult = docEgitimAnket.SaveDocument().Result;
        
      
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