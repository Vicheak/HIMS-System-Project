namespace HIMS.Patient
{
    partial class FrmAddOrModifyPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrModifyPatient));
            this.panelTitle = new DevComponents.DotNetBar.PanelEx();
            this.txtPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxIsInpatient = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtNationalCardID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPhoneNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeBirthDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbGender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtLastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtFirstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnShowPatientEmergencyFrm = new DevComponents.DotNetBar.ButtonX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.txtMedicalHistory = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
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
            this.panelTitle.Size = new System.Drawing.Size(732, 64);
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
            this.panelTitle.Text = "បញ្ចូល ឬ​ កែប្រែព័ត៌មានអ្នកជំងឺ";
            // 
            // txtPatientID
            // 
            this.txtPatientID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPatientID.Border.Class = "TextBoxBorder";
            this.txtPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientID.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientID.ForeColor = System.Drawing.Color.Black;
            this.txtPatientID.Location = new System.Drawing.Point(190, 75);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PreventEnterBeep = true;
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(373, 49);
            this.txtPatientID.TabIndex = 16;
            this.txtPatientID.TabStop = false;
            this.txtPatientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPatientID.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPatientID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(15, 80);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(146, 39);
            this.labelX5.TabIndex = 17;
            this.labelX5.Text = "លេខកូដអ្នកជំងឺ ៖";
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.ForeColor = System.Drawing.Color.Black;
            this.labelX14.Location = new System.Drawing.Point(15, 686);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(121, 39);
            this.labelX14.TabIndex = 76;
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
            this.checkBoxIsInpatient.Location = new System.Drawing.Point(190, 693);
            this.checkBoxIsInpatient.Name = "checkBoxIsInpatient";
            this.checkBoxIsInpatient.Size = new System.Drawing.Size(23, 23);
            this.checkBoxIsInpatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.checkBoxIsInpatient.TabIndex = 10;
            this.checkBoxIsInpatient.Text = "checkBoxX1";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.ForeColor = System.Drawing.Color.Black;
            this.labelX13.Location = new System.Drawing.Point(15, 591);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(145, 60);
            this.labelX13.TabIndex = 74;
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
            this.txtNationalCardID.Location = new System.Drawing.Point(190, 546);
            this.txtNationalCardID.Name = "txtNationalCardID";
            this.txtNationalCardID.PreventEnterBeep = true;
            this.txtNationalCardID.Size = new System.Drawing.Size(522, 49);
            this.txtNationalCardID.TabIndex = 8;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.ForeColor = System.Drawing.Color.Black;
            this.labelX12.Location = new System.Drawing.Point(15, 552);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(112, 39);
            this.labelX12.TabIndex = 72;
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
            this.txtEmail.Location = new System.Drawing.Point(190, 491);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.Size = new System.Drawing.Size(522, 49);
            this.txtEmail.TabIndex = 7;
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
            this.txtPhoneNumber.Location = new System.Drawing.Point(190, 379);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PreventEnterBeep = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(522, 49);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(15, 496);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(124, 39);
            this.labelX11.TabIndex = 70;
            this.labelX11.Text = "អីម៉ែល ៖";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(15, 303);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(108, 39);
            this.labelX6.TabIndex = 61;
            this.labelX6.Text = "អាស័យដ្ឋាន ៖";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(15, 388);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(108, 39);
            this.labelX7.TabIndex = 62;
            this.labelX7.Text = "លេខទូរស័ព្ទ ៖";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(362, 248);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(133, 39);
            this.labelX1.TabIndex = 60;
            this.labelX1.Text = "ថ្ងៃខែឆ្នាំកំណើត ៖";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(15, 443);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(121, 39);
            this.labelX8.TabIndex = 64;
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
            this.dateTimeBirthDate.IsInputReadOnly = true;
            this.dateTimeBirthDate.IsPopupCalendarOpen = false;
            this.dateTimeBirthDate.Location = new System.Drawing.Point(535, 243);
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
            this.dateTimeBirthDate.Size = new System.Drawing.Size(177, 49);
            this.dateTimeBirthDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeBirthDate.TabIndex = 3;
            this.dateTimeBirthDate.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
            // 
            // cbGender
            // 
            this.cbGender.DisplayMember = "Text";
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.ItemHeight = 44;
            this.cbGender.Location = new System.Drawing.Point(190, 240);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(134, 50);
            this.cbGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbGender.TabIndex = 2;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(15, 253);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(90, 39);
            this.labelX4.TabIndex = 57;
            this.labelX4.Text = "ភេទ ៖";
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
            this.txtLastName.Location = new System.Drawing.Point(190, 185);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PreventEnterBeep = true;
            this.txtLastName.Size = new System.Drawing.Size(522, 49);
            this.txtLastName.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(15, 193);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 39);
            this.labelX2.TabIndex = 56;
            this.labelX2.Text = "នាមខ្លួន ៖";
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
            this.txtFirstName.Location = new System.Drawing.Point(190, 130);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PreventEnterBeep = true;
            this.txtFirstName.Size = new System.Drawing.Size(522, 49);
            this.txtFirstName.TabIndex = 0;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(15, 138);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(108, 39);
            this.labelX3.TabIndex = 55;
            this.labelX3.Text = "នាមត្រកូល ៖";
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("Khmer Kep", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.ForeColor = System.Drawing.Color.Black;
            this.labelX15.Location = new System.Drawing.Point(235, 689);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(247, 36);
            this.labelX15.TabIndex = 79;
            this.labelX15.Text = "គ្រីសប្រសិនអ្នកជំងឺស្នាក់នៅមន្ទីរពេទ្យ ";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(18, 744);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 55);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "ចាកចេញ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(566, 744);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 55);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowPatientEmergencyFrm
            // 
            this.btnShowPatientEmergencyFrm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowPatientEmergencyFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPatientEmergencyFrm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowPatientEmergencyFrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPatientEmergencyFrm.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPatientEmergencyFrm.Image")));
            this.btnShowPatientEmergencyFrm.Location = new System.Drawing.Point(190, 436);
            this.btnShowPatientEmergencyFrm.Name = "btnShowPatientEmergencyFrm";
            this.btnShowPatientEmergencyFrm.Size = new System.Drawing.Size(274, 49);
            this.btnShowPatientEmergencyFrm.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnShowPatientEmergencyFrm.TabIndex = 6;
            this.btnShowPatientEmergencyFrm.Text = "បញ្ចូលព័ត៌មានទាក់ទងបន្ទាន់";
            this.btnShowPatientEmergencyFrm.Click += new System.EventHandler(this.btnShowPatientEmergencyFrm_Click);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.Location = new System.Drawing.Point(190, 297);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtAddress.Size = new System.Drawing.Size(522, 76);
            this.txtAddress.TabIndex = 83;
            // 
            // txtMedicalHistory
            // 
            // 
            // 
            // 
            this.txtMedicalHistory.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtMedicalHistory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMedicalHistory.Location = new System.Drawing.Point(190, 601);
            this.txtMedicalHistory.Name = "txtMedicalHistory";
            this.txtMedicalHistory.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtMedicalHistory.Size = new System.Drawing.Size(522, 86);
            this.txtMedicalHistory.TabIndex = 87;
            // 
            // FrmAddOrModifyPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(732, 819);
            this.Controls.Add(this.txtMedicalHistory);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnShowPatientEmergencyFrm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.checkBoxIsInpatient);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.txtNationalCardID);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.dateTimeBirthDate);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddOrModifyPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAddOrModifyPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeBirthDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientID;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxIsInpatient;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNationalCardID;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhoneNumber;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeBirthDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbGender;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLastName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFirstName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnShowPatientEmergencyFrm;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtAddress;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtMedicalHistory;
    }
}