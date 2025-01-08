using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace EgitimTalepDegerlendirmeSureci.Forms
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/FormEgitimTanim/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/FormEgitimTanim/[action]")]
    [Route("api/FormEgitimTanim/[action]")]
    [Produces("application/json")]
    public class FormEgitimTanimController : BaseFormController<FormEgitimTanim>
    {
        public FormEgitimTanimController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "FormEgitimTanim API Controller is ok";            
        }
    }
}