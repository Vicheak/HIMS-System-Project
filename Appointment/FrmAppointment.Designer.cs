namespace HIMS.Appointment
{
    partial class FrmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppointment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.btnClearFilter = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dateTimeFilterPatientEndBirthDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtSearchEntry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbSearchCriteria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalBed = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblBedAvailable = new System.Windows.Forms.ToolStripLabel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterTopBedRecord = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dgvBed = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.BedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFilterPatientEndBirthDate)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1211, 271);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 49);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDelete.TabIndex = 29;
            this.btnDelete.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(1211, 211);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 49);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnUpdate.TabIndex = 18;
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(1211, 150);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(58, 49);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddNew.TabIndex = 16;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.Location = new System.Drawing.Point(430, 98);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(58, 49);
            this.btnClearFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnClearFilter.TabIndex = 28;
            this.btnClearFilter.TabStop = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.Controls.Add(this.dateTimeFilterPatientEndBirthDate);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.btnClearFilter);
            this.groupPanel1.Controls.Add(this.comboBoxEx1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(26, 98);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(512, 222);
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
            this.groupPanel1.TabIndex = 26;
            this.groupPanel1.Text = "លក្ខខណ្ឌនៃការច្រោះ";
            // 
            // dateTimeFilterPatientEndBirthDate
            // 
            // 
            // 
            // 
            this.dateTimeFilterPatientEndBirthDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeFilterPatientEndBirthDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientEndBirthDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeFilterPatientEndBirthDate.ButtonDropDown.Visible = true;
            this.dateTimeFilterPatientEndBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimeFilterPatientEndBirthDate.IsPopupCalendarOpen = false;
            this.dateTimeFilterPatientEndBirthDate.Location = new System.Drawing.Point(140, 20);
            this.dateTimeFilterPatientEndBirthDate.Margin = new System.Windows.Forms.Padding(2);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeFilterPatientEndBirthDate.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeFilterPatientEndBirthDate.Name = "dateTimeFilterPatientEndBirthDate";
            this.dateTimeFilterPatientEndBirthDate.Size = new System.Drawing.Size(271, 49);
            this.dateTimeFilterPatientEndBirthDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeFilterPatientEndBirthDate.TabIndex = 19;
            this.dateTimeFilterPatientEndBirthDate.TabStop = false;
            this.dateTimeFilterPatientEndBirthDate.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.White;
            this.labelX6.Location = new System.Drawing.Point(12, 94);
            this.labelX6.Margin = new System.Windows.Forms.Padding(2);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(92, 39);
            this.labelX6.TabIndex = 14;
            this.labelX6.Text = "ស្ថានភាព ៖";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.White;
            this.labelX5.Location = new System.Drawing.Point(12, 32);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(124, 39);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "កាលបរិច្ឆេទ ៖";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 44;
            this.comboBoxEx1.Location = new System.Drawing.Point(140, 94);
            this.comboBoxEx1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(270, 50);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.comboBoxEx1.TabIndex = 17;
            this.comboBoxEx1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(774, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 49);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSearch.TabIndex = 25;
            this.btnSearch.TabStop = false;
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
            this.txtSearchEntry.Location = new System.Drawing.Point(532, 12);
            this.txtSearchEntry.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchEntry.Name = "txtSearchEntry";
            this.txtSearchEntry.PreventEnterBeep = true;
            this.txtSearchEntry.Size = new System.Drawing.Size(235, 49);
            this.txtSearchEntry.TabIndex = 24;
            this.txtSearchEntry.TabStop = false;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(446, 19);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 39);
            this.labelX3.TabIndex = 23;
            this.labelX3.Text = "ស្វែងរក​ ៖";
            // 
            // cbSearchCriteria
            // 
            this.cbSearchCriteria.DisplayMember = "Text";
            this.cbSearchCriteria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCriteria.ForeColor = System.Drawing.Color.Black;
            this.cbSearchCriteria.FormattingEnabled = true;
            this.cbSearchCriteria.ItemHeight = 44;
            this.cbSearchCriteria.Location = new System.Drawing.Point(171, 12);
            this.cbSearchCriteria.Margin = new System.Windows.Forms.Padding(2);
            this.cbSearchCriteria.Name = "cbSearchCriteria";
            this.cbSearchCriteria.Size = new System.Drawing.Size(269, 50);
            this.cbSearchCriteria.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbSearchCriteria.TabIndex = 22;
            this.cbSearchCriteria.TabStop = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(26, 19);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(155, 39);
            this.labelX2.TabIndex = 21;
            this.labelX2.Text = "កំណត់លក្ខខណ្ឌ​ ៖";
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
            this.toolStripLblTotalBed,
            this.toolStripLabel3,
            this.toolStripLblBedAvailable});
            this.toolStrip1.Location = new System.Drawing.Point(0, 654);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1302, 30);
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
            // toolStripLblTotalBed
            // 
            this.toolStripLblTotalBed.ForeColor = System.Drawing.Color.White;
            this.toolStripLblTotalBed.Name = "toolStripLblTotalBed";
            this.toolStripLblTotalBed.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblTotalBed.Text = "?";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(110, 27);
            this.toolStripLabel3.Text = "ចំនួនគ្រែទំនេរសរុប ៖";
            // 
            // toolStripLblBedAvailable
            // 
            this.toolStripLblBedAvailable.ForeColor = System.Drawing.Color.White;
            this.toolStripLblBedAvailable.Name = "toolStripLblBedAvailable";
            this.toolStripLblBedAvailable.Size = new System.Drawing.Size(18, 27);
            this.toolStripLblBedAvailable.Text = "?";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(980, 14);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(270, 39);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "ជ្រើសរើសចំនួនកំណត់ត្រា​ ៖";
            // 
            // cbFilterTopBedRecord
            // 
            this.cbFilterTopBedRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterTopBedRecord.DisplayMember = "Text";
            this.cbFilterTopBedRecord.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTopBedRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTopBedRecord.ForeColor = System.Drawing.Color.Black;
            this.cbFilterTopBedRecord.FormattingEnabled = true;
            this.cbFilterTopBedRecord.ItemHeight = 44;
            this.cbFilterTopBedRecord.Location = new System.Drawing.Point(980, 59);
            this.cbFilterTopBedRecord.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterTopBedRecord.Name = "cbFilterTopBedRecord";
            this.cbFilterTopBedRecord.Size = new System.Drawing.Size(286, 50);
            this.cbFilterTopBedRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterTopBedRecord.TabIndex = 17;
            this.cbFilterTopBedRecord.TabStop = false;
            // 
            // dgvBed
            // 
            this.dgvBed.AllowUserToAddRows = false;
            this.dgvBed.AllowUserToDeleteRows = false;
            this.dgvBed.AllowUserToResizeColumns = false;
            this.dgvBed.AllowUserToResizeRows = false;
            this.dgvBed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBed.ColumnHeadersHeight = 40;
            this.dgvBed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BedID,
            this.BedDescription,
            this.Status,
            this.StatusText,
            this.RoomID,
            this.RoomNumber});
            this.dgvBed.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBed.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBed.EnableHeadersVisualStyles = false;
            this.dgvBed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvBed.Location = new System.Drawing.Point(26, 340);
            this.dgvBed.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBed.Name = "dgvBed";
            this.dgvBed.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer Kep", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBed.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBed.RowHeadersWidth = 51;
            this.dgvBed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBed.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBed.RowTemplate.Height = 35;
            this.dgvBed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBed.Size = new System.Drawing.Size(1242, 266);
            this.dgvBed.TabIndex = 15;
            // 
            // BedID
            // 
            this.BedID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BedID.DataPropertyName = "BedID";
            this.BedID.HeaderText = "លេខកូដ";
            this.BedID.MinimumWidth = 6;
            this.BedID.Name = "BedID";
            this.BedID.ReadOnly = true;
            this.BedID.Width = 108;
            // 
            // BedDescription
            // 
            this.BedDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BedDescription.DataPropertyName = "BedDescription";
            this.BedDescription.HeaderText = "កាលបរិច្ឆេទ";
            this.BedDescription.MinimumWidth = 6;
            this.BedDescription.Name = "BedDescription";
            this.BedDescription.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "ប្រភេទ";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // StatusText
            // 
            this.StatusText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StatusText.DataPropertyName = "StatusText";
            this.StatusText.HeaderText = "ឈ្មោះអ្នកជំងឺ";
            this.StatusText.MinimumWidth = 6;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.Width = 146;
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "ឈ្មោះវេជ្ជបណ្ឌិត";
            this.RoomID.MinimumWidth = 6;
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.Width = 125;
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
            // FrmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1302, 684);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopBedRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchEntry);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cbSearchCriteria);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBed);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAppointment";
            this.Text = "Appointment List";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFilterPatientEndBirthDate)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
        private DevComponents.DotNetBar.ButtonX btnClearFilter;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchEntry;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSearchCriteria;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalBed;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLblBedAvailable;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterTopBedRecord;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBed;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeFilterPatientEndBirthDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusText;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;

    }
}