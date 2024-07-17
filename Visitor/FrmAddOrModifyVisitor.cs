using HIMS.Patient;
using HIMS.Properties;
using HIMS.RoomBed;
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
    public partial class FrmVisitor : Form
    {
        private int visitorId;
        private int selectedVisitorId;
        protected SqlConnection connection = ConnectionUtil.GetConnection();
        protected DataSet dataSet = new DataSet();
        public SqlDataAdapter visitorAdapter;
        public BindingSource visitorBindingSource;
        public new DialogResult DialogResult { get; internal set; }
        public event EventHandler DataSaved;

        public bool isAdded;
        private object cbVisitingStatus;
        private object txtVisitingPurpose;
        private object visitingStatus;
        private object visitingPurpose;
        private BindingSource visitingBindingSource;
        private BindingSource visitingTrackingBindingSource;

        public FrmVisitor(int selectedVisitorID)
        {
            InitializeComponent();
            connection = ConnectionUtil.GetConnection();
            dataSet = new DataSet();

            // Initialize other components and event handlers
            btnShowVisitingDetails.Click += BtnShowVisitingDetails_Click;
            cbVisitorSex.Items.Add("M");
            cbVisitorSex.Items.Add("F");
            cbVisitorSex.SelectedIndex = 0; // Default selection

            this.selectedVisitorId = selectedVisitorID; // Store the selected visitor ID
            this.visitorId = selectedVisitorID; // Ensure visitorId is assigned here

            LoadData();
            BindControls();

            btnChoosePatient.Click += btnChoosePatient_Click;
            txtChoosePatientID.KeyDown += txtChoosePatientID_KeyDown;

            btnShowVisitingDetails.Click += BtnShowVisitingDetails_Click;
        }



        private void BtnShowVisitingDetails_Click(object sender, EventArgs e)
        {
            using (FrmAddOrModifyVisiting frmVisiting = new FrmAddOrModifyVisiting(visitorId))
            {
                frmVisiting.VisitingDetailsSelected += FrmVisiting_VisitingDetailsSelected;
                DialogResult result = frmVisiting.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Reload data after saving in FrmAddOrModifyVisiting
                    LoadData();
                    BindControls();
                }
            }
        }


        public new DialogResult ShowDialog()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            return base.ShowDialog();
        }

        public void ClearInputFields()
        {
            txtVisitorID.Text = string.Empty;
            txtVisitorFname.Text = string.Empty;
            txtVisitorLname.Text = string.Empty;
            txtVisitorPhoneNum.Text = string.Empty;
            txtVisitorAddress.Text = string.Empty;
            txtPatientRelation.Text = string.Empty;
            txtChoosePatientID.Text = string.Empty;
            txtChoosePatientFName.Text = string.Empty;
            txtChoosePatientLname.Text = string.Empty;
        }

        public void SetNewVisitorID(int newID)
        {
            txtVisitorID.Text = newID.ToString("D2"); // Format as 2-digit number, e.g., "01", "02"
        }

        private void FrmVisitor_Load(object sender, EventArgs e)
        {

            //this.tbVisitingTableAdapter.Fill(this.hIMSDataSet2.tbVisiting);
            this.tbPatientTableAdapter.Fill(this.hIMSDataSet1.tbPatient);
            if (isAdded)
            {
                txtVisitorID.TextAlign = HorizontalAlignment.Center;
                txtVisitorID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
                ClearInputFields(); // Clear fields for adding a new visitor
            }
            else
            {
                var currentRow = visitorBindingSource.Current as DataRowView;
                txtVisitorID.TextAlign = HorizontalAlignment.Left;
                txtVisitorID.WatermarkText = "";
                txtVisitorID.Text = currentRow.Row["VisitorID"].ToString();
                txtVisitorFname.Text = currentRow.Row["FirstName"].ToString();
                txtVisitorLname.Text = currentRow.Row["LastName"].ToString();
                cbVisitorSex.SelectedItem = currentRow.Row["Gender"].ToString();
                txtVisitorPhoneNum.Text = currentRow.Row["PhoneNumber"].ToString();
                txtVisitorAddress.Text = currentRow.Row["Address"].ToString();
                txtPatientRelation.Text = currentRow.Row["PatientRelation"].ToString();
                txtChoosePatientID.Text = currentRow.Row["PatientID"].ToString();
                txtChoosePatientFName.Text = currentRow.Row["PatientFirstName"].ToString();
                txtChoosePatientLname.Text = currentRow.Row["PatientLastName"].ToString();
            }
        }


        private void LoadData()
        {
            try
            {
                string query = $"SELECT * FROM tbVisitor WHERE VisitorID = {selectedVisitorId}";
                visitorAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(visitorAdapter);

                dataSet.Clear();
                visitorAdapter.Fill(dataSet, "tbVisitor");

                string visitingQuery = $"SELECT * FROM tbVisiting WHERE VisitorID = {selectedVisitorId}";
                SqlDataAdapter visitingAdapter = new SqlDataAdapter(visitingQuery, connection);
                visitingAdapter.Fill(dataSet, "tbVisiting");

                string visitingTrackingQuery = $"SELECT * FROM tbVisitingTracking WHERE VisitingID IN (SELECT VisitingID FROM tbVisiting WHERE VisitorID = {selectedVisitorId})";
                SqlDataAdapter visitingTrackingAdapter = new SqlDataAdapter(visitingTrackingQuery, connection);
                visitingTrackingAdapter.Fill(dataSet, "tbVisitingTracking");

                if (visitorBindingSource == null)
                {
                    visitorBindingSource = new BindingSource();
                }

                visitorBindingSource.DataSource = dataSet.Tables["tbVisitor"];
                visitingBindingSource = new BindingSource(dataSet, "tbVisiting");
                visitingTrackingBindingSource = new BindingSource(dataSet, "tbVisitingTracking");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void BindControls()
        {
            // Clear previous bindings
            txtVisitorID.DataBindings.Clear();
            txtVisitorFname.DataBindings.Clear();
            txtVisitorLname.DataBindings.Clear();
            cbVisitorSex.DataBindings.Clear();
            txtVisitorPhoneNum.DataBindings.Clear();
            txtPatientRelation.DataBindings.Clear();
            txtChoosePatientID.DataBindings.Clear();
            txtChoosePatientFName.DataBindings.Clear();
            txtChoosePatientLname.DataBindings.Clear();

            // Add new bindings
            txtVisitorID.DataBindings.Add("Text", visitorBindingSource, "VisitorID");
            txtVisitorFname.DataBindings.Add("Text", visitorBindingSource, "FirstName");
            txtVisitorLname.DataBindings.Add("Text", visitorBindingSource, "LastName");
            cbVisitorSex.DataBindings.Add("SelectedItem", visitorBindingSource, "Gender");
            txtVisitorPhoneNum.DataBindings.Add("Text", visitorBindingSource, "PhoneNumber");
            txtVisitorAddress.DataBindings.Add("Text", visitorBindingSource, "Address");
            txtPatientRelation.DataBindings.Add("Text", visitorBindingSource, "PatientRelation");
            txtChoosePatientID.DataBindings.Add("Text", visitorBindingSource, "PatientID");
            txtChoosePatientFName.DataBindings.Add("Text", visitorBindingSource, "PatientFirstName");
            txtChoosePatientLname.DataBindings.Add("Text", visitorBindingSource, "PatientLastName");


            // Bind visiting data
            if (visitingBindingSource != null)
            {
                textBoxX5.DataBindings.Clear();
                textBoxX3.DataBindings.Clear();

                textBoxX5.DataBindings.Add("Text", visitingBindingSource, "VisitingPurpose");
                textBoxX3.DataBindings.Add("Text", visitingBindingSource, "Status");
            }

            if (visitingTrackingBindingSource != null)
            {
                txtEntryDateTime.DataBindings.Clear();
                txtLeaveDateTime.DataBindings.Clear();

                txtEntryDateTime.DataBindings.Add("Text", visitingTrackingBindingSource, "EntryDateTime");
                txtLeaveDateTime.DataBindings.Add("Text", visitingTrackingBindingSource, "LeaveDateTime");
            }



        }

        private void btnChoosePatient_Click(object sender, EventArgs e)
        {
            FrmPatient frmPatient = new FrmPatient();
            frmPatient.PatientSelected += FrmPatient_PatientSelected;
            frmPatient.ShowDialog();
        }

        private void FrmPatient_PatientSelected(object arg1, FrmPatient.PatientSelectedEventArgs e)
        {
            txtChoosePatientID.Text = e.PatientID.ToString();
            txtChoosePatientFName.Text = (string)e.FirstName;
            txtChoosePatientLname.Text = (string)e.LastName;
        }


        private void txtChoosePatientID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress beep sound on Enter press
                btnChoosePatient_Click(null, EventArgs.Empty); // Simulate button click to open FrmPatient
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                char gender = cbVisitorSex.SelectedItem.ToString()[0];

                if (isAdded)
                {
                    DataRow newRow = dataSet.Tables["tbVisitor"].NewRow();
                    newRow["FirstName"] = txtVisitorFname.Text;
                    newRow["LastName"] = txtVisitorLname.Text;
                    newRow["Gender"] = gender;
                    newRow["PhoneNumber"] = txtVisitorPhoneNum.Text;
                    newRow["Address"] = txtVisitorAddress.Text;
                    newRow["PatientRelation"] = txtPatientRelation.Text;
                    newRow["PatientID"] = txtChoosePatientID.Text;
                    newRow["PatientFirstName"] = txtChoosePatientFName.Text;
                    newRow["PatientLastName"] = txtChoosePatientLname.Text;
                    newRow["RegistryDate"] = DateTime.Now;

                    dataSet.Tables["tbVisitor"].Rows.Add(newRow);
                }
                else
                {
                    DataRowView currentRowView = visitorBindingSource.Current as DataRowView;
                    if (currentRowView != null)
                    {
                        DataRow currentRow = currentRowView.Row;
                        currentRow["FirstName"] = txtVisitorFname.Text;
                        currentRow["LastName"] = txtVisitorLname.Text;
                        currentRow["Gender"] = gender;
                        currentRow["PhoneNumber"] = txtVisitorPhoneNum.Text;
                        currentRow["Address"] = txtVisitorAddress.Text;
                        currentRow["PatientRelation"] = txtPatientRelation.Text;
                        currentRow["RegistryDate"] = DateTime.Now;
                        currentRow["PatientID"] = txtChoosePatientID.Text;
                        currentRow["PatientFirstName"] = txtChoosePatientFName.Text;
                        currentRow["PatientLastName"] = txtChoosePatientLname.Text;
                    }
                }

                visitorBindingSource.EndEdit();
                visitorAdapter.Update(dataSet, "tbVisitor");

                MessageBox.Show("Data saved successfully!");

                // Invoke the DataSaved event
                DataSaved?.Invoke(this, EventArgs.Empty);

                LoadData();
                ClearInputFields(); // Clear input fields after saving

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }


        private void FrmVisiting_VisitingDetailsSelected(object sender, VisitingDetailsSelectedEventArgs e)
        {
            try
            {
                textBoxX5.Text = e.VisitingPurpose;
                textBoxX3.Text = e.Status;

                txtEntryDateTime.Text = e.EntryDateTime.ToString();
                txtLeaveDateTime.Text = e.LeaveDateTime.ToString();

                SaveVisitingDetails(e.VisitingPurpose, e.Status, e.EntryDateTime, e.LeaveDateTime);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error handling visiting details: " + ex.Message);
            }
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
            visitorBindingSource.CancelEdit();
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            using (FrmAddOrModifyVisiting frmVisiting = new FrmAddOrModifyVisiting(selectedVisitorId))
            {
                frmVisiting.VisitingDetailsSelected += FrmVisiting_VisitingDetailsSelected;
                frmVisiting.ShowDialog();
            }
        }


        private void panelTitle_Click(object sender, EventArgs e)
        {
        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}