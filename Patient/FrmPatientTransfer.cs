﻿using HIMS.Helper;
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
    public partial class FrmPatientTransfer : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter inpatientResidenceAdapter = new SqlDataAdapter();
        protected BindingSource inpatientResidenceBindingSource = new BindingSource(); 

        protected SqlDataAdapter patientAdapter = new SqlDataAdapter();
        protected BindingSource patientBindingSource = new BindingSource();

        protected SqlDataAdapter roomTypeAdapter = new SqlDataAdapter();
        protected BindingSource roomTypeBindingSource = new BindingSource();

        protected SqlDataAdapter roomAdapter = new SqlDataAdapter();
        protected BindingSource roomBindingSource = new BindingSource();

        protected SqlDataAdapter bedAdapter = new SqlDataAdapter();
        protected BindingSource bedBindingSource = new BindingSource();

        public string TransferPatientID { get; set; }

        public FrmPatientTransfer()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
        }

        private void SetUpCommand()
        {
            //set up command for tbInpatientResidence
            inpatientResidenceAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectInpatientResidenceByPatientID",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            inpatientResidenceAdapter.SelectCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6)
               .Direction = ParameterDirection.Input;

            inpatientResidenceAdapter.UpdateCommand = new SqlCommand
            {
                CommandText = "spTransferInpatientResidence",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };

            inpatientResidenceAdapter.UpdateCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6)
               .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.UpdateCommand.Parameters.Add("@InpatientResidenceID", SqlDbType.Int, 0)
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.UpdateCommand.Parameters.Add("@PreviousBedID", SqlDbType.Int, 0)
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.UpdateCommand.Parameters.Add("@TransferBedID", SqlDbType.Int, 0)
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.UpdateCommand.Parameters.Add("@TransferDate", SqlDbType.DateTime, 0)
                   .Direction = ParameterDirection.Input;
            inpatientResidenceAdapter.UpdateCommand.Parameters.Add("@TransferReason", SqlDbType.NVarChar, 255)
                   .Direction = ParameterDirection.Input; 

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

        }

        protected void FillData()
        {
            roomTypeAdapter.TableMappings.Add("Table", FrmBed.VIEW_ROOM_TYPE_SELECT);
            roomTypeAdapter.Fill(dataSet);
            roomTypeBindingSource.DataSource = dataSet;
            roomTypeBindingSource.DataMember = FrmBed.VIEW_ROOM_TYPE_SELECT;

            dataSet.Tables.Add(new DataTable(FrmBed.VIEW_ROOM_SELECT));
            roomBindingSource.DataSource = dataSet;
            roomBindingSource.DataMember = FrmBed.VIEW_ROOM_SELECT;
        }

        protected void SetUpBinding()
        {
            cbRoomType.DisplayMember = "RoomTypeName";
            cbRoomType.ValueMember = "RoomTypeID";
            cbRoomType.DataSource = roomTypeBindingSource;

            cbRoom.DataSource = roomBindingSource;
            cbRoom.DisplayMember = "RoomNumber";
            cbRoom.ValueMember = "RoomID";
        }

        private void FrmPatientTransfer_Load(object sender, EventArgs e)
        {
            cbPatientGender.Items.AddRange(new object[]
            {
                "ប្រុស",
                "ស្រី"
            });

            if(!string.IsNullOrWhiteSpace(TransferPatientID)){
                txtSearchPatientID.Text = TransferPatientID;
                txtSearchPatientID.ReadOnly = true; 
            }
        }

        private void txtSearchPatientID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchPatientID.Text)) return;
            if (txtSearchPatientID.Text.Length > 6)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "លេខសម្គាល់អ្នកជំងឺមិនត្រឹមត្រូវ", Color.Yellow);
                txtSearchPatientID.Clear();
                return;
            }

            patientAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSearchPatientInfoByID",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };

            patientAdapter.SelectCommand.Parameters.Add("@PatientID", SqlDbType.VarChar, 6)
                .Direction = ParameterDirection.Input;

            patientAdapter.SelectCommand.Parameters["@PatientID"].Value = txtSearchPatientID.Text;
            if (!dataSet.Tables.Contains(FrmPatient.VIEW_PATIENT_INFO))
            {
                patientAdapter.Fill(dataSet, FrmPatient.VIEW_PATIENT_INFO);
                patientBindingSource.DataSource = dataSet;
                patientBindingSource.DataMember = FrmPatient.VIEW_PATIENT_INFO;
            }
            else
            {
                dataSet.Tables[FrmPatient.VIEW_PATIENT_INFO].Clear();
                patientAdapter.Fill(dataSet, FrmPatient.VIEW_PATIENT_INFO);
            }

            RefreshStaffInfo();
        }

        private void RefreshStaffInfo()
        {
            if (patientBindingSource.Count == 0) return;

            var currentPatient = patientBindingSource.Current as DataRowView;

            txtPatientID.Text = currentPatient.Row["PatientID"].ToString();
            txtPatientName.Text = $"{currentPatient.Row["FirstName"].ToString()} {currentPatient.Row["LastName"].ToString()}";
            cbPatientGender.SelectedIndex = currentPatient.Row["GenderKhmer"].ToString().Equals("ប្រុស") ? 0 : 1;
            dateTimePatientBirthDate.Value = Convert.ToDateTime(currentPatient.Row["BirthDate"]);
            txtPatientPhoneNumber.Text = currentPatient.Row["PhoneNumber"].ToString();
            txtPatientMedicalHistory.Text = currentPatient.Row["MedicalHistory"].ToString();

            LoadInpatientResidences(); 
        }

        private void LoadInpatientResidences()
        {
            if (string.IsNullOrWhiteSpace(txtPatientID.Text)) return;

            inpatientResidenceAdapter.SelectCommand.Parameters["@PatientID"].Value = txtPatientID.Text; 

            if (!dataSet.Tables.Contains(FrmInpatientResidence.VIEW_INPATIENT_RESIDENCE_INFO))
            { 
                inpatientResidenceAdapter.TableMappings.Add("Table", FrmInpatientResidence.VIEW_INPATIENT_RESIDENCE_INFO);
                inpatientResidenceAdapter.Fill(dataSet);
                inpatientResidenceBindingSource.DataSource = dataSet;
                inpatientResidenceBindingSource.DataMember = FrmInpatientResidence.VIEW_INPATIENT_RESIDENCE_INFO;
                dgvInpatientResidence.DataSource = inpatientResidenceBindingSource; 
            }
            else
            {
                dataSet.Tables[FrmInpatientResidence.VIEW_INPATIENT_RESIDENCE_INFO].Clear();
                inpatientResidenceAdapter.Fill(dataSet);
            }
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterRoomInfoByRoomTypeID(Convert.ToInt32(cbRoomType.SelectedValue));

            cbRoom.SelectedIndexChanged += CbRoom_SelectedIndexChanged;
        }

        private void CbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBedInfoByRoomID(Convert.ToInt32(cbRoom.SelectedValue));

            cbBed.SelectedIndexChanged += CbBed_SelectedIndexChanged;
        }

        private void CbBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bedBindingSource.Count == 0) return;

            txtBedDescription.Text = cbBed.SelectedValue.ToString();
        }

        private void FilterRoomInfoByRoomTypeID(int roomTypeID)
        {
            dataSet.Tables[FrmBed.VIEW_ROOM_SELECT].Clear();

            roomAdapter.SelectCommand.Parameters["@roomTypeID"].Value = roomTypeID;

            roomAdapter.Fill(dataSet, FrmBed.VIEW_ROOM_SELECT);

            if (dataSet.Tables[FrmBed.VIEW_ROOM_SELECT].Rows.Count == 0)
            {
                cbRoom.DataSource = null;
                if ((string)cbRoom.SelectedItem != "គ្មា​នជម្រើស")
                    cbRoom.Items.Add("គ្មា​នជម្រើស");
                cbRoom.SelectedItem = "គ្មា​នជម្រើស";
            }
            else
            {
                cbRoom.DataSource = roomBindingSource;
                cbRoom.DisplayMember = "RoomNumber";
                cbRoom.ValueMember = "RoomID";
            }
        }

        private void FilterBedInfoByRoomID(int roomID)
        {
            bedAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterBedInfoByRoomID",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            bedAdapter.SelectCommand.Parameters.Add("@roomID", SqlDbType.SmallInt, 0)
               .Direction = ParameterDirection.Input;

            bedAdapter.SelectCommand.Parameters["@roomID"].Value = roomID;

            if (!dataSet.Tables.Contains(FrmBed.VIEW_BED_INFO))
            {
                bedAdapter.TableMappings.Add("Table", FrmBed.VIEW_BED_INFO);
                bedAdapter.Fill(dataSet);
                bedBindingSource.DataSource = dataSet;
                bedBindingSource.DataMember = FrmBed.VIEW_BED_INFO;

                cbBed.Enabled = true;

                //bind to cbBed
                cbBed.DataSource = bedBindingSource;
                cbBed.DisplayMember = "BedID";
                cbBed.ValueMember = "BedDescription";
            }
            else
            {
                dataSet.Tables[FrmBed.VIEW_BED_INFO].Clear();
                bedAdapter.Fill(dataSet, FrmBed.VIEW_BED_INFO);
            }

            if (dataSet.Tables[FrmBed.VIEW_BED_INFO].Rows.Count == 0)
            {
                cbBed.DataSource = null;
                if ((string)cbBed.SelectedItem != "គ្មា​នជម្រើស")
                    cbBed.Items.Add("គ្មា​នជម្រើស");
                cbBed.SelectedItem = "គ្មា​នជម្រើស";

                txtBedDescription.Clear();
            }
            else
            {
                cbBed.DataSource = bedBindingSource;
                cbBed.DisplayMember = "BedID";
                cbBed.ValueMember = "BedDescription";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate
            if (string.IsNullOrWhiteSpace(txtPatientID.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមវាយបញ្ចូលលេខសម្គាល់អ្នកជំងឺ", Color.Yellow);
                txtSearchPatientID.Focus(); 
                return;
            }
            if (cbBed.DataSource == null)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសគ្រែអ្នកជំងឺ", Color.Yellow);
                cbBed.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTransferReason.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមវាយបញ្ចូលការបរិយាយមូលហេតុ", Color.Yellow);
                txtSearchPatientID.Focus();
                return;
            }

            //check if the patient is inpatient 
            SqlCommand cmdCheck = new SqlCommand($"SELECT dbo.fnCheckPatientInpatientResidence('{txtPatientID.Text}');",
                this.connection);
            cmdCheck.Connection.Open();
            var result = cmdCheck.ExecuteScalar();
            if ((bool)result == false)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "អ្នកជំងឺនេះមិនមានប្រវត្តិស្នាក់នៅក្នុងមន្ទីរពេទ្យទេ", Color.Yellow);
                cmdCheck.Connection.Close();
                return;
            }
            cmdCheck.Connection.Close();

            var rowHistory = dgvInpatientResidence.CurrentRow;
            var inpatientResidenceID = rowHistory.Cells["InpatientResidenceID"].Value;
            var roomNumber = rowHistory.Cells["RoomNumber"].Value; 
            var previousBedID = rowHistory.Cells["BedID"].Value;

            CustomMessageBox resultConfirm = new CustomMessageBox($"ផ្ទេរអ្នកជំងឺពីគ្រែលេខ​ #{previousBedID} ក្នុងបន្ទប់ {roomNumber} ទៅគ្រែលេខ #{cbBed.Text} ក្នុងបន្ទប់ {cbRoom.Text}?");
            resultConfirm.ShowDialog();
            if (resultConfirm.DialogResult == DialogResult.OK)
            {
                inpatientResidenceAdapter.UpdateCommand.Parameters["@PatientID"].Value = txtPatientID.Text;
                inpatientResidenceAdapter.UpdateCommand.Parameters["@InpatientResidenceID"].Value = inpatientResidenceID;
                inpatientResidenceAdapter.UpdateCommand.Parameters["@PreviousBedID"].Value = previousBedID;
                inpatientResidenceAdapter.UpdateCommand.Parameters["@TransferBedID"].Value = cbBed.Text;
                inpatientResidenceAdapter.UpdateCommand.Parameters["@TransferDate"].Value = DateTime.Now;
                inpatientResidenceAdapter.UpdateCommand.Parameters["@TransferReason"].Value = txtTransferReason.Text;

                inpatientResidenceAdapter.UpdateCommand.Connection.Open();
                inpatientResidenceAdapter.UpdateCommand.ExecuteNonQuery();
                inpatientResidenceAdapter.UpdateCommand.Connection.Close();

                NotificationUtil.AlertNotificationEdit();
            }
        }

        private void dgvInpatientResidence_Paint(object sender, PaintEventArgs e)
        {
            if (dgvInpatientResidence.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "មិនមានប្រវត្តិស្នាក់នៅក្នុងមន្ទីរពេទ្យ...",
                    new Font(dgvInpatientResidence.Font.FontFamily, 12, FontStyle.Regular),
                    dgvInpatientResidence.ClientRectangle,
                    dgvInpatientResidence.ForeColor,
                    dgvInpatientResidence.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInpatientResidences();    
        }
    }
}