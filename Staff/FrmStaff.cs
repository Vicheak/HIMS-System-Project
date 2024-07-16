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

namespace HIMS.Staff
{
    public partial class FrmStaff : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter staffAdapter = new SqlDataAdapter();
        protected BindingSource staffBindingSource = new BindingSource();

        public SqlDataAdapter staffPositionAdapter = new SqlDataAdapter();
        public BindingSource staffPositionBindingSource = new BindingSource();

        public SqlDataAdapter specialistAdapter = new SqlDataAdapter();
        public BindingSource specialistBindingSource = new BindingSource();

        public static string VIEW_STAFF_INFO = "vStaffInfo";
        public static string VIEW_STAFF_POSITION_SELECT = "vStaffPositionSelect";
        public static string VIEW_SPECIALIST_SELECT = "vSpecialistSelect";
        public FrmStaff()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
        }
        private void SetUpCommand()
        {
            // Set up Select command
            staffAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopStaffRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.TinyInt, 0)
                .Direction = ParameterDirection.Input;

            // Set up Insert command
            staffAdapter.InsertCommand = new SqlCommand
            {
                CommandText = "spInsertStaffInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffAdapter.InsertCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add("@Gender", SqlDbType.Char, 1, "Gender").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add("@BirthDate", SqlDbType.Date, 0, "BirthDate").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255, "Address") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.InsertCommand.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 20, "PhoneNumber").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 30, "Email") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.InsertCommand.Parameters.Add("@NationalCardID", SqlDbType.VarChar, 50, "NationalCardID").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add(new SqlParameter("@DepartmentID", SqlDbType.TinyInt, 0, "DepartmentID") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Certificate", SqlDbType.VarBinary, -1, "Certificate") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.InsertCommand.Parameters.Add("@HiredDate", SqlDbType.DateTime, 0, "HiredDate").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add("@StopWork", SqlDbType.Bit, 0, "StopWork").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add(new SqlParameter("@LeaveDate", SqlDbType.Date, 0, "LeaveDate") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.InsertCommand.Parameters.Add("@WorkShift", SqlDbType.NVarChar, 30, "WorkShift").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add("@Salary", SqlDbType.Money, 0, "Salary").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add(new SqlParameter("@BankAccountID", SqlDbType.VarChar, 30, "BankAccountID") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.InsertCommand.Parameters.Add(new SqlParameter("@ReportTo", SqlDbType.SmallInt, 0, "ReportTo") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary, -1, "Photo") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.InsertCommand.Parameters.Add(new SqlParameter("@AcadeDegreeID", SqlDbType.TinyInt, 0, "AcadeDegreeID") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.InsertCommand.Parameters.Add("@StaffPositionID", SqlDbType.TinyInt, 0, "StaffPositionID").Direction = ParameterDirection.Input;
            staffAdapter.InsertCommand.Parameters.Add(new SqlParameter("@SpecialistID", SqlDbType.TinyInt, 0, "SpecialistID") { IsNullable = true, Direction = ParameterDirection.Input });

            // Set up Update command
            staffAdapter.UpdateCommand = new SqlCommand
            {
                CommandText = "spUpdateStaffInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            var staffIDParam = staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.SmallInt, 0, "StaffID")
            {
                Direction = ParameterDirection.Input
            });
            staffIDParam.SourceVersion = DataRowVersion.Original;
            staffAdapter.UpdateCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add("@Gender", SqlDbType.Char, 1, "Gender").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add("@BirthDate", SqlDbType.Date, 0, "BirthDate").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255, "Address") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.UpdateCommand.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 20, "PhoneNumber").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 30, "Email") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.UpdateCommand.Parameters.Add("@NationalCardID", SqlDbType.VarChar, 50, "NationalCardID").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@DepartmentID", SqlDbType.TinyInt, 0, "DepartmentID") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Certificate", SqlDbType.VarBinary, -1, "Certificate") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.UpdateCommand.Parameters.Add("@HiredDate", SqlDbType.DateTime, 0, "HiredDate").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add("@StopWork", SqlDbType.Bit, 0, "StopWork").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@LeaveDate", SqlDbType.Date, 0, "LeaveDate") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.UpdateCommand.Parameters.Add("@WorkShift", SqlDbType.NVarChar, 30, "WorkShift").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add("@Salary", SqlDbType.Money, 0, "Salary").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@BankAccountID", SqlDbType.VarChar, 30, "BankAccountID") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@ReportTo", SqlDbType.SmallInt, 0, "ReportTo") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary, -1, "Photo") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@AcadeDegreeID", SqlDbType.TinyInt, 0, "AcadeDegreeID") { IsNullable = true, Direction = ParameterDirection.Input });
            staffAdapter.UpdateCommand.Parameters.Add("@StaffPositionID", SqlDbType.TinyInt, 0, "StaffPositionID").Direction = ParameterDirection.Input;
            staffAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@SpecialistID", SqlDbType.TinyInt, 0, "SpecialistID") { IsNullable = true, Direction = ParameterDirection.Input });

            // Set up Delete command
            staffAdapter.DeleteCommand = new SqlCommand
            {
                CommandText = "spDeleteStaffInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffAdapter.DeleteCommand.Parameters.Add("@StaffID", SqlDbType.SmallInt, 0, "StaffID")
                .Direction = ParameterDirection.Input;

            staffPositionAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {VIEW_STAFF_POSITION_SELECT}", this.connection);
            specialistAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {VIEW_SPECIALIST_SELECT}", this.connection);
        }

        private void FillData()
        {
            staffAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 10;
            staffAdapter.TableMappings.Add("Table", VIEW_STAFF_INFO);
            staffAdapter.Fill(dataSet);
            staffBindingSource.DataSource = dataSet;
            staffBindingSource.DataMember = VIEW_STAFF_INFO;

            // Staff Position
            staffPositionAdapter.TableMappings.Add("Table", VIEW_STAFF_POSITION_SELECT);
            staffPositionAdapter.Fill(dataSet);
            staffPositionBindingSource.DataSource = dataSet;
            staffPositionBindingSource.DataMember = VIEW_STAFF_POSITION_SELECT;

            // Specialist
            specialistAdapter.TableMappings.Add("Table", VIEW_SPECIALIST_SELECT);
            specialistAdapter.Fill(dataSet);
            specialistBindingSource.DataSource = dataSet;
            specialistBindingSource.DataMember = VIEW_SPECIALIST_SELECT;
        }

        private void SetUpBinding()
        {
            //bind to control
            dgvStaff.DataSource = staffBindingSource;

            cbFilterStaffPosition.DisplayMember = "StaffPositionName";
            cbFilterStaffPosition.ValueMember = "StaffPositionID";
            cbFilterStaffPosition.DataSource = staffPositionBindingSource;

            cbFilterStaffSpecialist.DisplayMember = "SpecialistName";
            cbFilterStaffSpecialist.ValueMember = "SpecialistID";
            cbFilterStaffSpecialist.DataSource = specialistBindingSource;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyStaff frmAddOrModifyStaff = new FrmAddOrModifyStaff
            {
                staffAdapter = staffAdapter,
                staffBindingSource = staffBindingSource,
                isAdded = true
            };
            frmAddOrModifyStaff.ShowDialog();

            if (frmAddOrModifyStaff.DialogResult == DialogResult.OK)
            {
                staffBindingSource.EndEdit();
                staffAdapter.Update(dataSet, VIEW_STAFF_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ColumnIindex = 0 (Detail), 1 (Update), 2 (Delete)
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 1)
            {
                FrmAddOrModifyStaff frmAddOrModifyStaff = new FrmAddOrModifyStaff();
                frmAddOrModifyStaff.staffBindingSource = staffBindingSource;
                frmAddOrModifyStaff.isAdded = false;
                frmAddOrModifyStaff.ShowDialog();

                if (frmAddOrModifyStaff.DialogResult == DialogResult.OK)
                {
                    staffBindingSource.EndEdit();
                    //refresh staff record
                    staffBindingSource.ResetCurrentItem();
                    staffAdapter.Update(dataSet, VIEW_STAFF_INFO);

                    NotificationUtil.AlertNotificationEdit();
                }
            }
            else if (e.ColumnIndex == 2)
            {
                if (staffBindingSource.Count == 0) return;

                var currentRow = staffBindingSource.Current as DataRowView;
                string staffID = Convert.ToString(currentRow.Row["StaffID"]);

                CustomMessageBox result = new CustomMessageBox($"តើលោកអ្នកពិតជាចង់លុប​ព័ត៌មានបុគ្គលិក #{staffID} មែនដែរឬទេ?");
                result.ShowDialog();
                if (result.DialogResult == DialogResult.OK)
                {
                    staffBindingSource.RemoveCurrent();
                    staffBindingSource.EndEdit();

                    staffAdapter.Update(dataSet, VIEW_STAFF_INFO);

                    NotificationUtil.AlertNotificationDelete();
                }
            }
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            cbFilterTopStaffRecord.Items.AddRange(new object[] {
                "ជម្រើស ៥ កំណត់ត្រាដំបូង",
                "ជម្រើស ១០ កំណត់ត្រាដំបូង"
            });
            cbFilterTopStaffRecord.SelectedIndex = 0;
            cbFilterStaffPosition.SelectedIndex = -1;
            cbFilterStaffSpecialist.SelectedIndex = -1;

            ListChangeStaffBindingSource();
            staffBindingSource.ListChanged += StaffBindingSource_ListChanged;
        }

        private void StaffBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangeStaffBindingSource();
        }

        private void ListChangeStaffBindingSource()
        {
            toolStripLblTotalStaff.Text = staffBindingSource.Count.ToString();

            int countFemale = 0;
            foreach (DataRow dataRow in dataSet.Tables[VIEW_STAFF_INFO].Rows)
            {
                if (dataRow.RowState == DataRowState.Deleted) continue;
                try
                {
                    if (Convert.ToString(dataRow["Gender"]).Equals("ស្រី")) countFemale++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            toolStripLblStaffFemale.Text = countFemale.ToString();
        }

        private void txtSearchStaffName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch_Click(null, EventArgs.Empty);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrWhiteSpace(txtSearchStaffName.Text)) return;

            staffAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSearchStaffInfoByName",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffAdapter.SelectCommand.Parameters.Add("@Search", SqlDbType.NVarChar, 100)
               .Direction = ParameterDirection.Input;

            staffAdapter.SelectCommand.Parameters["@Search"].Value = txtSearchStaffName.Text;

            dataSet.Tables[VIEW_STAFF_INFO].Clear();
            staffAdapter.Fill(dataSet);
        }

        private void dgvStaff_Paint(object sender, PaintEventArgs e)
        {
            if (dgvStaff.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "មិនមានព័ត៌មានត្រូវបង្ហាញទេ",
                    new Font(dgvStaff.Font.FontFamily, 12, FontStyle.Regular),
                    dgvStaff.ClientRectangle,
                    dgvStaff.ForeColor,
                    dgvStaff.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void txtSearchStaffName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchStaffName.Text))
            {
                cbFilterTopStaffRecord_SelectedIndexChanged(sender, e);
            }
        }

        private void cbFilterTopStaffRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            staffAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopStaffRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            staffAdapter.SelectCommand.Parameters["@numberOfRecords"].Value =
                    cbFilterTopStaffRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_STAFF_INFO].Clear();
            staffAdapter.Fill(dataSet);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbFilterStaffPosition.SelectedIndex = 0;
            cbFilterStaffSpecialist.SelectedIndex = 0;
            dateTimeFilterStartBirthDate.Text = "";
            dateTimeFilterEndBirthDate.Text = "";

            cbFilterTopStaffRecord_SelectedIndexChanged(null, EventArgs.Empty);
        }

        private void btnFilterStaffGroupBirthDate_Click(object sender, EventArgs e)
        {
            //validate
            if (string.IsNullOrWhiteSpace(dateTimeFilterStartBirthDate.Text) ||
                string.IsNullOrWhiteSpace(dateTimeFilterEndBirthDate.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសថ្ងៃខែឆ្នាំកំណើតរបស់អ្នកជំងឺ", Color.Yellow);
                dateTimeFilterStartBirthDate.Focus();
                return;
            }
            if (dateTimeFilterStartBirthDate.Value >= dateTimeFilterEndBirthDate.Value)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសថ្ងៃខែឆ្នាំកំណើតរបស់អ្នកជំងឺអោយបានត្រឹមត្រូវ", Color.Yellow);
                dateTimeFilterStartBirthDate.Focus();
                return;
            }

            staffAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterStaffInfoByBirthDate",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffAdapter.SelectCommand.Parameters.Add("@StartBirthDate", SqlDbType.Date, 0)
               .Direction = ParameterDirection.Input;
            staffAdapter.SelectCommand.Parameters.Add("@EndBirthDate", SqlDbType.Date, 0)
                .Direction = ParameterDirection.Input;

            staffAdapter.SelectCommand.Parameters["@StartBirthDate"].Value = dateTimeFilterStartBirthDate.Value;
            staffAdapter.SelectCommand.Parameters["@EndBirthDate"].Value = dateTimeFilterEndBirthDate.Value;

            dataSet.Tables[VIEW_STAFF_INFO].Clear();
            staffAdapter.Fill(dataSet);
        }

        private void cbFilterStaffPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilterStaffPosition_Click(object sender, EventArgs e)
        {
            //validate
            if (cbFilterStaffPosition.Text.Equals("") || string.IsNullOrEmpty(cbFilterStaffPosition.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសមុខតំណែង", Color.Yellow);
                cbFilterStaffPosition.Focus();
                return;
            }

            staffAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterStaffInfoByPosition",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffAdapter.SelectCommand.Parameters.Add("@StaffPositionID", SqlDbType.SmallInt, 0)
               .Direction = ParameterDirection.Input;
            staffAdapter.SelectCommand.Parameters.Add("@Offset", SqlDbType.Int, 0)
               .Direction = ParameterDirection.Input;
            staffAdapter.SelectCommand.Parameters.Add("@NumberOfRecord", SqlDbType.Int, 0)
               .Direction = ParameterDirection.Input;

            staffAdapter.SelectCommand.Parameters["@StaffPositionID"].Value = cbFilterStaffPosition.SelectedValue;
            staffAdapter.SelectCommand.Parameters["@Offset"].Value = numericUpDownStaffOffset.Value - 1;
            staffAdapter.SelectCommand.Parameters["@NumberOfRecord"].Value = numericUpDownFilterStaffGroupByPosition.Value;

            dataSet.Tables[VIEW_STAFF_INFO].Clear();
            staffAdapter.Fill(dataSet);
        }

        private void btnFilterSpecialist_Degree_Click(object sender, EventArgs e)
        {
            //validate
            if (cbFilterStaffSpecialist.Text.Equals("") || string.IsNullOrEmpty(cbFilterStaffSpecialist.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសជំនាញឯកទេស", Color.Yellow);
                cbFilterStaffSpecialist.Focus();
                return;
            }

            staffAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterStaffInfoBySpecialist",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            staffAdapter.SelectCommand.Parameters.Add("@SpecialistID", SqlDbType.SmallInt, 0)
               .Direction = ParameterDirection.Input;
            staffAdapter.SelectCommand.Parameters.Add("@Offset", SqlDbType.Int, 0)
               .Direction = ParameterDirection.Input;
            staffAdapter.SelectCommand.Parameters.Add("@NumberOfRecord", SqlDbType.Int, 0)
               .Direction = ParameterDirection.Input;

            staffAdapter.SelectCommand.Parameters["@SpecialistID"].Value = cbFilterStaffSpecialist.SelectedValue;
            staffAdapter.SelectCommand.Parameters["@Offset"].Value = numericUpDownStaffOffset.Value - 1;
            staffAdapter.SelectCommand.Parameters["@NumberOfRecord"].Value = numericUpDownFilterStaffGroupBySpecialist.Value;

            dataSet.Tables[VIEW_STAFF_INFO].Clear();
            staffAdapter.Fill(dataSet);
        }
    }
}
