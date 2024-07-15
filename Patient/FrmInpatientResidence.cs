using HIMS.Helper;
using HIMS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS.Patient
{
    public partial class FrmInpatientResidence : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter inpatientResidenceAdapter = new SqlDataAdapter();
        protected BindingSource inpatientResidenceBindingSource = new BindingSource();

        protected SqlDataAdapter staffInpatientResidenceAdapter = new SqlDataAdapter();

        public static string VIEW_INPATIENT_RESIDENCE_INFO = "vInpatientResidenceInfo";

        public FrmInpatientResidence()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
        }

        private void SetUpCommand()
        {
            inpatientResidenceAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopInpatientResidenceRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            inpatientResidenceAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            inpatientResidenceAdapter.InsertCommand = new SqlCommand
            {
                CommandText = "spInsertInpatientResidenceInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };

            inpatientResidenceAdapter.InsertCommand.Parameters.Add("@AdmissionDate", SqlDbType.Date, 0, "AdmissionDate")
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.InsertCommand.Parameters.Add("@DischargeDate", SqlDbType.Date, 0, "DischargeDate")
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.InsertCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 50, "Status")
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            inpatientResidenceAdapter.InsertCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6, "PatientID")
                .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.InsertCommand.Parameters.Add("@BedID", SqlDbType.Int, 0, "BedID")
              .Direction = ParameterDirection.Input;

            inpatientResidenceAdapter.UpdateCommand = new SqlCommand
            {
                CommandText = "spUpdateInpatientResidenceInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };

            inpatientResidenceAdapter.UpdateCommand.Parameters.Add("@InpatientResidenceID", SqlDbType.Int, 0, "InpatientResidenceID")
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.UpdateCommand.Parameters.Add("@AdmissionDate", SqlDbType.Date, 0, "AdmissionDate")
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.UpdateCommand.Parameters.Add("@DischargeDate", SqlDbType.Date, 0, "DischargeDate")
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 50, "Status")
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            inpatientResidenceAdapter.DeleteCommand = new SqlCommand
            {
                CommandText = "spDeleteInpatientResidenceInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };

            inpatientResidenceAdapter.DeleteCommand.Parameters.Add("@InpatientResidenceID", SqlDbType.Int, 0, "InpatientResidenceID")
                   .Direction = ParameterDirection.Input;

            //command for staff inpatient residence
            staffInpatientResidenceAdapter.DeleteCommand = new SqlCommand
            {
                CommandText = "spDeleteStaffInpatientResidenceInfoByInpatientResidenceID",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };

            staffInpatientResidenceAdapter.DeleteCommand.Parameters.Add("@InpatientResidenceID", SqlDbType.Int, 0, "InpatientResidenceID")
                .Direction = ParameterDirection.Input;
        }

        protected void FillData()
        {
            inpatientResidenceAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 5;
            inpatientResidenceAdapter.TableMappings.Add("Table", VIEW_INPATIENT_RESIDENCE_INFO);
            inpatientResidenceAdapter.Fill(dataSet);
            inpatientResidenceBindingSource.DataSource = dataSet;
            inpatientResidenceBindingSource.DataMember = VIEW_INPATIENT_RESIDENCE_INFO;
        }

        protected void SetUpBinding()
        {
            //bind to control
            dgvInpatientResidence.DataSource = inpatientResidenceBindingSource;
        }

        private void FrmInpatientResidence_Load(object sender, EventArgs e)
        {
            cbFilterTopInpatientResidenceRecord.Items.AddRange(new object[] {
                "ជម្រើស ៥ កំណត់ត្រាដំបូង",
                "ជម្រើស ១០ កំណត់ត្រាដំបូង"
            });
            cbFilterTopInpatientResidenceRecord.SelectedIndex = 0;

            cbSearchCriteria.Items.AddRange(new object[]
            {
                "ស្វែករកតាមលេខកូដអ្នកជំងឺ",
                "ស្វែករកតាមឈ្មោះអ្នកជំងឺ"
            });
            cbSearchCriteria.SelectedIndex = 0;

            ListChangeInpatientResidenceBindingSource();
            inpatientResidenceBindingSource.ListChanged += InpatientResidenceBindingSource_ListChanged;
        }

        private void cbFilterTopInpatientResidenceRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            inpatientResidenceAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopInpatientResidenceRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            inpatientResidenceAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            inpatientResidenceAdapter.SelectCommand.Parameters["@numberOfRecords"].Value =
                    cbFilterTopInpatientResidenceRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_INPATIENT_RESIDENCE_INFO].Clear();
            inpatientResidenceAdapter.Fill(dataSet);
        }

        private void InpatientResidenceBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangeInpatientResidenceBindingSource();
        }

        private void ListChangeInpatientResidenceBindingSource()
        {
            toolStripLblTotalInpatientResidence.Text = inpatientResidenceBindingSource.Count.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FmrAddOrModifyInpatientResidence fmrAddOrModifyInpatientResidence = new FmrAddOrModifyInpatientResidence();
            fmrAddOrModifyInpatientResidence.inpatientResidenceAdapter = inpatientResidenceAdapter;
            fmrAddOrModifyInpatientResidence.inpatientResidenceBindingSource = inpatientResidenceBindingSource;
            fmrAddOrModifyInpatientResidence.ShowDialog();

            if (fmrAddOrModifyInpatientResidence.DialogResult == DialogResult.OK)
            {
                inpatientResidenceBindingSource.EndEdit();
                inpatientResidenceAdapter.Update(dataSet, VIEW_INPATIENT_RESIDENCE_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnAssignStaff_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyStaffInpatientResidence frmAddOrModifyStaffInpatientResidence = new FrmAddOrModifyStaffInpatientResidence();
            frmAddOrModifyStaffInpatientResidence.inpatientResidenceBindingSource = inpatientResidenceBindingSource;
            frmAddOrModifyStaffInpatientResidence.ShowDialog();
        }

        private void dgvInpatientResidence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ColumnIindex = 0 (Detail), 1 (Delete)
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 0)
            {
                FrmInpatientResidenceDetail frmInpatientResidenceDetail = new FrmInpatientResidenceDetail();
                frmInpatientResidenceDetail.dataSet = dataSet;
                frmInpatientResidenceDetail.inpatientResidenceAdapter = inpatientResidenceAdapter;
                frmInpatientResidenceDetail.inpatientResidenceBindingSource = inpatientResidenceBindingSource;
                frmInpatientResidenceDetail.ShowDialog();
            }
            else if (e.ColumnIndex == 1)
            {
                if (inpatientResidenceBindingSource.Count == 0) return;

                var currentRow = inpatientResidenceBindingSource.Current as DataRowView;
                string patientID = Convert.ToString(currentRow.Row["PatientID"]);

                CustomMessageBox result = new CustomMessageBox($"តើលោកអ្នកពិតជាចង់លុប​ព័ត៌មាននៃការស្នាក់នៅរបស់អ្នកជំងឺ #{patientID} មែនដែរឬទេ?");
                result.ShowDialog();
                if (result.DialogResult == DialogResult.OK)
                {
                    //remove all associated records first

                    staffInpatientResidenceAdapter.DeleteCommand.Parameters["@InpatientResidenceID"].Value = Convert.ToInt32(currentRow.Row["InpatientResidenceID"]);

                    staffInpatientResidenceAdapter.DeleteCommand.Connection.Open();
                    staffInpatientResidenceAdapter.DeleteCommand.ExecuteNonQuery();
                    staffInpatientResidenceAdapter.DeleteCommand.Connection.Close();

                    inpatientResidenceBindingSource.RemoveCurrent();
                    inpatientResidenceBindingSource.EndEdit();

                    inpatientResidenceAdapter.Update(dataSet, VIEW_INPATIENT_RESIDENCE_INFO);

                    NotificationUtil.AlertNotificationDelete();
                }
            }
        }

        private void dgvInpatientResidence_Paint(object sender, PaintEventArgs e)
        {
            if (dgvInpatientResidence.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "ព័ត៌មានមិនត្រូវបានស្វែងរកឃើញទេ...",
                    new Font(dgvInpatientResidence.Font.FontFamily, 12, FontStyle.Regular),
                    dgvInpatientResidence.ClientRectangle,
                    dgvInpatientResidence.ForeColor,
                    dgvInpatientResidence.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void searchByPatientID(string patientID)
        {
            inpatientResidenceAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectInpatientResidenceByPatientID",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            inpatientResidenceAdapter.SelectCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6)
               .Direction = ParameterDirection.Input;

            inpatientResidenceAdapter.SelectCommand.Parameters["@PatientID"].Value = patientID;

            dataSet.Tables[VIEW_INPATIENT_RESIDENCE_INFO].Clear();
            inpatientResidenceAdapter.Fill(dataSet);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var currentRow = inpatientResidenceBindingSource.Current as DataRowView;
            string patientID = Convert.ToString(currentRow.Row["PatientID"]);

            searchByPatientID(patientID); 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchEntry.Text)) return;

            if (cbSearchCriteria.SelectedIndex == 0)
            {
                searchByPatientID(txtSearchEntry.Text); 
            }
            else if (cbSearchCriteria.SelectedIndex == 1)
            {

                inpatientResidenceAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchInpatientResidenceInfoByPatientName",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                inpatientResidenceAdapter.SelectCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50)
                   .Direction = ParameterDirection.Input;

                inpatientResidenceAdapter.SelectCommand.Parameters["@Name"].Value = txtSearchEntry.Text;

                dataSet.Tables[VIEW_INPATIENT_RESIDENCE_INFO].Clear();
                inpatientResidenceAdapter.Fill(dataSet);
            }
        }

        private void txtSearchEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch_Click(null, EventArgs.Empty);
                txtSearchEntry.Clear();
            }
        }
    }
}
