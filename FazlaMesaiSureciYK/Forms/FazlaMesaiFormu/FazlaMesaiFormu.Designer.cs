using System;
using System.Collections.Generic;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Bimser.CSP.FormControls.Base;
using Bimser.CSP.FormControls.Common;
using Bimser.CSP.FormControls.Controls;
using Bimser.CSP.FormControls.RuleManager;
using Bimser.CSP.FormControls.Enums;
using Bimser.Framework.Entities;
using Bimser.Framework.Monitoring;
using Newtonsoft.Json;
using FazlaMesaiSureciYK.Entities;

namespace FazlaMesaiSureciYK.Forms {

    public partial class FazlaMesaiFormu : Form<E_FazlaMesaiSureciYK_FazlaMesaiFormuEntity> {

        // properties
        Column Column6 { get; set; }
Column Column7 { get; set; }
Column Column8 { get; set; }
Column Column9 { get; set; }
TimePicker tpBaslangicSaati { get; set; }
Section Section1 { get; set; }
TimePicker tpBitisSaati { get; set; }
Section Section2 { get; set; }
CheckBox removeValue { get; set; }
UserMetadata umDepartman { get; set; }
Section Section3 { get; set; }
TextBox nbFazlaMesaiSuresi { get; set; }
Section Section4 { get; set; }
Section Section5 { get; set; }
UserMetadata umUnvan { get; set; }
DateTimePicker dtTarih { get; set; }
ComboBox cbMesaiNedeni { get; set; }
UserMetadata umTalepEden { get; set; }
TextArea taAciklama { get; set; }
Column Column1 { get; set; }
InputGroup InputGroup1 { get; set; }
Column Column2 { get; set; }
InputGroup InputGroup2 { get; set; }
Column Column3 { get; set; }
Label Label1 { get; set; }
InputGroup InputGroup3 { get; set; }
Column Column4 { get; set; }
Label Label2 { get; set; }
InputGroup InputGroup4 { get; set; }
DocumentMetadata dtOlusturmaTarihi { get; set; }
DocumentMetadata dmBelgeNo { get; set; }
Column Column5 { get; set; }


        // constructor
        public FazlaMesaiFormu(FormHttpParameters httpParameters, IContext context)
 : base(httpParameters, context)
        {
        }

