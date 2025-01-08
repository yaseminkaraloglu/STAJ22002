using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace EgitimTalepDegerlendirmeSureci.Forms
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/FormEgitimPlanlama/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/FormEgitimPlanlama/[action]")]
    [Route("api/FormEgitimPlanlama/[action]")]
    [Produces("application/json")]
    public class FormEgitimPlanlamaController : BaseFormController<FormEgitimPlanlama>
    {
        public FormEgitimPlanlamaController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "FormEgitimPlanlama API Controller is ok";            
        }
    }
}