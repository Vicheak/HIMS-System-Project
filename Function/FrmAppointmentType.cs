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
    public partial class FrmAppointmentType : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter appointmentTypeAdapter = new SqlDataAdapter();
        protected BindingSource appointmentTypeBindingSource = new BindingSource();

        public static string VIEW_APPOINTMENT_TYPE_INFO = "vAppointmentTypeInfo";
        public FrmAppointmentType()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
        }

        private void SetUpCommand()
        {
            // Set up Select command
            appointmentTypeAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopAppointmentTypeRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            appointmentTypeAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.TinyInt, 0)
                .Direction = ParameterDirection.Input;

            // Set up Iinsert command
            appointmentTypeAdapter.InsertCommand = new SqlCommand
            {
                CommandText = "spInsertAppointmentTypeInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            appointmentTypeAdapter.InsertCommand.Parameters.Add("@AppointmentTypeName", SqlDbType.NVarChar, 50, "AppointmentTypeName")
                .Direction = ParameterDirection.Input;
            appointmentTypeAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            // Set up Update command
            appointmentTypeAdapter.UpdateCommand = new SqlCommand
            {
                CommandText = "spUpdateAppointmentTypeInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            var appointmentTypeIDParam = appointmentTypeAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@AppointmentTypeID", SqlDbType.TinyInt, 0, "AppointmentTypeID")
            {
                Direction = ParameterDirection.Input
            });
            appointmentTypeIDParam.SourceVersion = DataRowVersion.Original;

            appointmentTypeAdapter.UpdateCommand.Parameters.Add("@AppointmentTypeName", SqlDbType.NVarChar, 50, "AppointmentTypeName")
                   .Direction = ParameterDirection.Input;
            appointmentTypeAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            // Set up Delete command
            appointmentTypeAdapter.DeleteCommand = new SqlCommand
            {
                CommandText = "spDeleteAppointmentTypeInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            appointmentTypeAdapter.DeleteCommand.Parameters.Add(new SqlParameter("@AppointmentTypeID", SqlDbType.TinyInt, 0, "AppointmentTypeID")
            {
                SourceVersion = DataRowVersion.Original
            });
        }

        private void FillData()
        {
            appointmentTypeAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 5;
            appointmentTypeAdapter.TableMappings.Add("Table", VIEW_APPOINTMENT_TYPE_INFO);
            dataSet.Clear();
            appointmentTypeAdapter.Fill(dataSet);
            appointmentTypeBindingSource.DataSource = dataSet;
            appointmentTypeBindingSource.DataMember = VIEW_APPOINTMENT_TYPE_INFO;
        }

        private void SetUpBinding()
        {
            //bind to control
            dgvAppointmentType.DataSource = appointmentTypeBindingSource;
        }

        private void FrmAppointmentType_Load(object sender, EventArgs e)
        {
            cbFilterTopAppointmentTypeRecord.Items.AddRange(new object[] {
                "ជម្រើស ៥ កំណត់ត្រាដំបូង",
                "ជម្រើស ១០ កំណត់ត្រាដំបូង"
            });
            cbFilterTopAppointmentTypeRecord.SelectedIndex = 0;

            ListChangeappointmentTypeBindingSource();
            appointmentTypeBindingSource.ListChanged += appointmentTypeBindingSource_ListChanged;
        }

        private void ListChangeappointmentTypeBindingSource()
        {
            toolStripLblTotalAppointmentType.Text = appointmentTypeBindingSource.Count.ToString();
        }

        private void appointmentTypeBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangeappointmentTypeBindingSource();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyAppointmentType frmAddOrModifyAppointmentType = new FrmAddOrModifyAppointmentType
            {
                appointmentTypeAdapter = appointmentTypeAdapter,
                appointmentTypeBindingSource = appointmentTypeBindingSource,
                isAdded = true
            };
            frmAddOrModifyAppointmentType.ShowDialog();

            if (frmAddOrModifyAppointmentType.DialogResult == DialogResult.OK)
            {
                appointmentTypeBindingSource.EndEdit();
                appointmentTypeAdapter.Update(dataSet, VIEW_APPOINTMENT_TYPE_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyAppointmentType frmAddOrModifyAppointmentType = new FrmAddOrModifyAppointmentType
            {
                appointmentTypeAdapter = appointmentTypeAdapter,
                appointmentTypeBindingSource = appointmentTypeBindingSource,
                isAdded = false
            };
            frmAddOrModifyAppointmentType.ShowDialog();

            if (frmAddOrModifyAppointmentType.DialogResult == DialogResult.OK)
            {
                appointmentTypeBindingSource.EndEdit();
                appointmentTypeBindingSource.ResetCurrentItem();
                appointmentTypeAdapter.Update(dataSet, VIEW_APPOINTMENT_TYPE_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (appointmentTypeBindingSource.Count == 0) return;

            if (!(appointmentTypeBindingSource.Current is DataRowView currentRow)) return;

            byte AppointmentTypeID = Convert.ToByte(currentRow.Row["AppointmentTypeID"]);
            string AppointmentTypeName = Convert.ToString(currentRow.Row["AppointmentTypeName"]);

            CustomMessageBox result = new CustomMessageBox($"តើលោកអ្នកពិតជាចង់លុប ព័ត៌មាន #{AppointmentTypeID} ({AppointmentTypeName}) មែនដែរឬទេ?");
            result.ShowDialog();

            if (result.DialogResult == DialogResult.OK)
            {
                appointmentTypeBindingSource.RemoveCurrent();
                appointmentTypeBindingSource.EndEdit();

                appointmentTypeAdapter.Update(dataSet, VIEW_APPOINTMENT_TYPE_INFO);

                NotificationUtil.AlertNotificationDelete();
            }
        }

        private void cbFilterTopAppointmentTypeRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointmentTypeAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopAppointmentTypeRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            appointmentTypeAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            appointmentTypeAdapter.SelectCommand.Parameters["@numberOfRecords"].Value =
                    cbFilterTopAppointmentTypeRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_APPOINTMENT_TYPE_INFO].Clear();
            appointmentTypeAdapter.Fill(dataSet);
        }

        private void txtSearchAppointmentType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch_Click(null, EventArgs.Empty);

            }
        }
        private void txtSearchAppointmentType_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchAppointmentType.Text))
            {
                cbFilterTopAppointmentTypeRecord_SelectedIndexChanged(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrWhiteSpace(txtSearchAppointmentType.Text)) return;

            appointmentTypeAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSearchAppointmentTypeInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            appointmentTypeAdapter.SelectCommand.Parameters.Add("@AppointmentTypeName", SqlDbType.NVarChar, 50)
               .Direction = ParameterDirection.Input;

            appointmentTypeAdapter.SelectCommand.Parameters["@AppointmentTypeName"].Value = txtSearchAppointmentType.Text;

            dataSet.Tables[VIEW_APPOINTMENT_TYPE_INFO].Clear();
            appointmentTypeAdapter.Fill(dataSet);
        }

        private void dgvAppointmentType_Paint(object sender, PaintEventArgs e)
        {
            if (dgvAppointmentType.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "មិនមានព័ត៌មានត្រូវបង្ហាញទេ",
                    new Font(dgvAppointmentType.Font.FontFamily, 12, FontStyle.Regular),
                    dgvAppointmentType.ClientRectangle,
                    dgvAppointmentType.ForeColor,
                    dgvAppointmentType.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }
    }
}
