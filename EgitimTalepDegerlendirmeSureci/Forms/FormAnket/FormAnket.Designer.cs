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

    public partial class FormAnket : Form<E_EgitimTalepDegerlendirmeSureci_FormAnketEntity> {

        // properties
        Column Column6 { get; set; }
Column Column7 { get; set; }
TextBox tbxEgitimAdiAnket { get; set; }
Column Column8 { get; set; }
Column Column9 { get; set; }
TextBox tbxKatilimciAnket { get; set; }
Section Section1 { get; set; }
TextArea txDegerlendirmeAciklama { get; set; }
Section Section2 { get; set; }
TextBox tbxUnvanAnket { get; set; }
TextBox tbxEgitmenAnket { get; set; }
Section Section3 { get; set; }
TextBox tbxEgitimYeriAnket { get; set; }
Section Section4 { get; set; }
Section Section5 { get; set; }
NumberBox nbxDegerlendirmepuan { get; set; }
Section Section6 { get; set; }
Section Section7 { get; set; }
Column Column10 { get; set; }
DateTimePicker dtEgitimBitTarihAnket { get; set; }
Column Column11 { get; set; }
Divider Divider1 { get; set; }
Column Column1 { get; set; }
InputGroup InputGroup1 { get; set; }
DateTimePicker dtEgitimBasTarihAnket { get; set; }
Column Column2 { get; set; }
InputGroup InputGroup2 { get; set; }
Column Column3 { get; set; }
Label Label1 { get; set; }
InputGroup InputGroup3 { get; set; }
Column Column4 { get; set; }
InputGroup InputGroup4 { get; set; }
Column Column5 { get; set; }


        // constructor
        public FormAnket(FormHttpParameters httpParameters, IContext context)
 : base(httpParameters, context)
        {
        }

        // initialize members
        public override void InitMembers()
        {
            
Column6 = new Column {
ControlId = "6a019fca-3c33-4709-82bd-3c12ee759a37",
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
"dtEgitimBitTarihAnket",
},
Properties = Column6,
ViewProperties = "",
};

AddToViewItems("default", default_column6Component);
Controls.Add(Column6);

Column7 = new Column {
ControlId = "40370393-a5b1-46f2-81ab-3a9866562528",
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
"dtEgitimBasTarihAnket",
},
Properties = Column7,
ViewProperties = "",
};

AddToViewItems("default", default_column7Component);
Controls.Add(Column7);

tbxEgitimAdiAnket = new TextBox {
ControlId = "47f14557-04ae-4732-8a2d-e192467ce991",
Name = "tbxEgitimAdiAnket",
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
EntityPath = "ML.tbxEgitimAdiAnket",
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

Controls.Add(tbxEgitimAdiAnket);

BaseComponent default_tbxegitimadianketComponent = new BaseComponent {
Id = "tbxEgitimAdiAnket",
Type = "TextBox",
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
Properties = tbxEgitimAdiAnket,
ViewProperties = "",
};

AddToViewItems("default", default_tbxegitimadianketComponent);

Column8 = new Column {
ControlId = "20d458ed-5f17-48f8-96a2-71990a002d70",
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
"nbxDegerlendirmepuan",
},
Properties = Column8,
ViewProperties = "",
};

AddToViewItems("default", default_column8Component);
Controls.Add(Column8);

Column9 = new Column {
ControlId = "eb15e930-2459-4cd6-900a-d8aa552af83e",
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
"tbxEgitimYeriAnket",
},
Properties = Column9,
ViewProperties = "",
};

AddToViewItems("default", default_column9Component);
Controls.Add(Column9);

