namespace HIMS.Patient
{
    partial class FrmPatientDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientDetail));
            this.panelTitle = new DevComponents.DotNetBar.PanelEx();
            this.btnPrintPatientReport = new DevComponents.DotNetBar.ButtonX();
            this.btnPrintPatientDiagnosisReport = new DevComponents.DotNetBar.ButtonX();
            this.btnPrintPatientPrescriptionReport = new DevComponents.DotNetBar.ButtonX();
            this.btnPrintInvoice = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxIsInpatient = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtMedicalHistory = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtNationalCardID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.txtPhoneNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeBirthDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtEmergencyNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbGender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtEmergencyName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtLastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtEmergencyRelation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFirstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtBedDesc = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeBirthDate)).BeginInit();
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
            this.panelTitle.Size = new System.Drawing.Size(1690, 54);
            this.panelTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTitle.Style.GradientAngle = 90;
            this.panelTitle.Style.MarginLeft = 20;
            this.panelTitle.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panelTitle.StyleMouseOver.MarginLeft = 20;
            this.panelTitle.TabIndex = 12;
            this.panelTitle.Text = "ព័ត៌មានលម្អិតនៃអ្នកជំងឺ";
            // 
            // btnPrintPatientReport
            // 
            this.btnPrintPatientReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintPatientReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPatientReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintPatientReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPatientReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPatientReport.Image")));
            this.btnPrintPatientReport.Location = new System.Drawing.Point(503, 8);
            this.btnPrintPatientReport.Name = "btnPrintPatientReport";
            this.btnPrintPatientReport.Size = new System.Drawing.Size(262, 47);
            this.btnPrintPatientReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnPrintPatientReport.TabIndex = 28;
            this.btnPrintPatientReport.TabStop = false;
            this.btnPrintPatientReport.Text = "ចេញរបាយការណ៍អ្នកជំងឺ";
            // 
            // btnPrintPatientDiagnosisReport
            // 
            this.btnPrintPatientDiagnosisReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintPatientDiagnosisReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPatientDiagnosisReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintPatientDiagnosisReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPatientDiagnosisReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPatientDiagnosisReport.Image")));
            this.btnPrintPatientDiagnosisReport.Location = new System.Drawing.Point(771, 8);
            this.btnPrintPatientDiagnosisReport.Name = "btnPrintPatientDiagnosisReport";
            this.btnPrintPatientDiagnosisReport.Size = new System.Drawing.Size(309, 47);
            this.btnPrintPatientDiagnosisReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnPrintPatientDiagnosisReport.TabIndex = 29;
            this.btnPrintPatientDiagnosisReport.TabStop = false;
            this.btnPrintPatientDiagnosisReport.Text = "ចេញរបាយការណ៍វិន័ច្ឆ័យអ្នកជំងឺ";
            // 
            // btnPrintPatientPrescriptionReport
            // 
            this.btnPrintPatientPrescriptionReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintPatientPrescriptionReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPatientPrescriptionReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintPatientPrescriptionReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPatientPrescriptionReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPatientPrescriptionReport.Image")));
            this.btnPrintPatientPrescriptionReport.Location = new System.Drawing.Point(1086, 8);
            this.btnPrintPatientPrescriptionReport.Name = "btnPrintPatientPrescriptionReport";
            this.btnPrintPatientPrescriptionReport.Size = new System.Drawing.Size(293, 47);
            this.btnPrintPatientPrescriptionReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnPrintPatientPrescriptionReport.TabIndex = 30;
            this.btnPrintPatientPrescriptionReport.TabStop = false;
            this.btnPrintPatientPrescriptionReport.Text = "ចេញរបាយការណ៍វេជ្ជបញ្ជា";
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintInvoice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintInvoice.Image")));
            this.btnPrintInvoice.Location = new System.Drawing.Point(1385, 8);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(293, 47);
            this.btnPrintInvoice.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnPrintInvoice.TabIndex = 31;
            this.btnPrintInvoice.TabStop = false;
            this.btnPrintInvoice.Text = "បោះពុម្ពវិក័យប័ត្រ";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.panelEx1.Controls.Add(this.btnPrintInvoice);
            this.panelEx1.Controls.Add(this.btnPrintPatientReport);
            this.panelEx1.Controls.Add(this.btnPrintPatientPrescriptionReport);
            this.panelEx1.Controls.Add(this.btnPrintPatientDiagnosisReport);
            this.panelEx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 992);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1690, 63);
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.Style.MarginLeft = 20;
            this.panelEx1.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panelEx1.StyleMouseOver.MarginLeft = 20;
            this.panelEx1.TabIndex = 35;
            this.panelEx1.Text = "បោះពុម្ព ៖";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.tableLayoutPanel1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 54);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1690, 938);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 42;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 680F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.6165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.3835F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1690, 938);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel4.Location = new System.Drawing.Point(683, 552);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(1004, 383);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 3;
            this.groupPanel4.Text = "ចេញវេជ្ជបញ្ជា";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(683, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1004, 543);
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
            this.groupPanel2.Text = "រោគវិន័ច្ឆ័យរបស់អ្នកជំងឺ";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.Controls.Add(this.btnSave);
            this.groupPanel1.Controls.Add(this.btnUpdate);
            this.groupPanel1.Controls.Add(this.labelX14);
            this.groupPanel1.Controls.Add(this.checkBoxIsInpatient);
            this.groupPanel1.Controls.Add(this.txtMedicalHistory);
            this.groupPanel1.Controls.Add(this.labelX13);
            this.groupPanel1.Controls.Add(this.txtNationalCardID);
            this.groupPanel1.Controls.Add(this.labelX12);
            this.groupPanel1.Controls.Add(this.txtEmail);
            this.groupPanel1.Controls.Add(this.txtAddress);
            this.groupPanel1.Controls.Add(this.txtPhoneNumber);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.dateTimeBirthDate);
            this.groupPanel1.Controls.Add(this.txtEmergencyNumber);
            this.groupPanel1.Controls.Add(this.cbGender);
            this.groupPanel1.Controls.Add(this.txtEmergencyName);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.txtLastName);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtEmergencyRelation);
            this.groupPanel1.Controls.Add(this.txtFirstName);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtPatientID);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.groupPanel1, 2);
            this.groupPanel1.Size = new System.Drawing.Size(674, 932);
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
            this.groupPanel1.Text = "ព័ត៌មានលម្អិតផ្ទាល់ខ្លួនអ្នកជំងឺ";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(519, 830);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 49);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSave.TabIndex = 52;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "រក្សាទុក";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(291, 830);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(222, 49);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "កែប្រែព័ត៌មានអ្នកជំងឺ";
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.ForeColor = System.Drawing.Color.White;
            this.labelX14.Location = new System.Drawing.Point(6, 775);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(121, 39);
            this.labelX14.TabIndex = 50;
            this.labelX14.Text = "ស្នាក់នៅ ៖";
            // 
            // checkBoxIsInpatient
            // 
            this.checkBoxIsInpatient.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxIsInpatient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxIsInpatient.CheckSignSize = new System.Drawing.Size(20, 20);
            this.checkBoxIsInpatient.Enabled = false;
            this.checkBoxIsInpatient.Location = new System.Drawing.Point(143, 782);
            this.checkBoxIsInpatient.Name = "checkBoxIsInpatient";
            this.checkBoxIsInpatient.Size = new System.Drawing.Size(23, 23);
            this.checkBoxIsInpatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.checkBoxIsInpatient.TabIndex = 49;
            this.checkBoxIsInpatient.TabStop = false;
            this.checkBoxIsInpatient.Text = "checkBoxX1";
            // 
            // txtMedicalHistory
            // 
            // 
            // 
            // 
            this.txtMedicalHistory.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtMedicalHistory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMedicalHistory.Location = new System.Drawing.Point(143, 690);
            this.txtMedicalHistory.Name = "txtMedicalHistory";
            this.txtMedicalHistory.ReadOnly = true;
            this.txtMedicalHistory.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtMedicalHistory.Size = new System.Drawing.Size(522, 86);
            this.txtMedicalHistory.TabIndex = 48;
            this.txtMedicalHistory.TabStop = false;
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.ForeColor = System.Drawing.Color.White;
            this.labelX13.Location = new System.Drawing.Point(6, 692);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(145, 39);
            this.labelX13.TabIndex = 47;
            this.labelX13.Text = "ប្រវត្តិវេជ្ជសាស្ត្រ ៖";
            // 
            // txtNationalCardID
            // 
            this.txtNationalCardID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNationalCardID.Border.Class = "TextBoxBorder";
            this.txtNationalCardID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNationalCardID.DisabledBackColor = System.Drawing.Color.White;
            this.txtNationalCardID.ForeColor = System.Drawing.Color.Black;
            this.txtNationalCardID.Location = new System.Drawing.Point(143, 635);
            this.txtNationalCardID.Name = "txtNationalCardID";
            this.txtNationalCardID.PreventEnterBeep = true;
            this.txtNationalCardID.ReadOnly = true;
            this.txtNationalCardID.Size = new System.Drawing.Size(522, 49);
            this.txtNationalCardID.TabIndex = 46;
            this.txtNationalCardID.TabStop = false;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.ForeColor = System.Drawing.Color.White;
            this.labelX12.Location = new System.Drawing.Point(6, 640);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(112, 39);
            this.labelX12.TabIndex = 45;
            this.labelX12.Text = "អ.សប័ត្រ ៖";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(143, 580);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(522, 49);
            this.txtEmail.TabIndex = 44;
            this.txtEmail.TabStop = false;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.Location = new System.Drawing.Point(143, 279);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtAddress.Size = new System.Drawing.Size(522, 75);
            this.txtAddress.TabIndex = 42;
            this.txtAddress.TabStop = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPhoneNumber.Border.Class = "TextBoxBorder";
            this.txtPhoneNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhoneNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Location = new System.Drawing.Point(143, 360);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PreventEnterBeep = true;
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(522, 49);
            this.txtPhoneNumber.TabIndex = 35;
            this.txtPhoneNumber.TabStop = false;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.White;
            this.labelX11.Location = new System.Drawing.Point(6, 586);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(124, 39);
            this.labelX11.TabIndex = 43;
            this.labelX11.Text = "អីម៉ែល ៖";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.White;
            this.labelX6.Location = new System.Drawing.Point(6, 279);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(108, 39);
            this.labelX6.TabIndex = 33;
            this.labelX6.Text = "អាស័យដ្ឋាន ៖";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.White;
            this.labelX7.Location = new System.Drawing.Point(6, 367);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(108, 39);
            this.labelX7.TabIndex = 34;
            this.labelX7.Text = "លេខទូរស័ព្ទ ៖";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.White;
            this.labelX5.Location = new System.Drawing.Point(6, 230);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(133, 39);
            this.labelX5.TabIndex = 31;
            this.labelX5.Text = "ថ្ងៃខែឆ្នាំកំណើត ៖";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.White;
            this.labelX8.Location = new System.Drawing.Point(6, 421);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(121, 39);
            this.labelX8.TabIndex = 36;
            this.labelX8.Text = "ទាក់ទងបន្ទាន់ ៖";
            // 
            // dateTimeBirthDate
            // 
            // 
            // 
            // 
            this.dateTimeBirthDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeBirthDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeBirthDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeBirthDate.ButtonDropDown.Visible = true;
            this.dateTimeBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimeBirthDate.Enabled = false;
            this.dateTimeBirthDate.IsInputReadOnly = true;
            this.dateTimeBirthDate.IsPopupCalendarOpen = false;
            this.dateTimeBirthDate.Location = new System.Drawing.Point(143, 224);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeBirthDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeBirthDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeBirthDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeBirthDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeBirthDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeBirthDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeBirthDate.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.Size = new System.Drawing.Size(373, 49);
            this.dateTimeBirthDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeBirthDate.TabIndex = 30;
            this.dateTimeBirthDate.TabStop = false;
            this.dateTimeBirthDate.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
            // 
            // txtEmergencyNumber
            // 
            this.txtEmergencyNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmergencyNumber.Border.Class = "TextBoxBorder";
            this.txtEmergencyNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmergencyNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmergencyNumber.ForeColor = System.Drawing.Color.Black;
            this.txtEmergencyNumber.Location = new System.Drawing.Point(143, 525);
            this.txtEmergencyNumber.Name = "txtEmergencyNumber";
            this.txtEmergencyNumber.PreventEnterBeep = true;
            this.txtEmergencyNumber.ReadOnly = true;
            this.txtEmergencyNumber.Size = new System.Drawing.Size(522, 49);
            this.txtEmergencyNumber.TabIndex = 41;
            this.txtEmergencyNumber.TabStop = false;
            // 
            // cbGender
            // 
            this.cbGender.DisplayMember = "Text";
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Enabled = false;
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.ItemHeight = 44;
            this.cbGender.Location = new System.Drawing.Point(143, 168);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(373, 50);
            this.cbGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbGender.TabIndex = 29;
            this.cbGender.TabStop = false;
            // 
            // txtEmergencyName
            // 
            this.txtEmergencyName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmergencyName.Border.Class = "TextBoxBorder";
            this.txtEmergencyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmergencyName.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmergencyName.ForeColor = System.Drawing.Color.Black;
            this.txtEmergencyName.Location = new System.Drawing.Point(143, 415);
            this.txtEmergencyName.Name = "txtEmergencyName";
            this.txtEmergencyName.PreventEnterBeep = true;
            this.txtEmergencyName.ReadOnly = true;
            this.txtEmergencyName.Size = new System.Drawing.Size(522, 49);
            this.txtEmergencyName.TabIndex = 37;
            this.txtEmergencyName.TabStop = false;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.White;
            this.labelX4.Location = new System.Drawing.Point(6, 178);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(90, 39);
            this.labelX4.TabIndex = 28;
            this.labelX4.Text = "ភេទ ៖";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.White;
            this.labelX10.Location = new System.Drawing.Point(6, 531);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(124, 39);
            this.labelX10.TabIndex = 40;
            this.labelX10.Text = "លេខបន្ទាន់ ៖";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLastName.Border.Class = "TextBoxBorder";
            this.txtLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLastName.DisabledBackColor = System.Drawing.Color.White;
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(143, 113);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PreventEnterBeep = true;
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(522, 49);
            this.txtLastName.TabIndex = 26;
            this.txtLastName.TabStop = false;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.White;
            this.labelX9.Location = new System.Drawing.Point(6, 477);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(112, 39);
            this.labelX9.TabIndex = 38;
            this.labelX9.Text = "ត្រូវជា ៖";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(6, 118);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 39);
            this.labelX2.TabIndex = 27;
            this.labelX2.Text = "នាមខ្លួន ៖";
            // 
            // txtEmergencyRelation
            // 
            this.txtEmergencyRelation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmergencyRelation.Border.Class = "TextBoxBorder";
            this.txtEmergencyRelation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmergencyRelation.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmergencyRelation.ForeColor = System.Drawing.Color.Black;
            this.txtEmergencyRelation.Location = new System.Drawing.Point(143, 470);
            this.txtEmergencyRelation.Name = "txtEmergencyRelation";
            this.txtEmergencyRelation.PreventEnterBeep = true;
            this.txtEmergencyRelation.ReadOnly = true;
            this.txtEmergencyRelation.Size = new System.Drawing.Size(522, 49);
            this.txtEmergencyRelation.TabIndex = 39;
            this.txtEmergencyRelation.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFirstName.Border.Class = "TextBoxBorder";
            this.txtFirstName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFirstName.DisabledBackColor = System.Drawing.Color.White;
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(143, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PreventEnterBeep = true;
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(522, 49);
            this.txtFirstName.TabIndex = 26;
            this.txtFirstName.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(6, 63);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(108, 39);
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "នាមត្រកូល ៖";
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
            this.txtPatientID.Location = new System.Drawing.Point(143, 3);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PreventEnterBeep = true;
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(165, 49);
            this.txtPatientID.TabIndex = 24;
            this.txtPatientID.TabStop = false;
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
            this.labelX3.TabIndex = 25;
            this.labelX3.Text = "លេខកូដ ៖";
            // 
            // txtBedDesc
            // 
            // 
            // 
            // 
            this.txtBedDesc.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtBedDesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBedDesc.Location = new System.Drawing.Point(455, 3);
            this.txtBedDesc.Name = "txtBedDesc";
            this.txtBedDesc.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtBedDesc.Size = new System.Drawing.Size(360, 75);
            this.txtBedDesc.TabIndex = 32;
            // 
            // FrmPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1690, 1055);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPatientDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPatientDetail_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeBirthDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx panelTitle;
        public DevComponents.DotNetBar.ButtonX btnPrintPatientReport;
        public DevComponents.DotNetBar.ButtonX btnPrintPatientDiagnosisReport;
        public DevComponents.DotNetBar.ButtonX btnPrintPatientPrescriptionReport;
        public DevComponents.DotNetBar.ButtonX btnPrintInvoice;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmergencyNumber;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmergencyRelation;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmergencyName;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhoneNumber;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeBirthDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbGender;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLastName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFirstName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientID;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtBedDesc;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNationalCardID;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtMedicalHistory;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxIsInpatient;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}