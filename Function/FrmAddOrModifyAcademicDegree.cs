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
    public partial class FrmAddOrModifyAcademicDegree : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        public SqlDataAdapter acadeDegreeAdapter;
        public BindingSource acadeDegreeBindingSource;
        public bool isAdded = false;

        public FrmAddOrModifyAcademicDegree()
        {
            InitializeComponent();
        }
        private void FrmAddOrModifyAcademicDegree_Load(object sender, EventArgs e)
        {
            if (isAdded)
            {
                //user adds new record
                this.Text = "បញ្ចូលព័ត៌មាន";
                panelTitle.Text = "បញ្ចូលព័ត៌មានកម្រិតវប្បធម៌ថ្មី";
                txtAcadeDegreeID.TextAlign = HorizontalAlignment.Center;
                txtAcadeDegreeID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            }
            else
            {
                this.Text = "កែប្រែព័ត៌មាន";
                //user updates existing record
                var currentRow = acadeDegreeBindingSource.Current as DataRowView;

                panelTitle.Text = $"កែប្រែព័ត៌មានកម្រិតវប្បធម៌ #{currentRow.Row["AcadeDegreeID"]}";
                txtAcadeDegreeID.TextAlign = HorizontalAlignment.Left;
                txtAcadeDegreeID.WatermarkText = "";
                txtAcadeDegreeID.Text = currentRow.Row["AcadeDegreeID"].ToString();
                txtAcadeDegreeName.Text = currentRow.Row["AcadeDegreeName"].ToString();
                txtAcadeDegreeDesc.Text = currentRow.Row["Description"].ToString().Equals("គ្មានការបរិយាយ") ? "" :
                    currentRow.Row["Description"].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            acadeDegreeBindingSource.CancelEdit();

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (!ValidateUtil.ValidateTextBox(txtAcadeDegreeName, "Warning", "សូមវាយបញ្ចូលកម្រិតវប្បធម៌ជាមុនសិន")) return;

            var descriptionValue = new object();
            if (string.IsNullOrWhiteSpace(txtAcadeDegreeDesc.Text) || txtAcadeDegreeDesc.Text.Equals("គ្មានការបរិយាយ"))
                descriptionValue = DBNull.Value;
            else descriptionValue = txtAcadeDegreeDesc.Text;

            if (this.isAdded)
            {
                acadeDegreeBindingSource.AddNew();

                var currentRow = acadeDegreeBindingSource.Current as DataRowView;

                currentRow.Row.ItemArray = new object[]
                {
                   DBNull.Value,
                   txtAcadeDegreeName.Text,
                   descriptionValue
                };
            }
            else
            {
                var currentRow = acadeDegreeBindingSource.Current as DataRowView;
                currentRow.Row.ItemArray = new object[]
                {
                   txtAcadeDegreeID.Text,
                   txtAcadeDegreeName.Text,
                   descriptionValue
                };
            }

            //close the form itself
            this.DialogResult = DialogResult.OK;
        }
    }
}
