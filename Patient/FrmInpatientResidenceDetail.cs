using HIMS.RoomBed;
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
    public partial class FrmInpatientResidenceDetail : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        public DataSet dataSet = new DataSet();

        public SqlDataAdapter inpatientResidenceAdapter = new SqlDataAdapter();
        public BindingSource inpatientResidenceBindingSource = new BindingSource();

        protected SqlDataAdapter roomTypeAdapter = new SqlDataAdapter();
        protected BindingSource roomTypeBindingSource = new BindingSource();

        protected SqlDataAdapter roomAdapter = new SqlDataAdapter();
        protected BindingSource roomBindingSource = new BindingSource();

        protected SqlDataAdapter bedAdapter = new SqlDataAdapter();
        protected BindingSource bedBindingSource = new BindingSource();

        public FrmInpatientResidenceDetail()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
        }

        protected void SetUpCommand()
        {
            //set up command for tbRoomType
            roomTypeAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {FrmBed.VIEW_ROOM_TYPE_SELECT}",
                this.connection);

            //set up command for tbRoom
            roomAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterRoomInfoByRoomTypeID",
                CommandType = CommandType.StoredProcedure, 
                Connection = this.connection
            };

            roomAdapter.SelectCommand.Parameters.Add("@roomTypeID", SqlDbType.SmallInt, 0)
                .Direction = ParameterDirection.Input;

            //set up command for tbBed
            bedAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterBedInfoByRoomID",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };

            bedAdapter.SelectCommand.Parameters.Add("@roomID", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;
        }

        protected void FillData()
        {
            roomTypeAdapter.TableMappings.Add("Table", FrmBed.VIEW_ROOM_TYPE_SELECT);
            roomTypeAdapter.Fill(dataSet);
            roomTypeBindingSource.DataSource = dataSet;
            roomTypeBindingSource.DataMember = FrmBed.VIEW_ROOM_TYPE_SELECT;
        }

        protected void SetUpBinding()
        {
            cbRoomType.DataSource = roomTypeBindingSource;
            cbRoomType.DisplayMember = "RoomTypeName";
            cbRoomType.ValueMember = "RoomTypeID";
        }

        private void FrmInpatientResidenceDetail_Load(object sender, EventArgs e)
        {
            var currentRow = inpatientResidenceBindingSource.Current as DataRowView;

            txtInpatientResidenceID.Text = currentRow.Row["InpatientResidenceID"].ToString();
            dateTimeAdmissionDate.Value = Convert.ToDateTime(currentRow.Row["AdmissionDate"]);
            dateTimeDischargeDate.Value = Convert.ToDateTime(currentRow.Row["DischargeDate"]);
            txtStatus.Text = currentRow.Row["Status"].ToString();
            txtDescription.Text = currentRow.Row["Description"].ToString();
            txtPatientID.Text = currentRow.Row["PatientID"].ToString();
            txtFullName.Text = currentRow.Row["FullName"].ToString();
            cbRoomType.SelectedValue = currentRow.Row["RoomTypeID"];

            roomAdapter.SelectCommand.Parameters["@roomTypeID"].Value = cbRoomType.SelectedValue;
            roomAdapter.TableMappings.Add("Table", FrmBed.VIEW_ROOM_SELECT);
            roomAdapter.Fill(dataSet);
            roomBindingSource.DataSource = dataSet;
            roomBindingSource.DataMember = FrmBed.VIEW_ROOM_SELECT;

            cbRoom.DataSource = roomBindingSource;
            cbRoom.DisplayMember = "RoomNumber";
            cbRoom.ValueMember = "RoomID";
            cbRoom.SelectedValue = currentRow.Row["RoomID"];

            bedAdapter.SelectCommand.Parameters["@roomID"].Value = cbRoom.SelectedValue;
            bedAdapter.TableMappings.Add("Table", FrmBed.VIEW_BED_INFO);
            bedAdapter.Fill(dataSet);
            bedBindingSource.DataSource = dataSet;
            bedBindingSource.DataMember = FrmBed.VIEW_BED_INFO;

            cbBed.DataSource = bedBindingSource;
            cbBed.DisplayMember = "BedID";
            cbBed.ValueMember = "BedID"; 
            cbBed.SelectedValue = currentRow.Row["BedID"];

            txtBedDescription.Text = currentRow.Row["BedDescription"].ToString(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableUpdate(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateTimeAdmissionDate.Text) || 
                string.IsNullOrWhiteSpace(dateTimeDischargeDate.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសកាលបរិច្ឆេទចូលនិងចេញ", Color.Yellow);
                dateTimeAdmissionDate.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមវាយបញ្ចូលការបរិយាយស្ថានភាពការស្នាក់នៅ", Color.Yellow);
                txtStatus.Focus(); 
                return;
            }
            if (dateTimeAdmissionDate.Value >= dateTimeDischargeDate.Value)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសកាលបរិច្ឆេទចូលនិងចេញរបស់អ្នកជំងឺអោយបានត្រឹមត្រូវ", Color.Yellow);
                dateTimeAdmissionDate.Focus();
                return;
            }

            var descriptionValue = new object();
            if (string.IsNullOrWhiteSpace(txtDescription.Text) || txtDescription.Text.Equals("គ្មា​នការបរិយាយ"))
                descriptionValue = DBNull.Value;
            else descriptionValue = txtDescription.Text;

            var currentRow = inpatientResidenceBindingSource.Current as DataRowView;

            currentRow.Row.ItemArray = new object[]
            {
                txtInpatientResidenceID.Text, 
                dateTimeAdmissionDate.Value, 
                dateTimeDischargeDate.Value, 
                txtStatus.Text, 
                descriptionValue,
                txtPatientID.Text, 
                txtFullName.Text, 
                cbBed.SelectedValue, 
                txtBedDescription.Text, 
                cbRoom.SelectedValue,
                cbRoomType.SelectedValue
            };

            inpatientResidenceBindingSource.EndEdit();
            inpatientResidenceBindingSource.ResetCurrentItem();
            inpatientResidenceAdapter.Update(dataSet, FrmInpatientResidence.VIEW_INPATIENT_RESIDENCE_INFO);

            NotificationUtil.AlertNotificationEdit();

            DisableUpdate(); 
        }

        private void EnableUpdate()
        {
            dateTimeAdmissionDate.Enabled = true;
            dateTimeDischargeDate.Enabled = true;
            txtStatus.ReadOnly = false;
            txtDescription.ReadOnly = false;
        }

        private void DisableUpdate()
        {
            dateTimeAdmissionDate.Enabled = false;
            dateTimeDischargeDate.Enabled = false;
            txtStatus.ReadOnly = true;
            txtDescription.ReadOnly = true;
        }
    }
}
