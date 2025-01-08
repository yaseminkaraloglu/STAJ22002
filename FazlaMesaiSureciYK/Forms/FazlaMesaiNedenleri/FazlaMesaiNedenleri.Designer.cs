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

    public partial class FazlaMesaiNedenleri : Form<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriEntity> {

        // properties
        Section Section1 { get; set; }
Column Column1 { get; set; }
DataGrid dgFazlaMesaiNedeni { get; set; }


        // constructor
        public FazlaMesaiNedenleri(FormHttpParameters httpParameters, IContext context)
 : base(httpParameters, context)
        {
        }

        // initialize members
        public override void InitMembers()
        {
            
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
{ "tr-TR", "FazlaMesaiNedenleri" },
{ "en-US", "FazlaMesaiNedenleri" },
{ "ru-RU", "FazlaMesaiNedenleri" },
{ "az-Latn-AZ", "FazlaMesaiNedenleri" },
};
Name = "FazlaMesaiNedenleri";
FormId = "64037686-4488-4280-98b4-551190cff7f7";
FormType = FormType.Parameter;
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
};
CheckInCheckOut = new CheckInCheckOutOptions {
Enabled = false,
Timeout = 10,
AdditionalTime = 5,
};
SizeType = SizeType.Middle;
PaddingType = SizeType.Middle;
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Fazla Mesai Nedenleri" },{ "en-US", "FazlaMesaiNedenleri" },{ "ru-RU", "FazlaMesaiNedenleri" },{ "az-Latn-AZ", "FazlaMesaiNedenleri" },}){
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

BaseComponent default_fazlamesainedenleriComponent = new BaseComponent {
Id = "FazlaMesaiNedenleri",
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

AddToViewItems("default", default_fazlamesainedenleriComponent);

Section1 = new Section {
ControlId = "d9e7126c-9a6f-4bbe-9686-f9d85d8f7c2e",
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
ParentId = "FazlaMesaiNedenleri",
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

Column1 = new Column {
ControlId = "35f52572-3cab-4572-839f-273c05fcf1e3",
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
"dgFazlaMesaiNedeni",
},
Properties = Column1,
ViewProperties = "",
};

AddToViewItems("default", default_column1Component);
Controls.Add(Column1);

dgFazlaMesaiNedeni = new DataGrid {
ControlId = "d42e7352-d712-8236-6df0-baddebf4c2a2",
Name = "dgFazlaMesaiNedeni",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Fazla Mesai Nedenleri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
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
EntityPath = "E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeni",
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
EntityPath = "DGID",
ReadOnly = false,
Required = false,
},
DbType = new ColumnDbType() {
ColumnName = "DGID",
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
{ "tr-TR", "ID" },
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
Name = "DGID",
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
IsGeneratedColumn = false,
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
AutoIncrement = true,
},
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.MesaiNedeni",
ReadOnly = false,
Required = false,
MaxLength = 50
},
DbType = new ColumnDbType() {
ColumnName = "MesaiNedeni",
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
{ "tr-TR", "Fazla Mesai Nedeni" },
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
Name = "MesaiNedeni",
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
IsGeneratedColumn = false,
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
ShowAddCommand = true,
ShowEditCommand = true,
ShowDeleteCommand = true,
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

Controls.Add(dgFazlaMesaiNedeni);

BaseComponent default_dgfazlamesainedeniComponent = new BaseComponent {
Id = "dgFazlaMesaiNedeni",
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
Properties = dgFazlaMesaiNedeni,
ViewProperties = "",
};

AddToViewItems("default", default_dgfazlamesainedeniComponent);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            


        }
    }
}