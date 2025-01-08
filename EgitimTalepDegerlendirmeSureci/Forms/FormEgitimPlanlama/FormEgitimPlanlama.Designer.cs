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
using EgitimTalepDegerlendirmeSureci.Entities;

namespace EgitimTalepDegerlendirmeSureci.Forms {

    public partial class FormEgitimPlanlama : Form<E_EgitimTalepDegerlendirmeSureci_FormEgitimPlanlamaEntity> {

        // properties
        Column Column6 { get; set; }
Column Column7 { get; set; }
TextArea txEgitimTalepAciklama { get; set; }
Column Column8 { get; set; }
Column Column9 { get; set; }
InputGroup InputGroup9 { get; set; }
Section Section11 { get; set; }
Section Section12 { get; set; }
Section Section13 { get; set; }
Section Section1 { get; set; }
Section Section2 { get; set; }
Section Section3 { get; set; }
Section Section4 { get; set; }
Section Section5 { get; set; }
DateTimePicker dtEgitimBasTarih { get; set; }
InputGroup InputGroup10 { get; set; }
Column Column32 { get; set; }
DataGrid dgKatilimcilar { get; set; }
Column Column33 { get; set; }
Column Column34 { get; set; }
Column Column35 { get; set; }
DateTimePicker dtEgitimBitTarih { get; set; }
NumberBox nbxKatilimciSayisi { get; set; }
Column Column1 { get; set; }
InputGroup InputGroup1 { get; set; }
Column Column2 { get; set; }
ComboBox cbxEgitimAdi { get; set; }
InputGroup InputGroup2 { get; set; }
Column Column3 { get; set; }
Label Label1 { get; set; }
TextBox tbxEgitimYeri { get; set; }
InputGroup InputGroup3 { get; set; }
Column Column4 { get; set; }
InputGroup InputGroup4 { get; set; }
TextBox tbxEgitmen { get; set; }
Column Column5 { get; set; }
InputGroup InputGroup5 { get; set; }
InputGroup InputGroup6 { get; set; }
InputGroup InputGroup7 { get; set; }
InputGroup InputGroup8 { get; set; }
Section Section10 { get; set; }
Section Section6 { get; set; }
MaskInput maskIban { get; set; }
Section Section7 { get; set; }
NumberBox nbxEgitimBedel { get; set; }
Column Column30 { get; set; }
Section Section8 { get; set; }
ComboBox cbxParaBirimi { get; set; }
Column Column20 { get; set; }
Column Column31 { get; set; }
Section Section9 { get; set; }
Column Column10 { get; set; }
Column Column21 { get; set; }
Column Column11 { get; set; }
Column Column22 { get; set; }
ComboBox cbxOdemeYontemi { get; set; }
Column Column12 { get; set; }
Column Column23 { get; set; }
Column Column13 { get; set; }
Column Column24 { get; set; }
Divider Divider1 { get; set; }
Section Column14 { get; set; }
Column Column25 { get; set; }
Section Column15 { get; set; }
Column Column26 { get; set; }
Section Column16 { get; set; }
Column Column27 { get; set; }
Section Column17 { get; set; }
Column Column28 { get; set; }
Section Column18 { get; set; }
Column Column29 { get; set; }
Column Column19 { get; set; }


        // constructor
        public FormEgitimPlanlama(FormHttpParameters httpParameters, IContext context)
 : base(httpParameters, context)
        {
        }

        // initialize members
        public override void InitMembers()
        {
            
Column6 = new Column {
ControlId = "82930144-24ea-46e2-a593-e3bcb46d9bef",
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
"InputGroup9",
},
Properties = Column6,
ViewProperties = "",
};

AddToViewItems("default", default_column6Component);
Controls.Add(Column6);

Column7 = new Column {
ControlId = "6c870c90-7ae9-4259-b70e-f4d027acd918",
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
"tbxEgitimYeri",
},
Properties = Column7,
ViewProperties = "",
};

AddToViewItems("default", default_column7Component);
Controls.Add(Column7);

txEgitimTalepAciklama = new TextArea {
ControlId = "40484d1a-43e9-7a7b-8f81-d71842a6fb1d",
Name = "txEgitimTalepAciklama",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim Talep Açıklama" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 25
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
EntityPath = "ML.txEgitimTalepAciklama",
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
Rows = 3
};

Controls.Add(txEgitimTalepAciklama);

BaseComponent default_txegitimtalepaciklamaComponent = new BaseComponent {
Id = "txEgitimTalepAciklama",
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
Properties = txEgitimTalepAciklama,
ViewProperties = "",
};

AddToViewItems("default", default_txegitimtalepaciklamaComponent);

Column8 = new Column {
ControlId = "0b6db335-edc7-4cb7-ae15-b4bdde09e0f7",
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
"nbxKatilimciSayisi",
},
Properties = Column8,
ViewProperties = "",
};

AddToViewItems("default", default_column8Component);
Controls.Add(Column8);

Column9 = new Column {
ControlId = "e14a6d7c-3447-4afd-bc98-1b3fb7798fab",
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
"InputGroup10",
},
Properties = Column9,
ViewProperties = "",
};

AddToViewItems("default", default_column9Component);
Controls.Add(Column9);

InputGroup9 = new InputGroup {
ControlId = "d318ad08-041f-e414-25c2-9fe55d2b52f9",
Name = "InputGroup9",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "InputGroup9" },}){
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

Controls.Add(InputGroup9);

BaseComponent default_inputgroup9Component = new BaseComponent {
Id = "InputGroup9",
Type = "InputGroup",
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
"Section11",
},
Properties = InputGroup9,
ViewProperties = "",
};

AddToViewItems("default", default_inputgroup9Component);

Section11 = new Section {
ControlId = "729c984f-d439-4c6a-993d-6f17aea05517",
Name = "Section11",
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


BaseComponent default_section11Component = new BaseComponent {
Id = "Section11",
Type = "Section",
ParentId = "InputGroup9",
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
"Column33",
"Column32",
},
Properties = Section11,
ViewProperties = "",
};

AddToViewItems("default", default_section11Component);
Controls.Add(Section11);

Section12 = new Section {
ControlId = "18832662-ed00-401c-8435-50c2ce6bd8ab",
Name = "Section12",
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


BaseComponent default_section12Component = new BaseComponent {
Id = "Section12",
Type = "Section",
ParentId = "InputGroup10",
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
"Column35",
"Column34",
},
Properties = Section12,
ViewProperties = "",
};

AddToViewItems("default", default_section12Component);
Controls.Add(Section12);

