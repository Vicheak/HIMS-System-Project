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

namespace HIMS.Function
{
    public partial class FrmAddOrModifyAppointmentType : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        public SqlDataAdapter appointmentTypeAdapter;
        public BindingSource appointmentTypeBindingSource;
        public bool isAdded = false;

        public FrmAddOrModifyAppointmentType()
        {
            InitializeComponent();
        }

        private void FrmAddOrModifyAppointmentType_Load(object sender, EventArgs e)
        {
            if (isAdded)
            {
                //user adds new record
                this.Text = "បញ្ចូលព័ត៌មាន";
                panelTitle.Text = "បញ្ចូលព័ត៌មានប្រភេទនៃការណាត់ជួបថ្មី";
                txtAppointmentTypeID.TextAlign = HorizontalAlignment.Center;
                txtAppointmentTypeID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            }
            else
            {
                this.Text = "កែប្រែព័ត៌មាន";
                //user updates existing record
                var currentRow = appointmentTypeBindingSource.Current as DataRowView;

                panelTitle.Text = $"កែប្រែព័ត៌មានប្រភេទនៃការណាត់ជួប #{currentRow.Row["AppointmentTypeID"]}";
                txtAppointmentTypeID.TextAlign = HorizontalAlignment.Left;
                txtAppointmentTypeID.WatermarkText = "";
                txtAppointmentTypeID.Text = currentRow.Row["AppointmentTypeID"].ToString();
                txtAppointmentTypeName.Text = currentRow.Row["AppointmentTypeName"].ToString();
                txtAppointmentTypeDesc.Text = currentRow.Row["Description"].ToString().Equals("គ្មានការបរិយាយ") ? "" :
                    currentRow.Row["Description"].ToString();
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            appointmentTypeBindingSource.CancelEdit();

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (!ValidateUtil.ValidateTextBox(txtAppointmentTypeName, "Warning", "សូមវាយបញ្ចូលប្រភេទនៃការណាត់ជួបជាមុនសិន")) return;

            var descriptionValue = new object();
            if (string.IsNullOrWhiteSpace(txtAppointmentTypeDesc.Text) || txtAppointmentTypeDesc.Text.Equals("គ្មានការបរិយាយ"))
                descriptionValue = DBNull.Value;
            else descriptionValue = txtAppointmentTypeDesc.Text;

            if (this.isAdded)
            {
                appointmentTypeBindingSource.AddNew();

                var currentRow = appointmentTypeBindingSource.Current as DataRowView;

                currentRow.Row.ItemArray = new object[]
                {
                   DBNull.Value,
                   txtAppointmentTypeName.Text,
                   descriptionValue
                };
            }
            else
            {
                var currentRow = appointmentTypeBindingSource.Current as DataRowView;
                currentRow.Row.ItemArray = new object[]
                {
                   txtAppointmentTypeID.Text,
                   txtAppointmentTypeName.Text,
                   descriptionValue
                };
            }

            //close the form itself
            this.DialogResult = DialogResult.OK;
        }
    }
}
