using HIMS.Utility;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace HIMS.Visitor
{
    partial class FrmAddOrModifyVisiting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrModifyVisiting));
            this.panelTitle = new DevComponents.DotNetBar.PanelEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtVisitingPurpose = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.cbVisitingStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtEntryDateTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtLeaveDateTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntryDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLeaveDateTime)).BeginInit();
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
            this.panelTitle.Location = new System.Drawing.Point(-1, -1);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1183, 63);
            this.panelTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTitle.Style.GradientAngle = 90;
            this.panelTitle.Style.MarginLeft = 20;
            this.panelTitle.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.panelTitle.StyleMouseOver.MarginLeft = 20;
            this.panelTitle.TabIndex = 134;
            this.panelTitle.Text = "គោលបំណងមកសួរសុខទុក្ខ";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(643, 97);
            this.labelX9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(228, 38);
            this.labelX9.TabIndex = 144;
            this.labelX9.Text = "ស្ថានភាព ៖";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(93, 97);
            this.labelX8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(328, 38);
            this.labelX8.TabIndex = 142;
            this.labelX8.Text = "គោលបំណងមកសួរសុខទុក្ខ ៖";
            // 
            // txtVisitingPurpose
            // 
            // 
            // 
            // 
            this.txtVisitingPurpose.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtVisitingPurpose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVisitingPurpose.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitingPurpose.Location = new System.Drawing.Point(93, 140);
            this.txtVisitingPurpose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVisitingPurpose.Name = "txtVisitingPurpose";
            this.txtVisitingPurpose.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Khmer Kep;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs24\\p" +
    "ar\r\n}\r\n";
            this.txtVisitingPurpose.Size = new System.Drawing.Size(481, 203);
            this.txtVisitingPurpose.TabIndex = 146;
            this.txtVisitingPurpose.TextChanged += new System.EventHandler(this.txtVisitingPurpose_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(863, 448);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(285, 54);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSave.TabIndex = 153;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbVisitingStatus
            // 
            this.cbVisitingStatus.DisplayMember = "Text";
            this.cbVisitingStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVisitingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisitingStatus.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisitingStatus.ForeColor = System.Drawing.Color.Black;
            this.cbVisitingStatus.FormattingEnabled = true;
            this.cbVisitingStatus.ItemHeight = 36;
            this.cbVisitingStatus.Location = new System.Drawing.Point(643, 140);
            this.cbVisitingStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVisitingStatus.Name = "cbVisitingStatus";
            this.cbVisitingStatus.Size = new System.Drawing.Size(200, 42);
            this.cbVisitingStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cbVisitingStatus.TabIndex = 154;
            this.cbVisitingStatus.SelectedIndexChanged += new System.EventHandler(this.cbVisitingStatus_SelectedIndexChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(643, 217);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(228, 38);
            this.labelX1.TabIndex = 160;
            this.labelX1.Text = "ម៉ោងចូលសួរសុខទុក្ខ ៖";
            // 
            // dtEntryDateTime
            // 
            // 
            // 
            // 
            this.dtEntryDateTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEntryDateTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEntryDateTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEntryDateTime.ButtonDropDown.Visible = true;
            this.dtEntryDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtEntryDateTime.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEntryDateTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtEntryDateTime.IsPopupCalendarOpen = false;
            this.dtEntryDateTime.Location = new System.Drawing.Point(643, 272);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtEntryDateTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEntryDateTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtEntryDateTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEntryDateTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEntryDateTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEntryDateTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEntryDateTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEntryDateTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEntryDateTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEntryDateTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEntryDateTime.MonthCalendar.DisplayMonth = new System.DateTime(2024, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtEntryDateTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEntryDateTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEntryDateTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEntryDateTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEntryDateTime.MonthCalendar.TodayButtonVisible = true;
            this.dtEntryDateTime.Name = "dtEntryDateTime";
            this.dtEntryDateTime.Size = new System.Drawing.Size(200, 49);
            this.dtEntryDateTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEntryDateTime.TabIndex = 161;
            // 
            // dtLeaveDateTime
            // 
            // 
            // 
            // 
            this.dtLeaveDateTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtLeaveDateTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLeaveDateTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtLeaveDateTime.ButtonDropDown.Visible = true;
            this.dtLeaveDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtLeaveDateTime.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLeaveDateTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtLeaveDateTime.IsPopupCalendarOpen = false;
            this.dtLeaveDateTime.Location = new System.Drawing.Point(877, 272);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtLeaveDateTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLeaveDateTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtLeaveDateTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtLeaveDateTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtLeaveDateTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtLeaveDateTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtLeaveDateTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtLeaveDateTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtLeaveDateTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtLeaveDateTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLeaveDateTime.MonthCalendar.DisplayMonth = new System.DateTime(2024, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtLeaveDateTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtLeaveDateTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtLeaveDateTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtLeaveDateTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtLeaveDateTime.MonthCalendar.TodayButtonVisible = true;
            this.dtLeaveDateTime.Name = "dtLeaveDateTime";
            this.dtLeaveDateTime.Size = new System.Drawing.Size(200, 49);
            this.dtLeaveDateTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtLeaveDateTime.TabIndex = 163;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(877, 217);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(228, 38);
            this.labelX2.TabIndex = 162;
            this.labelX2.Text = "ម៉ោងចេញ ៖";
            // 
            // FrmAddOrModifyVisiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 539);
            this.Controls.Add(this.dtLeaveDateTime);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dtEntryDateTime);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbVisitingStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVisitingPurpose);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddOrModifyVisiting";
            this.Text = "FrmAddOrModifyVisiting";

            this.Load += new System.EventHandler(this.FrmAddOrModifyVisiting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEntryDateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLeaveDateTime)).EndInit();
            this.ResumeLayout(false);

        }

        private void FrmAddOrModifyVisiting_Load(object sender, EventArgs e)
        {
            // Optionally, you could initialize or set default values here if necessary.
            // For example, you can set default values for the datetime pickers:
            dtEntryDateTime.Value = DateTime.Now;
            dtLeaveDateTime.Value = DateTime.Now;

            // You can also load any other data or set the initial state of the form here
            // For instance, you can set a default visiting status:
            cbVisitingStatus.SelectedIndex = 0; // Assuming the first option is the default

            // Load existing visiting details if you're modifying an existing visit
            LoadExistingVisitingDetails();
        }

        private void LoadExistingVisitingDetails()
        {
            if (visitingID != null)
            {
                try
                {
                    using (SqlConnection connection = ConnectionUtil.GetConnection())
                    {
                        connection.Open();

                        string query = "SELECT VisitingPurpose, Status, EntryDateTime, LeaveDateTime FROM tbVisitingTracking WHERE VisitingID = @VisitingID";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@VisitingID", visitingID);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtVisitingPurpose.Text = reader["VisitingPurpose"].ToString();
                                    cbVisitingStatus.SelectedItem = reader["Status"].ToString();
                                    dtEntryDateTime.Value = Convert.ToDateTime(reader["EntryDateTime"]);
                                    dtLeaveDateTime.Value = Convert.ToDateTime(reader["LeaveDateTime"]);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading visiting details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        #endregion

        private DevComponents.DotNetBar.PanelEx panelTitle;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtVisitingPurpose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbVisitingStatus;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEntryDateTime;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtLeaveDateTime;
        private DevComponents.DotNetBar.LabelX labelX2;

    }
}