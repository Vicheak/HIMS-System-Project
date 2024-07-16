using HIMS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS.Visitor
{
    public partial class FrmAddOrModifyVisiting : Form
    {
        public event EventHandler<VisitingDetailsSelectedEventArgs> VisitingDetailsSelected;

        private int visitorId;
        private int patientId;
        private int staffId;
        private object visitingID;

        public FrmAddOrModifyVisiting(int selectedVisitorId)
        {
            this.visitorId = selectedVisitorId;
            InitializeComponent();

            cbVisitingStatus.DataSource = GetVisitingStatusOptions(); // Populate status options
            // Configure EntryDateTime
            dtEntryDateTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            dtEntryDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            // Configure LeaveDateTime
            dtLeaveDateTime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            dtLeaveDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private List<string> GetVisitingStatusOptions()
        {
            return new List<string>() { "អុនញ្ញាត", "មិនអនុញ្ញាត" };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string visitingPurpose = txtVisitingPurpose.Text.Trim();
            string visitingStatus = cbVisitingStatus.SelectedItem?.ToString();
            // Capture the DateTime values
            DateTime entryDateTime = dtEntryDateTime.Value;
            DateTime leaveDateTime = dtLeaveDateTime.Value;

            if (string.IsNullOrEmpty(visitingPurpose))
            {
                MessageBox.Show("Please enter a visiting purpose.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(visitingStatus))
            {
                MessageBox.Show("Please select a visiting status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Additional validation for DateTime fields (optional)
            if (entryDateTime > leaveDateTime)
            {
                MessageBox.Show("Entry date and time cannot be after leave date and time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save visiting details
            SaveVisitingDetails(visitingPurpose, visitingStatus, entryDateTime, leaveDateTime);

            VisitingDetailsSelected?.Invoke(this, new VisitingDetailsSelectedEventArgs
            {
                VisitingPurpose = visitingPurpose,
                Status = visitingStatus,
                EntryDateTime = entryDateTime, // Include in the event args if needed
                LeaveDateTime = leaveDateTime
            });

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveVisitingDetails(string visitingPurpose, string status, DateTime entryDateTime, DateTime leaveDateTime)
        {
            try
            {
                using (SqlConnection connection = ConnectionUtil.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tbVisiting (VisitorID, VisitingPurpose, Status) VALUES (@VisitorID, @VisitingPurpose, @Status); SELECT SCOPE_IDENTITY();", connection))
                    {
                        cmd.Parameters.AddWithValue("@VisitorID", visitorId);
                        cmd.Parameters.AddWithValue("@VisitingPurpose", visitingPurpose);
                        cmd.Parameters.AddWithValue("@Status", status);

                        int visitingID = Convert.ToInt32(cmd.ExecuteScalar());

                        using (SqlCommand trackingCmd = new SqlCommand("INSERT INTO tbVisitingTracking (VisitingID, EntryDateTime, LeaveDateTime) VALUES (@VisitingID, @EntryDateTime, @LeaveDateTime)", connection))
                        {
                            trackingCmd.Parameters.AddWithValue("@VisitingID", visitingID);
                            trackingCmd.Parameters.AddWithValue("@EntryDateTime", entryDateTime);
                            trackingCmd.Parameters.AddWithValue("@LeaveDateTime", leaveDateTime);

                            trackingCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving visiting tracking details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVisitingPurpose_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbVisitingStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class VisitingDetailsSelectedEventArgs : EventArgs
    {
        public string VisitingPurpose { get; set; }
        public string Status { get; set; }
        public DateTime EntryDateTime { get; internal set; }
        public DateTime LeaveDateTime { get; internal set; }
    }
}
