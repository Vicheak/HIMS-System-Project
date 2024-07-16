namespace HIMS.Function
{
    partial class FrmAppointmentType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppointmentType));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterTopAppointmentTypeRecord = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtSearchAppointmentType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalAppointmentType = new System.Windows.Forms.ToolStripLabel();
            this.dgvAppointmentType = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AppointmentTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentType)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(36, 44);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(270, 39);
            this.labelX1.TabIndex = 41;
            this.labelX1.Text = "ជ្រើសរើសចំនួនកំណត់ត្រា​ ៖";
            // 
            // cbFilterTopAppointmentTypeRecord
            // 
            this.cbFilterTopAppointmentTypeRecord.DisplayMember = "Text";
            this.cbFilterTopAppointmentTypeRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTopAppointmentTypeRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTopAppointmentTypeRecord.ForeColor = System.Drawing.Color.Black;
            this.cbFilterTopAppointmentTypeRecord.FormattingEnabled = true;
            this.cbFilterTopAppointmentTypeRecord.ItemHeight = 44;
            this.cbFilterTopAppointmentTypeRecord.Location = new System.Drawing.Point(36, 89);
            this.cbFilterTopAppointmentTypeRecord.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterTopAppointmentTypeRecord.Name = "cbFilterTopAppointmentTypeRecord";
            this.cbFilterTopAppointmentTypeRecord.Size = new System.Drawing.Size(286, 50);
            this.cbFilterTopAppointmentTypeRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterTopAppointmentTypeRecord.TabIndex = 32;
            this.cbFilterTopAppointmentTypeRecord.TabStop = false;
            this.cbFilterTopAppointmentTypeRecord.SelectedIndexChanged += new System.EventHandler(this.cbFilterTopAppointmentTypeRecord_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1128, 165);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 49);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDelete.TabIndex = 37;
            this.btnDelete.TabStop = false;
            this.btnDelete.Tooltip = "លុប";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(1128, 105);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 49);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Tooltip = "កែប្រែ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(1128, 44);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(58, 49);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddNew.TabIndex = 35;
            this.btnAddNew.Tooltip = "បន្ថែមថ្មី";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(656, 170);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 51);
            this.btnSearch.SplitButton = true;
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSearch.TabIndex = 34;
            this.btnSearch.TabStop = false;
            this.btnSearch.Tooltip = "ស្វែងរក";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchAppointmentType
            // 
            this.txtSearchAppointmentType.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchAppointmentType.Border.Class = "TextBoxBorder";
            this.txtSearchAppointmentType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchAppointmentType.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchAppointmentType.ForeColor = System.Drawing.Color.Black;
            this.txtSearchAppointmentType.Location = new System.Drawing.Point(322, 170);
            this.txtSearchAppointmentType.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchAppointmentType.Name = "txtSearchAppointmentType";
            this.txtSearchAppointmentType.PreventEnterBeep = true;
            this.txtSearchAppointmentType.Size = new System.Drawing.Size(325, 49);
            this.txtSearchAppointmentType.TabIndex = 33;
            this.txtSearchAppointmentType.TabStop = false;
            this.txtSearchAppointmentType.TextChanged += new System.EventHandler(this.txtSearchAppointmentType_TextChanged);
            this.txtSearchAppointmentType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchAppointmentType_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(36, 176);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(278, 39);
            this.labelX3.TabIndex = 40;
            this.labelX3.Text = "ស្វែងរក (ប្រភេទនៃការណាត់ជួប) ៖";
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
            this.toolStripLblTotalAppointmentType});
            this.toolStrip1.Location = new System.Drawing.Point(0, 559);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1220, 30);
            this.toolStrip1.TabIndex = 39;
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
            this.toolStripLabel2.Size = new System.Drawing.Size(70, 27);
            this.toolStripLabel2.Text = "ចំនួនសរុប ៖";
            // 
            // toolStripLblTotalAppointmentType
            // 
            this.toolStripLblTotalAppointmentType.ForeColor = System.Drawing.Color.White;
            this.toolStripLblTotalAppointmentType.Name = "toolStripLblTotalAppointmentType";
            this.toolStripLblTotalAppointmentType.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblTotalAppointmentType.Text = "?";
            // 
            // dgvAppointmentType
            // 
            this.dgvAppointmentType.AllowUserToAddRows = false;
            this.dgvAppointmentType.AllowUserToDeleteRows = false;
            this.dgvAppointmentType.AllowUserToResizeColumns = false;
            this.dgvAppointmentType.AllowUserToResizeRows = false;
            this.dgvAppointmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointmentType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointmentType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAppointmentType.ColumnHeadersHeight = 40;
            this.dgvAppointmentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppointmentType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentTypeID,
            this.AppointmentTypeName,
            this.Description});
            this.dgvAppointmentType.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointmentType.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvAppointmentType.EnableHeadersVisualStyles = false;
            this.dgvAppointmentType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvAppointmentType.Location = new System.Drawing.Point(11, 250);
            this.dgvAppointmentType.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointmentType.Name = "dgvAppointmentType";
            this.dgvAppointmentType.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointmentType.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvAppointmentType.RowHeadersWidth = 51;
            this.dgvAppointmentType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAppointmentType.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvAppointmentType.RowTemplate.Height = 35;
            this.dgvAppointmentType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointmentType.Size = new System.Drawing.Size(1198, 292);
            this.dgvAppointmentType.TabIndex = 38;
            this.dgvAppointmentType.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvAppointmentType_Paint);
            // 
            // AppointmentTypeID
            // 
            this.AppointmentTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AppointmentTypeID.DataPropertyName = "AppointmentTypeID";
            this.AppointmentTypeID.HeaderText = "លេខកូដ";
            this.AppointmentTypeID.MinimumWidth = 6;
            this.AppointmentTypeID.Name = "AppointmentTypeID";
            this.AppointmentTypeID.ReadOnly = true;
            this.AppointmentTypeID.Width = 108;
            // 
            // AppointmentTypeName
            // 
            this.AppointmentTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppointmentTypeName.DataPropertyName = "AppointmentTypeName";
            this.AppointmentTypeName.HeaderText = "ប្រភេទនៃការណាត់ជួប";
            this.AppointmentTypeName.MinimumWidth = 6;
            this.AppointmentTypeName.Name = "AppointmentTypeName";
            this.AppointmentTypeName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "បរិយាយ";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // FrmAppointmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1220, 589);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopAppointmentTypeRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchAppointmentType);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAppointmentType);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAppointmentType";
            this.Text = "FrmAppointmentType";
            this.Load += new System.EventHandler(this.FrmAppointmentType_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterTopAppointmentTypeRecord;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchAppointmentType;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalAppointmentType;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvAppointmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}