using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace EgitimTalepDegerlendirmeSureci.Forms
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/FormAnket/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/FormAnket/[action]")]
    [Route("api/FormAnket/[action]")]
    [Produces("application/json")]
    public class FormAnketController : BaseFormController<FormAnket>
    {
        public FormAnketController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "FormAnket API Controller is ok";            
        }
    }
}