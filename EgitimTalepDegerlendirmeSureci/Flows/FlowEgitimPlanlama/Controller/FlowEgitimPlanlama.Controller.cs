using Bimser.CSP.Workflow.Runtime.Base;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;
using WorkflowCore.Interface;

namespace EgitimTalepDegerlendirmeSureci.Flows
{
    [Route("apps/EgitimTalepDegerlendirmeSureci/latest/api/FlowEgitimPlanlama/[action]")]
    [Route("apps/EgitimTalepDegerlendirmeSureci/{v:int:min(1)}/api/FlowEgitimPlanlama/[action]")]
    [Route("api/FlowEgitimPlanlama/[action]")]
    [Produces("application/json")]
    public class FlowEgitimPlanlamaController : BaseFlowController
    {
        private readonly string _flowFileName = "FlowEgitimPlanlama";

        public FlowEgitimPlanlamaController(IIocManager iocManager, IWorkflowController workflowController, IWorkflowRegistry workflowRegistry, IDefinitionLoader definitionLoader) 
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
            return "FlowEgitimPlanlama API Controller is ok";
        }
    }
}