namespace HIMS.Function
{
    partial class FrmAddOrModifyStaffPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrModifyStaffPosition));
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtPositionName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtPositionDesc = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtPositionID = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.btnCancel.Location = new System.Drawing.Point(44, 468);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 55);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "ចាកចេញ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(514, 468);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 55);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPositionName
            // 
            this.txtPositionName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPositionName.Border.Class = "TextBoxBorder";
            this.txtPositionName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPositionName.DisabledBackColor = System.Drawing.Color.White;
            this.txtPositionName.ForeColor = System.Drawing.Color.Black;
            this.txtPositionName.Location = new System.Drawing.Point(219, 172);
            this.txtPositionName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.PreventEnterBeep = true;
            this.txtPositionName.Size = new System.Drawing.Size(441, 49);
            this.txtPositionName.TabIndex = 68;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(44, 179);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(200, 39);
            this.labelX3.TabIndex = 75;
            this.labelX3.Text = "កម្រិតវប្បធម៌ ៖";
            // 
            // txtPositionDesc
            // 
            // 
            // 
            // 
            this.txtPositionDesc.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtPositionDesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPositionDesc.Location = new System.Drawing.Point(219, 248);
            this.txtPositionDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtPositionDesc.Name = "txtPositionDesc";
            this.txtPositionDesc.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil Khmer Kep;" +
    "}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\par\r\n}\r\n";
            this.txtPositionDesc.Size = new System.Drawing.Size(441, 190);
            this.txtPositionDesc.TabIndex = 69;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(44, 248);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(148, 39);
            this.labelX2.TabIndex = 74;
            this.labelX2.Text = "បរិយាយ​ ៖";
            // 
            // txtPositionID
            // 
            this.txtPositionID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPositionID.Border.Class = "TextBoxBorder";
            this.txtPositionID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPositionID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPositionID.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPositionID.ForeColor = System.Drawing.Color.Black;
            this.txtPositionID.Location = new System.Drawing.Point(219, 104);
            this.txtPositionID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPositionID.Name = "txtPositionID";
            this.txtPositionID.PreventEnterBeep = true;
            this.txtPositionID.ReadOnly = true;
            this.txtPositionID.Size = new System.Drawing.Size(441, 49);
            this.txtPositionID.TabIndex = 67;
            this.txtPositionID.TabStop = false;
            this.txtPositionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPositionID.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPositionID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(44, 110);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(121, 39);
            this.labelX5.TabIndex = 73;
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
            this.panelTitle.TabIndex = 72;
            this.panelTitle.Text = "បញ្ចូល ឬ​ កែប្រែព័ត៌មានមុខតំណែង";
            // 
            // FrmAddOrModifyStaffPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(708, 552);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPositionName);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtPositionDesc);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtPositionID);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAddOrModifyStaffPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAddOrModifyStaffPosition_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPositionName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtPositionDesc;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPositionID;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.PanelEx panelTitle;
    }
}