namespace HIMS.Function
{
    partial class FrmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            this.lbstaffid = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtStaffID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDepartmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBuildingName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtfloorNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCapacity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvDepartment = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnAddnewbtnAddnew = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnClean = new DevComponents.DotNetBar.ButtonX();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // lbstaffid
            // 
            // 
            // 
            // 
            this.lbstaffid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbstaffid.Location = new System.Drawing.Point(36, 28);
            this.lbstaffid.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.lbstaffid.Name = "lbstaffid";
            this.lbstaffid.Size = new System.Drawing.Size(176, 59);
            this.lbstaffid.TabIndex = 0;
            this.lbstaffid.Text = "លេខសម្គាល់បុគ្គលិក";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(36, 133);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(176, 59);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "ឈ្មោះនាយកដ្ឋាន";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(36, 249);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(176, 59);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "ឈ្មោះអគារ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(759, 28);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(176, 59);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "លេខជាន់";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(759, 133);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(176, 59);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "សមត្ថភាព";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(759, 249);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(176, 59);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "ការពិពណ៌នា";
            // 
            // txtStaffID
            // 
            this.txtStaffID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtStaffID.Border.Class = "TextBoxBorder";
            this.txtStaffID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStaffID.DisabledBackColor = System.Drawing.Color.White;
            this.txtStaffID.ForeColor = System.Drawing.Color.Black;
            this.txtStaffID.Location = new System.Drawing.Point(236, 28);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.PreventEnterBeep = true;
            this.txtStaffID.Size = new System.Drawing.Size(383, 49);
            this.txtStaffID.TabIndex = 6;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDepartmentName.Border.Class = "TextBoxBorder";
            this.txtDepartmentName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDepartmentName.DisabledBackColor = System.Drawing.Color.White;
            this.txtDepartmentName.ForeColor = System.Drawing.Color.Black;
            this.txtDepartmentName.Location = new System.Drawing.Point(236, 133);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.PreventEnterBeep = true;
            this.txtDepartmentName.Size = new System.Drawing.Size(383, 49);
            this.txtDepartmentName.TabIndex = 7;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBuildingName.Border.Class = "TextBoxBorder";
            this.txtBuildingName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBuildingName.DisabledBackColor = System.Drawing.Color.White;
            this.txtBuildingName.ForeColor = System.Drawing.Color.Black;
            this.txtBuildingName.Location = new System.Drawing.Point(236, 249);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.PreventEnterBeep = true;
            this.txtBuildingName.Size = new System.Drawing.Size(383, 49);
            this.txtBuildingName.TabIndex = 8;
            // 
            // txtfloorNumber
            // 
            this.txtfloorNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtfloorNumber.Border.Class = "TextBoxBorder";
            this.txtfloorNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfloorNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtfloorNumber.ForeColor = System.Drawing.Color.Black;
            this.txtfloorNumber.Location = new System.Drawing.Point(957, 28);
            this.txtfloorNumber.Name = "txtfloorNumber";
            this.txtfloorNumber.PreventEnterBeep = true;
            this.txtfloorNumber.Size = new System.Drawing.Size(383, 49);
            this.txtfloorNumber.TabIndex = 9;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCapacity.Border.Class = "TextBoxBorder";
            this.txtCapacity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCapacity.DisabledBackColor = System.Drawing.Color.White;
            this.txtCapacity.ForeColor = System.Drawing.Color.Black;
            this.txtCapacity.Location = new System.Drawing.Point(957, 133);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.PreventEnterBeep = true;
            this.txtCapacity.Size = new System.Drawing.Size(383, 49);
            this.txtCapacity.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDescription.Border.Class = "TextBoxBorder";
            this.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescription.DisabledBackColor = System.Drawing.Color.White;
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(957, 249);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PreventEnterBeep = true;
            this.txtDescription.Size = new System.Drawing.Size(383, 49);
            this.txtDescription.TabIndex = 11;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.AllowUserToResizeColumns = false;
            this.dgvDepartment.AllowUserToResizeRows = false;
            this.dgvDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartment.ColumnHeadersHeight = 40;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentID,
            this.DepartmentName,
            this.BuildingName,
            this.FloorNumber,
            this.Capacity,
            this.Description});
            this.dgvDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartment.EnableHeadersVisualStyles = false;
            this.dgvDepartment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDepartment.Location = new System.Drawing.Point(10, 452);
            this.dgvDepartment.Name = "dgvDepartment";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepartment.RowHeadersWidth = 51;
            this.dgvDepartment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDepartment.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepartment.RowTemplate.Height = 35;
            this.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartment.Size = new System.Drawing.Size(1350, 277);
            this.dgvDepartment.TabIndex = 12;
            // 
            // btnAddnewbtnAddnew
            // 
            this.btnAddnewbtnAddnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddnewbtnAddnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddnewbtnAddnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddnewbtnAddnew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddnewbtnAddnew.Image")));
            this.btnAddnewbtnAddnew.Location = new System.Drawing.Point(36, 350);
            this.btnAddnewbtnAddnew.Name = "btnAddnewbtnAddnew";
            this.btnAddnewbtnAddnew.Size = new System.Drawing.Size(146, 55);
            this.btnAddnewbtnAddnew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddnewbtnAddnew.TabIndex = 13;
            this.btnAddnewbtnAddnew.Text = "បញ្ចូល";
            this.btnAddnewbtnAddnew.Click += new System.EventHandler(this.btnAddnewbtnAddnew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(263, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 55);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "កែប្រែ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(484, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 55);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "លុប";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClean
            // 
            this.btnClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.Location = new System.Drawing.Point(720, 350);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(146, 55);
            this.btnClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnClean.TabIndex = 23;
            this.btnClean.Text = "សម្អាត";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // DepartmentID
            // 
            this.DepartmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DepartmentID.DataPropertyName = "DepartmentID";
            this.DepartmentID.HeaderText = "លេខសម្គាល់នាយកដ្ឋាន";
            this.DepartmentID.MinimumWidth = 6;
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Width = 221;
            // 
            // DepartmentName
            // 
            this.DepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "ឈ្មោះនាយកដ្ឋាន";
            this.DepartmentName.MinimumWidth = 6;
            this.DepartmentName.Name = "DepartmentName";
            // 
            // BuildingName
            // 
            this.BuildingName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BuildingName.DataPropertyName = "BuildingName";
            this.BuildingName.HeaderText = "ឈ្មោះអាគារ";
            this.BuildingName.MinimumWidth = 6;
            this.BuildingName.Name = "BuildingName";
            // 
            // FloorNumber
            // 
            this.FloorNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FloorNumber.DataPropertyName = "FloorNumber";
            this.FloorNumber.HeaderText = "លេខជាន់";
            this.FloorNumber.MinimumWidth = 6;
            this.FloorNumber.Name = "FloorNumber";
            this.FloorNumber.Width = 115;
            // 
            // Capacity
            // 
            this.Capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Capacity.DataPropertyName = "Capacity";
            this.Capacity.HeaderText = "សមត្ថភាព";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.Width = 124;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "ពិពណ៌នា";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 741);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddnewbtnAddnew);
            this.Controls.Add(this.dgvDepartment);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtfloorNumber);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lbstaffid);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "FrmDepartment";
            this.Text = "FormDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbstaffid;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStaffID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDepartmentName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBuildingName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtfloorNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCapacity;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescription;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDepartment;
        private DevComponents.DotNetBar.ButtonX btnAddnewbtnAddnew;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnClean;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}