AddViews("default");
ClientVisible = true;
ProjectName = "EgitimTalepDegerlendirmeSureci";
ProjectId = "5b7af9b4-6ff1-4b14-ab36-893a706aa0a0";
EntityPath = "";
ActiveView = "default";
Version = 19;
ReadOnly = false;
DefaultReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "FormAnket" },
{ "en-US", "FormAnket" },
{ "ru-RU", "FormAnket" },
{ "az-Latn-AZ", "FormAnket" },
};
Name = "FormAnket";
FormId = "ccce75b3-e9f5-4348-b408-81e8fba5bcde";
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
"FormRequiredFields",
new Rule {
Id = "FormRequiredFields",
Name = "FormRequiredFields",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "FormRequiredFields_Statement_default_nbxDegerlendirmepuan",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_nbxDegerlendirmepuan",
Name = "nbxDegerlendirmepuan_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Değerlendirme Puanı: Gerekli alan"
},
{
"en-US",
"nbxDegerlendirmepuan: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"nbxDegerlendirmepuan",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_nbxDegerlendirmepuan",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_nbxDegerlendirmepuan_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "nbxDegerlendirmepuan",
PropertyName = "value",
Type = FieldValueType.Number,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_nbxDegerlendirmepuan",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "FormAnket",
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
Id = "FormRequiredToasterMessage_default_nbxDegerlendirmepuan",
Name = "nbxDegerlendirmepuan_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Değerlendirme Puanı: Gerekli alan"
},
{
"en-US",
"nbxDegerlendirmepuan: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"nbxDegerlendirmepuan",
},
},
},
TriggerEvents = new List<string> {
"FormAnket.client.OnBeforeSave",
"FormAnket.server.OnBeforeSave",
"FormAnket.client.OnToolbarButtonClicked",
"FormAnket.server.OnToolbarButtonClicked",
}
}
},
{
"87bf8db3-b12d-46e3-abde-ac5995af998b",
new Rule {
Id = "87bf8db3-b12d-46e3-abde-ac5995af998b",
Name = "nbxDegerlendirmepuan_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "fdc5b6f8-3ad4-407c-ad75-dafa503c36b1",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "b37b41bd-2b44-496d-aeac-3c84ebba8b17",
Name = "nbxDegerlendirmepuan_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"nbxDegerlendirmepuan alanı zorunludur"
},
{
"en-US",
"nbxDegerlendirmepuan is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"nbxDegerlendirmepuan",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "8b8785c8-9863-4883-8890-e0ce8c4d2f69",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "f0a847fc-0885-471a-99df-bd16ca966aa6",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "nbxDegerlendirmepuan",
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
Id = "6795b1e4-b02d-48ef-b721-042a6fb3a463",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "b37b41bd-2b44-496d-aeac-3c84ebba8b17",
Name = "nbxDegerlendirmepuan_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"nbxDegerlendirmepuan alanı zorunludur"
},
{
"en-US",
"nbxDegerlendirmepuan is required"
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
"FormAnket.server.OnBeforeSave",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "FormAnket" },{ "en-US", "FormAnket" },{ "ru-RU", "FormAnket" },{ "az-Latn-AZ", "FormAnket" },}){
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

BaseComponent default_formanketComponent = new BaseComponent {
Id = "FormAnket",
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
"Section7",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("default", default_formanketComponent);

tbxKatilimciAnket = new TextBox {
ControlId = "8bf0c3e3-c939-486e-c7b7-fb0aa595b756",
Name = "tbxKatilimciAnket",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Katılımcı" },}){
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
EntityPath = "ML.TextBox1",
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

Controls.Add(tbxKatilimciAnket);

BaseComponent default_tbxkatilimcianketComponent = new BaseComponent {
Id = "tbxKatilimciAnket",
Type = "TextBox",
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
Properties = tbxKatilimciAnket,
ViewProperties = "",
};

AddToViewItems("default", default_tbxkatilimcianketComponent);

Section1 = new Section {
ControlId = "033bed73-9889-4230-816c-4b49c008787e",
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
ParentId = "FormAnket",
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

txDegerlendirmeAciklama = new TextArea {
ControlId = "c9476605-1db4-54aa-6bb2-b97e8f1f95f2",
Name = "txDegerlendirmeAciklama",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Değerlendirme Açıklaması" },}){
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
EntityPath = "ML.txDegerlendirmeAciklama",
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

Controls.Add(txDegerlendirmeAciklama);

BaseComponent default_txdegerlendirmeaciklamaComponent = new BaseComponent {
Id = "txDegerlendirmeAciklama",
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
Properties = txDegerlendirmeAciklama,
ViewProperties = "",
};

AddToViewItems("default", default_txdegerlendirmeaciklamaComponent);

Section2 = new Section {
ControlId = "34fbe6cc-ad1a-42bb-9467-30709cad3782",
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

tbxUnvanAnket = new TextBox {
ControlId = "315c1562-d28b-ddc0-3649-07abda128a7d",
Name = "tbxUnvanAnket",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Unvan" },}){
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
EntityPath = "ML.tbxUnvanAnket",
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

Controls.Add(tbxUnvanAnket);

BaseComponent default_tbxunvananketComponent = new BaseComponent {
Id = "tbxUnvanAnket",
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
Properties = tbxUnvanAnket,
ViewProperties = "",
};

AddToViewItems("default", default_tbxunvananketComponent);

tbxEgitmenAnket = new TextBox {
ControlId = "0b94778f-ab7e-ddcd-9a1e-1a75620d92a6",
Name = "tbxEgitmenAnket",
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
EntityPath = "ML.tbxEgitmenAnket",
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

Controls.Add(tbxEgitmenAnket);

BaseComponent default_tbxegitmenanketComponent = new BaseComponent {
Id = "tbxEgitmenAnket",
Type = "TextBox",
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
Properties = tbxEgitmenAnket,
ViewProperties = "",
};

AddToViewItems("default", default_tbxegitmenanketComponent);

Section3 = new Section {
ControlId = "b8085a78-5925-4962-aa2b-d86c568fa113",
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

tbxEgitimYeriAnket = new TextBox {
ControlId = "d449588b-a09e-f333-e9e1-ed3a3592fef9",
Name = "tbxEgitimYeriAnket",
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
EntityPath = "ML.tbxEgitimYeriAnket",
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

Controls.Add(tbxEgitimYeriAnket);

BaseComponent default_tbxegitimyerianketComponent = new BaseComponent {
Id = "tbxEgitimYeriAnket",
Type = "TextBox",
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
Properties = tbxEgitimYeriAnket,
ViewProperties = "",
};

AddToViewItems("default", default_tbxegitimyerianketComponent);

Section4 = new Section {
ControlId = "6d6a0182-9d86-42a8-be42-039ff370d995",
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
ControlId = "acd9eb5d-7302-42ee-b849-acf93ce9d323",
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

nbxDegerlendirmepuan = new NumberBox {
ControlId = "7fefe747-e3fd-7953-1042-2918d644b44b",
Name = "nbxDegerlendirmepuan",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Değerlendirme Puanı" },}){
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
EntityPath = "nbxDegerlendirmepuan",
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
TextAlign = HorizontalAlign.Right,
Min = 0M,
Max = 100M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(nbxDegerlendirmepuan);

BaseComponent default_nbxdegerlendirmepuanComponent = new BaseComponent {
Id = "nbxDegerlendirmepuan",
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
Properties = nbxDegerlendirmepuan,
ViewProperties = "",
};

AddToViewItems("default", default_nbxdegerlendirmepuanComponent);

Section6 = new Section {
ControlId = "7396cad3-51e9-48b4-9e28-4579f1c1551d",
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


BaseComponent default_section6Component = new BaseComponent {
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
"Column11",
"Column10",
},
Properties = Section6,
ViewProperties = "",
};

AddToViewItems("default", default_section6Component);
Controls.Add(Section6);

Section7 = new Section {
ControlId = "1f43aa3c-1ad7-48aa-b771-48e184378a15",
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


BaseComponent default_section7Component = new BaseComponent {
Id = "Section7",
Type = "Section",
ParentId = "FormAnket",
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
Properties = Section7,
ViewProperties = "",
};

AddToViewItems("default", default_section7Component);
Controls.Add(Section7);

Column10 = new Column {
ControlId = "44ed6538-b018-4529-8919-964a1171045e",
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


BaseComponent default_column10Component = new BaseComponent {
Id = "Column10",
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
},
Properties = Column10,
ViewProperties = "",
};

AddToViewItems("default", default_column10Component);
Controls.Add(Column10);

dtEgitimBitTarihAnket = new DateTimePicker {
ControlId = "f1bda945-0821-adde-7cb5-7b0aed059133",
Name = "dtEgitimBitTarihAnket",
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
EntityPath = "dtEgitimBitTarihAnket",
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

Controls.Add(dtEgitimBitTarihAnket);

BaseComponent default_dtegitimbittarihanketComponent = new BaseComponent {
Id = "dtEgitimBitTarihAnket",
Type = "DateTimePicker",
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
Properties = dtEgitimBitTarihAnket,
ViewProperties = "",
};

AddToViewItems("default", default_dtegitimbittarihanketComponent);

Column11 = new Column {
ControlId = "4b892785-abba-41c5-943a-179e00d1ce9e",
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


BaseComponent default_column11Component = new BaseComponent {
Id = "Column11",
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
},
Properties = Column11,
ViewProperties = "",
};

AddToViewItems("default", default_column11Component);
Controls.Add(Column11);

Divider1 = new Divider {
ControlId = "8be05105-0c0a-66b8-a160-fe4d30767d3a",
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

BaseComponent default_divider1Component = new BaseComponent {
Id = "Divider1",
Type = "Divider",
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
Properties = Divider1,
ViewProperties = "",
};

AddToViewItems("default", default_divider1Component);

Column1 = new Column {
ControlId = "0ab63a5c-7e3e-4167-8488-192395056ba8",
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
"Divider1",
"InputGroup1",
"InputGroup2",
"InputGroup3",
"InputGroup4",
"txDegerlendirmeAciklama",
},
Properties = Column1,
ViewProperties = "",
};

AddToViewItems("default", default_column1Component);
Controls.Add(Column1);

InputGroup1 = new InputGroup {
ControlId = "32bfd0ac-87d1-a3bd-6608-c7a6440a034b",
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

dtEgitimBasTarihAnket = new DateTimePicker {
ControlId = "0a1d9be4-2ede-7e8d-45be-14c216c046fb",
Name = "dtEgitimBasTarihAnket",
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
EntityPath = "dtEgitimBasTarihAnket",
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

Controls.Add(dtEgitimBasTarihAnket);

BaseComponent default_dtegitimbastarihanketComponent = new BaseComponent {
Id = "dtEgitimBasTarihAnket",
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
Properties = dtEgitimBasTarihAnket,
ViewProperties = "",
};

AddToViewItems("default", default_dtegitimbastarihanketComponent);

Column2 = new Column {
ControlId = "1fd1b8c2-3aae-4940-a500-0a5f9021bb4a",
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
"tbxUnvanAnket",
},
Properties = Column2,
ViewProperties = "",
};

AddToViewItems("default", default_column2Component);
Controls.Add(Column2);

InputGroup2 = new InputGroup {
ControlId = "8a115350-76e6-0171-4269-8d7d038ee66e",
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
ControlId = "ca59f1dc-b078-46c9-9a44-e72d0e118846",
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
"tbxKatilimciAnket",
},
Properties = Column3,
ViewProperties = "",
};

AddToViewItems("default", default_column3Component);
Controls.Add(Column3);

Label1 = new Label {
ControlId = "e0484236-828d-9f58-e9d8-7116d4257d7e",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim Anket Formu" },}){
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim Anket Formu" },{ "en-US", "Label1" },}){
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
ControlId = "0c009623-a666-0e8b-86a8-48595c41f2f9",
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
ControlId = "21e185be-e18c-4267-a43d-c82dbdde3aab",
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
"tbxEgitmenAnket",
},
Properties = Column4,
ViewProperties = "",
};

AddToViewItems("default", default_column4Component);
Controls.Add(Column4);

InputGroup4 = new InputGroup {
ControlId = "b8d138c4-90fd-c2e8-0fd0-444f75cdddd5",
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

Column5 = new Column {
ControlId = "f2d672df-24de-4f48-ba72-d66e2ba08945",
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
"tbxEgitimAdiAnket",
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