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
    public partial class FrmAddOrModifyStaffPosition : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        public SqlDataAdapter staffPositionAdapter;
        public BindingSource staffPositionBindingSource;
        public bool isAdded = false;
        public FrmAddOrModifyStaffPosition()
        {
            InitializeComponent();
        }
        private void FrmAddOrModifyStaffPosition_Load(object sender, EventArgs e)
        {
            if (isAdded)
            {
                //user adds new record
                this.Text = "បញ្ចូលព័ត៌មាន";
                panelTitle.Text = "បញ្ចូលព័ត៌មានមុខតំណែងថ្មី";
                txtPositionID.TextAlign = HorizontalAlignment.Center;
                txtPositionID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            }
            else
            {
                this.Text = "កែប្រែព័ត៌មាន";
                //user updates existing record
                var currentRow = staffPositionBindingSource.Current as DataRowView;

                panelTitle.Text = $"កែប្រែព័ត៌មានមុខតំណែង #{currentRow.Row["StaffPositionID"]}";
                txtPositionID.TextAlign = HorizontalAlignment.Left;
                txtPositionID.WatermarkText = "";
                txtPositionID.Text = currentRow.Row["StaffPositionID"].ToString();
                txtPositionName.Text = currentRow.Row["StaffPositionName"].ToString();
                txtPositionDesc.Text = currentRow.Row["Description"].ToString().Equals("គ្មានការបរិយាយ") ? "" :
                    currentRow.Row["Description"].ToString();
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            staffPositionBindingSource.CancelEdit();

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (!ValidateUtil.ValidateTextBox(txtPositionName, "Warning", "សូមវាយបញ្ចូលមុខតំណែងជាមុនសិន")) return;

            var descriptionValue = new object();
            if (string.IsNullOrWhiteSpace(txtPositionDesc.Text) || txtPositionDesc.Text.Equals("គ្មានការបរិយាយ"))
                descriptionValue = DBNull.Value;
            else descriptionValue = txtPositionDesc.Text;

            if (this.isAdded)
            {
                staffPositionBindingSource.AddNew();

                var currentRow = staffPositionBindingSource.Current as DataRowView;

                currentRow.Row.ItemArray = new object[]
                {
                   DBNull.Value,
                   txtPositionName.Text,
                   descriptionValue
                };
            }
            else
            {
                var currentRow = staffPositionBindingSource.Current as DataRowView;
                currentRow.Row.ItemArray = new object[]
                {
                   txtPositionID.Text,
                   txtPositionName.Text,
                   descriptionValue
                };
            }

            //close the form itself
            this.DialogResult = DialogResult.OK;
        }
    }
}
