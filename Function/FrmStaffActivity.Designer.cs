namespace HIMS.Function
{
    partial class FrmStaffActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaffActivity));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtSearchStaffActivity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalActivity = new System.Windows.Forms.ToolStripLabel();
            this.dgvStaffActivity = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ActivityTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterTopStaffActivityRecord = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1122, 156);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 49);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDelete.TabIndex = 5;
            this.btnDelete.TabStop = false;
            this.btnDelete.Tooltip = "លុប";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AutoExpandOnClick = true;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(1122, 87);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 49);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Tooltip = "កែប្រែ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(1122, 18);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(58, 49);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Tooltip = "បន្ថែមថ្មី";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(551, 154);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 51);
            this.btnSearch.SplitButton = true;
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TabStop = false;
            this.btnSearch.Tooltip = "ស្វែងរក";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchStaffActivity
            // 
            this.txtSearchStaffActivity.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchStaffActivity.Border.Class = "TextBoxBorder";
            this.txtSearchStaffActivity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchStaffActivity.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchStaffActivity.ForeColor = System.Drawing.Color.Black;
            this.txtSearchStaffActivity.Location = new System.Drawing.Point(218, 154);
            this.txtSearchStaffActivity.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchStaffActivity.Name = "txtSearchStaffActivity";
            this.txtSearchStaffActivity.PreventEnterBeep = true;
            this.txtSearchStaffActivity.Size = new System.Drawing.Size(325, 49);
            this.txtSearchStaffActivity.TabIndex = 1;
            this.txtSearchStaffActivity.TabStop = false;
            this.txtSearchStaffActivity.TextChanged += new System.EventHandler(this.txtSearchStaffActivity_TextChanged);
            this.txtSearchStaffActivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchStaffActivity_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(36, 160);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(178, 39);
            this.labelX3.TabIndex = 23;
            this.labelX3.Text = "ស្វែងរក (សកម្មភាព) ៖";
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
            this.toolStripLblTotalActivity});
            this.toolStrip1.Location = new System.Drawing.Point(0, 515);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1221, 30);
            this.toolStrip1.TabIndex = 20;
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
            // toolStripLblTotalActivity
            // 
            this.toolStripLblTotalActivity.ForeColor = System.Drawing.Color.White;
            this.toolStripLblTotalActivity.Name = "toolStripLblTotalActivity";
            this.toolStripLblTotalActivity.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblTotalActivity.Text = "?";
            // 
            // dgvStaffActivity
            // 
            this.dgvStaffActivity.AllowUserToAddRows = false;
            this.dgvStaffActivity.AllowUserToDeleteRows = false;
            this.dgvStaffActivity.AllowUserToResizeColumns = false;
            this.dgvStaffActivity.AllowUserToResizeRows = false;
            this.dgvStaffActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaffActivity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStaffActivity.ColumnHeadersHeight = 40;
            this.dgvStaffActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaffActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivityTypeID,
            this.ActivityName,
            this.Description});
            this.dgvStaffActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffActivity.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStaffActivity.EnableHeadersVisualStyles = false;
            this.dgvStaffActivity.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvStaffActivity.Location = new System.Drawing.Point(11, 234);
            this.dgvStaffActivity.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStaffActivity.Name = "dgvStaffActivity";
            this.dgvStaffActivity.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffActivity.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStaffActivity.RowHeadersWidth = 51;
            this.dgvStaffActivity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStaffActivity.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStaffActivity.RowTemplate.Height = 35;
            this.dgvStaffActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffActivity.Size = new System.Drawing.Size(1199, 266);
            this.dgvStaffActivity.TabIndex = 0;
            this.dgvStaffActivity.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvStaffActivity_Paint);
            // 
            // ActivityTypeID
            // 
            this.ActivityTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ActivityTypeID.DataPropertyName = "ActivityTypeID";
            this.ActivityTypeID.HeaderText = "លេខកូដ";
            this.ActivityTypeID.MinimumWidth = 6;
            this.ActivityTypeID.Name = "ActivityTypeID";
            this.ActivityTypeID.ReadOnly = true;
            this.ActivityTypeID.Width = 108;
            // 
            // ActivityName
            // 
            this.ActivityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActivityName.DataPropertyName = "ActivityName";
            this.ActivityName.HeaderText = "សកម្មភាព";
            this.ActivityName.MinimumWidth = 6;
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.ReadOnly = true;
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
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(36, 28);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(270, 39);
            this.labelX1.TabIndex = 31;
            this.labelX1.Text = "ជ្រើសរើសចំនួនកំណត់ត្រា​ ៖";
            // 
            // cbFilterTopStaffActivityRecord
            // 
            this.cbFilterTopStaffActivityRecord.DisplayMember = "Text";
            this.cbFilterTopStaffActivityRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTopStaffActivityRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTopStaffActivityRecord.ForeColor = System.Drawing.Color.Black;
            this.cbFilterTopStaffActivityRecord.FormattingEnabled = true;
            this.cbFilterTopStaffActivityRecord.ItemHeight = 44;
            this.cbFilterTopStaffActivityRecord.Location = new System.Drawing.Point(36, 71);
            this.cbFilterTopStaffActivityRecord.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterTopStaffActivityRecord.Name = "cbFilterTopStaffActivityRecord";
            this.cbFilterTopStaffActivityRecord.Size = new System.Drawing.Size(286, 50);
            this.cbFilterTopStaffActivityRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterTopStaffActivityRecord.TabIndex = 0;
            this.cbFilterTopStaffActivityRecord.TabStop = false;
            this.cbFilterTopStaffActivityRecord.SelectedIndexChanged += new System.EventHandler(this.cbFilterTopStaffActivityRecord_SelectedIndexChanged);
            // 
            // FrmStaffActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1221, 545);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopStaffActivityRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchStaffActivity);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvStaffActivity);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Name = "FrmStaffActivity";
            this.Load += new System.EventHandler(this.FrmStaffActivity_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchStaffActivity;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalActivity;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvStaffActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterTopStaffActivityRecord;
    }
}