AddViews("default,viewFinans");
ClientVisible = true;
ProjectName = "EgitimTalepDegerlendirmeSureci";
ProjectId = "5b7af9b4-6ff1-4b14-ab36-893a706aa0a0";
EntityPath = "";
ActiveView = "default";
Version = 19;
ReadOnly = false;
DefaultReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "FormEgitimPlanlama" },
{ "en-US", "FormEgitimPlanlama" },
{ "ru-RU", "FormEgitimPlanlama" },
{ "az-Latn-AZ", "FormEgitimPlanlama" },
};
Name = "FormEgitimPlanlama";
FormId = "6d0d140a-72e6-4c6a-a238-250ce889e220";
FormType = FormType.Standard;
ServerEvents = new List<EventItem> {
};
ClientEvents = new List<EventItem> {
};
Statuses = new List<DocumentStatus> {
};
IdentityFormat = "<u>";
IdentityFormatId = 0;
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
{ "ru-RU", "Сохранять" },
{ "az-Latn-AZ", "Yadda Saxla" },
},
View = "",
IsServerPrint = false,
},
new ToolbarButton {
Key = "toolbarSaveAsButton",
Name = "Farklı Kaydet",
Icon = "save-as",
Enabled = false,
DefaultEnabled = false,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Farklı Kaydet" },
{ "en-US", "Save As" },
{ "ru-RU", "Сохранить как" },
{ "az-Latn-AZ", "Fərqli Saxla" },
},
View = "",
IsServerPrint = false,
},
};
Variables = new Dictionary<string, object> {
};
Rules = new Dictionary<string, Rule> {
{
"dc30db86-f407-89a2-c1d8-edd3f097698a",
new Rule {
Id = "dc30db86-f407-89a2-c1d8-edd3f097698a",
Name = "OdemeYontemiKontrol",
Enabled = true,
OrderNo = 1,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "5b4c0b2e-b07a-43b7-8104-9ed460a60aa3",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "6c89f7fe-f603-8eba-3df8-c54e09078b85",
Name = "Sabit Değer Atama 1",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "maskIban",
PropertyName = "clientEnabled",
Type = FieldValueType.Boolean,
},
Value = true
},
},
ConditionGroup = new AndConditionGroup {
Id = "97b226ec-e592-2625-2103-36a6f8e2da78",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "5b4c0b2e-b07a-43b7-8104-9ed460a60aa3",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "cbxOdemeYontemi",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "Banka"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "d7c6506d-bb04-bf97-a747-a9979b99770f",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "d7c6506d-bb04-bf97-a747-a9979b99770f",
Name = "Sabit Değer Atama 2",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "maskIban",
PropertyName = "clientEnabled",
Type = FieldValueType.Boolean,
},
Value = false
},
},
},
},
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "6c89f7fe-f603-8eba-3df8-c54e09078b85",
Name = "Sabit Değer Atama 1",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "maskIban",
PropertyName = "clientEnabled",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "d7c6506d-bb04-bf97-a747-a9979b99770f",
Name = "Sabit Değer Atama 2",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "maskIban",
PropertyName = "clientEnabled",
Type = FieldValueType.Boolean,
},
Value = false
},
},
TriggerEvents = new List<string> {
"cbxOdemeYontemi.client.OnValueChanged",
"FormEgitimPlanlama.client.OnLoad",
}
}
},
{
"FormRequiredFields",
new Rule {
Id = "FormRequiredFields",
Name = "FormRequiredFields",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "FormRequiredFields_Statement_viewFinans_nbxEgitimBedel",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_viewFinans_nbxEgitimBedel",
Name = "nbxEgitimBedel_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Eğitim Bedeli: Gerekli alan"
},
{
"en-US",
"nbxEgitimBedel: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"nbxEgitimBedel",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_viewFinans_nbxEgitimBedel",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_viewFinans_nbxEgitimBedel_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "nbxEgitimBedel",
PropertyName = "value",
Type = FieldValueType.Number,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_viewFinans_nbxEgitimBedel",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FormEgitimPlanlama",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "viewFinans"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_viewFinans_cbxParaBirimi",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_viewFinans_cbxParaBirimi",
Name = "cbxParaBirimi_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"cbxParaBirimi: Gerekli alan"
},
{
"en-US",
"cbxParaBirimi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"cbxParaBirimi",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_viewFinans_cbxParaBirimi",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_viewFinans_cbxParaBirimi_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "cbxParaBirimi",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_viewFinans_cbxParaBirimi",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FormEgitimPlanlama",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "viewFinans"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_viewFinans_cbxOdemeYontemi",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_viewFinans_cbxOdemeYontemi",
Name = "cbxOdemeYontemi_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Ödeme Yöntemi: Gerekli alan"
},
{
"en-US",
"cbxOdemeYontemi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"cbxOdemeYontemi",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_viewFinans_cbxOdemeYontemi",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_viewFinans_cbxOdemeYontemi_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "cbxOdemeYontemi",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_viewFinans_cbxOdemeYontemi",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FormEgitimPlanlama",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "viewFinans"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_viewFinans_maskIban",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_viewFinans_maskIban",
Name = "maskIban_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"IBAN: Gerekli alan"
},
{
"en-US",
"maskIban: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"maskIban",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_viewFinans_maskIban",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_viewFinans_maskIban_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "maskIban",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_viewFinans_maskIban",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FormEgitimPlanlama",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "viewFinans"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_viewFinans_nbxEgitimBedel",
Name = "nbxEgitimBedel_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Eğitim Bedeli: Gerekli alan"
},
{
"en-US",
"nbxEgitimBedel: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"nbxEgitimBedel",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_viewFinans_cbxParaBirimi",
Name = "cbxParaBirimi_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"cbxParaBirimi: Gerekli alan"
},
{
"en-US",
"cbxParaBirimi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"cbxParaBirimi",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_viewFinans_cbxOdemeYontemi",
Name = "cbxOdemeYontemi_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Ödeme Yöntemi: Gerekli alan"
},
{
"en-US",
"cbxOdemeYontemi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"cbxOdemeYontemi",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_viewFinans_maskIban",
Name = "maskIban_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"IBAN: Gerekli alan"
},
{
"en-US",
"maskIban: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"maskIban",
},
},
},
TriggerEvents = new List<string> {
"FormEgitimPlanlama.client.OnBeforeSave",
"FormEgitimPlanlama.server.OnBeforeSave",
"FormEgitimPlanlama.client.OnToolbarButtonClicked",
"FormEgitimPlanlama.server.OnToolbarButtonClicked",
}
}
},
{
"b9494d8f-9dcb-49bc-b56e-a38a643d0965",
new Rule {
Id = "b9494d8f-9dcb-49bc-b56e-a38a643d0965",
Name = "cbxEgitimAdi_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "54f50ac8-3856-4bf8-9504-eec20d763050",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "3c2ba69a-c30d-4f31-93d6-4164f0771f10",
Name = "cbxEgitimAdi_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"cbxEgitimAdi alanı zorunludur"
},
{
"en-US",
"cbxEgitimAdi is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"cbxEgitimAdi",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "d103a116-db4e-4593-bc2c-d396d103ca9e",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "dc564c3b-a5d4-4d3b-9850-1bbd6339195e",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "cbxEgitimAdi",
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
Id = "36085bb0-df1b-4f7c-9fd9-43dd1ee44e74",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "3c2ba69a-c30d-4f31-93d6-4164f0771f10",
Name = "cbxEgitimAdi_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"cbxEgitimAdi alanı zorunludur"
},
{
"en-US",
"cbxEgitimAdi is required"
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
"FormEgitimPlanlama.server.OnBeforeSave",
}
}
},
{
"07ace6ff-43cf-4ec7-9952-b524994b3d27",
new Rule {
Id = "07ace6ff-43cf-4ec7-9952-b524994b3d27",
Name = "nbxEgitimBedel_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "33c4403e-96df-4241-ab1f-1f35829dbb93",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "40736a13-ca09-4608-8a9a-0b8992215d23",
Name = "nbxEgitimBedel_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"nbxEgitimBedel alanı zorunludur"
},
{
"en-US",
"nbxEgitimBedel is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"nbxEgitimBedel",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "040ebb2e-c433-4099-8b3a-ce61f5e51422",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "d0fb02a1-5858-4d74-a6ff-174c8d955d38",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "nbxEgitimBedel",
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
Id = "352e6087-53c5-44b8-8651-fc82f8a60477",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "40736a13-ca09-4608-8a9a-0b8992215d23",
Name = "nbxEgitimBedel_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"nbxEgitimBedel alanı zorunludur"
},
{
"en-US",
"nbxEgitimBedel is required"
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
"FormEgitimPlanlama.server.OnBeforeSave",
}
}
},
{
"cdcf29c1-5e16-41dc-8e19-aa371cfb8668",
new Rule {
Id = "cdcf29c1-5e16-41dc-8e19-aa371cfb8668",
Name = "cbxParaBirimi_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "9e5464b3-8c85-4ca4-b332-bd0f98c29fa3",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "da03dc8d-5bf3-4f8d-8e0b-73e6fb2e42f5",
Name = "cbxParaBirimi_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"cbxParaBirimi alanı zorunludur"
},
{
"en-US",
"cbxParaBirimi is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"cbxParaBirimi",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "81e1357b-f2a8-43d4-9810-477186a5e93e",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "81e700c6-ea5b-4a09-b6c6-5ed91a695f7c",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "cbxParaBirimi",
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
Id = "2cc8b11a-5f02-479a-8048-69a8fc31d5d8",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "da03dc8d-5bf3-4f8d-8e0b-73e6fb2e42f5",
Name = "cbxParaBirimi_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"cbxParaBirimi alanı zorunludur"
},
{
"en-US",
"cbxParaBirimi is required"
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
"FormEgitimPlanlama.server.OnBeforeSave",
}
}
},
{
"b129c227-fcd4-40c2-ad9e-76413065f690",
new Rule {
Id = "b129c227-fcd4-40c2-ad9e-76413065f690",
Name = "cbxOdemeYontemi_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "8a619267-c492-4ebe-86b8-33efe64fe868",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "c4d2129e-1d3d-4315-93f8-d215e4bdf1fc",
Name = "cbxOdemeYontemi_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"cbxOdemeYontemi alanı zorunludur"
},
{
"en-US",
"cbxOdemeYontemi is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"cbxOdemeYontemi",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "7f2f5484-c4c5-4eb1-8630-697068c67c81",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "a75ee8a9-0e4e-4d1e-aa88-6f42f9342160",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "cbxOdemeYontemi",
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
Id = "8fdd16a4-88d3-4a40-aae9-71780535a6ee",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "c4d2129e-1d3d-4315-93f8-d215e4bdf1fc",
Name = "cbxOdemeYontemi_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"cbxOdemeYontemi alanı zorunludur"
},
{
"en-US",
"cbxOdemeYontemi is required"
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
"FormEgitimPlanlama.server.OnBeforeSave",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim Planlama Formu" },{ "en-US", "FormEgitimPlanlama" },{ "ru-RU", "FormEgitimPlanlama" },{ "az-Latn-AZ", "FormEgitimPlanlama" },}){
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

BaseComponent default_formegitimplanlamaComponent = new BaseComponent {
Id = "FormEgitimPlanlama",
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
"Section13",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("default", default_formegitimplanlamaComponent);

Section13 = new Section {
ControlId = "eb95d891-d352-44e6-ae32-8f08b67422cb",
Name = "Section13",
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


BaseComponent default_section13Component = new BaseComponent {
Id = "Section13",
Type = "Section",
ParentId = "FormEgitimPlanlama",
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
Properties = Section13,
ViewProperties = "",
};

AddToViewItems("default", default_section13Component);
Controls.Add(Section13);

Section1 = new Section {
ControlId = "43640633-4177-46bd-808f-bf05db3dc499",
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
ParentId = "FormEgitimPlanlama",
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

Section2 = new Section {
ControlId = "1c41f0e2-4cb9-473e-b381-20bb4d982d48",
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

Section3 = new Section {
ControlId = "89e3c8ca-a9f1-4255-a906-edf662a87fa7",
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

Section4 = new Section {
ControlId = "af06a067-26f1-4f25-8ed4-01d4bf53e2d3",
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
ControlId = "4f590452-2265-4b61-a813-c57ffcd0bfc7",
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

dtEgitimBasTarih = new DateTimePicker {
ControlId = "e659258f-4b66-058f-645b-c5929711e570",
Name = "dtEgitimBasTarih",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanging",
MethodName = "dtEgitimBasTarih_OnValueChanging",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim Başlangıç Tarihi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 125,
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
EntityPath = "dtEgitimBasTarih",
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

Controls.Add(dtEgitimBasTarih);

BaseComponent default_dtegitimbastarihComponent = new BaseComponent {
Id = "dtEgitimBasTarih",
Type = "DateTimePicker",
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
Properties = dtEgitimBasTarih,
ViewProperties = "",
};

AddToViewItems("default", default_dtegitimbastarihComponent);

InputGroup10 = new InputGroup {
ControlId = "dec3f0d7-fae1-fdff-b2e1-3d2d8e392f8c",
Name = "InputGroup10",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "InputGroup10" },}){
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

Controls.Add(InputGroup10);

BaseComponent default_inputgroup10Component = new BaseComponent {
Id = "InputGroup10",
Type = "InputGroup",
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
"Section12",
},
Properties = InputGroup10,
ViewProperties = "",
};

AddToViewItems("default", default_inputgroup10Component);

Column32 = new Column {
ControlId = "b3d08ac6-5bd4-4cd0-a4ae-8ca95bc8b738",
Name = "Column32",
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


BaseComponent default_column32Component = new BaseComponent {
Id = "Column32",
Type = "Column",
ParentId = "Section11",
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
Properties = Column32,
ViewProperties = "",
};

AddToViewItems("default", default_column32Component);
Controls.Add(Column32);

dgKatilimcilar = new DataGrid {
ControlId = "9406c954-2439-1769-3cc4-fb19c4528bb9",
Name = "dgKatilimcilar",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnRender",
MethodName = "dgKatilimcilar_OnRender",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Katılımcılar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 25
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
EntityPath = "E_EgitimTalepDegerlendirmeSureci_FormEgitimPlanlama_dgKatilimcilar",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
DisplayType = DataGridDisplayType.AutoGrow,
PreferredWidthType = DataGridColumnPreferredWidthType.Auto,
SaveMode = SaveMode.Form,
Columns = new DataGridColumnCollection {
new GridColumn() {
EditControl = 
new NumberBox {
Visible = true,
EntityPath = "USERID",
ReadOnly = false,
Required = false,
},
DbType = new ColumnDbType() {
ColumnName = "USERID",
Type = "decimal"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "USERID" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.NumberBox,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "USERID",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = true,
IsGeneratedColumn = true,
Visible = false,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
PreferredWidth = 0,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
CheckUniqueValue = false,
CustomizeNullText = false,
NullText = new Dictionary<string, string> {
},
AlertType = AlertType.Warning,
AutoIncrement = false,
},
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.FULLNAME",
ReadOnly = false,
Required = false,
MaxLength = 50
},
DbType = new ColumnDbType() {
ColumnName = "FULLNAME",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "FULLNAME" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 1,
Name = "FULLNAME",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
PreferredWidth = 0,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
CheckUniqueValue = false,
CustomizeNullText = false,
NullText = new Dictionary<string, string> {
},
AlertType = AlertType.Warning,
AutoIncrement = false,
},
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.PROFESSION",
ReadOnly = false,
Required = false,
MaxLength = 50
},
DbType = new ColumnDbType() {
ColumnName = "PROFESSION",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "PROFESSION" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 2,
Name = "PROFESSION",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
PreferredWidth = 0,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
CheckUniqueValue = false,
CustomizeNullText = false,
NullText = new Dictionary<string, string> {
},
AlertType = AlertType.Warning,
AutoIncrement = false,
},
},
Rows = new DataGridRowCollection {

},
DataSource = new DataSource {
Name = "",
ValueMember = "",
DisplayMember = new List<string>{
},
DisplayFormat = "",
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
ColumnSettings = new DataGridColumnOptions {
Orderable = false,
Resizeable = false,
ShowColumnChooser = false,
},
DetailRow = new DataGridDetailRowOptions {
Enabled = false,
},
Editing = new DataGridEditingOptions {
Enabled = false,
ShowAddCommand = false,
ShowEditCommand = false,
ShowDeleteCommand = false,
Mode = DataGridEditingModeType.Row,
},
Filtering = new DataGridFilteringOptions {
Enabled = false,
ShowOperationChooser = false,
HeaderFilterEnabled = false,
},
Grouping = new DataGridGroupingOptions {
Enabled = false,
},
Paging = new DataGridPagingOptions {
Enabled = true,
CurrentPage = 1,
PageSize = 10,
PagingSizes = new List<int> {
10,
20,
30,
40,
},
},
Searching = new DataGridSearchingOptions {
Enabled = false,
},
Selection = new DataGridSelectionOptions {
Enabled = false,
Mode = DataGridSelectionMode.Single,
SelectAllMode = DataGridSelectAllMode.Page,
ShowCheckBoxesMode = DataGridShowCheckBoxMode.OnClick,
ShowSelectAll = false,
Type = DataGridSelectionType.Rowselect,
DisabledValueColumnName = "",
DisabledValueMatchers = new List<object>{
},},
Sorting = new DataGridSortingOptions {
Enabled = false,
AllSortingColumns = true,
Mode = DataGridSortingMode.None,
},
TreeView = new DataGridTreeViewOptions {
Enabled = false,
Id = "",
ParentId = "",
},
AlternateColor = new DataGridAlternateColorOptions {
Enabled = true,
Color = "rgba(33, 150, 243, 0.05)",
},
RowDragging = new DataGridRowDraggingOptions {
Enabled = false,
ShowDragIcons = false,
},
ToolbarActionButtons = new List<ExecuteActionButton> {
new ExecuteActionButton {
TypeName = ExecuteActionType.OpenSelectionFormArgs,
Icon = "add",
Title = new Dictionary<string, string> {
},
Text = new Dictionary<string, string> {
},
Args = new OpenSelectionFormArgs {
DataSource = new DataSource {
Name = "KatilimciGetir",
ValueMember = "",
DisplayMember = new List<string>{
},
DisplayFormat = "",
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
DoNotOverrideSelectedRows = false,
Options = new OpenSelectionGridOptionsArgs {
Columns = new DataGridColumnCollection {
new GridColumn() {
EditControl = 
new NumberBox {
Visible = true,
EntityPath = "USERID"
},
DbType = new ColumnDbType() {
ColumnName = "USERID",
Type = "decimal"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
EditType = ColumnEditType.NumberBox,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "USERID" },
},
EditingEnabled = true,
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = ""
},
Index = 0,
Name = "USERID",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = true,
IsGeneratedColumn = true,
Visible = true,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
},
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.FULLNAME",
MaxLength = 50
},
DbType = new ColumnDbType() {
ColumnName = "FULLNAME",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
EditType = ColumnEditType.TextBox,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "FULLNAME" },
},
EditingEnabled = true,
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = ""
},
Index = 0,
Name = "FULLNAME",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
},
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.PROFESSION",
MaxLength = 50
},
DbType = new ColumnDbType() {
ColumnName = "PROFESSION",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
EditType = ColumnEditType.TextBox,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "PROFESSION" },
},
EditingEnabled = true,
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = ""
},
Index = 0,
Name = "PROFESSION",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
},
},
ColumnSettings = new DataGridColumnOptions {
Orderable = true,
Resizeable = true,
ShowColumnChooser = false
},
Filtering = new DataGridFilteringOptions {
Enabled = true
},
Paging = new DataGridPagingOptions {
Enabled = true,
CurrentPage = 1,
PageSize = 10,
PagingSizes = new List<int> {
10,
20,
30,
40,
},
},
Searching = new DataGridSearchingOptions {
Enabled = true
},
Selection = new DataGridSelectionOptions {
Enabled = true,
SelectAllMode = DataGridSelectAllMode.Page,
Mode = DataGridSelectionMode.Multiple,
ShowCheckBoxesMode = DataGridShowCheckBoxMode.OnClick,
ShowSelectAll = false,
Type = DataGridSelectionType.Rowselect
},
Sorting = new DataGridSortingOptions {
Enabled = true,
AllSortingColumns = true,
Mode = DataGridSortingMode.Multiple,
},
ColumnMapping = new List<ColumnMapItem> {
new ColumnMapItem {
Source = "USERID",
Target = "USERID",
TargetEditType = ColumnEditType.TextBox,
},
new ColumnMapItem {
Source = "FULLNAME",
Target = "FULLNAME",
TargetEditType = ColumnEditType.TextBox,
},
new ColumnMapItem {
Source = "PROFESSION",
Target = "PROFESSION",
TargetEditType = ColumnEditType.TextBox,
},
},
},
OkButton = new OpenSelectionFormArgsOkButton {
Icon = "ok",
Text = null,
Title = null,
},
CacheSettingsEnabled = false,
Size = 1,
ShowOn = ActionButtonShowOnTypes.Panel,
CloseCurrentPanel = false,
Parameters = new List<ExecutionArgsParameterItem> {
},
},
Name = "Katılımcı Listesi",
Visible = true,
},
},
FillForm = null,
Height = null,
ExportToExcel = false,
GridBorder = true,
ColumnVerticalBorder = true,
VirtualScrolling = false,
HoverStateEnabled = false,
ShowClearAllButton = false,
ColumnAutoWidth = true,
SaveAction = false,
WordWrapEnabled = false,
ColumnHidingEnabled = false,
ColumnFixingEnabled = false,
CacheSettingsEnabled = false,
GridLines = DataGridLineType.Horizontal,
DataSourceType = DataSourceType.Dynamic,
HiddenRowColumnName = null,
HiddenRowValueMatchers = new DataGridHiddenRowValueOptions {
},
};

