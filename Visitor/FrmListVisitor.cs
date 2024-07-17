using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Schedule;
using HIMS.Helper;
using HIMS.RoomBed;
using HIMS.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HIMS.Visitor
{
    public partial class FrmListVisitor : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();
        protected DataSet dataSet = new DataSet();
        protected SqlDataAdapter visitorAdapter = new SqlDataAdapter();
        protected BindingSource visitorBindingSource = new BindingSource();
        public static string VIEW_VISITOR_INFO = "vVisitorInfo";
        public FrmListVisitor()
        {
            InitializeComponent();
            //txtSearchVisitorID.KeyPress += new KeyPressEventHandler(txtSearchVisitorID_KeyPress);
            LoadData();
            // Set up event handler for DateTimePicker
            dtpVisitor.ValueChanged += dtpVisitor_ValueChanged;
            

        }

        private void btnVisitorDetail_Click(object sender, EventArgs e)
        {
            if (dgvVisitor.SelectedRows.Count > 0)
            {
                int selectedVisitorID = Convert.ToInt32(dgvVisitor.SelectedRows[0].Cells[0].Value);

                try
                {
                    FrmVisitorDetail frmVisitorDetail = new FrmVisitorDetail(selectedVisitorID);
                    frmVisitorDetail.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening FrmVisitorDetail: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a visitor to view details.");
            }
        }

        private void FrmListVisitor_Load(object sender, EventArgs e)
        {


            dgvVisitor.DataSource = visitorBindingSource;

            // Set up data binding
            visitorBindingSource.DataSource = dataSet.Tables["tbVisitor"];

            // Optionally set column properties
            this.hIMSDataSet.tbVisitor.Columns["NationalCardID"].AllowDBNull = true;


            try
            {
                // Load data into the DataSet and refresh DataGridView
                LoadData();
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("ConstraintException: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dataSet.Tables["tbVisitor"].HasErrors)
                {
                    foreach (DataRow row in dataSet.Tables["tbVisitor"].GetErrors())
                    {
                        foreach (DataColumn column in row.GetColumnsInError())
                        {
                            MessageBox.Show($"Error in column: {column.ColumnName} - {row.GetColumnError(column)}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM tbVisitor ORDER BY VisitorID DESC";

                visitorAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(visitorAdapter);

                dataSet.Clear();
                visitorAdapter.Fill(dataSet, "tbVisitor");

                if (visitorBindingSource == null)
                {
                    visitorBindingSource = new BindingSource();
                }

                visitorBindingSource.DataSource = dataSet.Tables["tbVisitor"];
                dgvVisitor.DataSource = visitorBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }



        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                int nextVisitorID = GetNextVisitorID(); // Get the next available visitor ID
                FrmVisitor frmVisitor = new FrmVisitor(0);
                frmVisitor.isAdded = true;
                frmVisitor.DataSaved += FrmVisitor_DataSaved;

                if (frmVisitor.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Reload data after adding a new visitor
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating or showing FrmVisitor: " + ex.Message);
            }
        }

       


        private int GetNextVisitorID()
        {
            int nextID = 1; // Default to 1 if no existing records

            try
            {
                using (SqlConnection connection = ConnectionUtil.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT MAX(VisitorID) FROM tbVisitor";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            nextID = Convert.ToInt32(result) + 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving next VisitorID: " + ex.Message);
            }

            return nextID;
        }


        private void btnModifyVisitor_Click(object sender, EventArgs e)
        {
            if (dgvVisitor.SelectedRows.Count > 0)
            {
                int selectedVisitorID = Convert.ToInt32(dgvVisitor.SelectedRows[0].Cells[0].Value);

                FrmVisitor frmVisitor = new FrmVisitor(selectedVisitorID);
                frmVisitor.isAdded = false;
                frmVisitor.DataSaved += FrmVisitor_DataSaved;

                if (frmVisitor.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Refresh data after modifying a visitor
                }
            }
            else
            {
                MessageBox.Show("Please select a visitor to modify.");
            }
        }

        private void FrmVisitor_DataSaved(object sender, EventArgs e)
        {
            LoadData(); // Reload data in the DataGridView
        }

        private void btnDeleteVisitor_Click(object sender, EventArgs e)
        {
            if (visitorBindingSource.Count == 0) return;

            try
            {
                var currentRow = visitorBindingSource.Current as DataRowView;
                int visitorId = Convert.ToInt32(currentRow.Row["VisitorID"]);

                CustomMessageBox result = new CustomMessageBox($"តើលោកអ្នកពិតជាចង់លុប​ព័ត៌មានអ្នកជម្ងឺ #{visitorId} មែនដែរឬទេ?");
                result.ShowDialog();

                if (result.DialogResult == DialogResult.OK)
                {
                    currentRow.Row.Delete(); // Mark the row for deletion

                    // Update the database
                    visitorAdapter.Update(dataSet, "tbVisitor");

                    NotificationUtil.AlertNotificationDelete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting visitor: " + ex.Message);
            }
        }

        private void txtSearchVisitorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchVisitorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch_Click(null, EventArgs.Empty);
               // txtSearchVisitorID.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtSearchVisitorName.Text)) return;

            try
            {
                visitorAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchVisitorInfo",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };

                // Clear and fill DataSet based on search parameter
                dataSet.Clear(); // Clear entire DataSet to refresh with new search results
                visitorAdapter.SelectCommand.Parameters.AddWithValue("@visitorName", txtSearchVisitorName.Text);

                visitorAdapter.Fill(dataSet, VIEW_VISITOR_INFO); // Fill DataSet with search results

                // Update the BindingSource with the refreshed data
                visitorBindingSource.DataSource = dataSet.Tables[VIEW_VISITOR_INFO];

                // Refresh DataGridView
                dgvVisitor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message);
            }
        }

        private void txtSearchVisitorName_TextChanged(object sender, EventArgs e)
        {
            // Reset search when the text box is cleared
            if (string.IsNullOrWhiteSpace(txtSearchVisitorName.Text))
            {
                LoadData(); // Reload full visitor list
            }
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void dtpVisitor_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dtpVisitor.Value.Date;
                DataView dv = new DataView(dataSet.Tables["tbVisitor"]);
                dv.RowFilter = $"RegistryDate = '{selectedDate.ToString("yyyy-MM-dd")}'";
                dgvVisitor.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                visitorBindingSource.Filter = string.Empty;
                dgvVisitor.DataSource = visitorBindingSource;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error showing all data: " + ex.Message);
            }
        }

        
    }
}