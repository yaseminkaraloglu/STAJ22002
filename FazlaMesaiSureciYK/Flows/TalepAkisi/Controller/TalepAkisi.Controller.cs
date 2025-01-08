using Bimser.CSP.Workflow.Runtime.Base;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;
using WorkflowCore.Interface;

namespace FazlaMesaiSureciYK.Flows
{
    [Route("apps/FazlaMesaiSureciYK/latest/api/TalepAkisi/[action]")]
    [Route("apps/FazlaMesaiSureciYK/{v:int:min(1)}/api/TalepAkisi/[action]")]
    [Route("api/TalepAkisi/[action]")]
    [Produces("application/json")]
    public class TalepAkisiController : BaseFlowController
    {
        private readonly string _flowFileName = "TalepAkisi";

        public TalepAkisiController(IIocManager iocManager, IWorkflowController workflowController, IWorkflowRegistry workflowRegistry, IDefinitionLoader definitionLoader) 
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
            return "TalepAkisi API Controller is ok";
        }
    }
}