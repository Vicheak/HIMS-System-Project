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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInpatientResidence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.RoomTypeID,
            this.dgvBtnDetail,
            this.Column19});
            this.dgvInpatientResidence.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInpatientResidence.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInpatientResidence.EnableHeadersVisualStyles = false;
            this.dgvInpatientResidence.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvInpatientResidence.Location = new System.Drawing.Point(12, 312);
            this.dgvInpatientResidence.Name = "dgvInpatientResidence";
            this.dgvInpatientResidence.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInpatientResidence.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInpatientResidence.RowHeadersWidth = 51;
            this.dgvInpatientResidence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInpatientResidence.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInpatientResidence.RowTemplate.Height = 35;
            this.dgvInpatientResidence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInpatientResidence.Size = new System.Drawing.Size(1385, 318);
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
            this.BedID.DataPropertyName = "BedID";
            this.BedID.HeaderText = "លេខកូដគ្រែ";
            this.BedID.MinimumWidth = 6;
            this.BedID.Name = "BedID";
            this.BedID.ReadOnly = true;
            this.BedID.Visible = false;
            this.BedID.Width = 125;
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
            this.btnAssignStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignStaff.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssignStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignStaff.Image")));
            this.btnAssignStaff.Location = new System.Drawing.Point(1129, 244);
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
            this.btnAddNew.Location = new System.Drawing.Point(1230, 128);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(166, 95);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddNew.TabIndex = 63;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "បញ្ចូលការសម្រាកថ្មី";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // FrmInpatientResidence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1409, 679);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnAssignStaff);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopInpatientResidenceRecord);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvInpatientResidence);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInpatientResidence";
            this.Text = "FrmInpatientResidence";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeID;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dgvBtnDetail;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column19;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
    }
}