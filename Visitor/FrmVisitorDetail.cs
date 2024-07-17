using HIMS.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HIMS.Visitor
{
    public partial class FrmVisitorDetail : Form
    {
        private int visitorId;
        private SqlConnection connection;
        private DataSet dataSet;
        private SqlDataAdapter visitorAdapter;
        private SqlDataAdapter visitingAdapter;
        private SqlDataAdapter visitingTrackingAdapter;
        private int visitingId;

        public FrmVisitorDetail(int visitorId)
        {
            InitializeComponent();
            this.visitorId = visitorId;
            connection = ConnectionUtil.GetConnection();
            dataSet = new DataSet();

            LoadVisitorData();
            LoadVisitingData();
            LoadVisitingTrackingData();

            // Set all input fields to read-only
            MakeFieldsReadOnly();
        }

        private void LoadVisitorData()
        {
            try
            {
                string query = $"SELECT * FROM tbVisitor WHERE VisitorID = {visitorId}";
                visitorAdapter = new SqlDataAdapter(query, connection);
                visitorAdapter.Fill(dataSet, "tbVisitor");

                if (dataSet.Tables["tbVisitor"].Rows.Count > 0)
                {
                    DataRow row = dataSet.Tables["tbVisitor"].Rows[0];
                    txtVisitorID.Text = row["VisitorID"].ToString();
                    txtVisitorFname.Text = row["FirstName"].ToString();
                    txtVisitorLname.Text = row["LastName"].ToString();
                    txtVisitorPhoneNum.Text = row["PhoneNumber"].ToString();
                    txtVisitorAddress.Text = row["Address"].ToString();
                    txtPatientRelation.Text = row["PatientRelation"].ToString();
                    txtChoosePatientID.Text = row["PatientID"].ToString();
                    txtChoosePatientFName.Text = row["PatientFirstName"].ToString();
                    txtChoosePatientLname.Text = row["PatientLastName"].ToString();

                    // Get the gender from the database
                    string gender = row["Gender"].ToString();

                    // Set the selected item in cbVisitorSex
                    if (cbVisitorSex.Items.Contains(gender))
                    {
                        cbVisitorSex.SelectedItem = gender;
                    }
                    else
                    {
                        // Add the gender to ComboBox items if not already present
                        cbVisitorSex.Items.Add(gender);
                        cbVisitorSex.SelectedItem = gender;
                    }
                }
                else
                {
                    MessageBox.Show("No visitor data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading visitor data: " + ex.Message);
            }
        }

        private void LoadVisitingData()
        {
            try
            {
                string query = $"SELECT * FROM tbVisiting WHERE VisitorID = {visitorId}";
                visitingAdapter = new SqlDataAdapter(query, connection);
                visitingAdapter.Fill(dataSet, "tbVisiting");

                if (dataSet.Tables["tbVisiting"].Rows.Count > 0)
                {
                    DataRow row = dataSet.Tables["tbVisiting"].Rows[0];
                    visitingId = Convert.ToInt32(row["VisitingID"]); // Set the visitingId
                    textBoxX5.Text = row["VisitingPurpose"].ToString();
                    textBoxX3.Text = row["Status"].ToString();

                    // Load visiting tracking data
                    LoadVisitingTrackingData();
                }
                else
                {
                    MessageBox.Show("No visiting data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading visiting data: " + ex.Message);
            }
        }

        private void LoadVisitingTrackingData()
        {
            try
            {
                string query = $"SELECT * FROM tbVisitingTracking WHERE VisitingID = {visitingId}";
                visitingTrackingAdapter = new SqlDataAdapter(query, connection);
                visitingTrackingAdapter.Fill(dataSet, "tbVisitingTracking");

                if (dataSet.Tables["tbVisitingTracking"].Rows.Count > 0)
                {
                    DataRow row = dataSet.Tables["tbVisitingTracking"].Rows[0];
                    txtEntryDateTime.Text = row["EntryDateTime"].ToString();
                    txtLeaveDateTime.Text = row["LeaveDateTime"].ToString();
                }
                else
                {
                    MessageBox.Show("No visiting tracking data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading visiting tracking data: " + ex.Message);
            }
        }

        private void MakeFieldsReadOnly()
        {
            // Set text boxes to read-only
            txtVisitorID.ReadOnly = true;
            txtVisitorFname.ReadOnly = true;
            txtVisitorLname.ReadOnly = true;
            txtVisitorPhoneNum.ReadOnly = true;
            txtVisitorAddress.ReadOnly = true;
            txtPatientRelation.ReadOnly = true;
            txtChoosePatientID.ReadOnly = true;
            txtChoosePatientFName.ReadOnly = true;
            txtChoosePatientLname.ReadOnly = true;
            textBoxX5.ReadOnly = true;
            textBoxX3.ReadOnly = true;
            txtEntryDateTime.ReadOnly = true;
            txtLeaveDateTime.ReadOnly = true;

            // Disable combo boxes
            cbVisitorSex.Enabled = false;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            // Your event handling code here
        }

        private void FrmVisitorDetail_Load(object sender, EventArgs e)
        {
            // Your event handling code here
        }

        private void cbVisitorSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Your event handling code here
        }
    }
}
