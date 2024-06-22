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
    public partial class FrmAddOrModifyStaffActivity : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        public SqlDataAdapter staffActivityAdapter;
        public BindingSource staffActivityBindingSource;
        public bool isAdded = false;

        public FrmAddOrModifyStaffActivity()
        {
            InitializeComponent();
        }

        private void FrmAddOrModifyBed_Load(object sender, EventArgs e)
        {
            if (isAdded)
            {
                //user adds new record
                panelTitle.Text = "បញ្ចូលព័ត៌មានសកម្មភាពថ្មី";
                txtStaffActivityID.TextAlign = HorizontalAlignment.Center;
                txtStaffActivityID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            }
            else
            {
                //user updates existing record
                var currentRow = staffActivityBindingSource.Current as DataRowView;

                panelTitle.Text = $"កែប្រែព័ត៌មានសកម្មភាព #{currentRow.Row["ActivityTypeID"]}";
                txtStaffActivityID.TextAlign = HorizontalAlignment.Left;
                txtStaffActivityID.WatermarkText = "";
                txtStaffActivityID.Text = currentRow.Row["ActivityTypeID"].ToString();
                txtStaffActivityName.Text = currentRow.Row["ActivityName"].ToString();
                txtStaffActivityDesc.Text = currentRow.Row["Description"].ToString().Equals("គ្មានការបរិយាយ") ? "" :
                    currentRow.Row["Description"].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            staffActivityBindingSource.CancelEdit();

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (!ValidateUtil.ValidateTextBox(txtStaffActivityName, "Warning", "សូមវាយបញ្ចូលសកម្មភាពជាមុនសិន")) return;

            var descriptionValue = new object();
            if (string.IsNullOrWhiteSpace(txtStaffActivityDesc.Text) || txtStaffActivityDesc.Text.Equals("គ្មានការបរិយាយ"))
                descriptionValue = DBNull.Value;
            else descriptionValue = txtStaffActivityDesc.Text;

            if (this.isAdded)
            {
                staffActivityBindingSource.AddNew();

                var currentRow = staffActivityBindingSource.Current as DataRowView;

                currentRow.Row.ItemArray = new object[]
                {
                   DBNull.Value,
                   txtStaffActivityName.Text,
                   descriptionValue
                };
            }
            else
            {
                var currentRow = staffActivityBindingSource.Current as DataRowView;
                currentRow.Row.ItemArray = new object[]
                {
                   txtStaffActivityID.Text,
                   txtStaffActivityName.Text,
                   descriptionValue
                };
            }

            //close the form itself
            this.DialogResult = DialogResult.OK;
        }
    }
}
