using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace FazlaMesaiSureciYK.Flows
{
    [WorkflowIdentifier("d298cbdf-1fbf-484e-8043-37717fc0ea8b")]
    public partial class TalepAkisi : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _akisBaslangic;
		private FlowEnd _akisBitisi;
		private FlowPosition _pstnDepartmanYonetici;
		private FlowPosition _posAkisBaslatanAmiri;
		private FlowPosition _position2;
		private FlowAssign _setAmirAtama;
		private FlowAssign _departmanAtama;
		private FlowState _amironayinda;
		private FlowState _departmanOnayinda;
		private FlowState _reddedildi;
		private FlowState _onaylandi;
		private FlowState _iptalEdildi;
		private FlowMail _iKBilgi;
		private FlowDepartment _dAkisBaslatanDepartman;
		private FlowDocument _fazlaMesaiDokuman;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart AkisBaslangic => _akisBaslangic ??= new FlowStart("AkisBaslangic", _workflowData, this);
		private FlowEnd AkisBitisi => _akisBitisi ??= new FlowEnd("AkisBitisi", _workflowData, this);
		private FlowPosition pstnDepartmanYonetici => _pstnDepartmanYonetici ??= new FlowPosition("pstnDepartmanYonetici", _workflowData, this);
		private FlowPosition posAkisBaslatanAmiri => _posAkisBaslatanAmiri ??= new FlowPosition("posAkisBaslatanAmiri", _workflowData, this);
		private FlowPosition Position2 => _position2 ??= new FlowPosition("Position2", _workflowData, this);
		private FlowAssign setAmirAtama => _setAmirAtama ??= new FlowAssign("setAmirAtama", _workflowData, this);
		private FlowAssign DepartmanAtama => _departmanAtama ??= new FlowAssign("DepartmanAtama", _workflowData, this);
		private FlowState Amironayinda => _amironayinda ??= new FlowState("Amironayinda", _workflowData, this);
		private FlowState DepartmanOnayinda => _departmanOnayinda ??= new FlowState("DepartmanOnayinda", _workflowData, this);
		private FlowState reddedildi => _reddedildi ??= new FlowState("reddedildi", _workflowData, this);
		private FlowState Onaylandi => _onaylandi ??= new FlowState("Onaylandi", _workflowData, this);
		private FlowState IptalEdildi => _iptalEdildi ??= new FlowState("IptalEdildi", _workflowData, this);
		private FlowMail IKBilgi => _iKBilgi ??= new FlowMail("IKBilgi", _workflowData, this);
		private FlowDepartment dAkisBaslatanDepartman => _dAkisBaslatanDepartman ??= new FlowDepartment("dAkisBaslatanDepartman", _workflowData, this);
		private FlowDocument FazlaMesaiDokuman => _fazlaMesaiDokuman ??= new FlowDocument("FazlaMesaiDokuman", _workflowData, this);


        #endregion

        #region [ctor]        

        public TalepAkisi() : this(null)
        {
            
        }
        
        public TalepAkisi(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}