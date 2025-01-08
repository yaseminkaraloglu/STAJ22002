using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace EgitimTalepDegerlendirmeSureci.Forms
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/FlowEgitimTalep_Process_Archive/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/FlowEgitimTalep_Process_Archive/[action]")]
    [Route("api/FlowEgitimTalep_Process_Archive/[action]")]
    [Produces("application/json")]
    public class FlowEgitimTalep_Process_ArchiveController : BaseFormController<FlowEgitimTalep_Process_Archive>
    {
        public FlowEgitimTalep_Process_ArchiveController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "FlowEgitimTalep_Process_Archive API Controller is ok";            
        }
    }
}