using System.Drawing;
using System.Windows.Forms;

namespace HIMS.Patient
{
    partial class FrmDianogsis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDianogsis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DiagnosisDatetime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiagnosisID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterTopDiagnosisRecord = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnAddDiagnosis = new DevComponents.DotNetBar.ButtonX();
            this.txtSearchDiagnosis = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtPatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dgvDiagnosis = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DiagnosisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStaffID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtPhysicianNote = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisDatetime)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // DiagnosisDatetime
            // 
            this.DiagnosisDatetime.AutoSelectDate = true;
            // 
            // 
            // 
            this.DiagnosisDatetime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DiagnosisDatetime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DiagnosisDatetime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DiagnosisDatetime.ButtonDropDown.Visible = true;
            this.DiagnosisDatetime.CustomFormat = "dd/MM/yyyy";
            this.DiagnosisDatetime.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector;
            this.DiagnosisDatetime.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisDatetime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.DiagnosisDatetime.IsPopupCalendarOpen = false;
            this.DiagnosisDatetime.Location = new System.Drawing.Point(184, 52);
            this.DiagnosisDatetime.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DiagnosisDatetime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DiagnosisDatetime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DiagnosisDatetime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DiagnosisDatetime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DiagnosisDatetime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DiagnosisDatetime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DiagnosisDatetime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DiagnosisDatetime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DiagnosisDatetime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DiagnosisDatetime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DiagnosisDatetime.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.DiagnosisDatetime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DiagnosisDatetime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DiagnosisDatetime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DiagnosisDatetime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DiagnosisDatetime.MonthCalendar.TodayButtonVisible = true;
            this.DiagnosisDatetime.Name = "DiagnosisDatetime";
            this.DiagnosisDatetime.Size = new System.Drawing.Size(282, 49);
            this.DiagnosisDatetime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DiagnosisDatetime.TabIndex = 3;
            this.DiagnosisDatetime.TabStop = false;
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
            this.txtDescription.Location = new System.Drawing.Point(486, 157);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PreventEnterBeep = true;
            this.txtDescription.Size = new System.Drawing.Size(880, 41);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.TabStop = false;
            // 
            // txtDiagnosisID
            // 
            this.txtDiagnosisID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDiagnosisID.Border.Class = "TextBoxBorder";
            this.txtDiagnosisID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiagnosisID.DisabledBackColor = System.Drawing.Color.White;
            this.txtDiagnosisID.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosisID.ForeColor = System.Drawing.Color.Black;
            this.txtDiagnosisID.Location = new System.Drawing.Point(9, 52);
            this.txtDiagnosisID.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtDiagnosisID.Name = "txtDiagnosisID";
            this.txtDiagnosisID.PreventEnterBeep = true;
            this.txtDiagnosisID.ReadOnly = true;
            this.txtDiagnosisID.Size = new System.Drawing.Size(163, 49);
            this.txtDiagnosisID.TabIndex = 0;
            this.txtDiagnosisID.TabStop = false;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtStatus.Border.Class = "TextBoxBorder";
            this.txtStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStatus.DisabledBackColor = System.Drawing.Color.White;
            this.txtStatus.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.Location = new System.Drawing.Point(486, 52);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PreventEnterBeep = true;
            this.txtStatus.Size = new System.Drawing.Size(282, 49);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.TabStop = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 229);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(270, 39);
            this.labelX1.TabIndex = 92;
            this.labelX1.Text = "ជ្រើសរើសចំនួនកំណត់ត្រា​ ៖";
            // 
            // cbFilterTopDiagnosisRecord
            // 
            this.cbFilterTopDiagnosisRecord.DisplayMember = "Text";
            this.cbFilterTopDiagnosisRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTopDiagnosisRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTopDiagnosisRecord.ForeColor = System.Drawing.Color.Black;
            this.cbFilterTopDiagnosisRecord.FormattingEnabled = true;
            this.cbFilterTopDiagnosisRecord.ItemHeight = 44;
            this.cbFilterTopDiagnosisRecord.Location = new System.Drawing.Point(9, 274);
            this.cbFilterTopDiagnosisRecord.Name = "cbFilterTopDiagnosisRecord";
            this.cbFilterTopDiagnosisRecord.Size = new System.Drawing.Size(286, 50);
            this.cbFilterTopDiagnosisRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterTopDiagnosisRecord.TabIndex = 11;
            this.cbFilterTopDiagnosisRecord.TabStop = false;
            this.cbFilterTopDiagnosisRecord.SelectedIndexChanged += new System.EventHandler(this.cbFilterTopDiagnosisRecord_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(1382, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 55);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "ត្រឡប់";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(1382, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 55);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSave.TabIndex = 8;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1470, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 49);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDiagnosis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDiagnosis.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDiagnosis.Image")));
            this.btnAddDiagnosis.Location = new System.Drawing.Point(1382, 80);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(58, 49);
            this.btnAddDiagnosis.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddDiagnosis.TabIndex = 7;
            this.btnAddDiagnosis.TabStop = false;
            this.btnAddDiagnosis.Click += new System.EventHandler(this.btnAddDiagnosis_Click);
            // 
            // txtSearchDiagnosis
            // 
            this.txtSearchDiagnosis.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchDiagnosis.Border.Class = "TextBoxBorder";
            this.txtSearchDiagnosis.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchDiagnosis.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchDiagnosis.ForeColor = System.Drawing.Color.Black;
            this.txtSearchDiagnosis.Location = new System.Drawing.Point(112, 2);
            this.txtSearchDiagnosis.Name = "txtSearchDiagnosis";
            this.txtSearchDiagnosis.PreventEnterBeep = true;
            this.txtSearchDiagnosis.Size = new System.Drawing.Size(235, 49);
            this.txtSearchDiagnosis.TabIndex = 0;
            this.txtSearchDiagnosis.TabStop = false;
            this.txtSearchDiagnosis.TextChanged += new System.EventHandler(this.txtSearchDiagnosis_TextChanged);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txtSearchDiagnosis);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(304, 269);
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
            this.groupPanel2.TabIndex = 93;
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
            this.txtPatientID.Location = new System.Drawing.Point(9, 157);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PreventEnterBeep = true;
            this.txtPatientID.Size = new System.Drawing.Size(163, 49);
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
            this.labelX16.Location = new System.Drawing.Point(184, -1);
            this.labelX16.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(213, 48);
            this.labelX16.TabIndex = 84;
            this.labelX16.Text = "កាលបរិច្ឆេទ";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(486, 3);
            this.labelX14.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(194, 48);
            this.labelX14.TabIndex = 82;
            this.labelX14.Text = "ស្ថានភាព";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(188, 104);
            this.labelX11.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(211, 48);
            this.labelX11.TabIndex = 79;
            this.labelX11.Text = "លេខសំគាល់បុគ្គលិក";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(9, 3);
            this.labelX10.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(159, 48);
            this.labelX10.TabIndex = 85;
            this.labelX10.Text = "លេខសំគាល់";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(9, 104);
            this.labelX9.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(159, 48);
            this.labelX9.TabIndex = 78;
            this.labelX9.Text = "លេខសំគាល់អ្នកជំងឺ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(486, 107);
            this.labelX3.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(492, 48);
            this.labelX3.TabIndex = 77;
            this.labelX3.Text = "ការបរិយាយ";
            // 
            // dgvDiagnosis
            // 
            this.dgvDiagnosis.AllowUserToAddRows = false;
            this.dgvDiagnosis.AllowUserToDeleteRows = false;
            this.dgvDiagnosis.AllowUserToResizeRows = false;
            this.dgvDiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiagnosis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiagnosis.ColumnHeadersHeight = 40;
            this.dgvDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiagnosis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiagnosisID,
            this.Date,
            this.Des,
            this.Status,
            this.NoteResult,
            this.Patien,
            this.StaffID});
            this.dgvDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiagnosis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiagnosis.EnableHeadersVisualStyles = false;
            this.dgvDiagnosis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDiagnosis.Location = new System.Drawing.Point(14, 342);
            this.dgvDiagnosis.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvDiagnosis.Name = "dgvDiagnosis";
            this.dgvDiagnosis.ReadOnly = true;
            this.dgvDiagnosis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiagnosis.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDiagnosis.RowHeadersWidth = 51;
            this.dgvDiagnosis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDiagnosis.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDiagnosis.RowTemplate.Height = 35;
            this.dgvDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosis.Size = new System.Drawing.Size(1512, 318);
            this.dgvDiagnosis.TabIndex = 75;
            this.dgvDiagnosis.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvDiagnosis_Paint);
            // 
            // DiagnosisID
            // 
            this.DiagnosisID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DiagnosisID.DataPropertyName = "DiagnosisID";
            this.DiagnosisID.HeaderText = "លេខសំគាល់";
            this.DiagnosisID.MinimumWidth = 6;
            this.DiagnosisID.Name = "DiagnosisID";
            this.DiagnosisID.ReadOnly = true;
            this.DiagnosisID.Width = 141;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Date.DataPropertyName = "DiagnosisDate";
            this.Date.HeaderText = "កាលបរិច្ឆេទ";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 140;
            // 
            // Des
            // 
            this.Des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Des.DataPropertyName = "Description";
            this.Des.HeaderText = "ការបរិយាយ";
            this.Des.MinimumWidth = 6;
            this.Des.Name = "Des";
            this.Des.ReadOnly = true;
            this.Des.Width = 250;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 50.82489F;
            this.Status.HeaderText = "ស្ថានភាព";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 115;
            // 
            // NoteResult
            // 
            this.NoteResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoteResult.DataPropertyName = "PhysicianNote";
            this.NoteResult.HeaderText = "លទ្ធផលការវិនិច្ឆ័យ";
            this.NoteResult.MinimumWidth = 6;
            this.NoteResult.Name = "NoteResult";
            this.NoteResult.ReadOnly = true;
            // 
            // Patien
            // 
            this.Patien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Patien.DataPropertyName = "PatientID";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Patien.DefaultCellStyle = dataGridViewCellStyle2;
            this.Patien.HeaderText = "លេខសំគាល់អ្នកជម្ងឺ";
            this.Patien.MinimumWidth = 6;
            this.Patien.Name = "Patien";
            this.Patien.ReadOnly = true;
            this.Patien.Width = 195;
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.HeaderText = "លេខសំគាល់បុគ្គលិក";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            this.StaffID.Width = 200;
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
            this.txtStaffID.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.ForeColor = System.Drawing.Color.Black;
            this.txtStaffID.Location = new System.Drawing.Point(188, 157);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.PreventEnterBeep = true;
            this.txtStaffID.Size = new System.Drawing.Size(282, 49);
            this.txtStaffID.TabIndex = 2;
            this.txtStaffID.TabStop = false;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(784, 2);
            this.labelX4.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(194, 48);
            this.labelX4.TabIndex = 77;
            this.labelX4.Text = "លទ្ធផល";
            // 
            // txtPhysicianNote
            // 
            this.txtPhysicianNote.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPhysicianNote.Border.Class = "TextBoxBorder";
            this.txtPhysicianNote.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhysicianNote.DisabledBackColor = System.Drawing.Color.White;
            this.txtPhysicianNote.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhysicianNote.ForeColor = System.Drawing.Color.Black;
            this.txtPhysicianNote.Location = new System.Drawing.Point(784, 52);
            this.txtPhysicianNote.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtPhysicianNote.Multiline = true;
            this.txtPhysicianNote.Name = "txtPhysicianNote";
            this.txtPhysicianNote.PreventEnterBeep = true;
            this.txtPhysicianNote.Size = new System.Drawing.Size(582, 41);
            this.txtPhysicianNote.TabIndex = 6;
            this.txtPhysicianNote.TabStop = false;
            // 
            // FrmDianogsis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1540, 698);
            this.Controls.Add(this.DiagnosisDatetime);
            this.Controls.Add(this.txtPhysicianNote);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDiagnosisID);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopDiagnosisRecord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.labelX16);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.dgvDiagnosis);
            this.Controls.Add(this.txtStaffID);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDianogsis";
            this.Text = "FrmDiagnosis";
            this.Load += new System.EventHandler(this.FrmDiagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisDatetime)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DiagnosisDatetime;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescription;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiagnosisID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStatus;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterTopDiagnosisRecord;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        public DevComponents.DotNetBar.ButtonX btnAddDiagnosis;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchDiagnosis;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientID;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDiagnosis;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patien;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhysicianNote;
    }
}