Controls.Add(dgKatilimcilar);

BaseComponent default_dgkatilimcilarComponent = new BaseComponent {
Id = "dgKatilimcilar",
Type = "DataGrid",
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
Properties = dgKatilimcilar,
ViewProperties = "",
};

AddToViewItems("default", default_dgkatilimcilarComponent);

Column33 = new Column {
ControlId = "579b128e-5aaf-49b1-8e4a-d1d207842737",
Name = "Column33",
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


BaseComponent default_column33Component = new BaseComponent {
Id = "Column33",
Type = "Column",
ParentId = "Section11",
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
Properties = Column33,
ViewProperties = "",
};

AddToViewItems("default", default_column33Component);
Controls.Add(Column33);

Column34 = new Column {
ControlId = "ac7c062f-7823-46db-a870-2d6f569b5308",
Name = "Column34",
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


BaseComponent default_column34Component = new BaseComponent {
Id = "Column34",
Type = "Column",
ParentId = "Section12",
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
Properties = Column34,
ViewProperties = "",
};

AddToViewItems("default", default_column34Component);
Controls.Add(Column34);

Column35 = new Column {
ControlId = "a31fb71d-e7fa-4e5b-9d15-e2099b560fce",
Name = "Column35",
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


BaseComponent default_column35Component = new BaseComponent {
Id = "Column35",
Type = "Column",
ParentId = "Section12",
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
Properties = Column35,
ViewProperties = "",
};

AddToViewItems("default", default_column35Component);
Controls.Add(Column35);

dtEgitimBitTarih = new DateTimePicker {
ControlId = "a0d17ca7-868d-7d62-89e0-155fdff77fa1",
Name = "dtEgitimBitTarih",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanging",
MethodName = "dtEgitimBitTarih_OnValueChanging",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim Bitiş Tarihi" },}){
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
EntityPath = "dtEgitimBitTarih",
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

Controls.Add(dtEgitimBitTarih);

BaseComponent default_dtegitimbittarihComponent = new BaseComponent {
Id = "dtEgitimBitTarih",
Type = "DateTimePicker",
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
Properties = dtEgitimBitTarih,
ViewProperties = "",
};

AddToViewItems("default", default_dtegitimbittarihComponent);

nbxKatilimciSayisi = new NumberBox {
ControlId = "1af895ba-af22-8ef6-c30a-66ed757f2832",
Name = "nbxKatilimciSayisi",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Katılımcı Sayısı" },}){
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
EntityPath = "nbxKatilimciSayisi",
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
TextAlign = HorizontalAlign.Right,
Min = null,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(nbxKatilimciSayisi);

BaseComponent default_nbxkatilimcisayisiComponent = new BaseComponent {
Id = "nbxKatilimciSayisi",
Type = "NumberBox",
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
Properties = nbxKatilimciSayisi,
ViewProperties = "",
};

AddToViewItems("default", default_nbxkatilimcisayisiComponent);

Column1 = new Column {
ControlId = "0d1097d3-0c33-4ca8-a94e-c4a219d82ddb",
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
"InputGroup3",
"txEgitimTalepAciklama",
"dgKatilimcilar",
"InputGroup4",
},
Properties = Column1,
ViewProperties = "",
};

AddToViewItems("default", default_column1Component);
Controls.Add(Column1);

InputGroup1 = new InputGroup {
ControlId = "6e1024af-3617-4076-5fcc-680f55270479",
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
ControlId = "e50b5fe9-9840-48fe-a331-5687ff43e6a5",
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
"tbxEgitmen",
},
Properties = Column2,
ViewProperties = "",
};

AddToViewItems("default", default_column2Component);
Controls.Add(Column2);

cbxEgitimAdi = new ComboBox {
ControlId = "18ef63d8-18c5-cfc6-ab30-8f56a9a4d034",
Name = "cbxEgitimAdi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnSelectedItemChanging",
MethodName = "cbxEgitimAdi_OnSelectedItemChanging",
Async = null
},
new EventItem {
Name = "OnValueChanging",
MethodName = "cbxEgitimAdi_OnValueChanging",
Async = null
},
new EventItem {
Name = "OnTextChanging",
MethodName = "cbxEgitimAdi_OnTextChanging",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim Adı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 125,
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
EntityPath = "SL.cbxEgitimAdi",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "EgitimBilgileriBetir",
ValueMember = "DGID",
DisplayMember = new List<string>{
"tbxEgitimAdi",
},
DisplayFormat = "{{ tbxEgitimAdi }}",
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
ValueType = PrimitiveType.String,
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

Controls.Add(cbxEgitimAdi);
cbxEgitimAdi.Items = new ListItemCollection();

BaseComponent default_cbxegitimadiComponent = new BaseComponent {
Id = "cbxEgitimAdi",
Type = "ComboBox",
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
Properties = cbxEgitimAdi,
ViewProperties = "",
};

AddToViewItems("default", default_cbxegitimadiComponent);

InputGroup2 = new InputGroup {
ControlId = "0529341f-df51-231e-8f43-faaa16bdd28d",
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
ControlId = "f25d2bd7-b220-4d2a-b4bf-e02b776004fc",
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
"cbxEgitimAdi",
},
Properties = Column3,
ViewProperties = "",
};

AddToViewItems("default", default_column3Component);
Controls.Add(Column3);

Label1 = new Label {
ControlId = "fc7067d1-17c0-6393-25e9-a59ca723432a",
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
Size = "20",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim Planlama Formu" },{ "en-US", "Label1" },}){
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

tbxEgitimYeri = new TextBox {
ControlId = "44472564-2072-1e5c-ed6e-4f12a3ee48dd",
Name = "tbxEgitimYeri",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim Yeri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 125,
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
EntityPath = "ML.tbxEgitimYeri",
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

Controls.Add(tbxEgitimYeri);

BaseComponent default_tbxegitimyeriComponent = new BaseComponent {
Id = "tbxEgitimYeri",
Type = "TextBox",
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
Properties = tbxEgitimYeri,
ViewProperties = "",
};

AddToViewItems("default", default_tbxegitimyeriComponent);

InputGroup3 = new InputGroup {
ControlId = "b0b7ca52-eeef-8291-f320-c55a3e113e47",
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
ControlId = "cc2a8ef1-37ad-46d8-8074-f74ae6d660a6",
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
"dtEgitimBitTarih",
},
Properties = Column4,
ViewProperties = "",
};

AddToViewItems("default", default_column4Component);
Controls.Add(Column4);

InputGroup4 = new InputGroup {
ControlId = "cfb448fa-5075-3f9d-0945-d32dcef3a32f",
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

tbxEgitmen = new TextBox {
ControlId = "398227a5-e597-e40e-17ea-9197e30e3a22",
Name = "tbxEgitmen",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitmen" },}){
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
EntityPath = "ML.tbxEgitmen",
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

Controls.Add(tbxEgitmen);

BaseComponent default_tbxegitmenComponent = new BaseComponent {
Id = "tbxEgitmen",
Type = "TextBox",
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
Properties = tbxEgitmen,
ViewProperties = "",
};

AddToViewItems("default", default_tbxegitmenComponent);

Column5 = new Column {
ControlId = "bf79f042-ef34-4b31-8125-4545dd716cc4",
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
"dtEgitimBasTarih",
},
Properties = Column5,
ViewProperties = "",
};

AddToViewItems("default", default_column5Component);
Controls.Add(Column5);

InputGroup5 = new InputGroup {
ControlId = "af621d64-c78b-564f-111c-40f463c74f6a",
Name = "InputGroup5",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "InputGroup5" },}){
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

Controls.Add(InputGroup5);

BaseComponent viewfinans_inputgroup5Component = new BaseComponent {
Id = "InputGroup5",
Type = "InputGroup",
ParentId = "Column19",
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
"Section6",
},
Properties = InputGroup5,
ViewProperties = "{\\\"caption\\\":{\\\"visible\\\":false},\\\"commitId\\\":0}",
};

AddToViewItems("viewFinans", viewfinans_inputgroup5Component);

InputGroup6 = new InputGroup {
ControlId = "f163cf07-2795-7b6a-de32-3c11bbf18a84",
Name = "InputGroup6",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "InputGroup6" },}){
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

Controls.Add(InputGroup6);

BaseComponent viewfinans_inputgroup6Component = new BaseComponent {
Id = "InputGroup6",
Type = "InputGroup",
ParentId = "Column19",
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
"Section7",
},
Properties = InputGroup6,
ViewProperties = "{\\\"caption\\\":{\\\"visible\\\":false},\\\"commitId\\\":0}",
};

AddToViewItems("viewFinans", viewfinans_inputgroup6Component);

InputGroup7 = new InputGroup {
ControlId = "20792d59-8ff8-ec42-3db1-3f24f7f0b48b",
Name = "InputGroup7",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "InputGroup7" },}){
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

Controls.Add(InputGroup7);

BaseComponent viewfinans_inputgroup7Component = new BaseComponent {
Id = "InputGroup7",
Type = "InputGroup",
ParentId = "Column10",
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
"Section9",
},
Properties = InputGroup7,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_inputgroup7Component);

