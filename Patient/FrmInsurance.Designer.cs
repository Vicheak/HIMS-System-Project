namespace HIMS.Patient
{
    partial class FrmInsurance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsurance));
            this.txtPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvInsurance = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.InsuranceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolicyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCompanyName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeEffectiveDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtCompanyContact = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtInsuranceID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPolicyNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeExpirationDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalInsurance = new System.Windows.Forms.ToolStripLabel();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterTopInsuranceRecord = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtSearchEntry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeEffectiveDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeExpirationDate)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.txtPatientID.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.ForeColor = System.Drawing.Color.Black;
            this.txtPatientID.Location = new System.Drawing.Point(9, 159);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PreventEnterBeep = true;
            this.txtPatientID.Size = new System.Drawing.Size(152, 49);
            this.txtPatientID.TabIndex = 1;
            this.txtPatientID.TabStop = false;
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX16.Location = new System.Drawing.Point(773, 5);
            this.labelX16.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(213, 48);
            this.labelX16.TabIndex = 46;
            this.labelX16.Text = "កាលបរិច្ឆេទមានប្រសិទ្ធភាព";
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(1002, 5);
            this.labelX15.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(211, 48);
            this.labelX15.TabIndex = 45;
            this.labelX15.Text = "កាលបរិច្ឆេទផុតកំណត់";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(475, 5);
            this.labelX14.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(194, 48);
            this.labelX14.TabIndex = 44;
            this.labelX14.Text = "លេខ​ Policy";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.Location = new System.Drawing.Point(475, 106);
            this.labelX13.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(211, 48);
            this.labelX13.TabIndex = 43;
            this.labelX13.Text = "ទំនាក់ទំនងក្រុមហ៊ុន";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(177, 3);
            this.labelX12.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(194, 48);
            this.labelX12.TabIndex = 42;
            this.labelX12.Text = "ឈ្មោះក្រុមហ៊ុន";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(177, 106);
            this.labelX11.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(211, 48);
            this.labelX11.TabIndex = 41;
            this.labelX11.Text = "ចំនួនទឹកប្រាក់";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(9, 5);
            this.labelX10.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(159, 48);
            this.labelX10.TabIndex = 48;
            this.labelX10.Text = "លេខសំគាល់ប័ណ្ណ";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(9, 106);
            this.labelX9.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(159, 48);
            this.labelX9.TabIndex = 40;
            this.labelX9.Text = "លេខសំគាល់អ្នកជំងឺ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(773, 106);
            this.labelX3.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(194, 48);
            this.labelX3.TabIndex = 39;
            this.labelX3.Text = "ការពិព័ណ៌នា";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAmount.Border.Class = "TextBoxBorder";
            this.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmount.DisabledBackColor = System.Drawing.Color.White;
            this.txtAmount.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.Location = new System.Drawing.Point(177, 159);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PreventEnterBeep = true;
            this.txtAmount.Size = new System.Drawing.Size(282, 49);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TabStop = false;
            // 
            // dgvInsurance
            // 
            this.dgvInsurance.AllowUserToAddRows = false;
            this.dgvInsurance.AllowUserToDeleteRows = false;
            this.dgvInsurance.AllowUserToResizeRows = false;
            this.dgvInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInsurance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsurance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsurance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.dgvInsurance.ColumnHeadersHeight = 40;
            this.dgvInsurance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInsurance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InsuranceID,
            this.CompanyName,
            this.PolicyNumber,
            this.EffectiveDate,
            this.ExpirationDate,
            this.Amount,
            this.CompanyContact,
            this.Description,
            this.PatientID,
            this.PatientFullName});
            this.dgvInsurance.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsurance.DefaultCellStyle = dataGridViewCellStyle53;
            this.dgvInsurance.EnableHeadersVisualStyles = false;
            this.dgvInsurance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvInsurance.Location = new System.Drawing.Point(9, 336);
            this.dgvInsurance.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvInsurance.Name = "dgvInsurance";
            this.dgvInsurance.ReadOnly = true;
            this.dgvInsurance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsurance.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.dgvInsurance.RowHeadersWidth = 51;
            this.dgvInsurance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInsurance.RowsDefaultCellStyle = dataGridViewCellStyle55;
            this.dgvInsurance.RowTemplate.Height = 35;
            this.dgvInsurance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsurance.Size = new System.Drawing.Size(1555, 295);
            this.dgvInsurance.TabIndex = 28;
            this.dgvInsurance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsurance_CellClick);
            this.dgvInsurance.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvInsurance_Paint);
            // 
            // InsuranceID
            // 
            this.InsuranceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InsuranceID.DataPropertyName = "InsuranceID";
            this.InsuranceID.HeaderText = "លេខប័ណ្ណ";
            this.InsuranceID.MinimumWidth = 6;
            this.InsuranceID.Name = "InsuranceID";
            this.InsuranceID.ReadOnly = true;
            this.InsuranceID.Width = 123;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "ឈ្មោះក្រុមហ៊ុន";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 159;
            // 
            // PolicyNumber
            // 
            this.PolicyNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PolicyNumber.DataPropertyName = "PolicyNumber";
            this.PolicyNumber.HeaderText = "លេខ Policy";
            this.PolicyNumber.MinimumWidth = 6;
            this.PolicyNumber.Name = "PolicyNumber";
            this.PolicyNumber.ReadOnly = true;
            this.PolicyNumber.Width = 141;
            // 
            // EffectiveDate
            // 
            this.EffectiveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EffectiveDate.DataPropertyName = "EffectiveDate";
            this.EffectiveDate.FillWeight = 50.82489F;
            this.EffectiveDate.HeaderText = "កាលបរិច្ឆេទមានប្រសិទ្ធភាព";
            this.EffectiveDate.MinimumWidth = 6;
            this.EffectiveDate.Name = "EffectiveDate";
            this.EffectiveDate.ReadOnly = true;
            this.EffectiveDate.Width = 255;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            this.ExpirationDate.HeaderText = "កាលបរិច្ឆេទផុតកំណត់";
            this.ExpirationDate.MinimumWidth = 6;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            this.ExpirationDate.Width = 215;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle52.Format = "C2";
            dataGridViewCellStyle52.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle52;
            this.Amount.HeaderText = "ចំនួនទឹកប្រាក់";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 146;
            // 
            // CompanyContact
            // 
            this.CompanyContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CompanyContact.DataPropertyName = "CompanyContact";
            this.CompanyContact.HeaderText = "ទំនាក់ទំនងក្រុមហ៊ុន";
            this.CompanyContact.MinimumWidth = 6;
            this.CompanyContact.Name = "CompanyContact";
            this.CompanyContact.ReadOnly = true;
            this.CompanyContact.Width = 192;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 50.82489F;
            this.Description.HeaderText = "បរិយាយ";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // PatientID
            // 
            this.PatientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "លេខសំគាល់អ្នកជម្ងឺ";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 195;
            // 
            // PatientFullName
            // 
            this.PatientFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PatientFullName.DataPropertyName = "PatientFullName";
            this.PatientFullName.HeaderText = "ឈ្មោះពេញអ្នកជំងឺ";
            this.PatientFullName.MinimumWidth = 6;
            this.PatientFullName.Name = "PatientFullName";
            this.PatientFullName.ReadOnly = true;
            this.PatientFullName.Width = 184;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyName.Border.Class = "TextBoxBorder";
            this.txtCompanyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyName.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyName.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyName.Location = new System.Drawing.Point(177, 54);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PreventEnterBeep = true;
            this.txtCompanyName.Size = new System.Drawing.Size(282, 49);
            this.txtCompanyName.TabIndex = 2;
            this.txtCompanyName.TabStop = false;
            // 
            // dateTimeEffectiveDate
            // 
            // 
            // 
            // 
            this.dateTimeEffectiveDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeEffectiveDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeEffectiveDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeEffectiveDate.ButtonDropDown.Visible = true;
            this.dateTimeEffectiveDate.CustomFormat = "dd/mm/yyyy";
            this.dateTimeEffectiveDate.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEffectiveDate.IsPopupCalendarOpen = false;
            this.dateTimeEffectiveDate.Location = new System.Drawing.Point(773, 54);
            this.dateTimeEffectiveDate.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeEffectiveDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeEffectiveDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeEffectiveDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeEffectiveDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeEffectiveDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeEffectiveDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeEffectiveDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeEffectiveDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeEffectiveDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeEffectiveDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeEffectiveDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeEffectiveDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeEffectiveDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeEffectiveDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeEffectiveDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeEffectiveDate.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeEffectiveDate.Name = "dateTimeEffectiveDate";
            this.dateTimeEffectiveDate.Size = new System.Drawing.Size(213, 49);
            this.dateTimeEffectiveDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeEffectiveDate.TabIndex = 6;
            this.dateTimeEffectiveDate.TabStop = false;
            // 
            // txtCompanyContact
            // 
            this.txtCompanyContact.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyContact.Border.Class = "TextBoxBorder";
            this.txtCompanyContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyContact.DisabledBackColor = System.Drawing.Color.White;
            this.txtCompanyContact.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyContact.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyContact.Location = new System.Drawing.Point(475, 159);
            this.txtCompanyContact.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtCompanyContact.Name = "txtCompanyContact";
            this.txtCompanyContact.PreventEnterBeep = true;
            this.txtCompanyContact.Size = new System.Drawing.Size(282, 49);
            this.txtCompanyContact.TabIndex = 5;
            this.txtCompanyContact.TabStop = false;
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
            this.txtDescription.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(773, 159);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PreventEnterBeep = true;
            this.txtDescription.Size = new System.Drawing.Size(442, 90);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.TabStop = false;
            // 
            // txtInsuranceID
            // 
            this.txtInsuranceID.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtInsuranceID.Border.Class = "TextBoxBorder";
            this.txtInsuranceID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInsuranceID.DisabledBackColor = System.Drawing.Color.White;
            this.txtInsuranceID.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsuranceID.ForeColor = System.Drawing.Color.Black;
            this.txtInsuranceID.Location = new System.Drawing.Point(9, 54);
            this.txtInsuranceID.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtInsuranceID.Name = "txtInsuranceID";
            this.txtInsuranceID.PreventEnterBeep = true;
            this.txtInsuranceID.ReadOnly = true;
            this.txtInsuranceID.Size = new System.Drawing.Size(152, 49);
            this.txtInsuranceID.TabIndex = 32;
            this.txtInsuranceID.TabStop = false;
            // 
            // txtPolicyNumber
            // 
            this.txtPolicyNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPolicyNumber.Border.Class = "TextBoxBorder";
            this.txtPolicyNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPolicyNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtPolicyNumber.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolicyNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPolicyNumber.Location = new System.Drawing.Point(475, 54);
            this.txtPolicyNumber.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtPolicyNumber.Name = "txtPolicyNumber";
            this.txtPolicyNumber.PreventEnterBeep = true;
            this.txtPolicyNumber.Size = new System.Drawing.Size(282, 49);
            this.txtPolicyNumber.TabIndex = 4;
            this.txtPolicyNumber.TabStop = false;
            // 
            // dateTimeExpirationDate
            // 
            // 
            // 
            // 
            this.dateTimeExpirationDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeExpirationDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeExpirationDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeExpirationDate.ButtonDropDown.Visible = true;
            this.dateTimeExpirationDate.CommandParameter = "";
            this.dateTimeExpirationDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimeExpirationDate.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeExpirationDate.IsPopupCalendarOpen = false;
            this.dateTimeExpirationDate.Location = new System.Drawing.Point(1002, 54);
            this.dateTimeExpirationDate.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeExpirationDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeExpirationDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeExpirationDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeExpirationDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeExpirationDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeExpirationDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeExpirationDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeExpirationDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeExpirationDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeExpirationDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeExpirationDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeExpirationDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeExpirationDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeExpirationDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeExpirationDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeExpirationDate.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeExpirationDate.Name = "dateTimeExpirationDate";
            this.dateTimeExpirationDate.Size = new System.Drawing.Size(213, 49);
            this.dateTimeExpirationDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeExpirationDate.TabIndex = 7;
            this.dateTimeExpirationDate.TabStop = false;
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
            this.toolStripLblTotalInsurance});
            this.toolStrip1.Location = new System.Drawing.Point(0, 639);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1578, 30);
            this.toolStrip1.TabIndex = 56;
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
            // toolStripLblTotalInsurance
            // 
            this.toolStripLblTotalInsurance.ForeColor = System.Drawing.Color.White;
            this.toolStripLblTotalInsurance.Name = "toolStripLblTotalInsurance";
            this.toolStripLblTotalInsurance.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblTotalInsurance.Text = "?";
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(1508, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(58, 49);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddNew.TabIndex = 57;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1508, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 49);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDelete.TabIndex = 58;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(1420, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 55);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSave.TabIndex = 59;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(1420, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 55);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnCancel.TabIndex = 60;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "ត្រឡប់";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 231);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(270, 39);
            this.labelX1.TabIndex = 62;
            this.labelX1.Text = "ជ្រើសរើសចំនួនកំណត់ត្រា​ ៖";
            // 
            // cbFilterTopInsuranceRecord
            // 
            this.cbFilterTopInsuranceRecord.DisplayMember = "Text";
            this.cbFilterTopInsuranceRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTopInsuranceRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTopInsuranceRecord.ForeColor = System.Drawing.Color.Black;
            this.cbFilterTopInsuranceRecord.FormattingEnabled = true;
            this.cbFilterTopInsuranceRecord.ItemHeight = 44;
            this.cbFilterTopInsuranceRecord.Location = new System.Drawing.Point(12, 276);
            this.cbFilterTopInsuranceRecord.Name = "cbFilterTopInsuranceRecord";
            this.cbFilterTopInsuranceRecord.Size = new System.Drawing.Size(286, 50);
            this.cbFilterTopInsuranceRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterTopInsuranceRecord.TabIndex = 61;
            this.cbFilterTopInsuranceRecord.TabStop = false;
            this.cbFilterTopInsuranceRecord.SelectedIndexChanged += new System.EventHandler(this.cbFilterTopInsuranceRecord_SelectedIndexChanged);
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
            this.txtSearchEntry.Location = new System.Drawing.Point(112, 2);
            this.txtSearchEntry.Name = "txtSearchEntry";
            this.txtSearchEntry.PreventEnterBeep = true;
            this.txtSearchEntry.Size = new System.Drawing.Size(235, 49);
            this.txtSearchEntry.TabIndex = 64;
            this.txtSearchEntry.TabStop = false;
            this.txtSearchEntry.TextChanged += new System.EventHandler(this.txtSearchEntry_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(14, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(92, 39);
            this.labelX2.TabIndex = 63;
            this.labelX2.Text = "ស្វែងរក​ ៖";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtSearchEntry);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(304, 271);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(365, 51);
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
            this.groupPanel2.TabIndex = 66;
            // 
            // FrmInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 669);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopInsuranceRecord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.labelX16);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dgvInsurance);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.dateTimeEffectiveDate);
            this.Controls.Add(this.txtCompanyContact);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtInsuranceID);
            this.Controls.Add(this.txtPolicyNumber);
            this.Controls.Add(this.dateTimeExpirationDate);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInsurance";
            this.ShowIcon = false;
            this.Text = "FrmInsurance";
            this.Load += new System.EventHandler(this.FrmInsurance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeEffectiveDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeExpirationDate)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientID;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAmount;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInsurance;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyName;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeEffectiveDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCompanyContact;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescription;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInsuranceID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPolicyNumber;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeExpirationDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolicyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFullName;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterTopInsuranceRecord;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchEntry;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
    }
}