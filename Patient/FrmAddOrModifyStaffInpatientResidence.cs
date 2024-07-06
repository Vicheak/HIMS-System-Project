using HIMS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS.Patient
{
    public partial class FrmAddOrModifyStaffInpatientResidence : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter staffAdapter = new SqlDataAdapter();
        protected BindingSource staffBindingSource = new BindingSource();  
       
        public BindingSource inpatientResidenceBindingSource; 

        protected SqlDataAdapter staffInpatientResidenceAdapter = new SqlDataAdapter(); 

        public FrmAddOrModifyStaffInpatientResidence()
        {
            InitializeComponent();
            SetUpCommand(); 
        }

        private void SetUpCommand()
        {
            staffInpatientResidenceAdapter.InsertCommand = new SqlCommand
            {
                 CommandText = "spInsertStaffInpatientResidenceInfo",
                 CommandType = CommandType.StoredProcedure,
                 Connection = this.connection
            };

            staffInpatientResidenceAdapter.InsertCommand.Parameters.Add("@StaffID", SqlDbType.SmallInt, 0)
                .Direction = ParameterDirection.Input;
            staffInpatientResidenceAdapter.InsertCommand.Parameters.Add("@InpatientResidenceID", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;
            staffInpatientResidenceAdapter.InsertCommand.Parameters.Add("@RoleInCare", SqlDbType.NVarChar, 50)
                .Direction = ParameterDirection.Input;
            staffInpatientResidenceAdapter.InsertCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 150)
                .Direction = ParameterDirection.Input;
        }

        private void FrmAddOrModifyStaffInpatientResidence_Load(object sender, EventArgs e)
        {
            var currentRow = inpatientResidenceBindingSource.Current as DataRowView;
            panelTitle.Text = $"បញ្ចូលព័ត៌មានបុគ្គលិកដែលទទួលខុសត្រូវលើអ្នកជំងឺនៃការសម្រាក #{currentRow.Row["InpatientResidenceID"].ToString()}"; 
        }

        private void txtSearchEntry_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchEntry.Text)) return; 
            if(txtSearchEntry.Text.Length > 4)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "លេខសម្គាល់បុគ្គលិកមិនត្រឹមត្រូវ", Color.Yellow);
                txtSearchEntry.Clear(); 
                return; 
            }

            staffAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSearchStaffInfoByStaffID",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            }; 
            
            staffAdapter.SelectCommand.Parameters.Add("@StaffID", SqlDbType.VarChar, 255)
                .Direction = ParameterDirection.Input;

            staffAdapter.SelectCommand.Parameters["@StaffID"].Value = txtSearchEntry.Text;
            if (dataSet.Tables.Count == 0)
            {
                staffAdapter.Fill(dataSet, "tbSearchStaff");
                staffBindingSource.DataSource = dataSet;
                staffBindingSource.DataMember = "tbSearchStaff";
            }
            else
            {
                dataSet.Tables["tbSearchStaff"].Clear();
                staffAdapter.Fill(dataSet, "tbSearchStaff");
            }


            RefreshStaffInfo();
        }

        private void RefreshStaffInfo()
        {
            if (staffBindingSource.Count == 0) return; 

            var currentStaff = staffBindingSource.Current as DataRowView;

            txtStaffID.Text = currentStaff.Row["StaffID"].ToString();
            txtStaffName.Text = currentStaff.Row["FullName"].ToString();
            txtStaffPosition.Text = currentStaff.Row["StaffPositionName"].ToString(); 
            txtStaffPhone.Text = currentStaff.Row["PhoneNumber"].ToString(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate
            if (!ValidateUtil.ValidateTextBox(txtStaffID, "Warning", "មិនមានព័ត៌មានគ្រប់គ្រាន់ដើម្បីរក្សាទុក")) return;

            var roleInCareValue = new object();
            if (string.IsNullOrWhiteSpace(txtRoleInCare.Text) || txtRoleInCare.Text.Equals("គ្មា​នការបរិយាយ"))
                roleInCareValue = DBNull.Value;
            else roleInCareValue = txtRoleInCare.Text;

            var descriptionValue = new object();
            if (string.IsNullOrWhiteSpace(txtDescription.Text) || txtDescription.Text.Equals("គ្មា​នការបរិយាយ"))
                descriptionValue = DBNull.Value;
            else descriptionValue = txtDescription.Text;

            var currentRow = inpatientResidenceBindingSource.Current as DataRowView;
            long inpatientResidenceID = Convert.ToInt64(currentRow.Row["InpatientResidenceID"]); 

            //check if there is already a staff reponsible for inpatient residence
            SqlCommand cmdCheck = new SqlCommand($"SELECT dbo.fnCheckStaffInpatientResidenceStaffID({txtStaffID.Text}, {inpatientResidenceID})",
                this.connection);
            cmdCheck.Connection.Open();
            var result = cmdCheck.ExecuteScalar();
            if ((bool)result == true)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "បុគ្គលិកនេះបានទទូលខុសត្រូវលើអ្នកជំងឺរូចហើយ", Color.Yellow);
                cmdCheck.Connection.Close();
                return;
            }
            cmdCheck.Connection.Close();

            staffInpatientResidenceAdapter.InsertCommand.Parameters["@StaffID"].Value = txtStaffID.Text;
            staffInpatientResidenceAdapter.InsertCommand.Parameters["@InpatientResidenceID"].Value = inpatientResidenceID; 
            staffInpatientResidenceAdapter.InsertCommand.Parameters["@RoleInCare"].Value = roleInCareValue;
            staffInpatientResidenceAdapter.InsertCommand.Parameters["@Description"].Value = descriptionValue;

            staffInpatientResidenceAdapter.InsertCommand.Connection.Open(); 
            staffInpatientResidenceAdapter.InsertCommand.ExecuteNonQuery();
            staffInpatientResidenceAdapter.InsertCommand.Connection.Close(); 

            NotificationUtil.AlertNotificationInsert();

            //close the form itself
            this.DialogResult = DialogResult.OK;
        }
    }
}
