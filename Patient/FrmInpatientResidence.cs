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
    public partial class FrmInpatientResidence : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter inpatientResidenceAdapter = new SqlDataAdapter();
        protected BindingSource inpatientResidenceBindingSource = new BindingSource();

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

        private void btnAssignStaff_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyStaffInpatientResidence frmAddOrModifyStaffInpatientResidence = new FrmAddOrModifyStaffInpatientResidence(); 
            frmAddOrModifyStaffInpatientResidence.inpatientResidenceBindingSource = inpatientResidenceBindingSource;
            frmAddOrModifyStaffInpatientResidence.isAdded = true; 
            frmAddOrModifyStaffInpatientResidence.ShowDialog(); 
        }

        private void dgvInpatientResidence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ColumnIindex = 0 (Detail), 1 (Update), 2 (Delete)
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
              
            }
            else if (e.ColumnIndex == 2)
            {
               
            }
        }
    }
}
