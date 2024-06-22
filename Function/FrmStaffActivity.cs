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
    public partial class FrmStaffActivity : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter staffActivityAdapter = new SqlDataAdapter();
        protected BindingSource staffActivityBindingSource = new BindingSource();

        public static string VIEW_STAFF_ACTIVITY_INFO = "vActivityTypeInfo";

        public FrmStaffActivity()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
        }

        private void SetUpCommand()
        {
            // Set up Select command
            staffActivityAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopStaffActivityRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffActivityAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.TinyInt, 0)
                .Direction = ParameterDirection.Input;

            // Set up Iinsert command
            staffActivityAdapter.InsertCommand = new SqlCommand
            {
                CommandText = "spInsertStaffActivityInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffActivityAdapter.InsertCommand.Parameters.Add("@ActivityName", SqlDbType.NVarChar, 50, "ActivityName")
                .Direction = ParameterDirection.Input;
            staffActivityAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            // Set up Update command
            staffActivityAdapter.UpdateCommand = new SqlCommand
            {
                CommandText = "spUpdateStaffActivityInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            var activityTypeIdParam = staffActivityAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@ActivityTypeID", SqlDbType.TinyInt, 0, "ActivityTypeID")
            {
                Direction = ParameterDirection.Input
            });
            activityTypeIdParam.SourceVersion = DataRowVersion.Original;

            staffActivityAdapter.UpdateCommand.Parameters.Add("@ActivityName", SqlDbType.NVarChar, 50, "ActivityName")
                   .Direction = ParameterDirection.Input;
            staffActivityAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            // Set up Delete command
            staffActivityAdapter.DeleteCommand = new SqlCommand
            {
                CommandText = "spDeleteStaffActivityInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffActivityAdapter.DeleteCommand.Parameters.Add(new SqlParameter("@ActivityTypeID", SqlDbType.TinyInt, 0, "ActivityTypeID")
            {
                SourceVersion = DataRowVersion.Original
            });
        }

        private void FillData()
        {
            staffActivityAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 5;
            staffActivityAdapter.TableMappings.Add("Table", VIEW_STAFF_ACTIVITY_INFO);
            staffActivityAdapter.Fill(dataSet);
            staffActivityBindingSource.DataSource = dataSet;
            staffActivityBindingSource.DataMember = VIEW_STAFF_ACTIVITY_INFO;
        }

        private void SetUpBinding()
        {
            //bind to control
            dgvStaffActivity.DataSource = staffActivityBindingSource;
        }

        private void FrmStaffActivity_Load(object sender, EventArgs e)
        {
            cbFilterTopStaffActivityRecord.Items.AddRange(new object[] {
                "ជម្រើស ៥ កំណត់ត្រាដំបូង",
                "ជម្រើស ១០ កំណត់ត្រាដំបូង"
            });
            cbFilterTopStaffActivityRecord.SelectedIndex = 0;

            ListChangeStaffActivityBindingSource();
            staffActivityBindingSource.ListChanged += StaffActivityBindingSource_ListChanged;
        }

        private void ListChangeStaffActivityBindingSource()
        {
            toolStripLblTotalActivity.Text = staffActivityBindingSource.Count.ToString();
        }

        private void StaffActivityBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangeStaffActivityBindingSource();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyStaffActivity frmAddOrModifyStaffActivity = new FrmAddOrModifyStaffActivity
            {
                staffActivityAdapter = staffActivityAdapter,
                staffActivityBindingSource = staffActivityBindingSource,
                isAdded = true
            };
            frmAddOrModifyStaffActivity.ShowDialog();

            if (frmAddOrModifyStaffActivity.DialogResult == DialogResult.OK)
            {
                staffActivityBindingSource.EndEdit();
                staffActivityAdapter.Update(dataSet, VIEW_STAFF_ACTIVITY_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyStaffActivity frmAddOrModifyStaffActivity = new FrmAddOrModifyStaffActivity
            {
                staffActivityAdapter = staffActivityAdapter,
                staffActivityBindingSource = staffActivityBindingSource,
                isAdded = false
            };
            frmAddOrModifyStaffActivity.ShowDialog();

            if (frmAddOrModifyStaffActivity.DialogResult == DialogResult.OK)
            {
                staffActivityBindingSource.EndEdit();
                staffActivityBindingSource.ResetCurrentItem();
                staffActivityAdapter.Update(dataSet, VIEW_STAFF_ACTIVITY_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (staffActivityBindingSource.Count == 0) return;

            if (!(staffActivityBindingSource.Current is DataRowView currentRow)) return;

            byte activityTypeID = Convert.ToByte(currentRow.Row["ActivityTypeID"]);
            string activityName = Convert.ToString(currentRow.Row["ActivityName"]);

            CustomMessageBox result = new CustomMessageBox($"តើលោកអ្នកពិតជាចង់លុបព័ត៌មានសកម្មភាព #{activityTypeID} ({activityName}) មែនដែរឬទេ?");
            result.ShowDialog();

            if (result.DialogResult == DialogResult.OK)
            {
                staffActivityBindingSource.RemoveCurrent();
                staffActivityBindingSource.EndEdit();

                staffActivityAdapter.Update(dataSet, VIEW_STAFF_ACTIVITY_INFO);

                NotificationUtil.AlertNotificationDelete();
            }
        }

        private void cbFilterTopStaffActivityRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            staffActivityAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopStaffActivityRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffActivityAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            staffActivityAdapter.SelectCommand.Parameters["@numberOfRecords"].Value =
                    cbFilterTopStaffActivityRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_STAFF_ACTIVITY_INFO].Clear();
            staffActivityAdapter.Fill(dataSet);
        }

        private void txtSearchStaffActivity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchStaffActivity.Text))
            {
                cbFilterTopStaffActivityRecord_SelectedIndexChanged(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrWhiteSpace(txtSearchStaffActivity.Text)) return;

            staffActivityAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSearchStaffActivityInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffActivityAdapter.SelectCommand.Parameters.Add("@ActivityName", SqlDbType.NVarChar, 50)
               .Direction = ParameterDirection.Input;

            staffActivityAdapter.SelectCommand.Parameters["@ActivityName"].Value = txtSearchStaffActivity.Text;

            dataSet.Tables[VIEW_STAFF_ACTIVITY_INFO].Clear();
            staffActivityAdapter.Fill(dataSet);
        }

        private void txtSearchStaffActivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch_Click(null, EventArgs.Empty);
            }
        }

        private void dgvStaffActivity_Paint(object sender, PaintEventArgs e)
        {
            if (dgvStaffActivity.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "ព័ត៌មានមិនត្រូវបានស្វែងរកឃើញទេ...",
                    new Font(dgvStaffActivity.Font.FontFamily, 12, FontStyle.Regular),
                    dgvStaffActivity.ClientRectangle,
                    dgvStaffActivity.ForeColor,
                    dgvStaffActivity.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

    }
}
