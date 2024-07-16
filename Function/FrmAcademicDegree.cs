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
    public partial class FrmAcademicDegree : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter acadeDegreeAdapter = new SqlDataAdapter();
        protected BindingSource acadeDegreeBindingSource = new BindingSource();
        public static string VIEW_ACADEMIC_DEGREE_INFO = "vAcademicDegreeInfo";
        public FrmAcademicDegree()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
        }

        private void SetUpCommand()
        {
            // Set up Select command
            acadeDegreeAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopAcademicDegreeRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            acadeDegreeAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.TinyInt, 0)
                .Direction = ParameterDirection.Input;

            // Set up Iinsert command
            acadeDegreeAdapter.InsertCommand = new SqlCommand
            {
                CommandText = "spInsertAcademicDegreeInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            acadeDegreeAdapter.InsertCommand.Parameters.Add("@AcadeDegreeName", SqlDbType.NVarChar, 50, "AcadeDegreeName")
                .Direction = ParameterDirection.Input;
            acadeDegreeAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            // Set up Update command
            acadeDegreeAdapter.UpdateCommand = new SqlCommand
            {
                CommandText = "spUpdateAcademicDegreeInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            var acadeDegreeIDParam = acadeDegreeAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@AcadeDegreeID", SqlDbType.TinyInt, 0, "AcadeDegreeID")
            {
                Direction = ParameterDirection.Input
            });
            acadeDegreeIDParam.SourceVersion = DataRowVersion.Original;

            acadeDegreeAdapter.UpdateCommand.Parameters.Add("@AcadeDegreeName", SqlDbType.NVarChar, 50, "AcadeDegreeName")
                   .Direction = ParameterDirection.Input;
            acadeDegreeAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            // Set up Delete command
            acadeDegreeAdapter.DeleteCommand = new SqlCommand
            {
                CommandText = "spDeleteAcademicDegreeInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            acadeDegreeAdapter.DeleteCommand.Parameters.Add(new SqlParameter("@AcadeDegreeID", SqlDbType.TinyInt, 0, "AcadeDegreeID")
            {
                SourceVersion = DataRowVersion.Original
            });
        }

        private void FillData()
        {
            acadeDegreeAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 5;
            acadeDegreeAdapter.TableMappings.Add("Table", VIEW_ACADEMIC_DEGREE_INFO);
            dataSet.Clear();
            acadeDegreeAdapter.Fill(dataSet);
            acadeDegreeBindingSource.DataSource = dataSet;
            acadeDegreeBindingSource.DataMember = VIEW_ACADEMIC_DEGREE_INFO;
        }

        private void SetUpBinding()
        {
            //bind to control
            dgvAcadeDegree.DataSource = acadeDegreeBindingSource;
        }

        private void FrmAcademicDegree_Load(object sender, EventArgs e)
        {
            cbFilterTopAcadeDegreeRecord.Items.AddRange(new object[] {
                "ជម្រើស ៥ កំណត់ត្រាដំបូង",
                "ជម្រើស ១០ កំណត់ត្រាដំបូង"
            });
            cbFilterTopAcadeDegreeRecord.SelectedIndex = 0;

            ListChangeAcadeDegreeBindingSource();
            acadeDegreeBindingSource.ListChanged += acadeDegreeBindingSource_ListChanged;
        }

        private void ListChangeAcadeDegreeBindingSource()
        {
            toolStripLblTotalAcadeDegree.Text = acadeDegreeBindingSource.Count.ToString();
        }

        private void acadeDegreeBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangeAcadeDegreeBindingSource();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyAcademicDegree frmAddOrModifyAcademicDegree = new FrmAddOrModifyAcademicDegree
            {
                acadeDegreeAdapter = acadeDegreeAdapter,
                acadeDegreeBindingSource = acadeDegreeBindingSource,
                isAdded = true
            };
            frmAddOrModifyAcademicDegree.ShowDialog();

            if (frmAddOrModifyAcademicDegree.DialogResult == DialogResult.OK)
            {
                acadeDegreeBindingSource.EndEdit();
                acadeDegreeAdapter.Update(dataSet, VIEW_ACADEMIC_DEGREE_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyAcademicDegree frmAddOrModifyAcademicDegree = new FrmAddOrModifyAcademicDegree
            {
                acadeDegreeAdapter = acadeDegreeAdapter,
                acadeDegreeBindingSource = acadeDegreeBindingSource,
                isAdded = false
            };
            frmAddOrModifyAcademicDegree.ShowDialog();

            if (frmAddOrModifyAcademicDegree.DialogResult == DialogResult.OK)
            {
                acadeDegreeBindingSource.EndEdit();
                acadeDegreeBindingSource.ResetCurrentItem();
                acadeDegreeAdapter.Update(dataSet, VIEW_ACADEMIC_DEGREE_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (acadeDegreeBindingSource.Count == 0) return;

            if (!(acadeDegreeBindingSource.Current is DataRowView currentRow)) return;

            byte AcadeDegreeID = Convert.ToByte(currentRow.Row["AcadeDegreeID"]);
            string AcadeDegreeName = Convert.ToString(currentRow.Row["AcadeDegreeName"]);

            CustomMessageBox result = new CustomMessageBox($"តើលោកអ្នកពិតជាចង់លុប ព័ត៌មាន #{AcadeDegreeID} ({AcadeDegreeName}) មែនដែរឬទេ?");
            result.ShowDialog();

            if (result.DialogResult == DialogResult.OK)
            {
                acadeDegreeBindingSource.RemoveCurrent();
                acadeDegreeBindingSource.EndEdit();

                acadeDegreeAdapter.Update(dataSet, VIEW_ACADEMIC_DEGREE_INFO);

                NotificationUtil.AlertNotificationDelete();
            }
        }

        private void cbFilterTopAcadeDegreeRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            acadeDegreeAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopAcademicDegreeRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            acadeDegreeAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            acadeDegreeAdapter.SelectCommand.Parameters["@numberOfRecords"].Value =
                    cbFilterTopAcadeDegreeRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_ACADEMIC_DEGREE_INFO].Clear();
            acadeDegreeAdapter.Fill(dataSet);
        }

        private void txtSearchAcadeDegree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch_Click(null, EventArgs.Empty);

            }
        }
        private void txtSearchAcadeDegree_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchAcadeDegree.Text))
            {
                cbFilterTopAcadeDegreeRecord_SelectedIndexChanged(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrWhiteSpace(txtSearchAcadeDegree.Text)) return;

            acadeDegreeAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSearchAcademicDegreeInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            acadeDegreeAdapter.SelectCommand.Parameters.Add("@AcadeDegreeName", SqlDbType.NVarChar, 50)
               .Direction = ParameterDirection.Input;

            acadeDegreeAdapter.SelectCommand.Parameters["@AcadeDegreeName"].Value = txtSearchAcadeDegree.Text;

            dataSet.Tables[VIEW_ACADEMIC_DEGREE_INFO].Clear();
            acadeDegreeAdapter.Fill(dataSet);
        }

        private void dgvAcadeDegree_Paint(object sender, PaintEventArgs e)
        {
            if (dgvAcadeDegree.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "មិនមានព័ត៌មានត្រូវបង្ហាញទេ",
                    new Font(dgvAcadeDegree.Font.FontFamily, 12, FontStyle.Regular),
                    dgvAcadeDegree.ClientRectangle,
                    dgvAcadeDegree.ForeColor,
                    dgvAcadeDegree.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }
    }
}