        // initialize members
        public override void InitMembers()
        {
            
Column6 = new Column {
ControlId = "f72523f9-fc24-48f9-a6f2-fcdc90d94077",
Name = "Column6",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column6Component = new BaseComponent {
Id = "Column6",
Type = "Column",
ParentId = "Section4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"cbMesaiNedeni",
},
Properties = Column6,
ViewProperties = "",
};

AddToViewItems("default", default_column6Component);
Controls.Add(Column6);

Column7 = new Column {
ControlId = "1e9380c6-4d1a-4371-bf16-90982b040990",
Name = "Column7",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column7Component = new BaseComponent {
Id = "Column7",
Type = "Column",
ParentId = "Section4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"dtTarih",
},
Properties = Column7,
ViewProperties = "",
};

AddToViewItems("default", default_column7Component);
Controls.Add(Column7);

AddViews("default");
ClientVisible = true;
ProjectName = "FazlaMesaiSureciYK";
ProjectId = "af56a55a-1942-4138-a15f-17ad6c93fb0a";
EntityPath = "";
ActiveView = "default";
Version = 19;
ReadOnly = false;
DefaultReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "FazlaMesaiFormu" },
{ "en-US", "Form1" },
};
Name = "FazlaMesaiFormu";
FormId = "3e32b9a5-d6d8-4eee-b202-75bbb0adeb2e";
FormType = FormType.Standard;
ServerEvents = new List<EventItem> {
};
ClientEvents = new List<EventItem> {
};
Statuses = new List<DocumentStatus> {
};
IdentityFormat = "Academy Masraf Beyan Formatı";
IdentityFormatId = 28;
PrintingEnabled = false;
PrintView = "default";
CopyPasteEnabled = false;
VersioningEnabled = false;
CanSaveAsDraft = false;
PanelSize = 2;
Style = new Style {
Padding = "10px 20px 10px 20px",
BackgroundColor = "rgba(255, 255, 255, 0)",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
};
PublicFields = new List<FormPublicField> {
};
ToolbarButtons = new List<ToolbarButton> {
new ToolbarButton {
Key = "toolbarSaveButton",
Name = "Kaydet",
Icon = "save",
Enabled = true,
DefaultEnabled = true,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Kaydet" },
{ "en-US", "Save" },
},
View = "",
IsServerPrint = false,
},
};
Variables = new Dictionary<string, object> {
};
Rules = new Dictionary<string, Rule> {
{
"FormRequiredFields",
new Rule {
Id = "FormRequiredFields",
Name = "FormRequiredFields",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "FOlusturmadtTariharihirmRequiredFields_Statement_default_dtOlusturmaTarihi",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FOlusturmadtTariharihirmRequiredToastercbMesaiNedeniessage_default_dtOlusturmaTarihi",
Name = "OlusturmaTarihi_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Oluşturma Tarihi: Gerekli alan"
},
{
"en-US",
"Oluşturma Tarihi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"OlusturmaTarihi",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_OlusturmaTarihi",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FOlusturmadtTariharihirmRequiredFields_Condition_default_dtOlusturmaTarihi_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "dtOlusturmaTarihi",
PropertyName = "value",
Type = FieldValueType.Date,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FOlusturmadtTariharihirmRequiredFields_View_Condition_default_dtOlusturmaTarihi",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FazlaMesaiFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_dtTarih",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToastercbMesaiNedeniessage_default_dtTarih",
Name = "Tarih_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Tarih: Gerekli alan"
},
{
"en-US",
"Tarih: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"Tarih",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_Tarih",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_dtTarih_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "dtTarih",
PropertyName = "value",
Type = FieldValueType.Date,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_dtTarih",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FazlaMesaiFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_dtTarih",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToastercbMesaiNedeniessage_default_dtTarih",
Name = "DateTimePicker1_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"DateTimePicker1: Gerekli alan"
},
{
"en-US",
"DateTimePicker1: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DateTimePicker1",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_DateTimePicker1",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_dtTarih_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "dtTarih",
PropertyName = "value",
Type = FieldValueType.Date,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_dtTarih",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FazlaMesaiFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_tpBaslangicSaatiaslangicSaati",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_tpBaslangicSaatiaslangicSaati",
Name = "BaslangicSaati_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"DateTimePicker1: Gerekli alan"
},
{
"en-US",
"DateTimePicker1: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"BaslangicSaati",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_BaslangicSaati",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_tpBaslangicSaatiaslangicSaati_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "tpBaslangicSaati",
PropertyName = "value",
Type = FieldValueType.Date,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_tpBaslangicSaatiaslangicSaati",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FazlaMesaiFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_tpBaslangicSaati",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_tpBaslangicSaati",
Name = "BaslangicSaati_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Başlangıç Saati: Gerekli alan"
},
{
"en-US",
"Başlangıç Saati: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"BaslangicSaati",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_BaslangicSaati",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_tpBaslangicSaati_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "tpBaslangicSaati",
PropertyName = "value",
Type = FieldValueType.Time,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_tpBaslangicSaati",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FazlaMesaiFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_tpBitisSaati",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_tpBitisSaati",
Name = "BitisSaati_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Bitiş Saati: Gerekli alan"
},
{
"en-US",
"Bitiş Saati: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"BitisSaati",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_BitisSaati",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_tpBitisSaati_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "tpBitisSaati",
PropertyName = "value",
Type = FieldValueType.Time,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_tpBitisSaati",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FazlaMesaiFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_taAciklama",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_taAciklama",
Name = "Aciklama_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Açıklama: Gerekli alan"
},
{
"en-US",
"Açıklama: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"Aciklama",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_Aciklama",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_taAciklama_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "taAciklama",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_taAciklama",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FazlaMesaiFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_cbMesaiNedeni",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_cbMesaiNedeni",
Name = "MesaiNedeni_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Fazla Mesai Nedeni: Gerekli alan"
},
{
"en-US",
"Fazla Mesai Nedeni: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"MesaiNedeni",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_MesaiNedeni",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_cbMesaiNedeni_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "cbMesaiNedeni",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_cbMesaiNedeni",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FazlaMesaiFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FOlusturmadtTariharihirmRequiredToastercbMesaiNedeniessage_default_dtOlusturmaTarihi",
Name = "OlusturmaTarihi_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Oluşturma Tarihi: Gerekli alan"
},
{
"en-US",
"Oluşturma Tarihi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"OlusturmaTarihi",
},
},
new ValidationFailureAction {
Id = "FormRequiredToastercbMesaiNedeniessage_default_dtTarih",
Name = "Tarih_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Tarih: Gerekli alan"
},
{
"en-US",
"Tarih: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"Tarih",
},
},
new ValidationFailureAction {
Id = "FormRequiredToastercbMesaiNedeniessage_default_dtTarih",
Name = "DateTimePicker1_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"DateTimePicker1: Gerekli alan"
},
{
"en-US",
"DateTimePicker1: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DateTimePicker1",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_tpBaslangicSaatiaslangicSaati",
Name = "BaslangicSaati_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"DateTimePicker1: Gerekli alan"
},
{
"en-US",
"DateTimePicker1: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"BaslangicSaati",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_tpBaslangicSaati",
Name = "BaslangicSaati_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Başlangıç Saati: Gerekli alan"
},
{
"en-US",
"Başlangıç Saati: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"BaslangicSaati",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_tpBitisSaati",
Name = "BitisSaati_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Bitiş Saati: Gerekli alan"
},
{
"en-US",
"Bitiş Saati: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"BitisSaati",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_taAciklama",
Name = "Aciklama_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Açıklama: Gerekli alan"
},
{
"en-US",
"Açıklama: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"Aciklama",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_cbMesaiNedeni",
Name = "MesaiNedeni_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Fazla Mesai Nedeni: Gerekli alan"
},
{
"en-US",
"Fazla Mesai Nedeni: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"MesaiNedeni",
},
},
},
TriggerEvents = new List<string> {
"FazlaMesaiFormu.client.OnBeforeSave",
"FazlaMesaiFormu.server.OnBeforeSave",
"FazlaMesaiFormu.client.OnToolbarButtonClicked",
"FazlaMesaiFormu.server.OnToolbarButtonClicked",
}
}
},
{
"56113cbf-0476-4c4e-93d0-c1e9c508cf97",
new Rule {
Id = "56113cbf-0476-4c4e-93d0-c1e9c508cf97",
Name = "tpBaslangicSaati_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "270e59b6-d7c1-4f32-91de-d4ab1c0add06",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "c6ad415c-8e14-4078-bb06-d1d69b738896",
Name = "tpBaslangicSaati_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"tpBaslangicSaati alanı zorunludur"
},
{
"en-US",
"tpBaslangicSaati is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"tpBaslangicSaati",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "9a8501d8-aeef-4152-9b96-c49e7a63d2a0",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "f0286c85-fcda-46df-9243-73cca37aa562",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "tpBaslangicSaati",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "98aee296-5320-4c6d-9233-ec7bdd7f8d52",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "c6ad415c-8e14-4078-bb06-d1d69b738896",
Name = "tpBaslangicSaati_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"tpBaslangicSaati alanı zorunludur"
},
{
"en-US",
"tpBaslangicSaati is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"FazlaMesaiFormu.server.OnBeforeSave",
}
}
},
{
"d765cb7b-93e9-49af-b63f-a5db887ccf17",
new Rule {
Id = "d765cb7b-93e9-49af-b63f-a5db887ccf17",
Name = "tpBitisSaati_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "6e764551-613a-438d-baf7-dc12c086364b",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "272018ca-8aa4-4362-acd5-ece6831c75cb",
Name = "tpBitisSaati_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"tpBitisSaati alanı zorunludur"
},
{
"en-US",
"tpBitisSaati is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"tpBitisSaati",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "5e162f6b-79e1-4b5d-938d-cd4d6f4144e6",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "e38a6d1e-fc4b-4db5-8237-81424257a919",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "tpBitisSaati",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "69fd1ade-a572-4a24-b29b-365caa9bf20c",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "272018ca-8aa4-4362-acd5-ece6831c75cb",
Name = "tpBitisSaati_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"tpBitisSaati alanı zorunludur"
},
{
"en-US",
"tpBitisSaati is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"FazlaMesaiFormu.server.OnBeforeSave",
}
}
},
{
"1c0068f9-1037-4b44-b6cf-d13dc13cbd54",
new Rule {
Id = "1c0068f9-1037-4b44-b6cf-d13dc13cbd54",
Name = "dtTarih_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "5f2e2ab2-a157-4295-99db-348c49a87421",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "0c150cb7-5e97-46e8-bf90-21a67a0d16d7",
Name = "dtTarih_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"dtTarih alanı zorunludur"
},
{
"en-US",
"dtTarih is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"dtTarih",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "c09d83a2-0258-45fa-b08b-3708d81122c6",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "10074db6-000e-4610-a974-a9d9aaeef491",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "dtTarih",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "2aceffab-68a6-4e20-8598-58ab0e42b939",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "0c150cb7-5e97-46e8-bf90-21a67a0d16d7",
Name = "dtTarih_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"dtTarih alanı zorunludur"
},
{
"en-US",
"dtTarih is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"FazlaMesaiFormu.server.OnBeforeSave",
}
}
},
{
"3402f46f-41f8-4948-9b14-d951ad8db1ef",
new Rule {
Id = "3402f46f-41f8-4948-9b14-d951ad8db1ef",
Name = "cbMesaiNedeni_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "0899ceb3-5b55-41e6-a0fa-374dc34fe515",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "c5e5940c-2fcf-48bd-836e-cd73ca023188",
Name = "cbMesaiNedeni_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"cbMesaiNedeni alanı zorunludur"
},
{
"en-US",
"cbMesaiNedeni is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"cbMesaiNedeni",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "cc71e417-1ade-47bc-b479-ceeabb264c76",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "40468263-3620-46e8-bb43-025ff7169faa",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "cbMesaiNedeni",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "94e43c92-c16e-48ad-8a35-26787943aac8",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "c5e5940c-2fcf-48bd-836e-cd73ca023188",
Name = "cbMesaiNedeni_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"cbMesaiNedeni alanı zorunludur"
},
{
"en-US",
"cbMesaiNedeni is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"FazlaMesaiFormu.server.OnBeforeSave",
}
}
},
};
CheckInCheckOut = new CheckInCheckOutOptions {
Enabled = false,
Timeout = 10,
AdditionalTime = 5,
};
SizeType = SizeType.Middle;
PaddingType = SizeType.Middle;
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Fazla Mesai Formu" },{ "en-US", "FazlaMesaiFormu" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
};

