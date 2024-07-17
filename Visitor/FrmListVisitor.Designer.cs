using System;
using System.Windows.Forms;

namespace HIMS.Visitor
{
    partial class FrmListVisitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListVisitor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchVisitorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.dgvVisitor = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.visitorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientRelationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVisitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hIMSDataSet = new HIMS.HIMSDataSet();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbVisitorTableAdapter = new HIMS.HIMSDataSetTableAdapters.tbVisitorTableAdapter();
            this.btnModifyVisitor = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteVisitor = new DevComponents.DotNetBar.ButtonX();
            this.dtpVisitor = new System.Windows.Forms.DateTimePicker();
            this.btnShowAll = new DevComponents.DotNetBar.ButtonX();
            this.btnVisitorDetail = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVisitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIMSDataSet)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchVisitorName
            // 
            this.txtSearchVisitorName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchVisitorName.Border.Class = "TextBoxBorder";
            this.txtSearchVisitorName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchVisitorName.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchVisitorName.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVisitorName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchVisitorName.Location = new System.Drawing.Point(53, 47);
            this.txtSearchVisitorName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchVisitorName.Name = "txtSearchVisitorName";
            this.txtSearchVisitorName.PreventEnterBeep = true;
            this.txtSearchVisitorName.Size = new System.Drawing.Size(318, 41);
            this.txtSearchVisitorName.TabIndex = 67;
            this.txtSearchVisitorName.TabStop = false;
            this.txtSearchVisitorName.TextChanged += new System.EventHandler(this.txtSearchVisitorName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(374, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 39);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSearch.TabIndex = 68;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvVisitor
            // 
            this.dgvVisitor.AllowUserToAddRows = false;
            this.dgvVisitor.AllowUserToDeleteRows = false;
            this.dgvVisitor.AllowUserToResizeColumns = false;
            this.dgvVisitor.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVisitor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVisitor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvVisitor.AutoGenerateColumns = false;
            this.dgvVisitor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVisitor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVisitor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVisitor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitorIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.registryDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.patientRelationDataGridViewTextBoxColumn});
            this.dgvVisitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvVisitor.DataSource = this.tbVisitorBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisitor.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVisitor.EnableHeadersVisualStyles = false;
            this.dgvVisitor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvVisitor.Location = new System.Drawing.Point(53, 185);
            this.dgvVisitor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVisitor.Name = "dgvVisitor";
            this.dgvVisitor.ReadOnly = true;
            this.dgvVisitor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitor.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVisitor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVisitor.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVisitor.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVisitor.RowTemplate.Height = 35;
            this.dgvVisitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitor.Size = new System.Drawing.Size(1212, 447);
            this.dgvVisitor.TabIndex = 69;
            // 
            // visitorIDDataGridViewTextBoxColumn
            // 
            this.visitorIDDataGridViewTextBoxColumn.DataPropertyName = "VisitorID";
            this.visitorIDDataGridViewTextBoxColumn.HeaderText = "លេខកូដ";
            this.visitorIDDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.visitorIDDataGridViewTextBoxColumn.Name = "visitorIDDataGridViewTextBoxColumn";
            this.visitorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitorIDDataGridViewTextBoxColumn.Width = 86;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "នាមខ្លួន";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "នាមខ្លួន";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "ភេទ";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "លេខទូរស័ព្ទ";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // registryDateDataGridViewTextBoxColumn
            // 
            this.registryDateDataGridViewTextBoxColumn.DataPropertyName = "RegistryDate";
            this.registryDateDataGridViewTextBoxColumn.HeaderText = "ចុះឈ្មោះថ្ងៃទី";
            this.registryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registryDateDataGridViewTextBoxColumn.Name = "registryDateDataGridViewTextBoxColumn";
            this.registryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "អាស័យដ្ឋាន";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientRelationDataGridViewTextBoxColumn
            // 
            this.patientRelationDataGridViewTextBoxColumn.DataPropertyName = "PatientRelation";
            this.patientRelationDataGridViewTextBoxColumn.HeaderText = "ត្រូវជា";
            this.patientRelationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientRelationDataGridViewTextBoxColumn.Name = "patientRelationDataGridViewTextBoxColumn";
            this.patientRelationDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientRelationDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbVisitorBindingSource
            // 
            this.tbVisitorBindingSource.DataMember = "tbVisitor";
            this.tbVisitorBindingSource.DataSource = this.hIMSDataSet;
            // 
            // hIMSDataSet
            // 
            this.hIMSDataSet.DataSetName = "HIMSDataSet";
            this.hIMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnAddNew);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.txtSearchVisitorName);
            this.panelEx1.Controls.Add(this.btnSearch);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1548, 107);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 79;
            this.panelEx1.Click += new System.EventHandler(this.panelEx1_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAddNew.Location = new System.Drawing.Point(1176, 7);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(166, 91);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddNew.TabIndex = 90;
            this.btnAddNew.Text = "ចុះឈ្មោះអ្នកសួរសុខទុក្ខថ្មី";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.SystemColors.Control;
            this.labelX5.Location = new System.Drawing.Point(53, 9);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(216, 31);
            this.labelX5.TabIndex = 74;
            this.labelX5.Text = "ឈ្មោះអ្នកសួរសុខទុក្ខ ៖";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(302, 134);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(163, 31);
            this.labelX2.TabIndex = 84;
            this.labelX2.Text = "បង្ហាញតាមកាលបរិច្ឆេទ​ ៖";
            // 
            // tbVisitorTableAdapter
            // 
            this.tbVisitorTableAdapter.ClearBeforeFill = true;
            // 
            // btnModifyVisitor
            // 
            this.btnModifyVisitor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModifyVisitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyVisitor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnModifyVisitor.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyVisitor.Image")));
            this.btnModifyVisitor.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnModifyVisitor.Location = new System.Drawing.Point(1345, 332);
            this.btnModifyVisitor.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyVisitor.Name = "btnModifyVisitor";
            this.btnModifyVisitor.Size = new System.Drawing.Size(144, 91);
            this.btnModifyVisitor.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnModifyVisitor.TabIndex = 106;
            this.btnModifyVisitor.Text = "កែព័ត៍មាន";
            this.btnModifyVisitor.Click += new System.EventHandler(this.btnModifyVisitor_Click);
            // 
            // btnDeleteVisitor
            // 
            this.btnDeleteVisitor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteVisitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteVisitor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteVisitor.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteVisitor.Image")));
            this.btnDeleteVisitor.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDeleteVisitor.Location = new System.Drawing.Point(1349, 437);
            this.btnDeleteVisitor.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteVisitor.Name = "btnDeleteVisitor";
            this.btnDeleteVisitor.Size = new System.Drawing.Size(140, 91);
            this.btnDeleteVisitor.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDeleteVisitor.TabIndex = 107;
            this.btnDeleteVisitor.Text = "លុប";
            this.btnDeleteVisitor.Click += new System.EventHandler(this.btnDeleteVisitor_Click);
            // 
            // dtpVisitor
            // 
            this.dtpVisitor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpVisitor.CustomFormat = "dd-MM-yyyy";
            this.dtpVisitor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVisitor.Location = new System.Drawing.Point(470, 129);
            this.dtpVisitor.Name = "dtpVisitor";
            this.dtpVisitor.Size = new System.Drawing.Size(264, 41);
            this.dtpVisitor.TabIndex = 122;
            this.dtpVisitor.ValueChanged += new System.EventHandler(this.dtpVisitor_ValueChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowAll.Location = new System.Drawing.Point(63, 124);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(144, 41);
            this.btnShowAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnShowAll.TabIndex = 126;
            this.btnShowAll.Text = "បង្ហាញទាំងអស់";
            this.btnShowAll.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnVisitorDetail
            // 
            this.btnVisitorDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVisitorDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisitorDetail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVisitorDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnVisitorDetail.Image")));
            this.btnVisitorDetail.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVisitorDetail.Location = new System.Drawing.Point(1345, 185);
            this.btnVisitorDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisitorDetail.Name = "btnVisitorDetail";
            this.btnVisitorDetail.Size = new System.Drawing.Size(144, 91);
            this.btnVisitorDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnVisitorDetail.TabIndex = 130;
            this.btnVisitorDetail.Text = "មើលទិន្នន័យលម្អិត";
            this.btnVisitorDetail.Click += new System.EventHandler(this.btnVisitorDetail_Click);
            // 
            // FrmListVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1540, 666);
            this.Controls.Add(this.btnVisitorDetail);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dtpVisitor);
            this.Controls.Add(this.btnDeleteVisitor);
            this.Controls.Add(this.btnModifyVisitor);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dgvVisitor);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmListVisitor";
            this.Text = "FrmListVisitor";
            this.Load += new System.EventHandler(this.FrmListVisitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVisitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIMSDataSet)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

      

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchVisitorName;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvVisitor;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
        private HIMSDataSet hIMSDataSet;
        private System.Windows.Forms.BindingSource tbVisitorBindingSource;
        private HIMSDataSetTableAdapters.tbVisitorTableAdapter tbVisitorTableAdapter;
        public DevComponents.DotNetBar.ButtonX btnModifyVisitor;
        public DevComponents.DotNetBar.ButtonX btnDeleteVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientRelationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpVisitor;
        public DevComponents.DotNetBar.ButtonX btnShowAll;
        public DevComponents.DotNetBar.ButtonX btnVisitorDetail;
    }
}