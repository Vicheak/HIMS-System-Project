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
    public partial class FrmSpecialist : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter specialistAdapter = new SqlDataAdapter();
        protected BindingSource specialistBindingSource = new BindingSource();

        public static string VIEW_SPECIALIST_INFO = "vSpecialistInfo";
        public FrmSpecialist()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
        }

        private void SetUpCommand()
        {
            // Set up Select command
            specialistAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopSpecialistRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            specialistAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.TinyInt, 0)
                .Direction = ParameterDirection.Input;

            // Set up Iinsert command
            specialistAdapter.InsertCommand = new SqlCommand
            {
                CommandText = "spInsertSpecialistInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            specialistAdapter.InsertCommand.Parameters.Add("@SpecialistName", SqlDbType.NVarChar, 50, "SpecialistName")
                .Direction = ParameterDirection.Input;
            specialistAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            // Set up Update command
            specialistAdapter.UpdateCommand = new SqlCommand
            {
                CommandText = "spUpdateSpecialistInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            var specialistIDParam = specialistAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@SpecialistID", SqlDbType.TinyInt, 0, "SpecialistID")
            {
                Direction = ParameterDirection.Input
            });
            specialistIDParam.SourceVersion = DataRowVersion.Original;

            specialistAdapter.UpdateCommand.Parameters.Add("@SpecialistName", SqlDbType.NVarChar, 50, "SpecialistName")
                   .Direction = ParameterDirection.Input;
            specialistAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, "Description")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            // Set up Delete command
            specialistAdapter.DeleteCommand = new SqlCommand
            {
                CommandText = "spDeleteSpecialistInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            specialistAdapter.DeleteCommand.Parameters.Add(new SqlParameter("@SpecialistID", SqlDbType.TinyInt, 0, "SpecialistID")
            {
                SourceVersion = DataRowVersion.Original
            });
        }

        private void FillData()
        {
            specialistAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 5;
            specialistAdapter.TableMappings.Add("Table", VIEW_SPECIALIST_INFO);
            dataSet.Clear();
            specialistAdapter.Fill(dataSet);
            specialistBindingSource.DataSource = dataSet;
            specialistBindingSource.DataMember = VIEW_SPECIALIST_INFO;
        }

        private void SetUpBinding()
        {
            //bind to control
            dgvSpecialist.DataSource = specialistBindingSource;
        }

        private void FrmSpecialist_Load(object sender, EventArgs e)
        {
            cbFilterTopSpecialistRecord.Items.AddRange(new object[] {
                "ជម្រើស ៥ កំណត់ត្រាដំបូង",
                "ជម្រើស ១០ កំណត់ត្រាដំបូង"
            });
            cbFilterTopSpecialistRecord.SelectedIndex = 0;

            ListChangeSpecialistBindingSource();
            specialistBindingSource.ListChanged += specialistBindingSource_ListChanged;
        }

        private void ListChangeSpecialistBindingSource()
        {
            toolStripLblTotalSpecialist.Text = specialistBindingSource.Count.ToString();
        }

        private void specialistBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangeSpecialistBindingSource();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddOrModifySpecialist frmAddOrModifySpecialist = new FrmAddOrModifySpecialist
            {
                specialistAdapter = specialistAdapter,
                specialistBindingSource = specialistBindingSource,
                isAdded = true
            };
            frmAddOrModifySpecialist.ShowDialog();

            if (frmAddOrModifySpecialist.DialogResult == DialogResult.OK)
            {
                specialistBindingSource.EndEdit();
                specialistAdapter.Update(dataSet, VIEW_SPECIALIST_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddOrModifySpecialist frmAddOrModifySpecialist = new FrmAddOrModifySpecialist
            {
                specialistAdapter = specialistAdapter,
                specialistBindingSource = specialistBindingSource,
                isAdded = false
            };
            frmAddOrModifySpecialist.ShowDialog();

            if (frmAddOrModifySpecialist.DialogResult == DialogResult.OK)
            {
                specialistBindingSource.EndEdit();
                specialistBindingSource.ResetCurrentItem();
                specialistAdapter.Update(dataSet, VIEW_SPECIALIST_INFO);

                NotificationUtil.AlertNotificationInsert();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (specialistBindingSource.Count == 0) return;

            if (!(specialistBindingSource.Current is DataRowView currentRow)) return;

            byte SpecialistID = Convert.ToByte(currentRow.Row["SpecialistID"]);
            string SpecialistName = Convert.ToString(currentRow.Row["SpecialistName"]);

            CustomMessageBox result = new CustomMessageBox($"តើលោកអ្នកពិតជាចង់លុប ព័ត៌មាន #{SpecialistID} ({SpecialistName}) មែនដែរឬទេ?");
            result.ShowDialog();

            if (result.DialogResult == DialogResult.OK)
            {
                specialistBindingSource.RemoveCurrent();
                specialistBindingSource.EndEdit();

                specialistAdapter.Update(dataSet, VIEW_SPECIALIST_INFO);

                NotificationUtil.AlertNotificationDelete();
            }
        }

        private void cbFilterTopSpecialistRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialistAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopSpecialistRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            specialistAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            specialistAdapter.SelectCommand.Parameters["@numberOfRecords"].Value =
                    cbFilterTopSpecialistRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_SPECIALIST_INFO].Clear();
            specialistAdapter.Fill(dataSet);
        }

        private void txtSearchSpecialist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch_Click(null, EventArgs.Empty);

            }
        }
        private void txtSearchSpecialist_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchSpecialist.Text))
            {
                cbFilterTopSpecialistRecord_SelectedIndexChanged(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrWhiteSpace(txtSearchSpecialist.Text)) return;

            specialistAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSearchSpecialistInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            specialistAdapter.SelectCommand.Parameters.Add("@SpecialistName", SqlDbType.NVarChar, 50)
               .Direction = ParameterDirection.Input;

            specialistAdapter.SelectCommand.Parameters["@SpecialistName"].Value = txtSearchSpecialist.Text;

            dataSet.Tables[VIEW_SPECIALIST_INFO].Clear();
            specialistAdapter.Fill(dataSet);
        }

        private void dgvSpecialist_Paint(object sender, PaintEventArgs e)
        {
            if (dgvSpecialist.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "មិនមានព័ត៌មានត្រូវបង្ហាញទេ",
                    new Font(dgvSpecialist.Font.FontFamily, 12, FontStyle.Regular),
                    dgvSpecialist.ClientRectangle,
                    dgvSpecialist.ForeColor,
                    dgvSpecialist.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }
    }
}
