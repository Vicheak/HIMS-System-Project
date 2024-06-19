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

        protected DataSet dataSet = new DataSet();

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
    }
}
