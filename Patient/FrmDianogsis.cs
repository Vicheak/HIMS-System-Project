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

namespace HIMS.Patient
{
    public partial class FrmDianogsis : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();
        protected SqlDataAdapter diagnosisAdapter = new SqlDataAdapter();
        protected BindingSource diagnosisBindingSource = new BindingSource();
        DataSet dataSet = new DataSet();
        private bool isAdded = false;

        public string VIEW_DIAGNOSIS = "vDiagnosis";
        public string INSERT_DIAGNOSIS = "InserttbDiagnosis";
        public string UPDATE_DIAGNOSIS = "UpdatetbDiagnosis";
        public string DELETE_DIAGNOSIS = "DeletetbDiagnosis";

        public FrmDianogsis()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
        }

        private void SetUpBinding()
        {
            dgvDiagnosis.DataSource = diagnosisBindingSource;
            txtDiagnosisID.DataBindings.Add(new Binding("Text", diagnosisBindingSource, "DiagnosisID"));
            txtDescription.DataBindings.Add(new Binding("Text", diagnosisBindingSource, "Description"));
            txtPatientID.DataBindings.Add(new Binding("Text", diagnosisBindingSource, "PatientID"));
            txtStaffID.DataBindings.Add(new Binding("Text", diagnosisBindingSource, "StaffID"));
            txtStatus.DataBindings.Add(new Binding("Text", diagnosisBindingSource, "Status"));
            txtPhysicianNote.DataBindings.Add(new Binding("Text", diagnosisBindingSource, "PhysicianNote"));
            DiagnosisDatetime.DataBindings.Add(new Binding("Text", diagnosisBindingSource, "DiagnosisDate"));
        }

        private void FillData()
        {
            diagnosisAdapter.SelectCommand.Parameters["@numberOfRecord"].Value = 5;
            diagnosisAdapter.TableMappings.Add("Table", VIEW_DIAGNOSIS);
            diagnosisAdapter.Fill(dataSet);
            diagnosisBindingSource.DataSource = dataSet;
            diagnosisBindingSource.DataMember = VIEW_DIAGNOSIS;

        }

        private void SetUpCommand()
        {
            diagnosisAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopDiagnosisRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            diagnosisAdapter.SelectCommand.Parameters.Add("@numberOfRecord", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;
            //=========[Insert]==============
            diagnosisAdapter.InsertCommand = new SqlCommand()
            {
                CommandText = INSERT_DIAGNOSIS,
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            diagnosisAdapter.InsertCommand.Parameters.Add("@DiagnosisDate", SqlDbType.Date, 0, "DiagnosisDate");
            diagnosisAdapter.InsertCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 255, "Description");
            diagnosisAdapter.InsertCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 50, "Status");
            diagnosisAdapter.InsertCommand.Parameters.Add("@PhysicianNote", SqlDbType.NVarChar, 255, "PhysicianNote");
            diagnosisAdapter.InsertCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6, "PatientID");
            diagnosisAdapter.InsertCommand.Parameters.Add("@StaffID", SqlDbType.SmallInt, 0, "StaffID");
            //======[Update]========
            diagnosisAdapter.UpdateCommand = new SqlCommand()
            {
                CommandText = UPDATE_DIAGNOSIS,
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            diagnosisAdapter.UpdateCommand.Parameters.Add("@DiagnosisID", SqlDbType.Int, 0, "DiagnosisID");
            diagnosisAdapter.UpdateCommand.Parameters.Add("@DiagnosisDate", SqlDbType.Date, 0, "DiagnosisDate");
            diagnosisAdapter.UpdateCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 255, "Description");
            diagnosisAdapter.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 50, "Status");
            diagnosisAdapter.UpdateCommand.Parameters.Add("@PhysicianNote", SqlDbType.NVarChar, 255, "PhysicianNote");
            diagnosisAdapter.UpdateCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6, "PatientID");
            diagnosisAdapter.UpdateCommand.Parameters.Add("@StaffID", SqlDbType.SmallInt, 0, "StaffID");
            //=================[Delete]===================
            diagnosisAdapter.DeleteCommand = new SqlCommand()
            {
                CommandText = DELETE_DIAGNOSIS,
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            diagnosisAdapter.DeleteCommand.Parameters.Add("@DiagnosisID", SqlDbType.Int, 0, "DiagnosisID");
        }

        private void FrmDiagnosis_Load(object sender, EventArgs e)
        {
            cbFilterTopDiagnosisRecord.Items.AddRange(new object[] {
                "ជម្រើស ៥ កំណត់ត្រាដំបូង",
                "ជម្រើស ១០ កំណត់ត្រាដំបូង"
            });
            cbFilterTopDiagnosisRecord.SelectedIndex = 0;
        }

        private void cbFilterTopDiagnosisRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            diagnosisAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopDiagnosisRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            diagnosisAdapter.SelectCommand.Parameters.Add("@numberOfRecord", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            diagnosisAdapter.SelectCommand.Parameters["@numberOfRecord"].Value =
                    cbFilterTopDiagnosisRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_DIAGNOSIS].Clear();
            diagnosisAdapter.Fill(dataSet);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check patient ID
            SqlCommand cmd = new SqlCommand($"EXEC spSearchPatientInfoByPreciseID '{txtPatientID.Text}'", this.connection);
            cmd.Connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (!dataReader.Read())
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសលេខកូដអ្នកជំងឺអោយបានត្រឹមត្រូវ", Color.Yellow);
                cmd.Connection.Close();
                return;
            }
            cmd.Connection.Close();

            //check staffID exist
            SqlCommand cmdcheckstaff = new SqlCommand($"EXEC spSearchStaffInfoByPreciseID '{txtStaffID.Text}'", this.connection);
            cmdcheckstaff.Connection.Open();
            SqlDataReader read = cmdcheckstaff.ExecuteReader();
            if (!read.Read())
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមបញ្ចូលលេខសំគាល់បុគ្គលិកអោយបានត្រឹមត្រូវ", Color.Yellow);
                cmdcheckstaff.Connection.Close();
                return;
            }
            cmdcheckstaff.Connection.Close();

            if (string.IsNullOrWhiteSpace(DiagnosisDatetime.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសកាលបរិច្ឆេទ", Color.Yellow);
                return;
            }
            if (!ValidateUtil.ValidateTextBox(txtPhysicianNote, "Warning", "សូមបញ្ចូលលទ្ធផល") ||
            !ValidateUtil.ValidateTextBox(txtDescription, "Warning", "សូមបញ្ចូលការបរិយាយ"))
                return;



            this.diagnosisBindingSource.EndEdit();
            this.diagnosisAdapter.Update(dataSet, VIEW_DIAGNOSIS);

            if (isAdded)
                NotificationUtil.AlertNotificationInsert();
            else
                NotificationUtil.AlertNotificationEdit();

            isAdded = false;
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {

            if (!isAdded)
            {
                var newRow = this.diagnosisBindingSource.AddNew() as DataRowView;
                if (newRow != null)
                {
                    newRow.Row["DiagnosisID"] = -1;
                    txtDiagnosisID.Text = "បង្កើតស្វ័យប្រវត្តិ";
                }
            }
            isAdded = true;
        }

        private void dgvDiagnosis_Paint(object sender, PaintEventArgs e)
        {
            if (dgvDiagnosis.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "ព័ត៌មានមិនត្រូវបានស្វែងរកឃើញទេ...",
                    new Font(dgvDiagnosis.Font.FontFamily, 12, FontStyle.Regular),
                    dgvDiagnosis.ClientRectangle,
                    dgvDiagnosis.ForeColor,
                    dgvDiagnosis.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (diagnosisBindingSource.Count == 0)
            {
                NotificationUtil.AlertNotificationWarning("warning", "មិនមានព័ត៌មានដែលត្រូវលុប", Color.Yellow);
                return;
            }

            var current = diagnosisBindingSource.Current as DataRowView;
            CustomMessageBox result = new CustomMessageBox($"តើអ្នកពិតជាចង់លុបព័ត៌មានដែលមានលេខសំគាល់ប័ណ្ណ ({current.Row["DiagnosisID"]}) មែនទេ?");
            if (result.ShowDialog() == DialogResult.OK)
            {
                this.diagnosisBindingSource.RemoveCurrent();
                this.diagnosisBindingSource.EndEdit();

                this.diagnosisAdapter.Update(dataSet, VIEW_DIAGNOSIS);

                NotificationUtil.AlertNotificationDelete();
            }

            isAdded = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.diagnosisBindingSource.CancelEdit();
            isAdded = false;

        }

        private void txtSearchDiagnosis_TextChanged(object sender, EventArgs e)
        {
            dataSet.Tables[VIEW_DIAGNOSIS].Clear();
            if (!string.IsNullOrWhiteSpace(txtSearchDiagnosis.Text))
            {
                diagnosisAdapter.SelectCommand = new SqlCommand()
                {
                    CommandText = "spSearchDiagnosis",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                diagnosisAdapter.SelectCommand.Parameters.Add("@SearchDiagnosis", SqlDbType.NVarChar, 255);
                diagnosisAdapter.SelectCommand.Parameters["@SearchDiagnosis"].Value = txtSearchDiagnosis.Text;
                diagnosisAdapter.Fill(dataSet);
            }
        }
    }
}
