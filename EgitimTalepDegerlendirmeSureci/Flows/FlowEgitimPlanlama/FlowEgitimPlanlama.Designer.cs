using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace EgitimTalepDegerlendirmeSureci.Flows
{
    [WorkflowIdentifier("636d2c73-c8c4-4a22-b4ba-c3c256bf9820")]
    public partial class FlowEgitimPlanlama : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _startEgitimPlanlamaFlow;
		private FlowEnd _endEgitimPlanlamaFlow;
		private FlowPosition _posEgitimCoor;
		private FlowMail _ntfKatilimciBilgi;
		private FlowGroup _posGroupFinans;
		private FlowDocument _docEgitimPlanlama;
		private FlowTrigger _flowTrigger1;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart startEgitimPlanlamaFlow => _startEgitimPlanlamaFlow ??= new FlowStart("startEgitimPlanlamaFlow", _workflowData, this);
		private FlowEnd endEgitimPlanlamaFlow => _endEgitimPlanlamaFlow ??= new FlowEnd("endEgitimPlanlamaFlow", _workflowData, this);
		private FlowPosition posEgitimCoor => _posEgitimCoor ??= new FlowPosition("posEgitimCoor", _workflowData, this);
		private FlowMail ntfKatilimciBilgi => _ntfKatilimciBilgi ??= new FlowMail("ntfKatilimciBilgi", _workflowData, this);
		private FlowGroup posGroupFinans => _posGroupFinans ??= new FlowGroup("posGroupFinans", _workflowData, this);
		private FlowDocument docEgitimPlanlama => _docEgitimPlanlama ??= new FlowDocument("docEgitimPlanlama", _workflowData, this);
		private FlowTrigger FlowTrigger1 => _flowTrigger1 ??= new FlowTrigger("FlowTrigger1", _workflowData, this);


        #endregion

        #region [ctor]        

        public FlowEgitimPlanlama() : this(null)
        {
            
        }
        
        public FlowEgitimPlanlama(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}