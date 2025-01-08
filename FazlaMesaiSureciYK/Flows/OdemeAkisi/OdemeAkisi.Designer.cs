using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace FazlaMesaiSureciYK.Flows
{
    [WorkflowIdentifier("185c9ba8-2da0-4872-b5b1-b539c294b0ad")]
    public partial class OdemeAkisi : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _akisBaslangicIK;
		private FlowEnd _akisBitis;
		private FlowCompare _ifIstekKarsilastirma;
		private FlowState _odemeBekle;
		private FlowState _odendi;
		private FlowState _iptalEdildi;
		private FlowMail _onayBilgi;
		private FlowMail _iptalBilgilendirme;
		private Variable _varDocumentIds;
		private Variable _varUserId;
		private Variable _varOdemeTalepTuru;
		private FlowScript _function1;
		private FlowGroup _pgMuhasebe;
		private FlowDocument _document1;
		private FlowCreateDocument _createOdemeTalep;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart AkisBaslangicIK => _akisBaslangicIK ??= new FlowStart("AkisBaslangicIK", _workflowData, this);
		private FlowEnd AkisBitis => _akisBitis ??= new FlowEnd("AkisBitis", _workflowData, this);
		private FlowCompare IfIstekKarsilastirma => _ifIstekKarsilastirma ??= new FlowCompare("IfIstekKarsilastirma", _workflowData, this);
		private FlowState OdemeBekle => _odemeBekle ??= new FlowState("OdemeBekle", _workflowData, this);
		private FlowState Odendi => _odendi ??= new FlowState("Odendi", _workflowData, this);
		private FlowState IptalEdildi => _iptalEdildi ??= new FlowState("IptalEdildi", _workflowData, this);
		private FlowMail OnayBilgi => _onayBilgi ??= new FlowMail("OnayBilgi", _workflowData, this);
		private FlowMail IptalBilgilendirme => _iptalBilgilendirme ??= new FlowMail("IptalBilgilendirme", _workflowData, this);
		private Variable varDocumentIds => _varDocumentIds ??= new Variable("varDocumentIds", _workflowData, this);
		private Variable varUserId => _varUserId ??= new Variable("varUserId", _workflowData, this);
		private Variable varOdemeTalepTuru => _varOdemeTalepTuru ??= new Variable("varOdemeTalepTuru", _workflowData, this);
		private FlowScript Function1 => _function1 ??= new FlowScript("Function1", _workflowData, this);
		private FlowGroup pgMuhasebe => _pgMuhasebe ??= new FlowGroup("pgMuhasebe", _workflowData, this);
		private FlowDocument Document1 => _document1 ??= new FlowDocument("Document1", _workflowData, this);
		private FlowCreateDocument CreateOdemeTalep => _createOdemeTalep ??= new FlowCreateDocument("CreateOdemeTalep", _workflowData, this);


        #endregion

        #region [ctor]        

        public OdemeAkisi() : this(null)
        {
            
        }
        
        public OdemeAkisi(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}