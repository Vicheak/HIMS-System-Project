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
    public partial class FrmAddOrModifySpecialist : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        public SqlDataAdapter specialistAdapter;
        public BindingSource specialistBindingSource;
        public bool isAdded = false;
        public FrmAddOrModifySpecialist()
        {
            InitializeComponent();
        }
        private void FrmAddOrModifySpecialist_Load(object sender, EventArgs e)
        {
            if (isAdded)
            {
                //user adds new record
                this.Text = "បញ្ចូលព័ត៌មាន";
                panelTitle.Text = "បញ្ចូលព័ត៌មានជំនាញឯកទេសថ្មី";
                txtSpecialistID.TextAlign = HorizontalAlignment.Center;
                txtSpecialistID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            }
            else
            {
                this.Text = "កែប្រែព័ត៌មាន";
                //user updates existing record
                var currentRow = specialistBindingSource.Current as DataRowView;

                panelTitle.Text = $"កែប្រែព័ត៌មានជំនាញឯកទេស #{currentRow.Row["SpecialistID"]}";
                txtSpecialistID.TextAlign = HorizontalAlignment.Left;
                txtSpecialistID.WatermarkText = "";
                txtSpecialistID.Text = currentRow.Row["SpecialistID"].ToString();
                txtSpecialistName.Text = currentRow.Row["SpecialistName"].ToString();
                txtSpecialistDesc.Text = currentRow.Row["Description"].ToString().Equals("គ្មានការបរិយាយ") ? "" :
                    currentRow.Row["Description"].ToString();
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            specialistBindingSource.CancelEdit();

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (!ValidateUtil.ValidateTextBox(txtSpecialistName, "Warning", "សូមវាយបញ្ចូលជំនាញឯកទេសជាមុនសិន")) return;

            var descriptionValue = new object();
            if (string.IsNullOrWhiteSpace(txtSpecialistDesc.Text) || txtSpecialistDesc.Text.Equals("គ្មានការបរិយាយ"))
                descriptionValue = DBNull.Value;
            else descriptionValue = txtSpecialistDesc.Text;

            if (this.isAdded)
            {
                specialistBindingSource.AddNew();

                var currentRow = specialistBindingSource.Current as DataRowView;

                currentRow.Row.ItemArray = new object[]
                {
                   DBNull.Value,
                   txtSpecialistName.Text,
                   descriptionValue
                };
            }
            else
            {
                var currentRow = specialistBindingSource.Current as DataRowView;
                currentRow.Row.ItemArray = new object[]
                {
                   txtSpecialistID.Text,
                   txtSpecialistName.Text,
                   descriptionValue
                };
            }

            //close the form itself
            this.DialogResult = DialogResult.OK;
        }
    }
}
