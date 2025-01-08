using Bimser.CSP.Workflow.Runtime.Base;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;
using WorkflowCore.Interface;

namespace EgitimTalepDegerlendirmeSureci.Flows
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/FlowEgitimTalep/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/FlowEgitimTalep/[action]")]
    [Route("api/FlowEgitimTalep/[action]")]
    [Produces("application/json")]
    public class FlowEgitimTalepController : BaseFlowController
    {
        private readonly string _flowFileName = "FlowEgitimTalep";

        public FlowEgitimTalepController(IIocManager iocManager, IWorkflowController workflowController, IWorkflowRegistry workflowRegistry, IDefinitionLoader definitionLoader) 
            : base(iocManager, workflowController, workflowRegistry, definitionLoader)
        {
            FlowFileName = _flowFileName;
        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "FlowEgitimTalep API Controller is ok";
        }
    }
}