using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace EgitimTalepDegerlendirmeSureci.Forms
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/FormEgitimAnketRaporu/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/FormEgitimAnketRaporu/[action]")]
    [Route("api/FormEgitimAnketRaporu/[action]")]
    [Produces("application/json")]
    public class FormEgitimAnketRaporuController : BaseFormController<FormEgitimAnketRaporu>
    {
        public FormEgitimAnketRaporuController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "FormEgitimAnketRaporu API Controller is ok";            
        }
    }
}