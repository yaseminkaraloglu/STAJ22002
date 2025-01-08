using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace EgitimTalepDegerlendirmeSureci.Flows
{
    [WorkflowIdentifier("062f23cf-d5c1-4dbe-adcf-9992f245bfe6")]
    public partial class FlowEgitimAnket : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _flowStart1;
		private FlowEnd _flowEnd1;
		private FlowPosition _posEgitimKatilimci;
		private FlowAssign _setKatilimciAta;
		private FlowMail _ntfEgitimKBilgilendirme;
		private Variable _katilimci;
		private FlowScript _function1;
		private FlowDocument _docEgitimAnket;
		private FlowCreateDocument _createEgitimAnketi;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart FlowStart1 => _flowStart1 ??= new FlowStart("FlowStart1", _workflowData, this);
		private FlowEnd FlowEnd1 => _flowEnd1 ??= new FlowEnd("FlowEnd1", _workflowData, this);
		private FlowPosition posEgitimKatilimci => _posEgitimKatilimci ??= new FlowPosition("posEgitimKatilimci", _workflowData, this);
		private FlowAssign setKatilimciAta => _setKatilimciAta ??= new FlowAssign("setKatilimciAta", _workflowData, this);
		private FlowMail ntfEgitimKBilgilendirme => _ntfEgitimKBilgilendirme ??= new FlowMail("ntfEgitimKBilgilendirme", _workflowData, this);
		private Variable Katilimci => _katilimci ??= new Variable("Katilimci", _workflowData, this);
		private FlowScript Function1 => _function1 ??= new FlowScript("Function1", _workflowData, this);
		private FlowDocument docEgitimAnket => _docEgitimAnket ??= new FlowDocument("docEgitimAnket", _workflowData, this);
		private FlowCreateDocument CreateEgitimAnketi => _createEgitimAnketi ??= new FlowCreateDocument("CreateEgitimAnketi", _workflowData, this);


        #endregion

        #region [ctor]        

        public FlowEgitimAnket() : this(null)
        {
            
        }
        
        public FlowEgitimAnket(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}