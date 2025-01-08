using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace EgitimTalepDegerlendirmeSureci.Flows
{
    [WorkflowIdentifier("44357071-f771-4221-ba92-bbc09587e085")]
    public partial class FlowEgitimTalep : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _akisBaslangic;
		private FlowEnd _flowEnd1;
		private FlowPosition _posAmir;
		private FlowPosition _posEgitimk;
		private FlowPosition _posTalepEden;
		private FlowAssign _setAmirAtama;
		private FlowAssign _setEgitimk;
		private FlowMail _notification1;
		private FlowDepartment _department1;
		private FlowDocument _document1;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart AkisBaslangic => _akisBaslangic ??= new FlowStart("AkisBaslangic", _workflowData, this);
		private FlowEnd FlowEnd1 => _flowEnd1 ??= new FlowEnd("FlowEnd1", _workflowData, this);
		private FlowPosition posAmir => _posAmir ??= new FlowPosition("posAmir", _workflowData, this);
		private FlowPosition posEgitimk => _posEgitimk ??= new FlowPosition("posEgitimk", _workflowData, this);
		private FlowPosition posTalepEden => _posTalepEden ??= new FlowPosition("posTalepEden", _workflowData, this);
		private FlowAssign setAmirAtama => _setAmirAtama ??= new FlowAssign("setAmirAtama", _workflowData, this);
		private FlowAssign setEgitimk => _setEgitimk ??= new FlowAssign("setEgitimk", _workflowData, this);
		private FlowMail Notification1 => _notification1 ??= new FlowMail("Notification1", _workflowData, this);
		private FlowDepartment Department1 => _department1 ??= new FlowDepartment("Department1", _workflowData, this);
		private FlowDocument Document1 => _document1 ??= new FlowDocument("Document1", _workflowData, this);


        #endregion

        #region [ctor]        

        public FlowEgitimTalep() : this(null)
        {
            
        }
        
        public FlowEgitimTalep(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}