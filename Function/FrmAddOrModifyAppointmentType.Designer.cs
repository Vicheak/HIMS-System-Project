namespace HIMS.Function
{
    partial class FrmAddOrModifyAppointmentType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrModifyAppointmentType));
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtAppointmentTypeName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtAppointmentTypeDesc = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtAppointmentTypeID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panelTitle = new DevComponents.DotNetBar.PanelEx();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(44, 481);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 55);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "ចាកចេញ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(514, 481);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 55);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAppointmentTypeName
            // 
            this.txtAppointmentTypeName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAppointmentTypeName.Border.Class = "TextBoxBorder";
            this.txtAppointmentTypeName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAppointmentTypeName.DisabledBackColor = System.Drawing.Color.White;
            this.txtAppointmentTypeName.ForeColor = System.Drawing.Color.Black;
            this.txtAppointmentTypeName.Location = new System.Drawing.Point(236, 184);
            this.txtAppointmentTypeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAppointmentTypeName.Name = "txtAppointmentTypeName";
            this.txtAppointmentTypeName.PreventEnterBeep = true;
            this.txtAppointmentTypeName.Size = new System.Drawing.Size(424, 49);
            this.txtAppointmentTypeName.TabIndex = 44;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(44, 190);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(200, 39);
            this.labelX3.TabIndex = 51;
            this.labelX3.Text = "ប្រភេទនៃការណាត់ជួប ៖";
            // 
            // txtAppointmentTypeDesc
            // 
            // 
            // 
            // 
            this.txtAppointmentTypeDesc.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtAppointmentTypeDesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAppointmentTypeDesc.Location = new System.Drawing.Point(236, 259);
            this.txtAppointmentTypeDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtAppointmentTypeDesc.Name = "txtAppointmentTypeDesc";
            this.txtAppointmentTypeDesc.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil Khmer Kep;" +
    "}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\par\r\n}\r\n";
            this.txtAppointmentTypeDesc.Size = new System.Drawing.Size(424, 190);
            this.txtAppointmentTypeDesc.TabIndex = 45;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(44, 259);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(148, 39);
            this.labelX2.TabIndex = 50;
            this.labelX2.Text = "បរិយាយ​ ៖";
            // 
            // txtAppointmentTypeID
            // 
            this.txtAppointmentTypeID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAppointmentTypeID.Border.Class = "TextBoxBorder";
            this.txtAppointmentTypeID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAppointmentTypeID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAppointmentTypeID.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAppointmentTypeID.ForeColor = System.Drawing.Color.Black;
            this.txtAppointmentTypeID.Location = new System.Drawing.Point(236, 115);
            this.txtAppointmentTypeID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAppointmentTypeID.Name = "txtAppointmentTypeID";
            this.txtAppointmentTypeID.PreventEnterBeep = true;
            this.txtAppointmentTypeID.ReadOnly = true;
            this.txtAppointmentTypeID.Size = new System.Drawing.Size(424, 49);
            this.txtAppointmentTypeID.TabIndex = 43;
            this.txtAppointmentTypeID.TabStop = false;
            this.txtAppointmentTypeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAppointmentTypeID.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtAppointmentTypeID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(44, 121);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(121, 39);
            this.labelX5.TabIndex = 49;
            this.labelX5.Text = "លេខកូដ​ ៖";
            // 
            // panelTitle
            // 
            this.panelTitle.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.panelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTitle.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(708, 64);
            this.panelTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTitle.Style.GradientAngle = 90;
            this.panelTitle.Style.MarginLeft = 20;
            this.panelTitle.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panelTitle.StyleMouseOver.MarginLeft = 20;
            this.panelTitle.TabIndex = 48;
            this.panelTitle.Text = "បញ្ចូល ឬ​ កែប្រែព័ត៌មានប្រភេទនៃការណាត់ជួប";
            // 
            // FrmAddOrModifyAppointmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(708, 552);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAppointmentTypeName);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtAppointmentTypeDesc);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtAppointmentTypeID);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Name = "FrmAddOrModifyAppointmentType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddOrModifyAppointmentType";
            this.Load += new System.EventHandler(this.FrmAddOrModifyAppointmentType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAppointmentTypeName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtAppointmentTypeDesc;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAppointmentTypeID;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.PanelEx panelTitle;
    }
}