Controls.Add(this);

BaseComponent default_fazlamesaiformuComponent = new BaseComponent {
Id = "FazlaMesaiFormu",
Type = "Form",
ParentId = "",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section1",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("default", default_fazlamesaiformuComponent);

Column8 = new Column {
ControlId = "bdf09362-ae47-44be-ab1e-5389b1333b3e",
Name = "Column8",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column8Component = new BaseComponent {
Id = "Column8",
Type = "Column",
ParentId = "Section5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"tpBitisSaati",
},
Properties = Column8,
ViewProperties = "",
};

AddToViewItems("default", default_column8Component);
Controls.Add(Column8);

Column9 = new Column {
ControlId = "900f2c4f-e285-4050-be1f-a8eac7e965c4",
Name = "Column9",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column9Component = new BaseComponent {
Id = "Column9",
Type = "Column",
ParentId = "Section5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"tpBaslangicSaati",
},
Properties = Column9,
ViewProperties = "",
};

AddToViewItems("default", default_column9Component);
Controls.Add(Column9);

tpBaslangicSaati = new TimePicker {
ControlId = "148d8e83-0758-5779-2c9b-3a7e67d88698",
Name = "tpBaslangicSaati",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanging",
MethodName = "tpBaslangicSaati_OnValueChanging",
Async = null
},
new EventItem {
Name = "OnValueChanged",
MethodName = "tpBitisSaati_OnValueChanged",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Başlangıç Saati" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "tpBaslangicSaati",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Format = "HH:mm",
SizeType = null,
DisabledHours = new List<int> {
},
Use12Hours = false,
HourStep = 1,
MinuteStep = 1,
SecondStep = 1,
AllowClear = true,
};

Controls.Add(tpBaslangicSaati);

BaseComponent default_tpbaslangicsaatiComponent = new BaseComponent {
Id = "tpBaslangicSaati",
Type = "TimePicker",
ParentId = "Column9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = tpBaslangicSaati,
ViewProperties = "",
};

AddToViewItems("default", default_tpbaslangicsaatiComponent);

Section1 = new Section {
ControlId = "08e8ef53-dd26-4660-bdcf-6a13b3b98f83",
Name = "Section1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section1Component = new BaseComponent {
Id = "Section1",
Type = "Section",
ParentId = "FazlaMesaiFormu",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column1",
},
Properties = Section1,
ViewProperties = "",
};

