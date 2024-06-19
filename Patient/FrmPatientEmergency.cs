using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS.Patient
{
    public partial class FrmPatientEmergency : Form
    {
        public string FullName
        {
            set
            {
                txtFullName.Text = value; 
            }
        }

        public string PhoneNumber
        {
            set
            {
                txtPhoneNumber.Text = value;
            }
        }

        public string EmergencyName { get => txtEmergencyName.Text; set => txtEmergencyName.Text = value; }
        public string EmergencyRelation { get => txtEmergencyRelation.Text; set => txtEmergencyRelation.Text = value; }
        public string EmergencyPhone { get => txtEmergencyNumber.Text; set => txtEmergencyNumber.Text = value; }

        public FrmPatientEmergency()
        {
            InitializeComponent();
        }

        private void FrmPatientEmergency_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //close the form itself
            this.DialogResult = DialogResult.OK;
        }
    }
}
