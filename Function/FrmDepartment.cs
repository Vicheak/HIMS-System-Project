using HIMS.Helper;
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
    public partial class FrmDepartment : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection(); 
        protected DataSet dataSet = new DataSet();
        protected SqlCommand command = new SqlCommand();
        protected SqlDataAdapter DepartmentAdapter = new SqlDataAdapter();
        protected BindingSource DepartmentBindingSource = new BindingSource();
        public static string V_DEPARTMENT = "VDepartment";

        public FrmDepartment()
        {
            InitializeComponent();
            setUp();
            setUpBinding();
        }

        private void Clean()
        {
            txtStaffID.Clear();
            txtDepartmentName.Clear();
            txtDescription.Clear();
            txtBuildingName.Clear();
            txtCapacity.Clear();
            txtfloorNumber.Clear();
        }
        private void setUp()
        {
            command.Connection = connection;
            command.CommandText = $"SELECT * FROM {V_DEPARTMENT}";
            DepartmentAdapter.SelectCommand = command;
            DepartmentAdapter.TableMappings.Add("Table", V_DEPARTMENT);
            DepartmentAdapter.Fill(dataSet);

            DepartmentBindingSource.DataSource = dataSet;
            DepartmentBindingSource.DataMember = V_DEPARTMENT;

            dgvDepartment.DataSource = DepartmentBindingSource;
        }
        private void setUpBinding()
        {
            dgvDepartment.DataSource = DepartmentBindingSource;
            txtDepartmentName.DataBindings.Add("text", DepartmentBindingSource, "DepartmentName");
            txtBuildingName.DataBindings.Add("text", DepartmentBindingSource, "BuildingName");
            txtfloorNumber.DataBindings.Add("text", DepartmentBindingSource, "FloorNumber");
            txtDescription.DataBindings.Add("text", DepartmentBindingSource, "Description");
            txtCapacity.DataBindings.Add("text", DepartmentBindingSource, "Capacity");
            txtStaffID.DataBindings.Add("text", DepartmentBindingSource, "StaffID");

        }
        private void FormDepartment_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DepartmentBindingSource.CancelEdit();

            this.Close();
        }

        private void btnAddnewbtnAddnew_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(txtStaffID.Text))
            {
                MessageBox.Show("StaffID cannot be empty.");
                return;
            }
            try
            {
                connection.Open();
                SqlCommand insertDepartmentCommand = new SqlCommand("spInsertDepartment", connection);
                insertDepartmentCommand.CommandType = CommandType.StoredProcedure;
                insertDepartmentCommand.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
                insertDepartmentCommand.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text);
                insertDepartmentCommand.Parameters.AddWithValue("@BuildingName", txtBuildingName.Text);
                insertDepartmentCommand.Parameters.AddWithValue("@FloorNumber", txtfloorNumber.Text);
                insertDepartmentCommand.Parameters.AddWithValue("@Description", txtDescription.Text);
                insertDepartmentCommand.Parameters.AddWithValue("@Capacity", txtCapacity.Text);

                insertDepartmentCommand.ExecuteNonQuery();
                dataSet.Clear();
                DepartmentAdapter.Fill(dataSet);

                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DepartmentBindingSource.Count == 0) return;
            var currentRow = DepartmentBindingSource.Current as DataRowView;
            int DepartmentID = Convert.ToInt32(currentRow.Row["DepartmentID"]);
            CustomMessageBox result = new CustomMessageBox("តើអ្នកចង់លុបទិន្នន័យមែនទេ?");
            result.ShowDialog();
            if (result.DialogResult == DialogResult.OK)
            {
                connection.Open();
                SqlCommand deleteDepartmentCommand = new SqlCommand("spDeleteDepartment", connection);
                deleteDepartmentCommand.CommandType = CommandType.StoredProcedure;
                deleteDepartmentCommand.Parameters.AddWithValue("@DepartmentID", dgvDepartment.CurrentRow.Cells["DepartmentID"].Value);
                deleteDepartmentCommand.ExecuteNonQuery();
                dataSet.Clear();
                DepartmentAdapter.Fill(dataSet);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    SqlCommand updateDepartmentCommand = new SqlCommand("spUpdateDepartment", connection);
                    updateDepartmentCommand.CommandType = CommandType.StoredProcedure;
                    updateDepartmentCommand.Parameters.AddWithValue("@DepartmentID", dgvDepartment.CurrentRow.Cells["DepartmentID"].Value);
                    updateDepartmentCommand.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text);
                    updateDepartmentCommand.Parameters.AddWithValue("@BuildingName", txtBuildingName.Text);
                    updateDepartmentCommand.Parameters.AddWithValue("@FloorNumber", txtfloorNumber.Text);
                    updateDepartmentCommand.Parameters.AddWithValue("@Description", txtDescription.Text);
                    updateDepartmentCommand.Parameters.AddWithValue("@Capacity", txtCapacity.Text);
                    updateDepartmentCommand.ExecuteNonQuery();
                    dataSet.Clear();
                    DepartmentAdapter.Fill(dataSet);


                    MessageBox.Show("Data updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}
