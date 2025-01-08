using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace EgitimTalepDegerlendirmeSureci.Forms
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/FormEgitimTalep/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/FormEgitimTalep/[action]")]
    [Route("api/FormEgitimTalep/[action]")]
    [Produces("application/json")]
    public class FormEgitimTalepController : BaseFormController<FormEgitimTalep>
    {
        public FormEgitimTalepController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "FormEgitimTalep API Controller is ok";            
        }
    }
}