BaseComponent viewfinans_txegitimtalepaciklamaComponent = new BaseComponent {
Id = "txEgitimTalepAciklama",
Type = "TextArea",
ParentId = "Column19",
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
Properties = txEgitimTalepAciklama,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_txegitimtalepaciklamaComponent);

InputGroup8 = new InputGroup {
ControlId = "ef225fb7-5544-a782-953e-025e22789bc4",
Name = "InputGroup8",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "InputGroup8" },}){
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

Controls.Add(InputGroup8);

BaseComponent viewfinans_inputgroup8Component = new BaseComponent {
Id = "InputGroup8",
Type = "InputGroup",
ParentId = "Column13",
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
"Section10",
},
Properties = InputGroup8,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_inputgroup8Component);

Section10 = new Section {
ControlId = "308e7123-968e-432b-b94d-e74bf2598e4b",
Name = "Section10",
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


BaseComponent viewfinans_section10Component = new BaseComponent {
Id = "Section10",
Type = "Section",
ParentId = "InputGroup8",
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
"Column31",
"Column30",
},
Properties = Section10,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_section10Component);
Controls.Add(Section10);

BaseComponent viewfinans_formegitimplanlamaComponent = new BaseComponent {
Id = "FormEgitimPlanlama",
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
"Column14",
"Section8",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_formegitimplanlamaComponent);

