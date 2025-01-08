using Bimser.CSP.Workflow.Runtime.Base;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;
using WorkflowCore.Interface;

namespace EgitimTalepDegerlendirmeSureci.Flows
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/FlowEgitimAnket/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/FlowEgitimAnket/[action]")]
    [Route("api/FlowEgitimAnket/[action]")]
    [Produces("application/json")]
    public class FlowEgitimAnketController : BaseFlowController
    {
        private readonly string _flowFileName = "FlowEgitimAnket";

        public FlowEgitimAnketController(IIocManager iocManager, IWorkflowController workflowController, IWorkflowRegistry workflowRegistry, IDefinitionLoader definitionLoader) 
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
            return "FlowEgitimAnket API Controller is ok";
        }
    }
}