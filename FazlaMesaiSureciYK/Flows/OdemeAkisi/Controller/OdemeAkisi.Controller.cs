using Bimser.CSP.Workflow.Runtime.Base;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;
using WorkflowCore.Interface;

namespace FazlaMesaiSureciYK.Flows
{
    [Route("apps/FazlaMesaiSureciYK/latest/api/OdemeAkisi/[action]")]
    [Route("apps/FazlaMesaiSureciYK/{v:int:min(1)}/api/OdemeAkisi/[action]")]
    [Route("api/OdemeAkisi/[action]")]
    [Produces("application/json")]
    public class OdemeAkisiController : BaseFlowController
    {
        private readonly string _flowFileName = "OdemeAkisi";

        public OdemeAkisiController(IIocManager iocManager, IWorkflowController workflowController, IWorkflowRegistry workflowRegistry, IDefinitionLoader definitionLoader) 
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
            return "OdemeAkisi API Controller is ok";
        }
    }
}