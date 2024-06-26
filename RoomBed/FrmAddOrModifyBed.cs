﻿using HIMS.Utility;
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

namespace HIMS.RoomBed
{
    public partial class FrmAddOrModifyBed : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        public SqlDataAdapter bedAdapter;
        public BindingSource bedBindingSource;
        public bool isAdded = false;

        protected SqlDataAdapter roomTypeAdapter = new SqlDataAdapter();
        protected BindingSource roomTypeBindingSource = new BindingSource();

        protected SqlDataAdapter roomAdapter = new SqlDataAdapter();
        protected BindingSource roomBindingSource = new BindingSource();

        public FrmAddOrModifyBed()
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

        private void FrmAddOrModifyBed_Load(object sender, EventArgs e)
        {
            if (isAdded)
            {
                //user adds new record
                panelTitle.Text = "បញ្ចូលព័ត៌មានគ្រែថ្មី";
                txtBedID.TextAlign = HorizontalAlignment.Center; 
                txtBedID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            }
            else
            {
                //user updates existing record
                var currentRow = bedBindingSource.Current as DataRowView;

                panelTitle.Text = $"កែប្រែព័ត៌មានគ្រែ #{currentRow.Row["BedID"]} នៃបន្ទប់ #{currentRow.Row["RoomNumber"]}";
                txtBedID.TextAlign = HorizontalAlignment.Left; 
                txtBedID.WatermarkText = "";
                txtBedID.Text = currentRow.Row["BedID"].ToString();
                cbRoomType.SelectedValue = Convert.ToInt32(currentRow.Row["RoomTypeID"]);
                cbRoom.SelectedValue = Convert.ToInt32(currentRow.Row["RoomID"]);
                checkBoxBedStatus.Checked = Convert.ToInt16(currentRow.Row["Status"]) == 1;
                txtBedDesc.Text = currentRow.Row["BedDescription"].ToString().Equals("គ្មានការបរិយាយ") ? "" :
                    currentRow.Row["BedDescription"].ToString();
            }
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterRoomInfoByRoomTypeID(Convert.ToInt32(cbRoomType.SelectedValue));
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bedBindingSource.CancelEdit();

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate
            if (cbRoom.SelectedValue == null)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមជ្រើសរើសបន្ទប់និងប្រភេទបន្ទប់", Color.Yellow);
                cbRoom.Focus(); 
                return;
            }

            var descriptionValue = new object();
            if (string.IsNullOrWhiteSpace(txtBedDesc.Text) || txtBedDesc.Text.Equals("គ្មានការបរិយាយ"))
                descriptionValue = DBNull.Value;
            else descriptionValue = txtBedDesc.Text;

            if (this.isAdded)
            {
                bedBindingSource.AddNew();

                var currentRow = bedBindingSource.Current as DataRowView;

                currentRow.Row.ItemArray = new object[]
                {
                   DBNull.Value,
                   descriptionValue,
                   checkBoxBedStatus.Checked ? 1 : 0,
                   checkBoxBedStatus.Checked ? "នៅទំនេរ" : "ជាប់រវល់",
                   Convert.ToInt32(cbRoom.SelectedValue),
                   cbRoom.Text,
                   Convert.ToInt32(cbRoomType.SelectedValue)
                };
            }
            else
            {
                var currentRow = bedBindingSource.Current as DataRowView;
                currentRow.Row.ItemArray = new object[]
                {
                   txtBedID.Text,
                   descriptionValue,
                   checkBoxBedStatus.Checked ? 1 : 0,
                   checkBoxBedStatus.Checked ? "នៅទំនេរ" : "ជាប់រវល់",
                   Convert.ToInt32(cbRoom.SelectedValue),
                   cbRoom.Text,
                   Convert.ToInt32(cbRoomType.SelectedValue)
                };
            }

            //close the form itself
            this.DialogResult = DialogResult.OK;
        }
    }
}
