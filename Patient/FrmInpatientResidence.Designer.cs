namespace HIMS.Patient
{
    partial class FrmInpatientResidence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInpatientResidence));
            this.dgvInpatientResidence = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.InpatientResidenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DischargeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBtnDetail = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.Column19 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalInpatientResidence = new System.Windows.Forms.ToolStripLabel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterTopInpatientResidenceRecord = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnAssignStaff = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtSearchEntry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbSearchCriteria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInpatientResidence)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInpatientResidence
            // 
            this.dgvInpatientResidence.AllowUserToAddRows = false;
            this.dgvInpatientResidence.AllowUserToDeleteRows = false;
            this.dgvInpatientResidence.AllowUserToResizeColumns = false;
            this.dgvInpatientResidence.AllowUserToResizeRows = false;
            this.dgvInpatientResidence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInpatientResidence.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInpatientResidence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvInpatientResidence.ColumnHeadersHeight = 45;
            this.dgvInpatientResidence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInpatientResidence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InpatientResidenceID,
            this.AdmissionDate,
            this.DischargeDate,
            this.Status,
            this.Description,
            this.PatientID,
            this.FullName,
            this.BedID,
            this.BedDescription,
            this.RoomID,
            this.RoomNumber,
            this.RoomTypeID,
            this.dgvBtnDetail,
            this.Column19});
            this.dgvInpatientResidence.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInpatientResidence.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvInpatientResidence.EnableHeadersVisualStyles = false;
            this.dgvInpatientResidence.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvInpatientResidence.Location = new System.Drawing.Point(12, 141);
            this.dgvInpatientResidence.Name = "dgvInpatientResidence";
            this.dgvInpatientResidence.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInpatientResidence.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvInpatientResidence.RowHeadersWidth = 51;
            this.dgvInpatientResidence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInpatientResidence.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvInpatientResidence.RowTemplate.Height = 35;
            this.dgvInpatientResidence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInpatientResidence.Size = new System.Drawing.Size(1385, 489);
            this.dgvInpatientResidence.TabIndex = 1;
            this.dgvInpatientResidence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInpatientResidence_CellContentClick);
            this.dgvInpatientResidence.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvInpatientResidence_Paint);
            // 
            // InpatientResidenceID
            // 
            this.InpatientResidenceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InpatientResidenceID.DataPropertyName = "InpatientResidenceID";
            this.InpatientResidenceID.HeaderText = "លេខកូដ";
            this.InpatientResidenceID.MinimumWidth = 6;
            this.InpatientResidenceID.Name = "InpatientResidenceID";
            this.InpatientResidenceID.ReadOnly = true;
            this.InpatientResidenceID.Width = 108;
            // 
            // AdmissionDate
            // 
            this.AdmissionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AdmissionDate.DataPropertyName = "AdmissionDate";
            this.AdmissionDate.HeaderText = "កាលបរិច្ឆេទចូល";
            this.AdmissionDate.MinimumWidth = 6;
            this.AdmissionDate.Name = "AdmissionDate";
            this.AdmissionDate.ReadOnly = true;
            this.AdmissionDate.Width = 172;
            // 
            // DischargeDate
            // 
            this.DischargeDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DischargeDate.DataPropertyName = "DischargeDate";
            this.DischargeDate.HeaderText = "កាលបរិច្ឆេទចេញ";
            this.DischargeDate.MinimumWidth = 6;
            this.DischargeDate.Name = "DischargeDate";
            this.DischargeDate.ReadOnly = true;
            this.DischargeDate.Width = 179;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "បរិយាយស្ថានភាព";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "បរិយាយ";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Visible = false;
            this.Description.Width = 125;
            // 
            // PatientID
            // 
            this.PatientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "លេខសម្គាល់អ្នកជំងឺ";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 195;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "ឈ្មោះពេញ";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 131;
            // 
            // BedID
            // 
            this.BedID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BedID.DataPropertyName = "BedID";
            this.BedID.HeaderText = "លេខកូដគ្រែ";
            this.BedID.MinimumWidth = 6;
            this.BedID.Name = "BedID";
            this.BedID.ReadOnly = true;
            this.BedID.Width = 135;
            // 
            // BedDescription
            // 
            this.BedDescription.DataPropertyName = "BedDescription";
            this.BedDescription.HeaderText = "បរិយាយពីគ្រែ";
            this.BedDescription.MinimumWidth = 6;
            this.BedDescription.Name = "BedDescription";
            this.BedDescription.ReadOnly = true;
            this.BedDescription.Visible = false;
            this.BedDescription.Width = 125;
            // 
            // RoomID
            // 
            this.RoomID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "លេខកូដបន្ទប់";
            this.RoomID.MinimumWidth = 6;
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.Visible = false;
            this.RoomID.Width = 147;
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "លេខបន្ទប់";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            this.RoomNumber.Width = 123;
            // 
            // RoomTypeID
            // 
            this.RoomTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RoomTypeID.DataPropertyName = "RoomTypeID";
            this.RoomTypeID.HeaderText = "លេខកូដប្រភេទបន្ទប់";
            this.RoomTypeID.MinimumWidth = 6;
            this.RoomTypeID.Name = "RoomTypeID";
            this.RoomTypeID.ReadOnly = true;
            this.RoomTypeID.Visible = false;
            this.RoomTypeID.Width = 200;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Khmer Kep", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLblTotalInpatientResidence});
            this.toolStrip1.Location = new System.Drawing.Point(0, 649);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1409, 30);
            this.toolStrip1.TabIndex = 17;
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
            this.toolStripLabel2.Size = new System.Drawing.Size(135, 27);
            this.toolStripLabel2.Text = "ចំនួននៃការសម្រាកសរុប ៖";
            // 
            // toolStripLblTotalInpatientResidence
            // 
            this.toolStripLblTotalInpatientResidence.ForeColor = System.Drawing.Color.White;
            this.toolStripLblTotalInpatientResidence.Name = "toolStripLblTotalInpatientResidence";
            this.toolStripLblTotalInpatientResidence.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblTotalInpatientResidence.Text = "?";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(1110, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(270, 39);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "ជ្រើសរើសចំនួនកំណត់ត្រា​ ៖";
            // 
            // cbFilterTopInpatientResidenceRecord
            // 
            this.cbFilterTopInpatientResidenceRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterTopInpatientResidenceRecord.DisplayMember = "Text";
            this.cbFilterTopInpatientResidenceRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTopInpatientResidenceRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTopInpatientResidenceRecord.ForeColor = System.Drawing.Color.Black;
            this.cbFilterTopInpatientResidenceRecord.FormattingEnabled = true;
            this.cbFilterTopInpatientResidenceRecord.ItemHeight = 44;
            this.cbFilterTopInpatientResidenceRecord.Location = new System.Drawing.Point(1110, 57);
            this.cbFilterTopInpatientResidenceRecord.Name = "cbFilterTopInpatientResidenceRecord";
            this.cbFilterTopInpatientResidenceRecord.Size = new System.Drawing.Size(286, 50);
            this.cbFilterTopInpatientResidenceRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterTopInpatientResidenceRecord.TabIndex = 18;
            this.cbFilterTopInpatientResidenceRecord.TabStop = false;
            this.cbFilterTopInpatientResidenceRecord.SelectedIndexChanged += new System.EventHandler(this.cbFilterTopInpatientResidenceRecord_SelectedIndexChanged);
            // 
            // btnAssignStaff
            // 
            this.btnAssignStaff.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssignStaff.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignStaff.Image")));
            this.btnAssignStaff.Location = new System.Drawing.Point(14, 77);
            this.btnAssignStaff.Name = "btnAssignStaff";
            this.btnAssignStaff.Size = new System.Drawing.Size(268, 49);
            this.btnAssignStaff.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAssignStaff.TabIndex = 62;
            this.btnAssignStaff.TabStop = false;
            this.btnAssignStaff.Text = "ចាត់បុគ្គលិកទទួលខុសត្រូវ";
            this.btnAssignStaff.Click += new System.EventHandler(this.btnAssignStaff_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAddNew.Location = new System.Drawing.Point(926, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(166, 95);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddNew.TabIndex = 63;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "បញ្ចូលការសម្រាកថ្មី";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(762, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 49);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSearch.TabIndex = 68;
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
            this.txtSearchEntry.Location = new System.Drawing.Point(521, 12);
            this.txtSearchEntry.Name = "txtSearchEntry";
            this.txtSearchEntry.PreventEnterBeep = true;
            this.txtSearchEntry.Size = new System.Drawing.Size(235, 49);
            this.txtSearchEntry.TabIndex = 67;
            this.txtSearchEntry.TabStop = false;
            this.txtSearchEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchEntry_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(434, 18);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 39);
            this.labelX3.TabIndex = 66;
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
            this.cbSearchCriteria.Location = new System.Drawing.Point(159, 12);
            this.cbSearchCriteria.Name = "cbSearchCriteria";
            this.cbSearchCriteria.Size = new System.Drawing.Size(269, 50);
            this.cbSearchCriteria.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbSearchCriteria.TabIndex = 65;
            this.cbSearchCriteria.TabStop = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 18);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(155, 39);
            this.labelX2.TabIndex = 64;
            this.labelX2.Text = "កំណត់លក្ខខណ្ឌ​ ៖";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(297, 77);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 49);
            this.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnRefresh.TabIndex = 104;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmInpatientResidence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1409, 679);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchEntry);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cbSearchCriteria);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnAssignStaff);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopInpatientResidenceRecord);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvInpatientResidence);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInpatientResidence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInpatientResidence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInpatientResidence)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInpatientResidence;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalInpatientResidence;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterTopInpatientResidenceRecord;
        private DevComponents.DotNetBar.ButtonX btnAssignStaff;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn InpatientResidenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DischargeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeID;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dgvBtnDetail;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column19;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchEntry;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSearchCriteria;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnRefresh;
    }
}