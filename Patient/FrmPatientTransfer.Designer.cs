namespace HIMS.Patient
{
    partial class FrmPatientTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientTransfer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtPatientMedicalHistory = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtPatientPhoneNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimePatientBirthDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cbPatientGender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtPatientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtSearchPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtBedDescription = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.cbBed = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbRoom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cbRoomType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTransferReason = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
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
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePatientBirthDate)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInpatientResidence)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.Controls.Add(this.txtPatientMedicalHistory);
            this.groupPanel2.Controls.Add(this.labelX13);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtPatientPhoneNumber);
            this.groupPanel2.Controls.Add(this.dateTimePatientBirthDate);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.cbPatientGender);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.txtPatientName);
            this.groupPanel2.Controls.Add(this.txtPatientID);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtSearchPatientID);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 12);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(655, 491);
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
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "ការផ្ទេររបស់អ្នកជំងឺ";
            // 
            // txtPatientMedicalHistory
            // 
            // 
            // 
            // 
            this.txtPatientMedicalHistory.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtPatientMedicalHistory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientMedicalHistory.Location = new System.Drawing.Point(278, 341);
            this.txtPatientMedicalHistory.Name = "txtPatientMedicalHistory";
            this.txtPatientMedicalHistory.ReadOnly = true;
            this.txtPatientMedicalHistory.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtPatientMedicalHistory.Size = new System.Drawing.Size(354, 86);
            this.txtPatientMedicalHistory.TabIndex = 92;
            this.txtPatientMedicalHistory.TabStop = false;
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.ForeColor = System.Drawing.Color.White;
            this.labelX13.Location = new System.Drawing.Point(17, 338);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(145, 60);
            this.labelX13.TabIndex = 90;
            this.labelX13.Text = "ប្រវត្តិវេជ្ជសាស្ត្រ ៖";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(17, 236);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(133, 39);
            this.labelX2.TabIndex = 62;
            this.labelX2.Text = "ថ្ងៃខែឆ្នាំកំណើត ៖";
            // 
            // txtPatientPhoneNumber
            // 
            this.txtPatientPhoneNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPatientPhoneNumber.Border.Class = "TextBoxBorder";
            this.txtPatientPhoneNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientPhoneNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtPatientPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPatientPhoneNumber.Location = new System.Drawing.Point(278, 286);
            this.txtPatientPhoneNumber.Name = "txtPatientPhoneNumber";
            this.txtPatientPhoneNumber.PreventEnterBeep = true;
            this.txtPatientPhoneNumber.ReadOnly = true;
            this.txtPatientPhoneNumber.Size = new System.Drawing.Size(354, 49);
            this.txtPatientPhoneNumber.TabIndex = 88;
            this.txtPatientPhoneNumber.TabStop = false;
            // 
            // dateTimePatientBirthDate
            // 
            // 
            // 
            // 
            this.dateTimePatientBirthDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimePatientBirthDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimePatientBirthDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimePatientBirthDate.ButtonDropDown.Visible = true;
            this.dateTimePatientBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePatientBirthDate.Enabled = false;
            this.dateTimePatientBirthDate.IsInputReadOnly = true;
            this.dateTimePatientBirthDate.IsPopupCalendarOpen = false;
            this.dateTimePatientBirthDate.Location = new System.Drawing.Point(278, 231);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimePatientBirthDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimePatientBirthDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimePatientBirthDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimePatientBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimePatientBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimePatientBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimePatientBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimePatientBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimePatientBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimePatientBirthDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimePatientBirthDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimePatientBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimePatientBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimePatientBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimePatientBirthDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimePatientBirthDate.MonthCalendar.TodayButtonVisible = true;
            this.dateTimePatientBirthDate.Name = "dateTimePatientBirthDate";
            this.dateTimePatientBirthDate.Size = new System.Drawing.Size(273, 49);
            this.dateTimePatientBirthDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimePatientBirthDate.TabIndex = 61;
            this.dateTimePatientBirthDate.TabStop = false;
            this.dateTimePatientBirthDate.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.White;
            this.labelX6.Location = new System.Drawing.Point(17, 293);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(108, 39);
            this.labelX6.TabIndex = 89;
            this.labelX6.Text = "លេខទូរស័ព្ទ ៖";
            // 
            // cbPatientGender
            // 
            this.cbPatientGender.DisplayMember = "Text";
            this.cbPatientGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPatientGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPatientGender.Enabled = false;
            this.cbPatientGender.ForeColor = System.Drawing.Color.Black;
            this.cbPatientGender.FormattingEnabled = true;
            this.cbPatientGender.ItemHeight = 44;
            this.cbPatientGender.Location = new System.Drawing.Point(278, 175);
            this.cbPatientGender.Name = "cbPatientGender";
            this.cbPatientGender.Size = new System.Drawing.Size(177, 50);
            this.cbPatientGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbPatientGender.TabIndex = 58;
            this.cbPatientGender.TabStop = false;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.White;
            this.labelX4.Location = new System.Drawing.Point(17, 182);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(90, 39);
            this.labelX4.TabIndex = 59;
            this.labelX4.Text = "ភេទ ៖";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPatientName.Border.Class = "TextBoxBorder";
            this.txtPatientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientName.DisabledBackColor = System.Drawing.Color.White;
            this.txtPatientName.ForeColor = System.Drawing.Color.Black;
            this.txtPatientName.Location = new System.Drawing.Point(278, 121);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PreventEnterBeep = true;
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(354, 49);
            this.txtPatientName.TabIndex = 20;
            this.txtPatientName.TabStop = false;
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
            this.txtPatientID.Location = new System.Drawing.Point(278, 66);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PreventEnterBeep = true;
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(354, 49);
            this.txtPatientID.TabIndex = 20;
            this.txtPatientID.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(17, 125);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(175, 39);
            this.labelX1.TabIndex = 18;
            this.labelX1.Text = "ឈ្មោះអ្នកជំងឺ ​ ៖";
            // 
            // txtSearchPatientID
            // 
            this.txtSearchPatientID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchPatientID.Border.Class = "TextBoxBorder";
            this.txtSearchPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchPatientID.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchPatientID.ForeColor = System.Drawing.Color.Black;
            this.txtSearchPatientID.Location = new System.Drawing.Point(278, 11);
            this.txtSearchPatientID.Name = "txtSearchPatientID";
            this.txtSearchPatientID.PreventEnterBeep = true;
            this.txtSearchPatientID.Size = new System.Drawing.Size(354, 49);
            this.txtSearchPatientID.TabIndex = 0;
            this.txtSearchPatientID.TabStop = false;
            this.txtSearchPatientID.TextChanged += new System.EventHandler(this.txtSearchPatientID_TextChanged);
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.White;
            this.labelX8.Location = new System.Drawing.Point(17, 70);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(175, 39);
            this.labelX8.TabIndex = 18;
            this.labelX8.Text = "លេខសម្គាល់អ្នកជំងឺ ៖";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.White;
            this.labelX7.Location = new System.Drawing.Point(17, 15);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(255, 39);
            this.labelX7.TabIndex = 16;
            this.labelX7.Text = "វាយបញ្ចូលលេខសម្គាល់អ្នកជំងឺ ៖";
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.Controls.Add(this.txtBedDescription);
            this.groupPanel3.Controls.Add(this.labelX11);
            this.groupPanel3.Controls.Add(this.labelX9);
            this.groupPanel3.Controls.Add(this.cbBed);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(686, 204);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(655, 299);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 69;
            this.groupPanel3.Text = "សូមជ្រើសរើសគ្រែ";
            // 
            // txtBedDescription
            // 
            // 
            // 
            // 
            this.txtBedDescription.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtBedDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBedDescription.Location = new System.Drawing.Point(191, 77);
            this.txtBedDescription.Name = "txtBedDescription";
            this.txtBedDescription.ReadOnly = true;
            this.txtBedDescription.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtBedDescription.Size = new System.Drawing.Size(444, 158);
            this.txtBedDescription.TabIndex = 60;
            this.txtBedDescription.TabStop = false;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.White;
            this.labelX11.Location = new System.Drawing.Point(17, 89);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(151, 39);
            this.labelX11.TabIndex = 59;
            this.labelX11.Text = "បរិយាយពីគ្រែ ៖";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.White;
            this.labelX9.Location = new System.Drawing.Point(17, 21);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(131, 39);
            this.labelX9.TabIndex = 16;
            this.labelX9.Text = "ជម្រើសគ្រែ​ ៖";
            // 
            // cbBed
            // 
            this.cbBed.DisplayMember = "Text";
            this.cbBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBed.Enabled = false;
            this.cbBed.ForeColor = System.Drawing.Color.Black;
            this.cbBed.FormattingEnabled = true;
            this.cbBed.ItemHeight = 44;
            this.cbBed.Location = new System.Drawing.Point(192, 21);
            this.cbBed.Name = "cbBed";
            this.cbBed.Size = new System.Drawing.Size(420, 50);
            this.cbBed.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbBed.TabIndex = 0;
            this.cbBed.TabStop = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.cbRoom);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.cbRoomType);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(686, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(655, 186);
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
            this.groupPanel1.TabIndex = 68;
            this.groupPanel1.Text = "សូមជ្រើសរើសបន្ទប់និងប្រភេទបន្ទប់";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(17, 77);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(131, 39);
            this.labelX3.TabIndex = 18;
            this.labelX3.Text = "ជម្រើសបន្ទប់​ ៖";
            // 
            // cbRoom
            // 
            this.cbRoom.DisplayMember = "Text";
            this.cbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.ForeColor = System.Drawing.Color.Black;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.ItemHeight = 44;
            this.cbRoom.Location = new System.Drawing.Point(192, 70);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(420, 50);
            this.cbRoom.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbRoom.TabIndex = 1;
            this.cbRoom.TabStop = false;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.White;
            this.labelX5.Location = new System.Drawing.Point(17, 21);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(131, 39);
            this.labelX5.TabIndex = 16;
            this.labelX5.Text = "ប្រភេទបន្ទប់​ ៖";
            // 
            // cbRoomType
            // 
            this.cbRoomType.DisplayMember = "Text";
            this.cbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.ForeColor = System.Drawing.Color.Black;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.ItemHeight = 44;
            this.cbRoomType.Location = new System.Drawing.Point(192, 14);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(420, 50);
            this.cbRoomType.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbRoomType.TabIndex = 0;
            this.cbRoomType.TabStop = false;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // txtTransferReason
            // 
            // 
            // 
            // 
            this.txtTransferReason.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtTransferReason.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTransferReason.Location = new System.Drawing.Point(1357, 57);
            this.txtTransferReason.Name = "txtTransferReason";
            this.txtTransferReason.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtTransferReason.Size = new System.Drawing.Size(547, 446);
            this.txtTransferReason.TabIndex = 99;
            this.txtTransferReason.TabStop = false;
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.ForeColor = System.Drawing.Color.Black;
            this.labelX15.Location = new System.Drawing.Point(1357, 12);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(177, 39);
            this.labelX15.TabIndex = 98;
            this.labelX15.Text = "បរិយាយមូលហេតុ ៖";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(1743, 702);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 54);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSave.TabIndex = 100;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "ផ្ទេរអ្នកជំងឺ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInpatientResidence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            this.RoomTypeID});
            this.dgvInpatientResidence.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInpatientResidence.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInpatientResidence.EnableHeadersVisualStyles = false;
            this.dgvInpatientResidence.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvInpatientResidence.Location = new System.Drawing.Point(12, 549);
            this.dgvInpatientResidence.Name = "dgvInpatientResidence";
            this.dgvInpatientResidence.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInpatientResidence.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInpatientResidence.RowHeadersWidth = 51;
            this.dgvInpatientResidence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInpatientResidence.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInpatientResidence.RowTemplate.Height = 35;
            this.dgvInpatientResidence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInpatientResidence.Size = new System.Drawing.Size(1630, 207);
            this.dgvInpatientResidence.TabIndex = 101;
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
            this.PatientID.Visible = false;
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
            this.FullName.Visible = false;
            this.FullName.Width = 131;
            // 
            // BedID
            // 
            this.BedID.DataPropertyName = "BedID";
            this.BedID.HeaderText = "លេខកូដគ្រែ";
            this.BedID.MinimumWidth = 6;
            this.BedID.Name = "BedID";
            this.BedID.ReadOnly = true;
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
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(14, 509);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(275, 39);
            this.labelX10.TabIndex = 102;
            this.labelX10.Text = "ប្រវត្តិនៃការស្នាក់នៅរបស់អ្នកជំងឺ ៖";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(1656, 549);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 49);
            this.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnRefresh.TabIndex = 103;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmPatientTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1917, 768);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.dgvInpatientResidence);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTransferReason);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPatientTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPatientTransfer_Load);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePatientBirthDate)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInpatientResidence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientPhoneNumber;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimePatientBirthDate;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbPatientGender;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchPatientID;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtPatientMedicalHistory;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtBedDescription;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbBed;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRoom;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRoomType;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtTransferReason;
        private DevComponents.DotNetBar.LabelX labelX15;
        public DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInpatientResidence;
        private DevComponents.DotNetBar.LabelX labelX10;
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
        private DevComponents.DotNetBar.ButtonX btnRefresh;
    }
}