AddToViewItems("default", default_section1Component);
Controls.Add(Section1);

tpBitisSaati = new TimePicker {
ControlId = "52cc8a33-b2a4-670f-ba44-3ab4b4f57178",
Name = "tpBitisSaati",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanged",
MethodName = "tpBitisSaati_OnValueChanged",
Async = null
},
new EventItem {
Name = "OnValueChanging",
MethodName = "tpBitisSaati_OnValueChanging",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bitiş Saati" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "tpBitisSaati",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Format = "HH:mm",
SizeType = null,
DisabledHours = new List<int> {
},
Use12Hours = false,
HourStep = 1,
MinuteStep = 1,
SecondStep = 1,
AllowClear = true,
};

Controls.Add(tpBitisSaati);

BaseComponent default_tpbitissaatiComponent = new BaseComponent {
Id = "tpBitisSaati",
Type = "TimePicker",
ParentId = "Column8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = tpBitisSaati,
ViewProperties = "",
};

AddToViewItems("default", default_tpbitissaatiComponent);

Section2 = new Section {
ControlId = "c21b4441-fb8e-4a12-bd95-d2d16224ffe9",
Name = "Section2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section2Component = new BaseComponent {
Id = "Section2",
Type = "Section",
ParentId = "InputGroup1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column3",
"Column2",
},
Properties = Section2,
ViewProperties = "",
};

