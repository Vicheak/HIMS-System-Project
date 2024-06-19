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

namespace HIMS.Patient
{
    public partial class FrmPatientDetail : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        public DataSet dataSet = new DataSet();
        public SqlDataAdapter patientAdapter;
        public BindingSource patientBindingSource;

        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            cbGender.Items.AddRange(new object[]
            {
                "ប្រុស",
                "ស្រី"
            });

            LoadPatientData(); 
        }

        private void LoadPatientData()
        {
            var currentRow = patientBindingSource.Current as DataRowView;

            txtPatientID.Text = currentRow.Row["PatientID"].ToString();
            txtFirstName.Text = currentRow.Row["FirstName"].ToString();
            txtLastName.Text = currentRow.Row["LastName"].ToString();
            cbGender.SelectedIndex = currentRow.Row["Gender"].ToString().Equals("ប្រុស") ? 0 : 1;
            dateTimeBirthDate.Value = Convert.ToDateTime(currentRow.Row["BirthDate"]);
            txtAddress.Text = currentRow.Row["Address"].ToString();
            txtPhoneNumber.Text = currentRow.Row["PhoneNumber"].ToString();
            txtEmergencyName.Text = currentRow.Row["EmergencyName"].ToString();
            txtEmergencyRelation.Text = currentRow.Row["EmergencyRelation"].ToString();
            txtEmergencyNumber.Text = currentRow.Row["EmergencyNumber"].ToString();
            txtEmail.Text = currentRow.Row["Email"].ToString();
            txtNationalCardID.Text = currentRow.Row["NationalCardID"].ToString();
            txtMedicalHistory.Text = currentRow.Row["MedicalHistory"].ToString();
            checkBoxIsInpatient.Checked = Convert.ToInt16(currentRow.Row["IsInpatient"]) == 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableUpdate();  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateUtil.ValidateTextBox(txtFirstName, "Warning", "សូមវាយបញ្ចូលនាមត្រកូលជាមុនសិន") ||
              !ValidateUtil.ValidateTextBox(txtLastName, "Warning", "សូមវាយបញ្ចូលនាមខ្លួនជាមុនសិន") ||
              !ValidateUtil.ValidateTextBox(txtPhoneNumber, "Warning", "សូមវាយបញ្ចូលលេខទូរស័ព្ទជាមុនសិន"))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(dateTimeBirthDate.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសថ្ងៃខែឆ្នាំកំណើតរបស់អ្នកជំងឺ", Color.Yellow);
                dateTimeBirthDate.Focus();
                return;
            }

            var addressValue = new object();
            if (string.IsNullOrWhiteSpace(txtAddress.Text) || txtAddress.Text.Equals("N/A"))
                addressValue = DBNull.Value;
            else addressValue = txtAddress.Text;

            var emailValue = new object();
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text.Equals("N/A"))
                emailValue = DBNull.Value;
            else emailValue = txtEmail.Text;

            var nationalCardIDValue = new object();
            if (string.IsNullOrWhiteSpace(txtNationalCardID.Text) || txtNationalCardID.Text.Equals("N/A"))
                nationalCardIDValue = DBNull.Value;
            else nationalCardIDValue = txtNationalCardID.Text;

            var medicalHistoryValue = new object();
            if (string.IsNullOrWhiteSpace(txtMedicalHistory.Text) || txtMedicalHistory.Text.Equals("N/A"))
                medicalHistoryValue = DBNull.Value;
            else medicalHistoryValue = txtMedicalHistory.Text;

            var emergencyNameValue = new object();
            if (string.IsNullOrWhiteSpace(txtEmergencyName.Text) || txtEmergencyName.Text.Equals("N/A"))
                emergencyNameValue = DBNull.Value;
            else emergencyNameValue = txtEmergencyName.Text;

            var emergencyRelationValue = new object();
            if (string.IsNullOrWhiteSpace(txtEmergencyRelation.Text) || txtEmergencyRelation.Text.Equals("N/A"))
                emergencyRelationValue = DBNull.Value;
            else emergencyRelationValue = txtEmergencyRelation.Text; 

            var emergencyPhoneValue = new object();
            if (string.IsNullOrWhiteSpace(txtEmergencyNumber.Text) || txtEmergencyNumber.Text.Equals("N/A"))
                emergencyPhoneValue = DBNull.Value;
            else emergencyPhoneValue = txtEmergencyNumber.Text; 

            var currentRow = patientBindingSource.Current as DataRowView;

            currentRow.Row.ItemArray = new object[]
            {
                txtPatientID.Text,
                txtFirstName.Text,
                txtLastName.Text,
                $"{txtFirstName.Text} {txtLastName.Text}",
                cbGender.SelectedIndex == 0 ? 'M' : 'F',
                cbGender.SelectedIndex == 0 ? "ប្រុស" : "ស្រី",
                dateTimeBirthDate.Value,
                addressValue,
                txtPhoneNumber.Text,
                emergencyNameValue,
                emergencyRelationValue,
                emergencyPhoneValue,
                emailValue,
                nationalCardIDValue,
                checkBoxIsInpatient.Checked ? 1 : 0,
                medicalHistoryValue
            };

            patientBindingSource.EndEdit();
            //refresh patient record
            patientBindingSource.ResetCurrentItem();
            patientAdapter.Update(dataSet, FrmPatient.VIEW_PATIENT_INFO);

            NotificationUtil.AlertNotificationEdit();

            DisableUpdate();
        }

        private void EnableUpdate()
        {
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            cbGender.Enabled = true;
            dateTimeBirthDate.Enabled = true;
            txtAddress.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtEmergencyName.ReadOnly = false;
            txtEmergencyRelation.ReadOnly = false;
            txtEmergencyNumber.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtNationalCardID.ReadOnly = false;
            txtMedicalHistory.ReadOnly = false;
            checkBoxIsInpatient.Enabled = true;
        }

        private void DisableUpdate()
        {
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            cbGender.Enabled = false;
            dateTimeBirthDate.Enabled = false;
            txtAddress.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            txtEmergencyName.ReadOnly = true;
            txtEmergencyRelation.ReadOnly = true;
            txtEmergencyNumber.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtNationalCardID.ReadOnly = true;
            txtMedicalHistory.ReadOnly = true;
            checkBoxIsInpatient.Enabled = false; 
        }
    }
}
