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

namespace HIMS.Patient
{
    public partial class FrmAddOrModifyPatient : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        public BindingSource patientBindingSource;
        public bool isAdded = false;

        protected FrmPatientEmergency frmPatientEmergency = new FrmPatientEmergency(); 

        public FrmAddOrModifyPatient()
        {
            InitializeComponent();
            setUpBinding();
        }

        protected void setUpBinding()
        {
            cbGender.Items.AddRange(new object[]
            {
                "ប្រុស",
                "ស្រី"
            });
            cbGender.SelectedIndex = 0; 
        }

        private void FrmAddOrModifyPatient_Load(object sender, EventArgs e)
        {
            if (isAdded)
            {
                //user adds new record
                panelTitle.Text = "បញ្ចូលព័ត៌មានអ្នកជំងឺថ្មី";
                txtPatientID.TextAlign = HorizontalAlignment.Center;
                txtPatientID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
                btnShowPatientEmergencyFrm.Text = "បញ្ចូលព័ត៌មានទាក់ទងបន្ទាន់"; 
            }
            else
            {
                btnShowPatientEmergencyFrm.Text = "កែប្រែព័ត៌មានទាក់ទងបន្ទាន់";

                //user updates existing record
                var currentRow = patientBindingSource.Current as DataRowView;

                panelTitle.Text = $"កែប្រែព័ត៌មានអ្នកជំងឺ #{currentRow.Row["PatientID"]}";
                txtPatientID.TextAlign = HorizontalAlignment.Left;
                txtPatientID.WatermarkText = "";
                txtPatientID.Text = currentRow.Row["PatientID"].ToString();
                txtFirstName.Text = currentRow.Row["FirstName"].ToString();
                txtLastName.Text = currentRow.Row["LastName"].ToString();
                cbGender.SelectedIndex = currentRow.Row["Gender"].ToString().Equals("M") ? 0 : 1;
                dateTimeBirthDate.Value = Convert.ToDateTime(currentRow.Row["BirthDate"]);
                txtAddress.Text = currentRow.Row["Address"].ToString();
                txtPhoneNumber.Text = currentRow.Row["PhoneNumber"].ToString();
                //txtEmergencyName.Text = currentRow.Row["EmergencyName"].ToString();
                //txtEmergencyRelation.Text = currentRow.Row["EmergencyRelation"].ToString();
                //txtEmergencyNumber.Text = currentRow.Row["EmergencyNumber"].ToString();
                txtEmail.Text = currentRow.Row["Email"].ToString();
                txtNationalCardID.Text = currentRow.Row["NationalCardID"].ToString();
                txtMedicalHistory.Text = currentRow.Row["MedicalHistory"].ToString();
                checkBoxIsInpatient.Checked = Convert.ToInt16(currentRow.Row["IsInpatient"]) == 1;

                //supply form patient emergency
                frmPatientEmergency.EmergencyName = currentRow.Row["EmergencyName"].ToString();
                frmPatientEmergency.EmergencyRelation = currentRow.Row["EmergencyRelation"].ToString();
                frmPatientEmergency.EmergencyPhone = currentRow.Row["EmergencyNumber"].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            patientBindingSource.CancelEdit(); 

            Close(); 
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
            if (string.IsNullOrWhiteSpace(frmPatientEmergency.EmergencyName) || frmPatientEmergency.EmergencyName.Equals("N/A"))
                emergencyNameValue = DBNull.Value;
            else emergencyNameValue = frmPatientEmergency.EmergencyName;

            var emergencyRelationValue = new object();
            if (string.IsNullOrWhiteSpace(frmPatientEmergency.EmergencyRelation) || frmPatientEmergency.EmergencyRelation.Equals("N/A"))
                emergencyRelationValue = DBNull.Value;
            else emergencyRelationValue = frmPatientEmergency.EmergencyRelation;

            var emergencyPhoneValue = new object();
            if (string.IsNullOrWhiteSpace(frmPatientEmergency.EmergencyPhone) || frmPatientEmergency.EmergencyPhone.Equals("N/A"))
                emergencyPhoneValue = DBNull.Value;
            else emergencyPhoneValue = frmPatientEmergency.EmergencyPhone;

            if (this.isAdded)
            {
                patientBindingSource.AddNew();

                var newRow = patientBindingSource.Current as DataRowView;

                newRow.Row.ItemArray = new object[]
                {
                       GeneralUtil.GenerateRandomSixDigitString(),
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
            }
            else
            {
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
            }

            //close the form itself
            this.DialogResult = DialogResult.OK;
        }

        private void btnShowPatientEmergencyFrm_Click(object sender, EventArgs e)
        {
            if(!ValidateUtil.ValidateTextBox(txtFirstName, "Warning", "សូមវាយបញ្ចូលនាមត្រកូលជាមុនសិន") ||
                !ValidateUtil.ValidateTextBox(txtLastName, "Warning", "សូមវាយបញ្ចូលនាមខ្លួនជាមុនសិន") ||
                !ValidateUtil.ValidateTextBox(txtPhoneNumber, "Warning", "សូមវាយបញ្ចូលលេខទូរស័ព្ទជាមុនសិន"))
            {
                return;
            }

            frmPatientEmergency.FullName = $"{txtFirstName.Text} {txtLastName.Text}";
            frmPatientEmergency.PhoneNumber = txtPhoneNumber.Text;
            if (!isAdded)
            {
                var currentRow = patientBindingSource.Current as DataRowView;

                frmPatientEmergency.EmergencyName = currentRow.Row["EmergencyName"].ToString();
                frmPatientEmergency.EmergencyRelation = currentRow.Row["EmergencyRelation"].ToString();
                frmPatientEmergency.EmergencyPhone = currentRow.Row["EmergencyNumber"].ToString(); 
            }

            frmPatientEmergency.ShowDialog(); 
        }
    }
}