AddToViewItems("default", default_section2Component);
Controls.Add(Section2);

removeValue = new CheckBox {
ControlId = "fe7303e1-c7cc-291a-de56-c7cf14527e1b",
Name = "removeValue",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = false,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "removeValue" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "removeValue",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = false,
Label = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
};

Controls.Add(removeValue);

BaseComponent default_removevalueComponent = new BaseComponent {
Id = "removeValue",
Type = "CheckBox",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = removeValue,
ViewProperties = "",
};

AddToViewItems("default", default_removevalueComponent);

umDepartman = new UserMetadata {
ControlId = "d268ca30-d896-843d-957a-8f3fd7881f34",
Name = "umDepartman",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Departman" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.umDepartman",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
MetadataType = UserMetadataType.Department,
CustomMetadataName = "",
SizeType = null,
PropertyType = UserMetadataOptionTypes.Text,
LocationDataType = LocationDataType.Coordinates,
};

Controls.Add(umDepartman);

BaseComponent default_umdepartmanComponent = new BaseComponent {
Id = "umDepartman",
Type = "UserMetadata",
ParentId = "Column5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = umDepartman,
ViewProperties = "",
};

AddToViewItems("default", default_umdepartmanComponent);

Section3 = new Section {
ControlId = "0b6882a4-e866-4160-82dd-2d7510b29e75",
Name = "Section3",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section3Component = new BaseComponent {
Id = "Section3",
Type = "Section",
ParentId = "InputGroup2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column5",
"Column4",
},
Properties = Section3,
ViewProperties = "",
};

