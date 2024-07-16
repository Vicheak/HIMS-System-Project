namespace HIMS.Function
{
    partial class FrmStaffPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaffPosition));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterTopStaffPositionRecord = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtSearchStaffPosition = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalStaffPosition = new System.Windows.Forms.ToolStripLabel();
            this.dgvStaffPosition = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.StaffPositionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(35, 42);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(270, 39);
            this.labelX1.TabIndex = 51;
            this.labelX1.Text = "ជ្រើសរើសចំនួនកំណត់ត្រា​ ៖";
            // 
            // cbFilterTopStaffPositionRecord
            // 
            this.cbFilterTopStaffPositionRecord.DisplayMember = "Text";
            this.cbFilterTopStaffPositionRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTopStaffPositionRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTopStaffPositionRecord.ForeColor = System.Drawing.Color.Black;
            this.cbFilterTopStaffPositionRecord.FormattingEnabled = true;
            this.cbFilterTopStaffPositionRecord.ItemHeight = 44;
            this.cbFilterTopStaffPositionRecord.Location = new System.Drawing.Point(35, 88);
            this.cbFilterTopStaffPositionRecord.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterTopStaffPositionRecord.Name = "cbFilterTopStaffPositionRecord";
            this.cbFilterTopStaffPositionRecord.Size = new System.Drawing.Size(286, 50);
            this.cbFilterTopStaffPositionRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterTopStaffPositionRecord.TabIndex = 42;
            this.cbFilterTopStaffPositionRecord.TabStop = false;
            this.cbFilterTopStaffPositionRecord.SelectedIndexChanged += new System.EventHandler(this.cbFilterTopStaffPositionRecord_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1126, 164);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 49);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDelete.TabIndex = 47;
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
            this.btnUpdate.Location = new System.Drawing.Point(1126, 104);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 49);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Tooltip = "កែប្រែ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(1126, 42);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(58, 49);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddNew.TabIndex = 45;
            this.btnAddNew.Tooltip = "បន្ថែមថ្មី";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(558, 170);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 51);
            this.btnSearch.SplitButton = true;
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSearch.TabIndex = 44;
            this.btnSearch.TabStop = false;
            this.btnSearch.Tooltip = "ស្វែងរក";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchStaffPosition
            // 
            this.txtSearchStaffPosition.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchStaffPosition.Border.Class = "TextBoxBorder";
            this.txtSearchStaffPosition.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchStaffPosition.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchStaffPosition.ForeColor = System.Drawing.Color.Black;
            this.txtSearchStaffPosition.Location = new System.Drawing.Point(224, 170);
            this.txtSearchStaffPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchStaffPosition.Name = "txtSearchStaffPosition";
            this.txtSearchStaffPosition.PreventEnterBeep = true;
            this.txtSearchStaffPosition.Size = new System.Drawing.Size(325, 49);
            this.txtSearchStaffPosition.TabIndex = 43;
            this.txtSearchStaffPosition.TabStop = false;
            this.txtSearchStaffPosition.TextChanged += new System.EventHandler(this.txtSearchStaffPosition_TextChanged);
            this.txtSearchStaffPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchStaffPosition_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(35, 175);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(278, 39);
            this.labelX3.TabIndex = 50;
            this.labelX3.Text = "ស្វែងរក (មុខតំណែង) ៖";
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
            this.toolStripLblTotalStaffPosition});
            this.toolStrip1.Location = new System.Drawing.Point(0, 559);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1220, 30);
            this.toolStrip1.TabIndex = 49;
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
            // toolStripLblTotalStaffPosition
            // 
            this.toolStripLblTotalStaffPosition.ForeColor = System.Drawing.Color.White;
            this.toolStripLblTotalStaffPosition.Name = "toolStripLblTotalStaffPosition";
            this.toolStripLblTotalStaffPosition.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblTotalStaffPosition.Text = "?";
            // 
            // dgvStaffPosition
            // 
            this.dgvStaffPosition.AllowUserToAddRows = false;
            this.dgvStaffPosition.AllowUserToDeleteRows = false;
            this.dgvStaffPosition.AllowUserToResizeColumns = false;
            this.dgvStaffPosition.AllowUserToResizeRows = false;
            this.dgvStaffPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaffPosition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffPosition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaffPosition.ColumnHeadersHeight = 40;
            this.dgvStaffPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaffPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffPositionID,
            this.StaffPositionName,
            this.Description});
            this.dgvStaffPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffPosition.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaffPosition.EnableHeadersVisualStyles = false;
            this.dgvStaffPosition.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvStaffPosition.Location = new System.Drawing.Point(11, 249);
            this.dgvStaffPosition.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStaffPosition.Name = "dgvStaffPosition";
            this.dgvStaffPosition.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffPosition.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaffPosition.RowHeadersWidth = 51;
            this.dgvStaffPosition.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStaffPosition.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStaffPosition.RowTemplate.Height = 35;
            this.dgvStaffPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffPosition.Size = new System.Drawing.Size(1198, 295);
            this.dgvStaffPosition.TabIndex = 48;
            this.dgvStaffPosition.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvStaffPosition_Paint);
            // 
            // StaffPositionID
            // 
            this.StaffPositionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StaffPositionID.DataPropertyName = "StaffPositionID";
            this.StaffPositionID.HeaderText = "លេខកូដ";
            this.StaffPositionID.MinimumWidth = 6;
            this.StaffPositionID.Name = "StaffPositionID";
            this.StaffPositionID.ReadOnly = true;
            this.StaffPositionID.Width = 108;
            // 
            // StaffPositionName
            // 
            this.StaffPositionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffPositionName.DataPropertyName = "StaffPositionName";
            this.StaffPositionName.HeaderText = "មុខតំណែង";
            this.StaffPositionName.MinimumWidth = 6;
            this.StaffPositionName.Name = "StaffPositionName";
            this.StaffPositionName.ReadOnly = true;
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
            // FrmStaffPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1220, 589);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopStaffPositionRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchStaffPosition);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvStaffPosition);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStaffPosition";
            this.Text = "FrmStaffPosition";
            this.Load += new System.EventHandler(this.FrmStaffPosition_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterTopStaffPositionRecord;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchStaffPosition;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalStaffPosition;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvStaffPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}