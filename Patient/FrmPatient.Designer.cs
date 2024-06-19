namespace HIMS.Patient
{
    partial class FrmPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatient));
            this.dgvPatient = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtSearchEntry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbSearchCriteria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterTopPatientRecord = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalPatient = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblPatientFemale = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblInPatient = new System.Windows.Forms.ToolStripLabel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.numericUpDownFilterPatientGroupByGenderAmount = new System.Windows.Forms.NumericUpDown();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterPatientGender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeFilterPatientStartBirthDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.numericUpDownFilterPatientGroupByIsInpatientAmount = new System.Windows.Forms.NumericUpDown();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterPatientIsInpatient = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeFilterPatientEndBirthDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.s = new DevComponents.DotNetBar.ButtonX();
            this.numericUpDownPatientOffset = new System.Windows.Forms.NumericUpDown();
            this.btnFilterPatientGroupIsInpatient = new DevComponents.DotNetBar.ButtonX();
            this.btnFilterPatientGroupBirthDate = new DevComponents.DotNetBar.ButtonX();
            this.btnClearFilter = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderKhmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmergencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmergencyRelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmergencyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsInpatient = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.MedicalHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBtnDetail = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.Column18 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.Column19 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterPatientGroupByGenderAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFilterPatientStartBirthDate)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterPatientGroupByIsInpatientAmount)).BeginInit();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFilterPatientEndBirthDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPatientOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.AllowUserToResizeColumns = false;
            this.dgvPatient.AllowUserToResizeRows = false;
            this.dgvPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatient.ColumnHeadersHeight = 45;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.FirstName,
            this.LastName,
            this.FullName,
            this.Gender,
            this.GenderKhmer,
            this.BirthDate,
            this.Address,
            this.PhoneNumber,
            this.EmergencyName,
            this.EmergencyRelation,
            this.EmergencyNumber,
            this.Email,
            this.NationalCardID,
            this.IsInpatient,
            this.MedicalHistory,
            this.dgvBtnDetail,
            this.Column18,
            this.Column19});
            this.dgvPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatient.EnableHeadersVisualStyles = false;
            this.dgvPatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvPatient.Location = new System.Drawing.Point(12, 291);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatient.RowHeadersWidth = 51;
            this.dgvPatient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPatient.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatient.RowTemplate.Height = 35;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(1438, 456);
            this.dgvPatient.TabIndex = 0;
            this.dgvPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellContentClick);
            this.dgvPatient.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvPatient_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(760, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 49);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSearch.TabIndex = 13;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchEntry
            // 
            this.txtSearchEntry.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchEntry.Border.Class = "TextBoxBorder";
            this.txtSearchEntry.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchEntry.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchEntry.ForeColor = System.Drawing.Color.Black;
            this.txtSearchEntry.Location = new System.Drawing.Point(519, 4);
            this.txtSearchEntry.Name = "txtSearchEntry";
            this.txtSearchEntry.PreventEnterBeep = true;
            this.txtSearchEntry.Size = new System.Drawing.Size(235, 49);
            this.txtSearchEntry.TabIndex = 12;
            this.txtSearchEntry.TabStop = false;
            this.txtSearchEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchEntry_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(432, 10);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 39);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "ស្វែងរក​ ៖";
            // 
            // cbSearchCriteria
            // 
            this.cbSearchCriteria.DisplayMember = "Text";
            this.cbSearchCriteria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCriteria.ForeColor = System.Drawing.Color.Black;
            this.cbSearchCriteria.FormattingEnabled = true;
            this.cbSearchCriteria.ItemHeight = 44;
            this.cbSearchCriteria.Location = new System.Drawing.Point(157, 4);
            this.cbSearchCriteria.Name = "cbSearchCriteria";
            this.cbSearchCriteria.Size = new System.Drawing.Size(269, 50);
            this.cbSearchCriteria.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbSearchCriteria.TabIndex = 10;
            this.cbSearchCriteria.TabStop = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 10);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(155, 39);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "កំណត់លក្ខខណ្ឌ​ ៖";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(989, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(270, 39);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "ជ្រើសរើសចំនួនកំណត់ត្រា​ ៖";
            // 
            // cbFilterTopPatientRecord
            // 
            this.cbFilterTopPatientRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterTopPatientRecord.DisplayMember = "Text";
            this.cbFilterTopPatientRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTopPatientRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTopPatientRecord.ForeColor = System.Drawing.Color.Black;
            this.cbFilterTopPatientRecord.FormattingEnabled = true;
            this.cbFilterTopPatientRecord.ItemHeight = 44;
            this.cbFilterTopPatientRecord.Location = new System.Drawing.Point(989, 49);
            this.cbFilterTopPatientRecord.Name = "cbFilterTopPatientRecord";
            this.cbFilterTopPatientRecord.Size = new System.Drawing.Size(286, 50);
            this.cbFilterTopPatientRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterTopPatientRecord.TabIndex = 14;
            this.cbFilterTopPatientRecord.TabStop = false;
            this.cbFilterTopPatientRecord.SelectedIndexChanged += new System.EventHandler(this.cbFilterTopPatientRecord_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Khmer Kep", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLblTotalPatient,
            this.toolStripLabel3,
            this.toolStripLblPatientFemale,
            this.toolStripLabel4,
            this.toolStripLblInPatient});
            this.toolStrip1.Location = new System.Drawing.Point(0, 757);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1462, 30);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(104, 27);
            this.toolStripLabel2.Text = "ចំនួនអ្នកជំងឺសរុប ៖";
            // 
            // toolStripLblTotalPatient
            // 
            this.toolStripLblTotalPatient.ForeColor = System.Drawing.Color.White;
            this.toolStripLblTotalPatient.Name = "toolStripLblTotalPatient";
            this.toolStripLblTotalPatient.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblTotalPatient.Text = "?";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(140, 27);
            this.toolStripLabel3.Text = "ចំនួនអ្នកជំងឺភេទស្រីសរុប ៖";
            // 
            // toolStripLblPatientFemale
            // 
            this.toolStripLblPatientFemale.ForeColor = System.Drawing.Color.White;
            this.toolStripLblPatientFemale.Name = "toolStripLblPatientFemale";
            this.toolStripLblPatientFemale.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblPatientFemale.Text = "?";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(205, 27);
            this.toolStripLabel4.Text = "ចំនួនអ្នកជំងឺស្នាក់នៅក្នុងមន្ទីរពេទ្យសរុប ៖";
            // 
            // toolStripLblInPatient
            // 
            this.toolStripLblInPatient.ForeColor = System.Drawing.Color.White;
            this.toolStripLblInPatient.Name = "toolStripLblInPatient";
            this.toolStripLblInPatient.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblInPatient.Text = "?";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.Controls.Add(this.numericUpDownFilterPatientGroupByGenderAmount);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.cbFilterPatientGender);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 140);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(443, 141);
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
            this.groupPanel1.TabIndex = 17;
            this.groupPanel1.Text = "លក្ខខណ្ឌនៃការច្រោះតាមភេទ";
            // 
            // numericUpDownFilterPatientGroupByGenderAmount
            // 
            this.numericUpDownFilterPatientGroupByGenderAmount.Location = new System.Drawing.Point(365, 18);
            this.numericUpDownFilterPatientGroupByGenderAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFilterPatientGroupByGenderAmount.Name = "numericUpDownFilterPatientGroupByGenderAmount";
            this.numericUpDownFilterPatientGroupByGenderAmount.Size = new System.Drawing.Size(68, 49);
            this.numericUpDownFilterPatientGroupByGenderAmount.TabIndex = 20;
            this.numericUpDownFilterPatientGroupByGenderAmount.TabStop = false;
            this.numericUpDownFilterPatientGroupByGenderAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.White;
            this.labelX7.Location = new System.Drawing.Point(257, 22);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(116, 39);
            this.labelX7.TabIndex = 19;
            this.labelX7.Text = "ចំនួនអ្នកជំងឺ ៖";
            // 
            // cbFilterPatientGender
            // 
            this.cbFilterPatientGender.DisplayMember = "Text";
            this.cbFilterPatientGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterPatientGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterPatientGender.ForeColor = System.Drawing.Color.Black;
            this.cbFilterPatientGender.FormattingEnabled = true;
            this.cbFilterPatientGender.ItemHeight = 44;
            this.cbFilterPatientGender.Location = new System.Drawing.Point(139, 17);
            this.cbFilterPatientGender.Name = "cbFilterPatientGender";
            this.cbFilterPatientGender.Size = new System.Drawing.Size(110, 50);
            this.cbFilterPatientGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterPatientGender.TabIndex = 18;
            this.cbFilterPatientGender.TabStop = false;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.White;
            this.labelX4.Location = new System.Drawing.Point(3, 22);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(204, 39);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "ជ្រើសរើសភេទ ៖";
            // 
            // dateTimeFilterPatientStartBirthDate
            // 
            // 
            // 
            // 
            this.dateTimeFilterPatientStartBirthDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeFilterPatientStartBirthDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientStartBirthDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeFilterPatientStartBirthDate.ButtonDropDown.Visible = true;
            this.dateTimeFilterPatientStartBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimeFilterPatientStartBirthDate.IsPopupCalendarOpen = false;
            this.dateTimeFilterPatientStartBirthDate.Location = new System.Drawing.Point(46, 17);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientStartBirthDate.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeFilterPatientStartBirthDate.Name = "dateTimeFilterPatientStartBirthDate";
            this.dateTimeFilterPatientStartBirthDate.Size = new System.Drawing.Size(156, 49);
            this.dateTimeFilterPatientStartBirthDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeFilterPatientStartBirthDate.TabIndex = 16;
            this.dateTimeFilterPatientStartBirthDate.TabStop = false;
            this.dateTimeFilterPatientStartBirthDate.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.Controls.Add(this.numericUpDownFilterPatientGroupByIsInpatientAmount);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.cbFilterPatientIsInpatient);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(461, 140);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(516, 141);
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
            this.groupPanel2.TabIndex = 18;
            this.groupPanel2.Text = "លក្ខខណ្ឌនៃការច្រោះតាមការស្នាក់នៅ";
            // 
            // numericUpDownFilterPatientGroupByIsInpatientAmount
            // 
            this.numericUpDownFilterPatientGroupByIsInpatientAmount.Location = new System.Drawing.Point(438, 18);
            this.numericUpDownFilterPatientGroupByIsInpatientAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFilterPatientGroupByIsInpatientAmount.Name = "numericUpDownFilterPatientGroupByIsInpatientAmount";
            this.numericUpDownFilterPatientGroupByIsInpatientAmount.Size = new System.Drawing.Size(68, 49);
            this.numericUpDownFilterPatientGroupByIsInpatientAmount.TabIndex = 21;
            this.numericUpDownFilterPatientGroupByIsInpatientAmount.TabStop = false;
            this.numericUpDownFilterPatientGroupByIsInpatientAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.White;
            this.labelX6.Location = new System.Drawing.Point(327, 22);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(116, 39);
            this.labelX6.TabIndex = 19;
            this.labelX6.Text = "ចំនួនអ្នកជំងឺ ៖";
            // 
            // cbFilterPatientIsInpatient
            // 
            this.cbFilterPatientIsInpatient.DisplayMember = "Text";
            this.cbFilterPatientIsInpatient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterPatientIsInpatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterPatientIsInpatient.ForeColor = System.Drawing.Color.Black;
            this.cbFilterPatientIsInpatient.FormattingEnabled = true;
            this.cbFilterPatientIsInpatient.ItemHeight = 44;
            this.cbFilterPatientIsInpatient.Location = new System.Drawing.Point(106, 17);
            this.cbFilterPatientIsInpatient.Name = "cbFilterPatientIsInpatient";
            this.cbFilterPatientIsInpatient.Size = new System.Drawing.Size(215, 50);
            this.cbFilterPatientIsInpatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterPatientIsInpatient.TabIndex = 18;
            this.cbFilterPatientIsInpatient.TabStop = false;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.White;
            this.labelX8.Location = new System.Drawing.Point(2, 22);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(204, 39);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "ជ្រើសរើស ៖";
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.Controls.Add(this.labelX10);
            this.groupPanel3.Controls.Add(this.dateTimeFilterPatientEndBirthDate);
            this.groupPanel3.Controls.Add(this.labelX9);
            this.groupPanel3.Controls.Add(this.dateTimeFilterPatientStartBirthDate);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(983, 140);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(440, 141);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 21;
            this.groupPanel3.Text = "លក្ខខណ្ឌនៃការច្រោះតាមថ្ងៃខែឆ្នាំកំណើត";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.White;
            this.labelX10.Location = new System.Drawing.Point(215, 22);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(58, 39);
            this.labelX10.TabIndex = 19;
            this.labelX10.Text = "ដល់ ៖";
            // 
            // dateTimeFilterPatientEndBirthDate
            // 
            // 
            // 
            // 
            this.dateTimeFilterPatientEndBirthDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeFilterPatientEndBirthDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientEndBirthDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeFilterPatientEndBirthDate.ButtonDropDown.Visible = true;
            this.dateTimeFilterPatientEndBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimeFilterPatientEndBirthDate.IsPopupCalendarOpen = false;
            this.dateTimeFilterPatientEndBirthDate.Location = new System.Drawing.Point(273, 18);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeFilterPatientEndBirthDate.Name = "dateTimeFilterPatientEndBirthDate";
            this.dateTimeFilterPatientEndBirthDate.Size = new System.Drawing.Size(156, 49);
            this.dateTimeFilterPatientEndBirthDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeFilterPatientEndBirthDate.TabIndex = 18;
            this.dateTimeFilterPatientEndBirthDate.TabStop = false;
            this.dateTimeFilterPatientEndBirthDate.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.White;
            this.labelX9.Location = new System.Drawing.Point(3, 22);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(39, 39);
            this.labelX9.TabIndex = 17;
            this.labelX9.Text = "ពី ៖";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(14, 79);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(216, 39);
            this.labelX11.TabIndex = 21;
            this.labelX11.Text = "រំកិលព័ត៌មាន​អ្នកជំងឺចំនួន ៖";
            // 
            // s
            // 
            this.s.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.s.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.s.Image = ((System.Drawing.Image)(resources.GetObject("s.Image")));
            this.s.Location = new System.Drawing.Point(398, 115);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(57, 49);
            this.s.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.s.TabIndex = 23;
            this.s.TabStop = false;
            this.s.Click += new System.EventHandler(this.btnFilterPatientGroupGender_Click);
            // 
            // numericUpDownPatientOffset
            // 
            this.numericUpDownPatientOffset.Location = new System.Drawing.Point(226, 73);
            this.numericUpDownPatientOffset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPatientOffset.Name = "numericUpDownPatientOffset";
            this.numericUpDownPatientOffset.Size = new System.Drawing.Size(68, 49);
            this.numericUpDownPatientOffset.TabIndex = 21;
            this.numericUpDownPatientOffset.TabStop = false;
            this.numericUpDownPatientOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFilterPatientGroupIsInpatient
            // 
            this.btnFilterPatientGroupIsInpatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFilterPatientGroupIsInpatient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFilterPatientGroupIsInpatient.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterPatientGroupIsInpatient.Image")));
            this.btnFilterPatientGroupIsInpatient.Location = new System.Drawing.Point(920, 115);
            this.btnFilterPatientGroupIsInpatient.Name = "btnFilterPatientGroupIsInpatient";
            this.btnFilterPatientGroupIsInpatient.Size = new System.Drawing.Size(57, 49);
            this.btnFilterPatientGroupIsInpatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnFilterPatientGroupIsInpatient.TabIndex = 24;
            this.btnFilterPatientGroupIsInpatient.TabStop = false;
            this.btnFilterPatientGroupIsInpatient.Click += new System.EventHandler(this.btnFilterPatientGroupIsInpatient_Click);
            // 
            // btnFilterPatientGroupBirthDate
            // 
            this.btnFilterPatientGroupBirthDate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFilterPatientGroupBirthDate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFilterPatientGroupBirthDate.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterPatientGroupBirthDate.Image")));
            this.btnFilterPatientGroupBirthDate.Location = new System.Drawing.Point(1366, 115);
            this.btnFilterPatientGroupBirthDate.Name = "btnFilterPatientGroupBirthDate";
            this.btnFilterPatientGroupBirthDate.Size = new System.Drawing.Size(57, 49);
            this.btnFilterPatientGroupBirthDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnFilterPatientGroupBirthDate.TabIndex = 25;
            this.btnFilterPatientGroupBirthDate.TabStop = false;
            this.btnFilterPatientGroupBirthDate.Click += new System.EventHandler(this.btnFilterPatientGroupBirthDate_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.Location = new System.Drawing.Point(1429, 232);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(58, 49);
            this.btnClearFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnClearFilter.TabIndex = 26;
            this.btnClearFilter.TabStop = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAddNew.Location = new System.Drawing.Point(1284, 4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(166, 95);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "ចុះឈ្មោះអ្នកជំងឺថ្មី";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // PatientID
            // 
            this.PatientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "លេខកូដ";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 108;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "នាមត្រកូល";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Visible = false;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "នាមខ្លួន";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Visible = false;
            this.LastName.Width = 125;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "ឈ្មោះពេញ";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "ភេទអង់គ្លេស";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            this.Gender.Width = 125;
            // 
            // GenderKhmer
            // 
            this.GenderKhmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GenderKhmer.DataPropertyName = "GenderKhmer";
            this.GenderKhmer.HeaderText = "ភេទ";
            this.GenderKhmer.MinimumWidth = 6;
            this.GenderKhmer.Name = "GenderKhmer";
            this.GenderKhmer.ReadOnly = true;
            this.GenderKhmer.Width = 79;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "ថ្ងៃខែឆ្នាំកំណើត";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Width = 162;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "អាស័យដ្ឋាន";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            this.Address.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "លេខទូរស័ព្ទ";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 135;
            // 
            // EmergencyName
            // 
            this.EmergencyName.DataPropertyName = "EmergencyName";
            this.EmergencyName.HeaderText = "ឈ្មោះទាក់ទងបន្ទាន់";
            this.EmergencyName.MinimumWidth = 6;
            this.EmergencyName.Name = "EmergencyName";
            this.EmergencyName.ReadOnly = true;
            this.EmergencyName.Visible = false;
            this.EmergencyName.Width = 125;
            // 
            // EmergencyRelation
            // 
            this.EmergencyRelation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmergencyRelation.DataPropertyName = "EmergencyRelation";
            this.EmergencyRelation.HeaderText = "ត្រូវជា";
            this.EmergencyRelation.MinimumWidth = 6;
            this.EmergencyRelation.Name = "EmergencyRelation";
            this.EmergencyRelation.ReadOnly = true;
            this.EmergencyRelation.Width = 94;
            // 
            // EmergencyNumber
            // 
            this.EmergencyNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmergencyNumber.DataPropertyName = "EmergencyNumber";
            this.EmergencyNumber.HeaderText = "លេខទាក់ទងបន្ទាន់";
            this.EmergencyNumber.MinimumWidth = 6;
            this.EmergencyNumber.Name = "EmergencyNumber";
            this.EmergencyNumber.ReadOnly = true;
            this.EmergencyNumber.Width = 184;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "អីម៉ែល";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            this.Email.Width = 125;
            // 
            // NationalCardID
            // 
            this.NationalCardID.DataPropertyName = "NationalCardID";
            this.NationalCardID.HeaderText = "លេខអត្តសញ្ញាណប័ត្រ";
            this.NationalCardID.MinimumWidth = 6;
            this.NationalCardID.Name = "NationalCardID";
            this.NationalCardID.ReadOnly = true;
            this.NationalCardID.Visible = false;
            this.NationalCardID.Width = 125;
            // 
            // IsInpatient
            // 
            this.IsInpatient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IsInpatient.Checked = true;
            this.IsInpatient.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.IsInpatient.CheckValue = "N";
            this.IsInpatient.DataPropertyName = "IsInpatient";
            this.IsInpatient.HeaderText = "ស្នាក់នៅមន្ទីរពេទ្យ";
            this.IsInpatient.MinimumWidth = 6;
            this.IsInpatient.Name = "IsInpatient";
            this.IsInpatient.ReadOnly = true;
            this.IsInpatient.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsInpatient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsInpatient.ToolTipText = "គ្រីសប្រសិនបើអ្នកជំងឺស្នាក់នៅក្នុងមន្ទីរពេទ្យ";
            this.IsInpatient.Width = 181;
            // 
            // MedicalHistory
            // 
            this.MedicalHistory.DataPropertyName = "MedicalHistory";
            this.MedicalHistory.HeaderText = "ប្រវត្តិវេជ្ជសាស្ត្រ";
            this.MedicalHistory.MinimumWidth = 6;
            this.MedicalHistory.Name = "MedicalHistory";
            this.MedicalHistory.ReadOnly = true;
            this.MedicalHistory.Visible = false;
            this.MedicalHistory.Width = 125;
            // 
            // dgvBtnDetail
            // 
            this.dgvBtnDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvBtnDetail.HeaderText = "លម្អិត";
            this.dgvBtnDetail.Image = ((System.Drawing.Image)(resources.GetObject("dgvBtnDetail.Image")));
            this.dgvBtnDetail.MinimumWidth = 6;
            this.dgvBtnDetail.Name = "dgvBtnDetail";
            this.dgvBtnDetail.ReadOnly = true;
            this.dgvBtnDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBtnDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvBtnDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.dgvBtnDetail.Text = null;
            this.dgvBtnDetail.Width = 92;
            // 
            // Column18
            // 
            this.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column18.HeaderText = "កែប្រែ";
            this.Column18.Image = ((System.Drawing.Image)(resources.GetObject("Column18.Image")));
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column18.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.Column18.Text = null;
            this.Column18.Width = 95;
            // 
            // Column19
            // 
            this.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column19.HeaderText = "លុប";
            this.Column19.Image = ((System.Drawing.Image)(resources.GetObject("Column19.Image")));
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column19.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.Column19.Text = null;
            this.Column19.Width = 80;
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1462, 787);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.btnFilterPatientGroupBirthDate);
            this.Controls.Add(this.btnFilterPatientGroupIsInpatient);
            this.Controls.Add(this.numericUpDownPatientOffset);
            this.Controls.Add(this.s);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopPatientRecord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchEntry);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cbSearchCriteria);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dgvPatient);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPatient";
            this.Text = "FrmPatient";
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterPatientGroupByGenderAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFilterPatientStartBirthDate)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterPatientGroupByIsInpatientAmount)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFilterPatientEndBirthDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPatientOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPatient;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchEntry;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSearchCriteria;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterTopPatientRecord;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalPatient;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLblPatientFemale;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLblInPatient;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeFilterPatientStartBirthDate;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterPatientGender;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterPatientIsInpatient;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeFilterPatientEndBirthDate;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX s;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterPatientGroupByGenderAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownPatientOffset;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterPatientGroupByIsInpatientAmount;
        private DevComponents.DotNetBar.ButtonX btnFilterPatientGroupIsInpatient;
        private DevComponents.DotNetBar.ButtonX btnFilterPatientGroupBirthDate;
        private DevComponents.DotNetBar.ButtonX btnClearFilter;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderKhmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmergencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmergencyRelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmergencyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCardID;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn IsInpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalHistory;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dgvBtnDetail;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column18;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column19;
    }
}