namespace HIMS.RoomBed
{
    partial class FrmBed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBed));
            this.dgvBed = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.BedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFilterTopBedRecord = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalBed = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblBedAvailable = new System.Windows.Forms.ToolStripLabel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbSearchCriteria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSearchEntry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtFilterBedPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtFilterBedRoom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxFilterBedStatus = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterRoom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterRoomType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnClearFilter = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBed)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.RoomNumber,
            this.RoomTypeID});
            this.dgvBed.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBed.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBed.EnableHeadersVisualStyles = false;
            this.dgvBed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvBed.Location = new System.Drawing.Point(12, 331);
            this.dgvBed.Name = "dgvBed";
            this.dgvBed.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvBed.Size = new System.Drawing.Size(1500, 291);
            this.dgvBed.TabIndex = 0;
            this.dgvBed.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvBed_Paint);
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
            this.BedDescription.HeaderText = "បរិយាយ";
            this.BedDescription.MinimumWidth = 6;
            this.BedDescription.Name = "BedDescription";
            this.BedDescription.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "ស្ថានភាព";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            this.Status.Width = 125;
            // 
            // StatusText
            // 
            this.StatusText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StatusText.DataPropertyName = "StatusText";
            this.StatusText.HeaderText = "បរិយាយ​ស្ថានភាព";
            this.StatusText.MinimumWidth = 6;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.Width = 182;
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "លេខកូដបន្ទប់";
            this.RoomID.MinimumWidth = 6;
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.Visible = false;
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
            // RoomTypeID
            // 
            this.RoomTypeID.DataPropertyName = "RoomTypeID";
            this.RoomTypeID.HeaderText = "លេខកូដប្រភេទបន្ទប់";
            this.RoomTypeID.MinimumWidth = 6;
            this.RoomTypeID.Name = "RoomTypeID";
            this.RoomTypeID.ReadOnly = true;
            this.RoomTypeID.Visible = false;
            this.RoomTypeID.Width = 125;
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
            this.cbFilterTopBedRecord.Location = new System.Drawing.Point(1226, 50);
            this.cbFilterTopBedRecord.Name = "cbFilterTopBedRecord";
            this.cbFilterTopBedRecord.Size = new System.Drawing.Size(286, 50);
            this.cbFilterTopBedRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterTopBedRecord.TabIndex = 1;
            this.cbFilterTopBedRecord.TabStop = false;
            this.cbFilterTopBedRecord.SelectedIndexChanged += new System.EventHandler(this.cbFilterTopBedRecord_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(1226, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(270, 39);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "ជ្រើសរើសចំនួនកំណត់ត្រា​ ៖";
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 639);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1524, 30);
            this.toolStrip1.TabIndex = 3;
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
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 11);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(155, 39);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "កំណត់លក្ខខណ្ឌ​ ៖";
            // 
            // cbSearchCriteria
            // 
            this.cbSearchCriteria.DisplayMember = "Text";
            this.cbSearchCriteria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCriteria.ForeColor = System.Drawing.Color.Black;
            this.cbSearchCriteria.FormattingEnabled = true;
            this.cbSearchCriteria.ItemHeight = 44;
            this.cbSearchCriteria.Location = new System.Drawing.Point(157, 5);
            this.cbSearchCriteria.Name = "cbSearchCriteria";
            this.cbSearchCriteria.Size = new System.Drawing.Size(269, 50);
            this.cbSearchCriteria.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbSearchCriteria.TabIndex = 5;
            this.cbSearchCriteria.TabStop = false;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(432, 11);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 39);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "ស្វែងរក​ ៖";
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
            this.txtSearchEntry.Location = new System.Drawing.Point(519, 5);
            this.txtSearchEntry.Name = "txtSearchEntry";
            this.txtSearchEntry.PreventEnterBeep = true;
            this.txtSearchEntry.Size = new System.Drawing.Size(235, 49);
            this.txtSearchEntry.TabIndex = 7;
            this.txtSearchEntry.TabStop = false;
            this.txtSearchEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchEntry_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(760, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 49);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSearch.TabIndex = 8;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.Controls.Add(this.txtFilterBedPrice);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.txtFilterBedRoom);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.checkBoxFilterBedStatus);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 76);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(512, 236);
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
            this.groupPanel1.TabIndex = 9;
            this.groupPanel1.Text = "លក្ខខណ្ឌនៃការច្រោះ";
            // 
            // txtFilterBedPrice
            // 
            this.txtFilterBedPrice.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFilterBedPrice.Border.Class = "TextBoxBorder";
            this.txtFilterBedPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFilterBedPrice.DisabledBackColor = System.Drawing.Color.White;
            this.txtFilterBedPrice.ForeColor = System.Drawing.Color.Black;
            this.txtFilterBedPrice.Location = new System.Drawing.Point(129, 121);
            this.txtFilterBedPrice.Name = "txtFilterBedPrice";
            this.txtFilterBedPrice.PreventEnterBeep = true;
            this.txtFilterBedPrice.Size = new System.Drawing.Size(354, 49);
            this.txtFilterBedPrice.TabIndex = 15;
            this.txtFilterBedPrice.TabStop = false;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.White;
            this.labelX6.Location = new System.Drawing.Point(14, 121);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(92, 39);
            this.labelX6.TabIndex = 14;
            this.labelX6.Text = "តម្លៃបន្ទប់​ ៖";
            // 
            // txtFilterBedRoom
            // 
            this.txtFilterBedRoom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFilterBedRoom.Border.Class = "TextBoxBorder";
            this.txtFilterBedRoom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFilterBedRoom.DisabledBackColor = System.Drawing.Color.White;
            this.txtFilterBedRoom.ForeColor = System.Drawing.Color.Black;
            this.txtFilterBedRoom.Location = new System.Drawing.Point(129, 57);
            this.txtFilterBedRoom.Name = "txtFilterBedRoom";
            this.txtFilterBedRoom.PreventEnterBeep = true;
            this.txtFilterBedRoom.Size = new System.Drawing.Size(354, 49);
            this.txtFilterBedRoom.TabIndex = 11;
            this.txtFilterBedRoom.TabStop = false;
            this.txtFilterBedRoom.TextChanged += new System.EventHandler(this.txtFilterBedRoom_TextChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.White;
            this.labelX5.Location = new System.Drawing.Point(14, 67);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(92, 39);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "លេខបន្ទប់​ ៖";
            // 
            // checkBoxFilterBedStatus
            // 
            this.checkBoxFilterBedStatus.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxFilterBedStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxFilterBedStatus.CheckSignSize = new System.Drawing.Size(20, 20);
            this.checkBoxFilterBedStatus.Location = new System.Drawing.Point(129, 22);
            this.checkBoxFilterBedStatus.Name = "checkBoxFilterBedStatus";
            this.checkBoxFilterBedStatus.Size = new System.Drawing.Size(23, 23);
            this.checkBoxFilterBedStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.checkBoxFilterBedStatus.TabIndex = 12;
            this.checkBoxFilterBedStatus.TabStop = false;
            this.checkBoxFilterBedStatus.Text = "checkBoxX1";
            this.checkBoxFilterBedStatus.CheckedChanged += new System.EventHandler(this.checkBoxFilterBedStatus_CheckedChanged);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.White;
            this.labelX4.Location = new System.Drawing.Point(14, 14);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(92, 39);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "គ្រែទំនេរ​ ៖";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.cbFilterRoom);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.cbFilterRoomType);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(543, 76);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(512, 236);
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
            this.groupPanel2.TabIndex = 10;
            this.groupPanel2.Text = "លក្ខខណ្ឌនៃការច្រោះតាមបន្ទប់";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.White;
            this.labelX8.Location = new System.Drawing.Point(17, 92);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(131, 39);
            this.labelX8.TabIndex = 18;
            this.labelX8.Text = "ជម្រើសបន្ទប់​ ៖";
            // 
            // cbFilterRoom
            // 
            this.cbFilterRoom.DisplayMember = "Text";
            this.cbFilterRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterRoom.ForeColor = System.Drawing.Color.Black;
            this.cbFilterRoom.FormattingEnabled = true;
            this.cbFilterRoom.ItemHeight = 44;
            this.cbFilterRoom.Location = new System.Drawing.Point(192, 85);
            this.cbFilterRoom.Name = "cbFilterRoom";
            this.cbFilterRoom.Size = new System.Drawing.Size(269, 50);
            this.cbFilterRoom.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterRoom.TabIndex = 17;
            this.cbFilterRoom.TabStop = false;
            this.cbFilterRoom.SelectedIndexChanged += new System.EventHandler(this.cbFilterRoom_SelectedIndexChanged);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.White;
            this.labelX7.Location = new System.Drawing.Point(17, 21);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(131, 39);
            this.labelX7.TabIndex = 16;
            this.labelX7.Text = "ប្រភេទបន្ទប់​ ៖";
            // 
            // cbFilterRoomType
            // 
            this.cbFilterRoomType.DisplayMember = "Text";
            this.cbFilterRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterRoomType.ForeColor = System.Drawing.Color.Black;
            this.cbFilterRoomType.FormattingEnabled = true;
            this.cbFilterRoomType.ItemHeight = 44;
            this.cbFilterRoomType.Location = new System.Drawing.Point(192, 14);
            this.cbFilterRoomType.Name = "cbFilterRoomType";
            this.cbFilterRoomType.Size = new System.Drawing.Size(269, 50);
            this.cbFilterRoomType.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbFilterRoomType.TabIndex = 11;
            this.cbFilterRoomType.TabStop = false;
            this.cbFilterRoomType.SelectedIndexChanged += new System.EventHandler(this.cbFilterRoomType_SelectedIndexChanged);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClearFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.Location = new System.Drawing.Point(1069, 263);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(58, 49);
            this.btnClearFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnClearFilter.TabIndex = 11;
            this.btnClearFilter.TabStop = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(1454, 141);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(58, 49);
            this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(1454, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 49);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1454, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 49);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmBed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1524, 669);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchEntry);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cbSearchCriteria);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbFilterTopBedRecord);
            this.Controls.Add(this.dgvBed);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "FrmBed";
            this.Text = "FrmBed";
            this.Load += new System.EventHandler(this.FrmBed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBed)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBed;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterTopBedRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusText;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalBed;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLblBedAvailable;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSearchCriteria;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchEntry;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxFilterBedStatus;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFilterBedRoom;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFilterBedPrice;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterRoomType;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterRoom;
        private DevComponents.DotNetBar.ButtonX btnClearFilter;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        public DevComponents.DotNetBar.ButtonX btnAddNew;
    }
}