Section6 = new Section {
ControlId = "c0f344a2-8d8f-4b1e-969b-7da3bfeb5ccc",
Name = "Section6",
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


BaseComponent viewfinans_section6Component = new BaseComponent {
Id = "Section6",
Type = "Section",
ParentId = "InputGroup5",
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
"Column25",
"Column24",
},
Properties = Section6,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_section6Component);
Controls.Add(Section6);

BaseComponent viewfinans_dtegitimbastarihComponent = new BaseComponent {
Id = "dtEgitimBasTarih",
Type = "DateTimePicker",
ParentId = "Column23",
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
Properties = dtEgitimBasTarih,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_dtegitimbastarihComponent);

maskIban = new MaskInput {
ControlId = "8452737b-c4ef-0e0d-ccf2-ad18ce67138c",
Name = "maskIban",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "IBAN" },}){
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
EntityPath = "maskIban",
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
Mask = @"TR99 9999 9999 9999 9999 9999 99",
FormatChars = new List<TextValueItem> {
},
SizeType = null,
MaxLength = 50,
};

Controls.Add(maskIban);

BaseComponent viewfinans_maskibanComponent = new BaseComponent {
Id = "maskIban",
Type = "MaskInput",
ParentId = "Column26",
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
Properties = maskIban,
ViewProperties = "{\\\"caption\\\":{\\\"text\\\":{\\\"tr-TR\\\":\\\"IBAN\\\"},\\\"visible\\\":true},\\\"mask\\\":\\\"TR99 9999 9999 9999 9999 9999 99\\\",\\\"commitId\\\":73,\\\"clientEnabled\\\":false,\\\"required\\\":true}",
};

