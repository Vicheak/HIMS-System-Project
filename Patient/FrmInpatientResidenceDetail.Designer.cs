namespace HIMS.Patient
{
    partial class FrmInpatientResidenceDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInpatientResidenceDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnPrintPatientReport = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvStaffInpatientResidence = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtInpatientResidenceID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBedDescription = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.cbBed = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cbRoom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.cbRoomType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtFullName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtDescription = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtStatus = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeDischargeDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeAdmissionDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InpatientResidenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleInCare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStaffCareDescription = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtRoleInCare = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtStaffPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.btnSaveStaffInpatient = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelStaffInpatientResidence = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteStaffInpatientResidence = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffInpatientResidence)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeDischargeDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeAdmissionDate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.panelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTitle.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1414, 54);
            this.panelTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTitle.Style.GradientAngle = 90;
            this.panelTitle.Style.MarginLeft = 20;
            this.panelTitle.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panelTitle.StyleMouseOver.MarginLeft = 20;
            this.panelTitle.TabIndex = 16;
            this.panelTitle.Text = "ព័ត៌មានលម្អិតនៃការស្នាក់នៅរបស់អ្នកជំងឺ";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.panelEx1.Controls.Add(this.btnSave);
            this.panelEx1.Controls.Add(this.btnUpdate);
            this.panelEx1.Controls.Add(this.btnPrintPatientReport);
            this.panelEx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 848);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1414, 63);
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.Style.MarginLeft = 20;
            this.panelEx1.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panelEx1.StyleMouseOver.MarginLeft = 20;
            this.panelEx1.TabIndex = 39;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(281, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 49);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSave.TabIndex = 62;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(7, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(268, 49);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "កែប្រែព័ត៌មានការស្នាក់នៅ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPrintPatientReport
            // 
            this.btnPrintPatientReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintPatientReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPatientReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintPatientReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPatientReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPatientReport.Image")));
            this.btnPrintPatientReport.Location = new System.Drawing.Point(1226, 7);
            this.btnPrintPatientReport.Name = "btnPrintPatientReport";
            this.btnPrintPatientReport.Size = new System.Drawing.Size(176, 47);
            this.btnPrintPatientReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnPrintPatientReport.TabIndex = 28;
            this.btnPrintPatientReport.TabStop = false;
            this.btnPrintPatientReport.Text = "ផ្ទេរអ្នកជំងឺ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1414, 794);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.Controls.Add(this.btnCancelStaffInpatientResidence);
            this.groupPanel2.Controls.Add(this.btnDeleteStaffInpatientResidence);
            this.groupPanel2.Controls.Add(this.btnSaveStaffInpatient);
            this.groupPanel2.Controls.Add(this.txtStaffPhone);
            this.groupPanel2.Controls.Add(this.labelX14);
            this.groupPanel2.Controls.Add(this.txtStaffCareDescription);
            this.groupPanel2.Controls.Add(this.labelX12);
            this.groupPanel2.Controls.Add(this.txtRoleInCare);
            this.groupPanel2.Controls.Add(this.labelX13);
            this.groupPanel2.Controls.Add(this.dgvStaffInpatientResidence);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(710, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(701, 788);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "ព័ត៌មានបុគ្គលិកដែលទទួលខុសត្រូវលើអ្នកជំងឺ";
            // 
            // dgvStaffInpatientResidence
            // 
            this.dgvStaffInpatientResidence.AllowUserToAddRows = false;
            this.dgvStaffInpatientResidence.AllowUserToDeleteRows = false;
            this.dgvStaffInpatientResidence.AllowUserToResizeColumns = false;
            this.dgvStaffInpatientResidence.AllowUserToResizeRows = false;
            this.dgvStaffInpatientResidence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaffInpatientResidence.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffInpatientResidence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStaffInpatientResidence.ColumnHeadersHeight = 45;
            this.dgvStaffInpatientResidence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaffInpatientResidence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.InpatientResidenceID,
            this.RoleInCare,
            this.Description,
            this.StaffName,
            this.PhoneNumber,
            this.StaffPosition});
            this.dgvStaffInpatientResidence.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffInpatientResidence.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStaffInpatientResidence.EnableHeadersVisualStyles = false;
            this.dgvStaffInpatientResidence.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvStaffInpatientResidence.Location = new System.Drawing.Point(6, 463);
            this.dgvStaffInpatientResidence.Name = "dgvStaffInpatientResidence";
            this.dgvStaffInpatientResidence.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffInpatientResidence.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStaffInpatientResidence.RowHeadersWidth = 51;
            this.dgvStaffInpatientResidence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStaffInpatientResidence.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStaffInpatientResidence.RowTemplate.Height = 35;
            this.dgvStaffInpatientResidence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffInpatientResidence.Size = new System.Drawing.Size(683, 266);
            this.dgvStaffInpatientResidence.TabIndex = 2;
            this.dgvStaffInpatientResidence.TabStop = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.Controls.Add(this.txtInpatientResidenceID);
            this.groupPanel1.Controls.Add(this.txtBedDescription);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.cbBed);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.cbRoom);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.cbRoomType);
            this.groupPanel1.Controls.Add(this.txtFullName);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.txtPatientID);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txtDescription);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtStatus);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.dateTimeDischargeDate);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.dateTimeAdmissionDate);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(701, 788);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "ព័ត៌មាននៃការស្នាក់នៅ";
            // 
            // txtInpatientResidenceID
            // 
            this.txtInpatientResidenceID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtInpatientResidenceID.Border.Class = "TextBoxBorder";
            this.txtInpatientResidenceID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInpatientResidenceID.DisabledBackColor = System.Drawing.Color.White;
            this.txtInpatientResidenceID.ForeColor = System.Drawing.Color.Black;
            this.txtInpatientResidenceID.Location = new System.Drawing.Point(157, 3);
            this.txtInpatientResidenceID.Name = "txtInpatientResidenceID";
            this.txtInpatientResidenceID.PreventEnterBeep = true;
            this.txtInpatientResidenceID.ReadOnly = true;
            this.txtInpatientResidenceID.Size = new System.Drawing.Size(165, 49);
            this.txtInpatientResidenceID.TabIndex = 61;
            this.txtInpatientResidenceID.TabStop = false;
            // 
            // txtBedDescription
            // 
            // 
            // 
            // 
            this.txtBedDescription.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtBedDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBedDescription.Location = new System.Drawing.Point(157, 608);
            this.txtBedDescription.Name = "txtBedDescription";
            this.txtBedDescription.ReadOnly = true;
            this.txtBedDescription.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtBedDescription.Size = new System.Drawing.Size(522, 75);
            this.txtBedDescription.TabIndex = 58;
            this.txtBedDescription.TabStop = false;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.White;
            this.labelX11.Location = new System.Drawing.Point(6, 608);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(151, 39);
            this.labelX11.TabIndex = 57;
            this.labelX11.Text = "បរិយាយពីគ្រែ ៖";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.White;
            this.labelX10.Location = new System.Drawing.Point(6, 558);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(131, 39);
            this.labelX10.TabIndex = 56;
            this.labelX10.Text = "ជម្រើសគ្រែ ៖";
            // 
            // cbBed
            // 
            this.cbBed.DisplayMember = "Text";
            this.cbBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBed.Enabled = false;
            this.cbBed.ForeColor = System.Drawing.Color.Black;
            this.cbBed.FormattingEnabled = true;
            this.cbBed.ItemHeight = 44;
            this.cbBed.Location = new System.Drawing.Point(157, 552);
            this.cbBed.Name = "cbBed";
            this.cbBed.Size = new System.Drawing.Size(269, 50);
            this.cbBed.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbBed.TabIndex = 55;
            this.cbBed.TabStop = false;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.White;
            this.labelX8.Location = new System.Drawing.Point(6, 502);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(131, 39);
            this.labelX8.TabIndex = 54;
            this.labelX8.Text = "ជម្រើសបន្ទប់​ ៖";
            // 
            // cbRoom
            // 
            this.cbRoom.DisplayMember = "Text";
            this.cbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.Enabled = false;
            this.cbRoom.ForeColor = System.Drawing.Color.Black;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.ItemHeight = 44;
            this.cbRoom.Location = new System.Drawing.Point(157, 496);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(269, 50);
            this.cbRoom.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbRoom.TabIndex = 53;
            this.cbRoom.TabStop = false;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.White;
            this.labelX9.Location = new System.Drawing.Point(6, 448);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(131, 39);
            this.labelX9.TabIndex = 52;
            this.labelX9.Text = "ប្រភេទបន្ទប់​ ៖";
            // 
            // cbRoomType
            // 
            this.cbRoomType.DisplayMember = "Text";
            this.cbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.Enabled = false;
            this.cbRoomType.ForeColor = System.Drawing.Color.Black;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.ItemHeight = 44;
            this.cbRoomType.Location = new System.Drawing.Point(157, 440);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(269, 50);
            this.cbRoomType.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbRoomType.TabIndex = 51;
            this.cbRoomType.TabStop = false;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFullName.Border.Class = "TextBoxBorder";
            this.txtFullName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFullName.DisabledBackColor = System.Drawing.Color.White;
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Location = new System.Drawing.Point(157, 385);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PreventEnterBeep = true;
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(522, 49);
            this.txtFullName.TabIndex = 49;
            this.txtFullName.TabStop = false;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.White;
            this.labelX7.Location = new System.Drawing.Point(6, 393);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(145, 39);
            this.labelX7.TabIndex = 50;
            this.labelX7.Text = "ឈ្មោះអ្នកជំងឺ ៖";
            // 
            // txtPatientID
            // 
            this.txtPatientID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPatientID.Border.Class = "TextBoxBorder";
            this.txtPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientID.DisabledBackColor = System.Drawing.Color.White;
            this.txtPatientID.ForeColor = System.Drawing.Color.Black;
            this.txtPatientID.Location = new System.Drawing.Point(157, 330);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PreventEnterBeep = true;
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(165, 49);
            this.txtPatientID.TabIndex = 47;
            this.txtPatientID.TabStop = false;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.White;
            this.labelX4.Location = new System.Drawing.Point(5, 335);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(146, 39);
            this.labelX4.TabIndex = 48;
            this.labelX4.Text = "លេខកូដអ្នកជំងឺ ៖";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescription.Location = new System.Drawing.Point(157, 249);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtDescription.Size = new System.Drawing.Size(522, 75);
            this.txtDescription.TabIndex = 46;
            this.txtDescription.TabStop = false;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(6, 249);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(151, 39);
            this.labelX2.TabIndex = 45;
            this.labelX2.Text = "បរិយាយ ៖";
            // 
            // txtStatus
            // 
            // 
            // 
            // 
            this.txtStatus.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStatus.Location = new System.Drawing.Point(157, 168);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtStatus.Size = new System.Drawing.Size(522, 75);
            this.txtStatus.TabIndex = 44;
            this.txtStatus.TabStop = false;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.White;
            this.labelX6.Location = new System.Drawing.Point(6, 168);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(151, 39);
            this.labelX6.TabIndex = 43;
            this.labelX6.Text = "បរិយាយស្ថានភាព ៖";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(6, 119);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(151, 39);
            this.labelX1.TabIndex = 35;
            this.labelX1.Text = "កាលបរិច្ឆេទចេញ ៖";
            // 
            // dateTimeDischargeDate
            // 
            // 
            // 
            // 
            this.dateTimeDischargeDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeDischargeDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeDischargeDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeDischargeDate.ButtonDropDown.Visible = true;
            this.dateTimeDischargeDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimeDischargeDate.Enabled = false;
            this.dateTimeDischargeDate.IsInputReadOnly = true;
            this.dateTimeDischargeDate.IsPopupCalendarOpen = false;
            this.dateTimeDischargeDate.Location = new System.Drawing.Point(157, 113);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeDischargeDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeDischargeDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeDischargeDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeDischargeDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeDischargeDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeDischargeDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeDischargeDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeDischargeDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeDischargeDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeDischargeDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeDischargeDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeDischargeDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeDischargeDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeDischargeDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeDischargeDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeDischargeDate.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeDischargeDate.Name = "dateTimeDischargeDate";
            this.dateTimeDischargeDate.Size = new System.Drawing.Size(373, 49);
            this.dateTimeDischargeDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeDischargeDate.TabIndex = 34;
            this.dateTimeDischargeDate.TabStop = false;
            this.dateTimeDischargeDate.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.White;
            this.labelX5.Location = new System.Drawing.Point(6, 64);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(145, 39);
            this.labelX5.TabIndex = 33;
            this.labelX5.Text = "កាលបរិច្ឆេទចូល ៖";
            // 
            // dateTimeAdmissionDate
            // 
            // 
            // 
            // 
            this.dateTimeAdmissionDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeAdmissionDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeAdmissionDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeAdmissionDate.ButtonDropDown.Visible = true;
            this.dateTimeAdmissionDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimeAdmissionDate.Enabled = false;
            this.dateTimeAdmissionDate.IsInputReadOnly = true;
            this.dateTimeAdmissionDate.IsPopupCalendarOpen = false;
            this.dateTimeAdmissionDate.Location = new System.Drawing.Point(157, 58);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeAdmissionDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeAdmissionDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeAdmissionDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeAdmissionDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeAdmissionDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeAdmissionDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeAdmissionDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeAdmissionDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeAdmissionDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeAdmissionDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeAdmissionDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeAdmissionDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeAdmissionDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeAdmissionDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeAdmissionDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeAdmissionDate.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeAdmissionDate.Name = "dateTimeAdmissionDate";
            this.dateTimeAdmissionDate.Size = new System.Drawing.Size(373, 49);
            this.dateTimeAdmissionDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeAdmissionDate.TabIndex = 32;
            this.dateTimeAdmissionDate.TabStop = false;
            this.dateTimeAdmissionDate.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(5, 8);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(91, 39);
            this.labelX3.TabIndex = 27;
            this.labelX3.Text = "លេខកូដ ៖";
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.HeaderText = "ល.បុគ្គលិក";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            this.StaffID.Width = 131;
            // 
            // InpatientResidenceID
            // 
            this.InpatientResidenceID.DataPropertyName = "InpatientResidenceID";
            this.InpatientResidenceID.HeaderText = "InpatientResidenceID";
            this.InpatientResidenceID.MinimumWidth = 6;
            this.InpatientResidenceID.Name = "InpatientResidenceID";
            this.InpatientResidenceID.ReadOnly = true;
            this.InpatientResidenceID.Visible = false;
            this.InpatientResidenceID.Width = 125;
            // 
            // RoleInCare
            // 
            this.RoleInCare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RoleInCare.DataPropertyName = "RoleInCare";
            this.RoleInCare.HeaderText = "មើលថែ";
            this.RoleInCare.MinimumWidth = 6;
            this.RoleInCare.Name = "RoleInCare";
            this.RoleInCare.ReadOnly = true;
            this.RoleInCare.Visible = false;
            this.RoleInCare.Width = 107;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Visible = false;
            this.Description.Width = 125;
            // 
            // StaffName
            // 
            this.StaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "ឈ្មោះបុគ្គលិក";
            this.StaffName.MinimumWidth = 6;
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Visible = false;
            this.PhoneNumber.Width = 172;
            // 
            // StaffPosition
            // 
            this.StaffPosition.DataPropertyName = "StaffPosition";
            this.StaffPosition.HeaderText = "តួ​នាទី";
            this.StaffPosition.MinimumWidth = 6;
            this.StaffPosition.Name = "StaffPosition";
            this.StaffPosition.ReadOnly = true;
            this.StaffPosition.Width = 125;
            // 
            // txtStaffCareDescription
            // 
            // 
            // 
            // 
            this.txtStaffCareDescription.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtStaffCareDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStaffCareDescription.Location = new System.Drawing.Point(198, 76);
            this.txtStaffCareDescription.Name = "txtStaffCareDescription";
            this.txtStaffCareDescription.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtStaffCareDescription.Size = new System.Drawing.Size(420, 185);
            this.txtStaffCareDescription.TabIndex = 26;
            this.txtStaffCareDescription.TabStop = false;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.ForeColor = System.Drawing.Color.White;
            this.labelX12.Location = new System.Drawing.Point(17, 72);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(148, 39);
            this.labelX12.TabIndex = 28;
            this.labelX12.Text = "បរិយាយ​ ៖";
            // 
            // txtRoleInCare
            // 
            this.txtRoleInCare.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRoleInCare.Border.Class = "TextBoxBorder";
            this.txtRoleInCare.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRoleInCare.DisabledBackColor = System.Drawing.Color.White;
            this.txtRoleInCare.ForeColor = System.Drawing.Color.Black;
            this.txtRoleInCare.Location = new System.Drawing.Point(198, 21);
            this.txtRoleInCare.Name = "txtRoleInCare";
            this.txtRoleInCare.PreventEnterBeep = true;
            this.txtRoleInCare.Size = new System.Drawing.Size(354, 49);
            this.txtRoleInCare.TabIndex = 25;
            this.txtRoleInCare.TabStop = false;
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.ForeColor = System.Drawing.Color.White;
            this.labelX13.Location = new System.Drawing.Point(17, 27);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(175, 39);
            this.labelX13.TabIndex = 27;
            this.labelX13.Text = "តួនាទីថែទាំ ៖";
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtStaffPhone.Border.Class = "TextBoxBorder";
            this.txtStaffPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStaffPhone.DisabledBackColor = System.Drawing.Color.White;
            this.txtStaffPhone.ForeColor = System.Drawing.Color.Black;
            this.txtStaffPhone.Location = new System.Drawing.Point(198, 267);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.PreventEnterBeep = true;
            this.txtStaffPhone.ReadOnly = true;
            this.txtStaffPhone.Size = new System.Drawing.Size(354, 49);
            this.txtStaffPhone.TabIndex = 30;
            this.txtStaffPhone.TabStop = false;
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.ForeColor = System.Drawing.Color.White;
            this.labelX14.Location = new System.Drawing.Point(17, 272);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(175, 39);
            this.labelX14.TabIndex = 29;
            this.labelX14.Text = "លេខទូរស័ព្ទបុគ្គលិក​ ៖";
            // 
            // btnSaveStaffInpatient
            // 
            this.btnSaveStaffInpatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveStaffInpatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveStaffInpatient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveStaffInpatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStaffInpatient.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveStaffInpatient.Image")));
            this.btnSaveStaffInpatient.Location = new System.Drawing.Point(543, 332);
            this.btnSaveStaffInpatient.Name = "btnSaveStaffInpatient";
            this.btnSaveStaffInpatient.Size = new System.Drawing.Size(146, 49);
            this.btnSaveStaffInpatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSaveStaffInpatient.TabIndex = 64;
            this.btnSaveStaffInpatient.TabStop = false;
            this.btnSaveStaffInpatient.Text = "រក្សាទុក";
            // 
            // btnCancelStaffInpatientResidence
            // 
            this.btnCancelStaffInpatientResidence.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelStaffInpatientResidence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelStaffInpatientResidence.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelStaffInpatientResidence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelStaffInpatientResidence.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelStaffInpatientResidence.Image")));
            this.btnCancelStaffInpatientResidence.Location = new System.Drawing.Point(543, 392);
            this.btnCancelStaffInpatientResidence.Name = "btnCancelStaffInpatientResidence";
            this.btnCancelStaffInpatientResidence.Size = new System.Drawing.Size(146, 55);
            this.btnCancelStaffInpatientResidence.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnCancelStaffInpatientResidence.TabIndex = 66;
            this.btnCancelStaffInpatientResidence.TabStop = false;
            this.btnCancelStaffInpatientResidence.Text = "ត្រឡប់";
            // 
            // btnDeleteStaffInpatientResidence
            // 
            this.btnDeleteStaffInpatientResidence.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteStaffInpatientResidence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStaffInpatientResidence.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteStaffInpatientResidence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStaffInpatientResidence.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStaffInpatientResidence.Image")));
            this.btnDeleteStaffInpatientResidence.Location = new System.Drawing.Point(631, 272);
            this.btnDeleteStaffInpatientResidence.Name = "btnDeleteStaffInpatientResidence";
            this.btnDeleteStaffInpatientResidence.Size = new System.Drawing.Size(58, 49);
            this.btnDeleteStaffInpatientResidence.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDeleteStaffInpatientResidence.TabIndex = 65;
            this.btnDeleteStaffInpatientResidence.TabStop = false;
            // 
            // FrmInpatientResidenceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1414, 911);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInpatientResidenceDetail";
            this.Text = "FrmInpatientResidenceDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInpatientResidenceDetail_Load);
            this.panelEx1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffInpatientResidence)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeDischargeDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeAdmissionDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelTitle;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        public DevComponents.DotNetBar.ButtonX btnPrintPatientReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeDischargeDate;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeAdmissionDate;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtStatus;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtDescription;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientID;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFullName;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRoom;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRoomType;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbBed;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtBedDescription;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvStaffInpatientResidence;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInpatientResidenceID;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InpatientResidenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleInCare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPosition;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtStaffCareDescription;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRoleInCare;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStaffPhone;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.ButtonX btnSaveStaffInpatient;
        private DevComponents.DotNetBar.ButtonX btnCancelStaffInpatientResidence;
        private DevComponents.DotNetBar.ButtonX btnDeleteStaffInpatientResidence;
    }
}