AddToViewItems("default", default_section3Component);
Controls.Add(Section3);

nbFazlaMesaiSuresi = new TextBox {
ControlId = "b24695e1-d8bf-3b7a-f980-ef26d666d1ee",
Name = "nbFazlaMesaiSuresi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = false,
DefaultClientEnabled = false,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Fazla Mesai Süresi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.nbFazlaMesaiSuresi",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(nbFazlaMesaiSuresi);

BaseComponent default_nbfazlamesaisuresiComponent = new BaseComponent {
Id = "nbFazlaMesaiSuresi",
Type = "TextBox",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = nbFazlaMesaiSuresi,
ViewProperties = "",
};

AddToViewItems("default", default_nbfazlamesaisuresiComponent);

Section4 = new Section {
ControlId = "09508bc7-e7b8-4ba7-a564-51c8979b8c33",
Name = "Section4",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section4Component = new BaseComponent {
Id = "Section4",
Type = "Section",
ParentId = "InputGroup3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column7",
"Column6",
},
Properties = Section4,
ViewProperties = "",
};

AddToViewItems("default", default_section4Component);
Controls.Add(Section4);

Section5 = new Section {
ControlId = "3ef14ef7-2c59-4eab-8171-7104e86f21f3",
Name = "Section5",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section5Component = new BaseComponent {
Id = "Section5",
Type = "Section",
ParentId = "InputGroup4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column9",
"Column8",
},
Properties = Section5,
ViewProperties = "",
};

AddToViewItems("default", default_section5Component);
Controls.Add(Section5);

umUnvan = new UserMetadata {
ControlId = "9d88d164-0fdc-c488-c87b-ecb483b6d088",
Name = "umUnvan",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ünvan" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.umUnvan",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
MetadataType = UserMetadataType.Profession,
CustomMetadataName = "",
SizeType = null,
PropertyType = UserMetadataOptionTypes.Text,
LocationDataType = LocationDataType.Coordinates,
};

Controls.Add(umUnvan);

BaseComponent default_umunvanComponent = new BaseComponent {
Id = "umUnvan",
Type = "UserMetadata",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = umUnvan,
ViewProperties = "",
};

AddToViewItems("default", default_umunvanComponent);

dtTarih = new DateTimePicker {
ControlId = "6fac1648-5a49-936c-e01d-31ab0715e17a",
Name = "dtTarih",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Tarih" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "dtTarih",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Format = "",
SetTodayAsDefault = false,
ShowTime = false,
ShowToday = false,
AllowClear = true,
DisableBefore = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
DisableAfter = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
SizeType = null,
};

Controls.Add(dtTarih);

BaseComponent default_dttarihComponent = new BaseComponent {
Id = "dtTarih",
Type = "DateTimePicker",
ParentId = "Column7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = dtTarih,
ViewProperties = "",
};

AddToViewItems("default", default_dttarihComponent);

cbMesaiNedeni = new ComboBox {
ControlId = "a417ba86-081c-ef56-2a23-170cfbe829b3",
Name = "cbMesaiNedeni",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Fazla Mesai Nedeni" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.cbMesaiNedeni",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "MesaiNedenleriGetir",
ValueMember = "DGID",
DisplayMember = new List<string>{
"MesaiNedeni",
},
DisplayFormat = "{{ MesaiNedeni }}",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = DataSourceConnectionType.MSSQL,
DefaultValue = null,
UseClientCachedData = true,
EnableMultiLanguageDisplayMember = false,
DisplayMemberML = new Dictionary<string, DisplayMemberML> {
},
},
DataSourceType = DataSourceType.Dynamic,
ValueType = PrimitiveType.Integer,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
HideForceRefreshButton = false,
};

Controls.Add(cbMesaiNedeni);
cbMesaiNedeni.Items = new ListItemCollection();

BaseComponent default_cbmesainedeniComponent = new BaseComponent {
Id = "cbMesaiNedeni",
Type = "ComboBox",
ParentId = "Column6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = cbMesaiNedeni,
ViewProperties = "",
};

