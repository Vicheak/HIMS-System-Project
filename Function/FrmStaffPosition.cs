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
    public partial class FrmStaffPosition : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter staffPositionAdapter = new SqlDataAdapter();
        protected BindingSource staffPositionBindingSource = new BindingSource();

        public static string VIEW_STAFF_POSITION_INFO = "vStaffPositionInfo";
        public FrmStaffPosition()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
        }

        private void SetUpCommand()
        {
            // Set up Select command
            staffPositionAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopStaffPositionRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffPositionAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.TinyInt, 0)
                .Direction = ParameterDirection.Input;

            // Set up Insert command
            staffPositionAdapter.InsertCommand = new SqlCommand
            {
                CommandText = "spInsertStaffPositionInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffPositionAdapter.InsertCommand.Parameters.Add("@StaffPositionName", SqlDbType.NVarChar, 50, "StaffPositionName")
                .Direction = ParameterDirection.Input;
            staffPositionAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            // Set up Update command
            staffPositionAdapter.UpdateCommand = new SqlCommand
            {
                CommandText = "spUpdateStaffPositionInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            var staffPositionIDParam = staffPositionAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@StaffPositionID", SqlDbType.TinyInt, 0, "StaffPositionID")
            {
                Direction = ParameterDirection.Input
            });
            staffPositionIDParam.SourceVersion = DataRowVersion.Original;

            staffPositionAdapter.UpdateCommand.Parameters.Add("@StaffPositionName", SqlDbType.NVarChar, 50, "StaffPositionName")
                   .Direction = ParameterDirection.Input;
            staffPositionAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            // Set up Delete command
            staffPositionAdapter.DeleteCommand = new SqlCommand
            {
                CommandText = "spDeleteStaffPositionInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffPositionAdapter.DeleteCommand.Parameters.Add(new SqlParameter("@StaffPositionID", SqlDbType.TinyInt, 0, "StaffPositionID")
            {
                SourceVersion = DataRowVersion.Original
            });
        }

        private void FillData()
        {
            staffPositionAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 5;
            staffPositionAdapter.TableMappings.Add("Table", VIEW_STAFF_POSITION_INFO);
            dataSet.Clear();
            staffPositionAdapter.Fill(dataSet);
            staffPositionBindingSource.DataSource = dataSet;
            staffPositionBindingSource.DataMember = VIEW_STAFF_POSITION_INFO;
        }

        private void SetUpBinding()
        {
            //bind to control
            dgvStaffPosition.DataSource = staffPositionBindingSource;
        }

        private void FrmStaffPosition_Load(object sender, EventArgs e)
        {
            cbFilterTopStaffPositionRecord.Items.AddRange(new object[] {
                "ជម្រើស ៥ កំណត់ត្រាដំបូង",
                "ជម្រើស ១០ កំណត់ត្រាដំបូង"
            });
            cbFilterTopStaffPositionRecord.SelectedIndex = 0;

            ListChangestaffPositionBindingSource();
            staffPositionBindingSource.ListChanged += staffPositionBindingSource_ListChanged;
        }

        private void ListChangestaffPositionBindingSource()
        {
            toolStripLblTotalStaffPosition.Text = staffPositionBindingSource.Count.ToString();
        }

        private void staffPositionBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangestaffPositionBindingSource();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyStaffPosition frmAddOrModifyStaffPosition = new FrmAddOrModifyStaffPosition
            {
                staffPositionAdapter = staffPositionAdapter,
                staffPositionBindingSource = staffPositionBindingSource,
                isAdded = true
            };
            frmAddOrModifyStaffPosition.ShowDialog();

            if (frmAddOrModifyStaffPosition.DialogResult == DialogResult.OK)
            {
                staffPositionBindingSource.EndEdit();
                staffPositionAdapter.Update(dataSet, VIEW_STAFF_POSITION_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyStaffPosition frmAddOrModifyStaffPosition = new FrmAddOrModifyStaffPosition
            {
                staffPositionAdapter = staffPositionAdapter,
                staffPositionBindingSource = staffPositionBindingSource,
                isAdded = false
            };
            frmAddOrModifyStaffPosition.ShowDialog();

            if (frmAddOrModifyStaffPosition.DialogResult == DialogResult.OK)
            {
                staffPositionBindingSource.EndEdit();
                staffPositionBindingSource.ResetCurrentItem();
                staffPositionAdapter.Update(dataSet, VIEW_STAFF_POSITION_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (staffPositionBindingSource.Count == 0) return;

            if (!(staffPositionBindingSource.Current is DataRowView currentRow)) return;

            byte StaffPositionID = Convert.ToByte(currentRow.Row["StaffPositionID"]);
            string StaffPositionName = Convert.ToString(currentRow.Row["StaffPositionName"]);

            CustomMessageBox result = new CustomMessageBox($"តើលោកអ្នកពិតជាចង់លុប ព័ត៌មាន #{StaffPositionID} ({StaffPositionName}) មែនដែរឬទេ?");
            result.ShowDialog();

            if (result.DialogResult == DialogResult.OK)
            {
                staffPositionBindingSource.RemoveCurrent();
                staffPositionBindingSource.EndEdit();

                staffPositionAdapter.Update(dataSet, VIEW_STAFF_POSITION_INFO);

                NotificationUtil.AlertNotificationDelete();
            }
        }

        private void cbFilterTopStaffPositionRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            staffPositionAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopStaffPositionRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffPositionAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            staffPositionAdapter.SelectCommand.Parameters["@numberOfRecords"].Value =
                    cbFilterTopStaffPositionRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_STAFF_POSITION_INFO].Clear();
            staffPositionAdapter.Fill(dataSet);
        }

        private void txtSearchStaffPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch_Click(null, EventArgs.Empty);

            }
        }
        private void txtSearchStaffPosition_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchStaffPosition.Text))
            {
                cbFilterTopStaffPositionRecord_SelectedIndexChanged(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrWhiteSpace(txtSearchStaffPosition.Text)) return;

            staffPositionAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSearchStaffPositionInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffPositionAdapter.SelectCommand.Parameters.Add("@StaffPositionName", SqlDbType.NVarChar, 50)
               .Direction = ParameterDirection.Input;

            staffPositionAdapter.SelectCommand.Parameters["@StaffPositionName"].Value = txtSearchStaffPosition.Text;

            dataSet.Tables[VIEW_STAFF_POSITION_INFO].Clear();
            staffPositionAdapter.Fill(dataSet);
        }

        private void dgvStaffPosition_Paint(object sender, PaintEventArgs e)
        {
            if (dgvStaffPosition.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "មិនមានព័ត៌មានត្រូវបង្ហាញទេ",
                    new Font(dgvStaffPosition.Font.FontFamily, 12, FontStyle.Regular),
                    dgvStaffPosition.ClientRectangle,
                    dgvStaffPosition.ForeColor,
                    dgvStaffPosition.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }
    }
}
