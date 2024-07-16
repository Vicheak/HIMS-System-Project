namespace HIMS.Function
{
    partial class FrmAcademicDegree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcademicDegree));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterTopAcadeDegreeRecord = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtSearchAcadeDegree = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalAcadeDegree = new System.Windows.Forms.ToolStripLabel();
            this.dgvAcadeDegree = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AcadeDegreeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcadeDegreeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcadeDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(36, 21);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(270, 39);
            this.labelX1.TabIndex = 51;
            this.labelX1.Text = "ជ្រើសរើសចំនួនកំណត់ត្រា​ ៖";
            // 
            // cbFilterTopAcadeDegreeRecord
            // 
            this.cbFilterTopAcadeDegreeRecord.DisplayMember = "Text";
            this.cbFilterTopAcadeDegreeRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTopAcadeDegreeRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTopAcadeDegreeRecord.ForeColor = System.Drawing.Color.Black;
            this.cbFilterTopAcadeDegreeRecord.FormattingEnabled = true;
            this.cbFilterTopAcadeDegreeRecord.ItemHeight = 44;
            this.cbFilterTopAcadeDegreeRecord.Location = new System.Drawing.Point(36, 66);
            this.cbFilterTopAcadeDegreeRecord.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterTopAcadeDegreeRecord.Name = "cbFilterTopAcadeDegreeRecord";
            this.cbFilterTopAcadeDegreeRecord.Size = new System.Drawing.Size(286, 50);
            this.cbFilterTopAcadeDegreeRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterTopAcadeDegreeRecord.TabIndex = 42;
            this.cbFilterTopAcadeDegreeRecord.TabStop = false;
            this.cbFilterTopAcadeDegreeRecord.SelectedIndexChanged += new System.EventHandler(this.cbFilterTopAcadeDegreeRecord_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1128, 142);
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
            this.btnUpdate.Location = new System.Drawing.Point(1128, 82);
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
            this.btnAddNew.Location = new System.Drawing.Point(1128, 21);
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
            this.btnSearch.Location = new System.Drawing.Point(605, 148);
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
            // txtSearchAcadeDegree
            // 
            this.txtSearchAcadeDegree.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchAcadeDegree.Border.Class = "TextBoxBorder";
            this.txtSearchAcadeDegree.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchAcadeDegree.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchAcadeDegree.ForeColor = System.Drawing.Color.Black;
            this.txtSearchAcadeDegree.Location = new System.Drawing.Point(272, 148);
            this.txtSearchAcadeDegree.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchAcadeDegree.Name = "txtSearchAcadeDegree";
            this.txtSearchAcadeDegree.PreventEnterBeep = true;
            this.txtSearchAcadeDegree.Size = new System.Drawing.Size(325, 49);
            this.txtSearchAcadeDegree.TabIndex = 43;
            this.txtSearchAcadeDegree.TabStop = false;
            this.txtSearchAcadeDegree.TextChanged += new System.EventHandler(this.txtSearchAcadeDegree_TextChanged);
            this.txtSearchAcadeDegree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchAcadeDegree_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(36, 154);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(232, 39);
            this.labelX3.TabIndex = 50;
            this.labelX3.Text = "ស្វែងរក (កម្រិតវប្បធម៌) ៖";
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
            this.toolStripLblTotalAcadeDegree});
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
            // toolStripLblTotalAcadeDegree
            // 
            this.toolStripLblTotalAcadeDegree.ForeColor = System.Drawing.Color.White;
            this.toolStripLblTotalAcadeDegree.Name = "toolStripLblTotalAcadeDegree";
            this.toolStripLblTotalAcadeDegree.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblTotalAcadeDegree.Text = "?";
            // 
            // dgvAcadeDegree
            // 
            this.dgvAcadeDegree.AllowUserToAddRows = false;
            this.dgvAcadeDegree.AllowUserToDeleteRows = false;
            this.dgvAcadeDegree.AllowUserToResizeColumns = false;
            this.dgvAcadeDegree.AllowUserToResizeRows = false;
            this.dgvAcadeDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAcadeDegree.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcadeDegree.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAcadeDegree.ColumnHeadersHeight = 40;
            this.dgvAcadeDegree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAcadeDegree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AcadeDegreeID,
            this.AcadeDegreeName,
            this.Description});
            this.dgvAcadeDegree.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAcadeDegree.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAcadeDegree.EnableHeadersVisualStyles = false;
            this.dgvAcadeDegree.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvAcadeDegree.Location = new System.Drawing.Point(11, 233);
            this.dgvAcadeDegree.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAcadeDegree.Name = "dgvAcadeDegree";
            this.dgvAcadeDegree.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcadeDegree.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAcadeDegree.RowHeadersWidth = 51;
            this.dgvAcadeDegree.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAcadeDegree.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAcadeDegree.RowTemplate.Height = 35;
            this.dgvAcadeDegree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcadeDegree.Size = new System.Drawing.Size(1198, 311);
            this.dgvAcadeDegree.TabIndex = 48;
            this.dgvAcadeDegree.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvAcadeDegree_Paint);
            // 
            // AcadeDegreeID
            // 
            this.AcadeDegreeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AcadeDegreeID.DataPropertyName = "AcadeDegreeID";
            this.AcadeDegreeID.HeaderText = "លេខកូដ";
            this.AcadeDegreeID.MinimumWidth = 6;
            this.AcadeDegreeID.Name = "AcadeDegreeID";
            this.AcadeDegreeID.ReadOnly = true;
            this.AcadeDegreeID.Width = 108;
            // 
            // AcadeDegreeName
            // 
            this.AcadeDegreeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AcadeDegreeName.DataPropertyName = "AcadeDegreeName";
            this.AcadeDegreeName.HeaderText = "កម្រិតវប្បធម៌";
            this.AcadeDegreeName.MinimumWidth = 6;
            this.AcadeDegreeName.Name = "AcadeDegreeName";
            this.AcadeDegreeName.ReadOnly = true;
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
            // FrmAcademicDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1220, 589);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopAcadeDegreeRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchAcadeDegree);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAcadeDegree);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAcademicDegree";
            this.Text = "FrmAcademicDegree";
            this.Load += new System.EventHandler(this.FrmAcademicDegree_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcadeDegree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterTopAcadeDegreeRecord;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchAcadeDegree;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalAcadeDegree;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvAcadeDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcadeDegreeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcadeDegreeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}