AddToViewItems("default", default_cbmesainedeniComponent);

umTalepEden = new UserMetadata {
ControlId = "fec15e5e-f6be-47e7-8575-811acddaef7c",
Name = "umTalepEden",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Talep Eden" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "umTalepEden",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
MetadataType = UserMetadataType.NameAndSurname,
CustomMetadataName = "",
SizeType = null,
PropertyType = UserMetadataOptionTypes.Text,
LocationDataType = LocationDataType.Coordinates,
};

Controls.Add(umTalepEden);

BaseComponent default_umtalepedenComponent = new BaseComponent {
Id = "umTalepEden",
Type = "UserMetadata",
ParentId = "Column3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = umTalepEden,
ViewProperties = "",
};

AddToViewItems("default", default_umtalepedenComponent);

taAciklama = new TextArea {
ControlId = "90d19bb0-83ac-f3bd-ad75-e37c95bd3176",
Name = "taAciklama",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Açıklama" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 35
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.taAciklama",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 250,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = true,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 3
};

Controls.Add(taAciklama);

BaseComponent default_taaciklamaComponent = new BaseComponent {
Id = "taAciklama",
Type = "TextArea",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = taAciklama,
ViewProperties = "",
};

AddToViewItems("default", default_taaciklamaComponent);

Column1 = new Column {
ControlId = "47b1de72-9f4b-48c1-8dac-9bab60ac1a52",
Name = "Column1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column1Component = new BaseComponent {
Id = "Column1",
Type = "Column",
ParentId = "Section1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Label1",
"InputGroup1",
"InputGroup2",
"umUnvan",
"Label2",
"InputGroup3",
"InputGroup4",
"taAciklama",
"nbFazlaMesaiSuresi",
"removeValue",
},
Properties = Column1,
ViewProperties = "",
};

AddToViewItems("default", default_column1Component);
Controls.Add(Column1);

InputGroup1 = new InputGroup {
ControlId = "7fb48e8e-0edd-55c9-20c6-aaa3691d308e",
Name = "InputGroup1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "InputGroup1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.None,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
};

Controls.Add(InputGroup1);

BaseComponent default_inputgroup1Component = new BaseComponent {
Id = "InputGroup1",
Type = "InputGroup",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section2",
},
Properties = InputGroup1,
ViewProperties = "",
};

AddToViewItems("default", default_inputgroup1Component);

Column2 = new Column {
ControlId = "af5ccf02-2abb-46d0-9643-eaa8a74101cc",
Name = "Column2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column2Component = new BaseComponent {
Id = "Column2",
Type = "Column",
ParentId = "Section2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"dtOlusturmaTarihi",
},
Properties = Column2,
ViewProperties = "",
};

AddToViewItems("default", default_column2Component);
Controls.Add(Column2);

InputGroup2 = new InputGroup {
ControlId = "ac05bfcb-6821-fb5a-d32b-a82ee89392a7",
Name = "InputGroup2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "InputGroup2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.None,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
};

Controls.Add(InputGroup2);

BaseComponent default_inputgroup2Component = new BaseComponent {
Id = "InputGroup2",
Type = "InputGroup",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section3",
},
Properties = InputGroup2,
ViewProperties = "",
};

AddToViewItems("default", default_inputgroup2Component);

Column3 = new Column {
ControlId = "65156f8b-47f4-4659-b99b-ca2838d08952",
Name = "Column3",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column3Component = new BaseComponent {
Id = "Column3",
Type = "Column",
ParentId = "Section2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"umTalepEden",
},
Properties = Column3,
ViewProperties = "",
};

AddToViewItems("default", default_column3Component);
Controls.Add(Column3);