AddToViewItems("viewFinans", viewfinans_maskibanComponent);

Section7 = new Section {
ControlId = "b7226854-ec59-4e24-8145-72c68c23fc26",
Name = "Section7",
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


BaseComponent viewfinans_section7Component = new BaseComponent {
Id = "Section7",
Type = "Section",
ParentId = "InputGroup6",
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
"Column27",
"Column26",
},
Properties = Section7,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_section7Component);
Controls.Add(Section7);

nbxEgitimBedel = new NumberBox {
ControlId = "5e72a733-e972-bdd4-4e99-2bf322c7c90a",
Name = "nbxEgitimBedel",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim Bedeli" },}){
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
EntityPath = "nbxEgitimBedel",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = 0M,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Right,
Min = 0M,
Max = 99999999999999M,
Step = 1M,
Precision = 2,
UseThousandSeparator = true,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(nbxEgitimBedel);

BaseComponent viewfinans_nbxegitimbedelComponent = new BaseComponent {
Id = "nbxEgitimBedel",
Type = "NumberBox",
ParentId = "Column25",
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
Properties = nbxEgitimBedel,
ViewProperties = "{\\\"useThousandSeparator\\\":true,\\\"commitId\\\":12,\\\"required\\\":true}",
};

AddToViewItems("viewFinans", viewfinans_nbxegitimbedelComponent);

Column30 = new Column {
ControlId = "62acabab-d15f-4ca4-b917-c23c44369d4a",
Name = "Column30",
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


BaseComponent viewfinans_column30Component = new BaseComponent {
Id = "Column30",
Type = "Column",
ParentId = "Section10",
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
Properties = Column30,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column30Component);
Controls.Add(Column30);

Section8 = new Section {
ControlId = "625dc97f-47ac-44d9-b2d8-f513cbe30d2b",
Name = "Section8",
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


BaseComponent viewfinans_section8Component = new BaseComponent {
Id = "Section8",
Type = "Section",
ParentId = "FormEgitimPlanlama",
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
Properties = Section8,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_section8Component);
Controls.Add(Section8);

cbxParaBirimi = new ComboBox {
ControlId = "ef2a385a-a5f4-0955-af1d-51cb3d3a6c6f",
Name = "cbxParaBirimi",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "" },}){
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
EntityPath = "SL.cbxParaBirimi",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
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

Controls.Add(cbxParaBirimi);
cbxParaBirimi.Items = new ListItemCollection();

cbxParaBirimi.Items.Add(new ListItem {
Value = "USD",
Key = "USD",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "USD" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

cbxParaBirimi.Items.Add(new ListItem {
Value = "EUR",
Key = "EUR",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "EUR" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

cbxParaBirimi.Items.Add(new ListItem {
Value = "TL",
Key = "TL",
Icon = @"",
Selected = true,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "TL" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent viewfinans_cbxparabirimiComponent = new BaseComponent {
Id = "cbxParaBirimi",
Type = "ComboBox",
ParentId = "Column24",
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
Properties = cbxParaBirimi,
ViewProperties = "{\\\"caption\\\":{\\\"text\\\":{\\\"tr-TR\\\":\\\"\\\"},\\\"visible\\\":true},\\\"commitId\\\":32,\\\"required\\\":true}",
};

AddToViewItems("viewFinans", viewfinans_cbxparabirimiComponent);

Column20 = new Column {
ControlId = "cea11e49-da0a-48e6-9272-9f16ab8dafb4",
Name = "Column20",
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


BaseComponent viewfinans_column20Component = new BaseComponent {
Id = "Column20",
Type = "Column",
ParentId = "Column15",
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
"tbxEgitmen",
},
Properties = Column20,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column20Component);
Controls.Add(Column20);

Column31 = new Column {
ControlId = "65ed52fa-b158-4515-8973-bbcc19c0e376",
Name = "Column31",
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


BaseComponent viewfinans_column31Component = new BaseComponent {
Id = "Column31",
Type = "Column",
ParentId = "Section10",
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
Properties = Column31,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column31Component);
Controls.Add(Column31);

Section9 = new Section {
ControlId = "6e06a7b6-6771-49a7-a4d1-abf4db415ee3",
Name = "Section9",
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


BaseComponent viewfinans_section9Component = new BaseComponent {
Id = "Section9",
Type = "Section",
ParentId = "InputGroup7",
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
"Column29",
"Column28",
},
Properties = Section9,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_section9Component);
Controls.Add(Section9);

Column10 = new Column {
ControlId = "a2a9fcf7-cffb-4348-8127-5efc6880f344",
Name = "Column10",
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


BaseComponent viewfinans_column10Component = new BaseComponent {
Id = "Column10",
Type = "Column",
ParentId = "Column17",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"InputGroup7",
},
Properties = Column10,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column10Component);
Controls.Add(Column10);

Column21 = new Column {
ControlId = "dec66ddb-27c3-430a-9ed6-30e828dd7098",
Name = "Column21",
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


BaseComponent viewfinans_column21Component = new BaseComponent {
Id = "Column21",
Type = "Column",
ParentId = "Column15",
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
"cbxEgitimAdi",
},
Properties = Column21,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column21Component);
Controls.Add(Column21);

BaseComponent viewfinans_dgkatilimcilarComponent = new BaseComponent {
Id = "dgKatilimcilar",
Type = "DataGrid",
ParentId = "Column19",
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
Properties = dgKatilimcilar,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_dgkatilimcilarComponent);

Column11 = new Column {
ControlId = "539cadfb-e3ff-4101-963d-d2cecf99ff0f",
Name = "Column11",
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


BaseComponent viewfinans_column11Component = new BaseComponent {
Id = "Column11",
Type = "Column",
ParentId = "Column17",
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
"tbxEgitimYeri",
},
Properties = Column11,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column11Component);
Controls.Add(Column11);

Column22 = new Column {
ControlId = "dc4e8ebf-9165-4cff-9cbc-a4ea527958cd",
Name = "Column22",
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


BaseComponent viewfinans_column22Component = new BaseComponent {
Id = "Column22",
Type = "Column",
ParentId = "Column16",
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
"dtEgitimBitTarih",
},
Properties = Column22,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column22Component);
Controls.Add(Column22);

cbxOdemeYontemi = new ComboBox {
ControlId = "f0f571b2-903e-4408-2208-ea8538189114",
Name = "cbxOdemeYontemi",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ödeme Yöntemi" },}){
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
EntityPath = "SL.cbxOdemeYontemi",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
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

Controls.Add(cbxOdemeYontemi);
cbxOdemeYontemi.Items = new ListItemCollection();

cbxOdemeYontemi.Items.Add(new ListItem {
Value = "Banka",
Key = "Banka",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Banka" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

cbxOdemeYontemi.Items.Add(new ListItem {
Value = "Nakit",
Key = "Nakit",
Icon = @"",
Selected = true,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Nakit" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent viewfinans_cbxodemeyontemiComponent = new BaseComponent {
Id = "cbxOdemeYontemi",
Type = "ComboBox",
ParentId = "Column27",
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
Properties = cbxOdemeYontemi,
ViewProperties = "{\\\"caption\\\":{\\\"text\\\":{\\\"tr-TR\\\":\\\"Ödeme Yöntemi\\\"},\\\"visible\\\":true},\\\"commitId\\\":9,\\\"required\\\":true}",
};

AddToViewItems("viewFinans", viewfinans_cbxodemeyontemiComponent);

Column12 = new Column {
ControlId = "4859736c-60ae-4746-81fe-fc055eaf57e7",
Name = "Column12",
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


BaseComponent viewfinans_column12Component = new BaseComponent {
Id = "Column12",
Type = "Column",
ParentId = "Column18",
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
"nbxKatilimciSayisi",
},
Properties = Column12,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column12Component);
Controls.Add(Column12);

Column23 = new Column {
ControlId = "0ccb6678-777b-42f0-91d8-a691db87adf1",
Name = "Column23",
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


BaseComponent viewfinans_column23Component = new BaseComponent {
Id = "Column23",
Type = "Column",
ParentId = "Column16",
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
"dtEgitimBasTarih",
},
Properties = Column23,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column23Component);
Controls.Add(Column23);

Column13 = new Column {
ControlId = "438c2306-9716-49be-a537-778d012ae747",
Name = "Column13",
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


BaseComponent viewfinans_column13Component = new BaseComponent {
Id = "Column13",
Type = "Column",
ParentId = "Column18",
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
"InputGroup8",
},
Properties = Column13,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column13Component);
Controls.Add(Column13);

Column24 = new Column {
ControlId = "bfb987e0-f89a-4edf-8228-d571659bd155",
Name = "Column24",
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


BaseComponent viewfinans_column24Component = new BaseComponent {
Id = "Column24",
Type = "Column",
ParentId = "Section6",
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
"cbxParaBirimi",
},
Properties = Column24,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column24Component);
Controls.Add(Column24);

Divider1 = new Divider {
ControlId = "6881256c-6fba-c805-5896-9abf7296c68b",
Name = "Divider1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider1" },}){
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
};

Controls.Add(Divider1);

BaseComponent viewfinans_divider1Component = new BaseComponent {
Id = "Divider1",
Type = "Divider",
ParentId = "Column19",
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
Properties = Divider1,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_divider1Component);

BaseComponent viewfinans_dtegitimbittarihComponent = new BaseComponent {
Id = "dtEgitimBitTarih",
Type = "DateTimePicker",
ParentId = "Column22",
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
Properties = dtEgitimBitTarih,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_dtegitimbittarihComponent);

Column14 = new Section {
ControlId = "7de16f3b-1bf3-4a43-9eb5-7610f68917e7",
Name = "Column14",
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


BaseComponent viewfinans_column14Component = new BaseComponent {
Id = "Column14",
Type = "Section",
ParentId = "FormEgitimPlanlama",
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
"Column19",
},
Properties = Column14,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column14Component);
Controls.Add(Column14);

Column25 = new Column {
ControlId = "506dc2d3-de87-4ffa-becd-68028b34286c",
Name = "Column25",
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


BaseComponent viewfinans_column25Component = new BaseComponent {
Id = "Column25",
Type = "Column",
ParentId = "Section6",
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
"nbxEgitimBedel",
},
Properties = Column25,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column25Component);
Controls.Add(Column25);

Column15 = new Section {
ControlId = "8f032775-8057-4179-92c1-bab996d49e62",
Name = "Column15",
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


BaseComponent viewfinans_column15Component = new BaseComponent {
Id = "Column15",
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
"Column21",
"Column20",
},
Properties = Column15,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column15Component);
Controls.Add(Column15);

Column26 = new Column {
ControlId = "52856e25-26cf-42bd-849c-d6a8089578bb",
Name = "Column26",
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


BaseComponent viewfinans_column26Component = new BaseComponent {
Id = "Column26",
Type = "Column",
ParentId = "Section7",
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
"maskIban",
},
Properties = Column26,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column26Component);
Controls.Add(Column26);

Column16 = new Section {
ControlId = "19e14eae-71a1-42cd-8e6b-551eb7bb25e3",
Name = "Column16",
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


BaseComponent viewfinans_column16Component = new BaseComponent {
Id = "Column16",
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
"Column23",
"Column22",
},
Properties = Column16,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column16Component);
Controls.Add(Column16);

Column27 = new Column {
ControlId = "142d5235-cde9-4028-8fe9-bf69feaeb1d2",
Name = "Column27",
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


BaseComponent viewfinans_column27Component = new BaseComponent {
Id = "Column27",
Type = "Column",
ParentId = "Section7",
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
"cbxOdemeYontemi",
},
Properties = Column27,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column27Component);
Controls.Add(Column27);

BaseComponent viewfinans_nbxkatilimcisayisiComponent = new BaseComponent {
Id = "nbxKatilimciSayisi",
Type = "NumberBox",
ParentId = "Column12",
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
Properties = nbxKatilimciSayisi,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_nbxkatilimcisayisiComponent);

Column17 = new Section {
ControlId = "6313ed63-7cd7-4b44-af3f-f61837621270",
Name = "Column17",
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


BaseComponent viewfinans_column17Component = new BaseComponent {
Id = "Column17",
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
"Column11",
"Column10",
},
Properties = Column17,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column17Component);
Controls.Add(Column17);

Column28 = new Column {
ControlId = "e1581dcf-93a9-4954-ab01-d8bcc5ada696",
Name = "Column28",
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


BaseComponent viewfinans_column28Component = new BaseComponent {
Id = "Column28",
Type = "Column",
ParentId = "Section9",
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
Properties = Column28,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column28Component);
Controls.Add(Column28);

BaseComponent viewfinans_inputgroup1Component = new BaseComponent {
Id = "InputGroup1",
Type = "InputGroup",
ParentId = "Column19",
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
"Column15",
},
Properties = InputGroup1,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_inputgroup1Component);

BaseComponent viewfinans_cbxegitimadiComponent = new BaseComponent {
Id = "cbxEgitimAdi",
Type = "ComboBox",
ParentId = "Column21",
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
Properties = cbxEgitimAdi,
ViewProperties = "{\\\"caption\\\":{\\\"size\\\":{\\\"width\\\":125}},\\\"commitId\\\":13}",
};

AddToViewItems("viewFinans", viewfinans_cbxegitimadiComponent);

Column18 = new Section {
ControlId = "a44a7f69-7fbb-42fd-9d92-eafa471bdd1f",
Name = "Column18",
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


BaseComponent viewfinans_column18Component = new BaseComponent {
Id = "Column18",
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
"Column13",
"Column12",
},
Properties = Column18,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column18Component);
Controls.Add(Column18);

Column29 = new Column {
ControlId = "c2d02137-4dae-4f1d-aa12-a4cb2d410ff8",
Name = "Column29",
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


BaseComponent viewfinans_column29Component = new BaseComponent {
Id = "Column29",
Type = "Column",
ParentId = "Section9",
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
Properties = Column29,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column29Component);
Controls.Add(Column29);

BaseComponent viewfinans_inputgroup2Component = new BaseComponent {
Id = "InputGroup2",
Type = "InputGroup",
ParentId = "Column19",
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
"Column16",
},
Properties = InputGroup2,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_inputgroup2Component);

BaseComponent viewfinans_label1Component = new BaseComponent {
Id = "Label1",
Type = "Label",
ParentId = "Column19",
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

AddToViewItems("viewFinans", viewfinans_label1Component);

Column19 = new Column {
ControlId = "bb68f0b0-6032-4600-b346-56ebef41a2c2",
Name = "Column19",
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


BaseComponent viewfinans_column19Component = new BaseComponent {
Id = "Column19",
Type = "Column",
ParentId = "Column14",
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
"Divider1",
"InputGroup1",
"InputGroup2",
"InputGroup3",
"txEgitimTalepAciklama",
"dgKatilimcilar",
"InputGroup4",
"InputGroup5",
"InputGroup6",
},
Properties = Column19,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_column19Component);
Controls.Add(Column19);

BaseComponent viewfinans_tbxegitimyeriComponent = new BaseComponent {
Id = "tbxEgitimYeri",
Type = "TextBox",
ParentId = "Column11",
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
Properties = tbxEgitimYeri,
ViewProperties = "{\\\"caption\\\":{\\\"size\\\":{\\\"width\\\":125}},\\\"commitId\\\":9}",
};

AddToViewItems("viewFinans", viewfinans_tbxegitimyeriComponent);

BaseComponent viewfinans_inputgroup3Component = new BaseComponent {
Id = "InputGroup3",
Type = "InputGroup",
ParentId = "Column19",
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
"Column17",
},
Properties = InputGroup3,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_inputgroup3Component);

BaseComponent viewfinans_inputgroup4Component = new BaseComponent {
Id = "InputGroup4",
Type = "InputGroup",
ParentId = "Column19",
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
"Column18",
},
Properties = InputGroup4,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_inputgroup4Component);

BaseComponent viewfinans_tbxegitmenComponent = new BaseComponent {
Id = "tbxEgitmen",
Type = "TextBox",
ParentId = "Column20",
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
Properties = tbxEgitmen,
ViewProperties = "",
};

AddToViewItems("viewFinans", viewfinans_tbxegitmenComponent);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            

























        }
    }
}