using DevComponents.DotNetBar.Controls;

namespace HIMS.Visitor
{
    partial class FrmVisitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisitor));
            this.panelTitle = new DevComponents.DotNetBar.PanelEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtVisitorAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtVisitorPhoneNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtVisitorLname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtVisitorFname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtVisitorID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtPatientRelation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.cbVisitorSex = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnShowVisitingDetails = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnChoosePatient = new DevComponents.DotNetBar.ButtonX();
            this.tbPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hIMSDataSet1 = new HIMS.HIMSDataSet1();
            this.tbPatientTableAdapter = new HIMS.HIMSDataSet1TableAdapters.tbPatientTableAdapter();
            this.tbVisitingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hIMSDataSet2 = new HIMS.HIMSDataSet2();
            this.tbVisitingTableAdapter = new HIMS.HIMSDataSet2TableAdapters.tbVisitingTableAdapter();
            this.txtChoosePatientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtChoosePatientFName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtChoosePatientLname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEntryDateTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLeaveDateTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tbPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVisitingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIMSDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTitle.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.panelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTitle.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelTitle.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(-3, -1);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1352, 64);
            this.panelTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTitle.Style.GradientAngle = 90;
            this.panelTitle.Style.MarginLeft = 20;
            this.panelTitle.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panelTitle.StyleMouseOver.MarginLeft = 20;
            this.panelTitle.TabIndex = 127;
            this.panelTitle.Text = "បញ្ចូល ឬ​ កែប្រែព័ត៌មានអ្នកសួរសុខទុក្ខ";
            this.panelTitle.Click += new System.EventHandler(this.panelTitle_Click);
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(48, 412);
            this.labelX9.Margin = new System.Windows.Forms.Padding(2);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(214, 39);
            this.labelX9.TabIndex = 140;
            this.labelX9.Text = "អាស័យដ្ឋានបច្ចុប្បន្ន ៖";
            // 
            // txtVisitorAddress
            // 
            this.txtVisitorAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVisitorAddress.Border.Class = "TextBoxBorder";
            this.txtVisitorAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVisitorAddress.DisabledBackColor = System.Drawing.Color.White;
            this.txtVisitorAddress.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorAddress.ForeColor = System.Drawing.Color.Black;
            this.txtVisitorAddress.Location = new System.Drawing.Point(47, 455);
            this.txtVisitorAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtVisitorAddress.Name = "txtVisitorAddress";
            this.txtVisitorAddress.PreventEnterBeep = true;
            this.txtVisitorAddress.Size = new System.Drawing.Size(350, 49);
            this.txtVisitorAddress.TabIndex = 141;
            this.txtVisitorAddress.TabStop = false;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(221, 305);
            this.labelX7.Margin = new System.Windows.Forms.Padding(2);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(110, 39);
            this.labelX7.TabIndex = 136;
            this.labelX7.Text = "លេខទូរស័ព្ទ ៖";
            // 
            // txtVisitorPhoneNum
            // 
            this.txtVisitorPhoneNum.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVisitorPhoneNum.Border.Class = "TextBoxBorder";
            this.txtVisitorPhoneNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVisitorPhoneNum.DisabledBackColor = System.Drawing.Color.White;
            this.txtVisitorPhoneNum.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorPhoneNum.ForeColor = System.Drawing.Color.Black;
            this.txtVisitorPhoneNum.Location = new System.Drawing.Point(219, 349);
            this.txtVisitorPhoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtVisitorPhoneNum.Name = "txtVisitorPhoneNum";
            this.txtVisitorPhoneNum.PreventEnterBeep = true;
            this.txtVisitorPhoneNum.Size = new System.Drawing.Size(178, 49);
            this.txtVisitorPhoneNum.TabIndex = 137;
            this.txtVisitorPhoneNum.TabStop = false;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(48, 305);
            this.labelX6.Margin = new System.Windows.Forms.Padding(2);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(110, 39);
            this.labelX6.TabIndex = 134;
            this.labelX6.Text = "ភេទ ៖";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(221, 194);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(110, 39);
            this.labelX4.TabIndex = 132;
            this.labelX4.Text = "នាមខ្លួន ៖";
            // 
            // txtVisitorLname
            // 
            this.txtVisitorLname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVisitorLname.Border.Class = "TextBoxBorder";
            this.txtVisitorLname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVisitorLname.DisabledBackColor = System.Drawing.Color.White;
            this.txtVisitorLname.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorLname.ForeColor = System.Drawing.Color.Black;
            this.txtVisitorLname.Location = new System.Drawing.Point(219, 238);
            this.txtVisitorLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtVisitorLname.Name = "txtVisitorLname";
            this.txtVisitorLname.PreventEnterBeep = true;
            this.txtVisitorLname.Size = new System.Drawing.Size(178, 49);
            this.txtVisitorLname.TabIndex = 133;
            this.txtVisitorLname.TabStop = false;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(48, 194);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(110, 39);
            this.labelX3.TabIndex = 130;
            this.labelX3.Text = "នាមត្រកូល ៖";
            // 
            // txtVisitorFname
            // 
            this.txtVisitorFname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVisitorFname.Border.Class = "TextBoxBorder";
            this.txtVisitorFname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVisitorFname.DisabledBackColor = System.Drawing.Color.White;
            this.txtVisitorFname.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorFname.ForeColor = System.Drawing.Color.Black;
            this.txtVisitorFname.Location = new System.Drawing.Point(47, 238);
            this.txtVisitorFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtVisitorFname.Name = "txtVisitorFname";
            this.txtVisitorFname.PreventEnterBeep = true;
            this.txtVisitorFname.Size = new System.Drawing.Size(134, 49);
            this.txtVisitorFname.TabIndex = 131;
            this.txtVisitorFname.TabStop = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(48, 84);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(110, 39);
            this.labelX2.TabIndex = 128;
            this.labelX2.Text = "លេខកូដ ៖";
            // 
            // txtVisitorID
            // 
            this.txtVisitorID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVisitorID.Border.Class = "TextBoxBorder";
            this.txtVisitorID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVisitorID.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVisitorID.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorID.ForeColor = System.Drawing.Color.Black;
            this.txtVisitorID.Location = new System.Drawing.Point(47, 135);
            this.txtVisitorID.Margin = new System.Windows.Forms.Padding(2);
            this.txtVisitorID.Name = "txtVisitorID";
            this.txtVisitorID.PreventEnterBeep = true;
            this.txtVisitorID.ReadOnly = true;
            this.txtVisitorID.Size = new System.Drawing.Size(350, 49);
            this.txtVisitorID.TabIndex = 142;
            this.txtVisitorID.TabStop = false;
            this.txtVisitorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVisitorID.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtVisitorID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(473, 84);
            this.labelX10.Margin = new System.Windows.Forms.Padding(2);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(124, 52);
            this.labelX10.TabIndex = 144;
            this.labelX10.Text = "ត្រូវជា ៖";
            // 
            // txtPatientRelation
            // 
            this.txtPatientRelation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPatientRelation.Border.Class = "TextBoxBorder";
            this.txtPatientRelation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPatientRelation.DisabledBackColor = System.Drawing.Color.White;
            this.txtPatientRelation.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientRelation.ForeColor = System.Drawing.Color.Black;
            this.txtPatientRelation.Location = new System.Drawing.Point(466, 135);
            this.txtPatientRelation.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientRelation.Name = "txtPatientRelation";
            this.txtPatientRelation.PreventEnterBeep = true;
            this.txtPatientRelation.Size = new System.Drawing.Size(337, 49);
            this.txtPatientRelation.TabIndex = 145;
            this.txtPatientRelation.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(25, 616);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(250, 55);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnCancel.TabIndex = 150;
            this.btnCancel.Text = "ចាកចេញ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(1050, 616);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(268, 55);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSave.TabIndex = 151;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbVisitorSex
            // 
            this.cbVisitorSex.DisplayMember = "Text";
            this.cbVisitorSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVisitorSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisitorSex.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisitorSex.ForeColor = System.Drawing.Color.Black;
            this.cbVisitorSex.FormattingEnabled = true;
            this.cbVisitorSex.ItemHeight = 36;
            this.cbVisitorSex.Location = new System.Drawing.Point(48, 349);
            this.cbVisitorSex.Margin = new System.Windows.Forms.Padding(2);
            this.cbVisitorSex.Name = "cbVisitorSex";
            this.cbVisitorSex.Size = new System.Drawing.Size(132, 42);
            this.cbVisitorSex.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbVisitorSex.TabIndex = 155;
            // 
            // btnShowVisitingDetails
            // 
            this.btnShowVisitingDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowVisitingDetails.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowVisitingDetails.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowVisitingDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnShowVisitingDetails.Image")));
            this.btnShowVisitingDetails.Location = new System.Drawing.Point(868, 238);
            this.btnShowVisitingDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowVisitingDetails.Name = "btnShowVisitingDetails";
            this.btnShowVisitingDetails.Size = new System.Drawing.Size(389, 65);
            this.btnShowVisitingDetails.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnShowVisitingDetails.TabIndex = 159;
            this.btnShowVisitingDetails.Text = "គោលបំណងសួរសុខទុក្ខ";
            this.btnShowVisitingDetails.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(467, 190);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(124, 52);
            this.labelX1.TabIndex = 163;
            this.labelX1.Text = "របស់អ្នកជម្ងឺ ៖";
            // 
            // btnChoosePatient
            // 
            this.btnChoosePatient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChoosePatient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChoosePatient.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePatient.Image = ((System.Drawing.Image)(resources.GetObject("btnChoosePatient.Image")));
            this.btnChoosePatient.Location = new System.Drawing.Point(466, 238);
            this.btnChoosePatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoosePatient.Name = "btnChoosePatient";
            this.btnChoosePatient.Size = new System.Drawing.Size(338, 65);
            this.btnChoosePatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnChoosePatient.TabIndex = 164;
            this.btnChoosePatient.Text = "ជ្រើសរើសអ្នកជម្ងឺ";
            this.btnChoosePatient.Click += new System.EventHandler(this.btnChoosePatient_Click);
            // 
            // tbPatientBindingSource
            // 
            this.tbPatientBindingSource.DataMember = "tbPatient";
            this.tbPatientBindingSource.DataSource = this.hIMSDataSet1;
            // 
            // hIMSDataSet1
            // 
            this.hIMSDataSet1.DataSetName = "HIMSDataSet1";
            this.hIMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPatientTableAdapter
            // 
            this.tbPatientTableAdapter.ClearBeforeFill = true;
            // 
            // tbVisitingBindingSource
            // 
            this.tbVisitingBindingSource.DataMember = "tbVisiting";
            this.tbVisitingBindingSource.DataSource = this.hIMSDataSet2;
            // 
            // hIMSDataSet2
            // 
            this.hIMSDataSet2.DataSetName = "HIMSDataSet2";
            this.hIMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbVisitingTableAdapter
            // 
            this.tbVisitingTableAdapter.ClearBeforeFill = true;
            // 
            // txtChoosePatientID
            // 
            this.txtChoosePatientID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtChoosePatientID.Border.Class = "TextBoxBorder";
            this.txtChoosePatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChoosePatientID.DisabledBackColor = System.Drawing.Color.White;
            this.txtChoosePatientID.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoosePatientID.ForeColor = System.Drawing.Color.Black;
            this.txtChoosePatientID.Location = new System.Drawing.Point(466, 348);
            this.txtChoosePatientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtChoosePatientID.Name = "txtChoosePatientID";
            this.txtChoosePatientID.PreventEnterBeep = true;
            this.txtChoosePatientID.Size = new System.Drawing.Size(125, 49);
            this.txtChoosePatientID.TabIndex = 170;
            this.txtChoosePatientID.TabStop = false;
            // 
            // txtChoosePatientFName
            // 
            this.txtChoosePatientFName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtChoosePatientFName.Border.Class = "TextBoxBorder";
            this.txtChoosePatientFName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChoosePatientFName.DisabledBackColor = System.Drawing.Color.White;
            this.txtChoosePatientFName.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoosePatientFName.ForeColor = System.Drawing.Color.Black;
            this.txtChoosePatientFName.Location = new System.Drawing.Point(466, 423);
            this.txtChoosePatientFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtChoosePatientFName.Name = "txtChoosePatientFName";
            this.txtChoosePatientFName.PreventEnterBeep = true;
            this.txtChoosePatientFName.Size = new System.Drawing.Size(125, 49);
            this.txtChoosePatientFName.TabIndex = 171;
            this.txtChoosePatientFName.TabStop = false;
            // 
            // textBoxX3
            // 
            this.textBoxX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX3.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX3.ForeColor = System.Drawing.Color.Black;
            this.textBoxX3.Location = new System.Drawing.Point(1090, 348);
            this.textBoxX3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.PreventEnterBeep = true;
            this.textBoxX3.Size = new System.Drawing.Size(167, 49);
            this.textBoxX3.TabIndex = 173;
            this.textBoxX3.TabStop = false;
            this.textBoxX3.TextChanged += new System.EventHandler(this.textBoxX3_TextChanged);
            // 
            // textBoxX5
            // 
            this.textBoxX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX5.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX5.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX5.ForeColor = System.Drawing.Color.Black;
            this.textBoxX5.Location = new System.Drawing.Point(868, 348);
            this.textBoxX5.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.PreventEnterBeep = true;
            this.textBoxX5.Size = new System.Drawing.Size(201, 49);
            this.textBoxX5.TabIndex = 174;
            this.textBoxX5.TabStop = false;
            // 
            // txtChoosePatientLname
            // 
            this.txtChoosePatientLname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtChoosePatientLname.Border.Class = "TextBoxBorder";
            this.txtChoosePatientLname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChoosePatientLname.DisabledBackColor = System.Drawing.Color.White;
            this.txtChoosePatientLname.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoosePatientLname.ForeColor = System.Drawing.Color.Black;
            this.txtChoosePatientLname.Location = new System.Drawing.Point(617, 423);
            this.txtChoosePatientLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtChoosePatientLname.Name = "txtChoosePatientLname";
            this.txtChoosePatientLname.PreventEnterBeep = true;
            this.txtChoosePatientLname.Size = new System.Drawing.Size(186, 49);
            this.txtChoosePatientLname.TabIndex = 180;
            this.txtChoosePatientLname.TabStop = false;
            // 
            // txtEntryDateTime
            // 
            this.txtEntryDateTime.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEntryDateTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEntryDateTime.DisabledBackColor = System.Drawing.Color.White;
            this.txtEntryDateTime.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryDateTime.ForeColor = System.Drawing.Color.Black;
            this.txtEntryDateTime.Location = new System.Drawing.Point(868, 454);
            this.txtEntryDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntryDateTime.Name = "txtEntryDateTime";
            this.txtEntryDateTime.PreventEnterBeep = true;
            this.txtEntryDateTime.Size = new System.Drawing.Size(201, 49);
            this.txtEntryDateTime.TabIndex = 185;
            this.txtEntryDateTime.TabStop = false;
            // 
            // txtLeaveDateTime
            // 
            this.txtLeaveDateTime.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLeaveDateTime.Border.Class = "TextBoxBorder";
            this.txtLeaveDateTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLeaveDateTime.DisabledBackColor = System.Drawing.Color.White;
            this.txtLeaveDateTime.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveDateTime.ForeColor = System.Drawing.Color.Black;
            this.txtLeaveDateTime.Location = new System.Drawing.Point(1090, 454);
            this.txtLeaveDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeaveDateTime.Name = "txtLeaveDateTime";
            this.txtLeaveDateTime.PreventEnterBeep = true;
            this.txtLeaveDateTime.Size = new System.Drawing.Size(201, 49);
            this.txtLeaveDateTime.TabIndex = 184;
            this.txtLeaveDateTime.TabStop = false;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(1090, 412);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(228, 38);
            this.labelX5.TabIndex = 187;
            this.labelX5.Text = "ម៉ោងចេញ ៖";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(868, 412);
            this.labelX8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(228, 38);
            this.labelX8.TabIndex = 186;
            this.labelX8.Text = "ម៉ោងចូលសួរសុខទុក្ខ ៖";
            // 
            // FrmVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1344, 701);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtEntryDateTime);
            this.Controls.Add(this.txtLeaveDateTime);
            this.Controls.Add(this.txtChoosePatientLname);
            this.Controls.Add(this.textBoxX5);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.txtChoosePatientFName);
            this.Controls.Add(this.txtChoosePatientID);
            this.Controls.Add(this.btnChoosePatient);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnShowVisitingDetails);
            this.Controls.Add(this.cbVisitorSex);
            this.Controls.Add(this.txtPatientRelation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.txtVisitorID);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtVisitorAddress);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtVisitorPhoneNum);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtVisitorLname);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtVisitorFname);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmVisitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVisitor";
            this.Load += new System.EventHandler(this.FrmVisitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVisitingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIMSDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx panelTitle;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVisitorAddress;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVisitorPhoneNum;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVisitorLname;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVisitorFname;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVisitorID;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPatientRelation;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbVisitorSex;
        private DevComponents.DotNetBar.ButtonX btnShowVisitingDetails;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnChoosePatient;
        private HIMSDataSet1 hIMSDataSet1;
        private System.Windows.Forms.BindingSource tbPatientBindingSource;
        private HIMSDataSet1TableAdapters.tbPatientTableAdapter tbPatientTableAdapter;
        private HIMSDataSet2 hIMSDataSet2;
        private System.Windows.Forms.BindingSource tbVisitingBindingSource;
        private HIMSDataSet2TableAdapters.tbVisitingTableAdapter tbVisitingTableAdapter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChoosePatientID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChoosePatientFName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChoosePatientLname;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtVisitingStatus;
        private TextBoxX txtEntryDateTime;
        private TextBoxX txtLeaveDateTime;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX8;
       
        private System.Windows.Forms.DateTimePicker dtEntryDateTime;
        private System.Windows.Forms.DateTimePicker dtLeaveDateTime;
        
    }
}