Label1 = new Label {
ControlId = "2f849c28-f35b-1a68-1bae-838e2c908788",
Name = "Label1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "15",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Personel Bilgileri" },{ "en-US", "Label1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label1);

BaseComponent default_label1Component = new BaseComponent {
Id = "Label1",
Type = "Label",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Label1,
ViewProperties = "",
};

AddToViewItems("default", default_label1Component);

InputGroup3 = new InputGroup {
ControlId = "01082a6c-fe47-eba7-a7cd-72b1fb0fb945",
Name = "InputGroup3",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "InputGroup3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.None,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
};

Controls.Add(InputGroup3);

BaseComponent default_inputgroup3Component = new BaseComponent {
Id = "InputGroup3",
Type = "InputGroup",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section4",
},
Properties = InputGroup3,
ViewProperties = "",
};

AddToViewItems("default", default_inputgroup3Component);

Column4 = new Column {
ControlId = "cf932a75-c0f1-4ee4-9b8a-07ae7a2f20d0",
Name = "Column4",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column4Component = new BaseComponent {
Id = "Column4",
Type = "Column",
ParentId = "Section3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"dmBelgeNo",
},
Properties = Column4,
ViewProperties = "",
};

AddToViewItems("default", default_column4Component);
Controls.Add(Column4);

Label2 = new Label {
ControlId = "45567ec7-8d3c-1da9-761e-5f7cbe33128a",
Name = "Label2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Fazla Mesai Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "15",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Fazla Mesai Bilgileri" },{ "en-US", "Label2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
};

Controls.Add(Label2);

BaseComponent default_label2Component = new BaseComponent {
Id = "Label2",
Type = "Label",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Label2,
ViewProperties = "",
};

AddToViewItems("default", default_label2Component);

InputGroup4 = new InputGroup {
ControlId = "16b40dbd-3829-9f21-b764-31333f5be960",
Name = "InputGroup4",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "InputGroup4" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.None,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
};

Controls.Add(InputGroup4);

BaseComponent default_inputgroup4Component = new BaseComponent {
Id = "InputGroup4",
Type = "InputGroup",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section5",
},
Properties = InputGroup4,
ViewProperties = "",
};

AddToViewItems("default", default_inputgroup4Component);

dtOlusturmaTarihi = new DocumentMetadata {
ControlId = "4c554588-9845-fbd6-e6f1-c0655225b259",
Name = "dtOlusturmaTarihi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Oluşturma Tarihi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "CREATEDAT",
ReadOnly = true,
DefaultReadOnly = true,
Required = false,
Indexable = false,
MetadataType = DocumentMetadataType.CreateDate,
DateFormat = "DD.MM.YYYY",
PullNumberOnStart = false,
PullNewNumber = false,
SizeType = null,
};

Controls.Add(dtOlusturmaTarihi);

BaseComponent default_dtolusturmatarihiComponent = new BaseComponent {
Id = "dtOlusturmaTarihi",
Type = "DocumentMetadata",
ParentId = "Column2",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = dtOlusturmaTarihi,
ViewProperties = "",
};

AddToViewItems("default", default_dtolusturmatarihiComponent);

dmBelgeNo = new DocumentMetadata {
ControlId = "b1e0ec0a-39fd-27b4-c8cb-8881aca4cebb",
Name = "dmBelgeNo",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Belge No" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "UNIQUEID",
ReadOnly = true,
DefaultReadOnly = true,
Required = false,
Indexable = false,
MetadataType = DocumentMetadataType.Id,
DateFormat = "",
PullNumberOnStart = true,
PullNewNumber = false,
SizeType = null,
};

Controls.Add(dmBelgeNo);

BaseComponent default_dmbelgenoComponent = new BaseComponent {
Id = "dmBelgeNo",
Type = "DocumentMetadata",
ParentId = "Column4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = dmBelgeNo,
ViewProperties = "",
};

AddToViewItems("default", default_dmbelgenoComponent);

Column5 = new Column {
ControlId = "06588f8b-18cc-48d0-9747-eafda82995c3",
Name = "Column5",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column5Component = new BaseComponent {
Id = "Column5",
Type = "Column",
ParentId = "Section3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"umDepartman",
},
Properties = Column5,
ViewProperties = "",
};

AddToViewItems("default", default_column5Component);
Controls.Add(Column5);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            



















        }
    }
}