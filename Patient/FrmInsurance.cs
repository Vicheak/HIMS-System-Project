using HIMS.Helper;
using HIMS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS.Patient
{
    public partial class FrmInsurance : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();

        protected SqlDataAdapter insuranceAdapter = new SqlDataAdapter();
        protected BindingSource insuranceBindingSource = new BindingSource();

        protected DataSet dataSet = new DataSet();

        public static string VIEW_INSURANCE_INFO = "vInsuranceInfo";

        private bool isAdded = false; 

        public FrmInsurance()
        {
            InitializeComponent();
            SetUpCommand();
            FillData(); 
            SetUpBinding();
        }

        protected void SetUpCommand()
        {
            insuranceAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopInsuranceRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            insuranceAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            insuranceAdapter.InsertCommand = new SqlCommand()
            {
                CommandText = "spInsertInsuranceInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            insuranceAdapter.InsertCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            insuranceAdapter.InsertCommand.Parameters.Add("@PolicyNumber", SqlDbType.NVarChar, 50, "PolicyNumber");
            insuranceAdapter.InsertCommand.Parameters.Add("@EffectiveDate", SqlDbType.DateTime, 0, "EffectiveDate");
            insuranceAdapter.InsertCommand.Parameters.Add("@ExpirationDate", SqlDbType.DateTime, 0, "ExpirationDate");
            insuranceAdapter.InsertCommand.Parameters.Add("@Amount", SqlDbType.Money, 0, "Amount");
            insuranceAdapter.InsertCommand.Parameters.Add("@CompanyContact", SqlDbType.NVarChar, 30, "CompanyContact");
            insuranceAdapter.InsertCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 255, "Description");
            insuranceAdapter.InsertCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6, "PatientID"); 

            insuranceAdapter.UpdateCommand = new SqlCommand()
            {
                CommandText = "spUpdateInsuranceInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            insuranceAdapter.UpdateCommand.Parameters.Add("@InsuranceID", SqlDbType.Int, 0, "InsuranceID");
            insuranceAdapter.UpdateCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            insuranceAdapter.UpdateCommand.Parameters.Add("@PolicyNumber", SqlDbType.NVarChar, 50, "PolicyNumber");
            insuranceAdapter.UpdateCommand.Parameters.Add("@EffectiveDate", SqlDbType.DateTime, 0, "EffectiveDate");
            insuranceAdapter.UpdateCommand.Parameters.Add("@ExpirationDate", SqlDbType.DateTime, 0, "ExpirationDate");
            insuranceAdapter.UpdateCommand.Parameters.Add("@Amount", SqlDbType.Money, 0, "Amount");
            insuranceAdapter.UpdateCommand.Parameters.Add("@CompanyContact", SqlDbType.NVarChar, 30, "CompanyContact");
            insuranceAdapter.UpdateCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 255, "Description");
            insuranceAdapter.UpdateCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6, "PatientID");

            insuranceAdapter.DeleteCommand = new SqlCommand()
            {
                CommandText = "spDeleteInsuranceInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            insuranceAdapter.DeleteCommand.Parameters.Add("@InsuranceID", SqlDbType.Int, 0, "InsuranceID");
        }

        protected void FillData()
        {
            insuranceAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 5;
            insuranceAdapter.TableMappings.Add("Table", VIEW_INSURANCE_INFO); 
            insuranceAdapter.Fill(dataSet);
            insuranceBindingSource.DataSource = dataSet;
            insuranceBindingSource.DataMember = VIEW_INSURANCE_INFO;
        }

        protected void SetUpBinding()
        {
            //Fill data to all text box and data grid views 
            dgvInsurance.DataSource = insuranceBindingSource;

            txtInsuranceID.DataBindings.Add(new Binding("Text", insuranceBindingSource, "InsuranceID"));
            txtCompanyName.DataBindings.Add(new Binding("Text", insuranceBindingSource, "CompanyName"));
            txtPolicyNumber.DataBindings.Add(new Binding("Text", insuranceBindingSource, "PolicyNumber"));
            dateTimeEffectiveDate.DataBindings.Add(new Binding("Text", insuranceBindingSource, "EffectiveDate"));
            dateTimeExpirationDate.DataBindings.Add(new Binding("Text", insuranceBindingSource, "ExpirationDate"));
            txtPatientID.DataBindings.Add(new Binding("Text", insuranceBindingSource, "PatientID")); 
            txtAmount.DataBindings.Add(new Binding("Text", insuranceBindingSource, "Amount"));
            txtCompanyContact.DataBindings.Add(new Binding("Text", insuranceBindingSource, "CompanyContact"));
            txtDescription.DataBindings.Add(new Binding("Text", insuranceBindingSource, "Description"));
        }

        private void FrmInsurance_Load(object sender, EventArgs e)
        {
            cbFilterTopInsuranceRecord.Items.AddRange(new object[] {
                "ជម្រើស ៥ កំណត់ត្រាដំបូង",
                "ជម្រើស ១០ កំណត់ត្រាដំបូង"
            });
            cbFilterTopInsuranceRecord.SelectedIndex = 0;

            ListChangedBindingSource();
            insuranceBindingSource.ListChanged += InsuranceBindingSource_ListChanged;
        }

        private void cbFilterTopInsuranceRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            insuranceAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopInsuranceRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            insuranceAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            insuranceAdapter.SelectCommand.Parameters["@numberOfRecords"].Value =
                    cbFilterTopInsuranceRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_INSURANCE_INFO].Clear();
            insuranceAdapter.Fill(dataSet);
        }

        private void InsuranceBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangedBindingSource();
        }

        private void ListChangedBindingSource()
        {
            toolStripLblTotalInsurance.Text = insuranceBindingSource.Count.ToString();
        }

        private void dgvInsurance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isAdded)
            {
                var current = insuranceBindingSource.Current as DataRowView;
                if (Convert.ToInt32(current.Row["InsuranceID"]) != -1)
                {
                    foreach (DataRow dataRow in dataSet.Tables[VIEW_INSURANCE_INFO].Rows)
                    {
                        if (dataRow.RowState == DataRowState.Deleted) continue;
                        try
                        {
                            if (Convert.ToInt32(dataRow["InsuranceID"]) == -1)
                            {
                                dataSet.Tables[VIEW_INSURANCE_INFO].Rows.Remove(dataRow);
                                isAdded = false;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                    }

                    NotificationUtil.AlertNotificationWarning("warning", "សូមបញ្ចូលព័ត៌មានជាមុនសិន", Color.Yellow);
                }
            }
            if (txtCompanyContact.Equals("N/A")) txtCompanyContact.Clear();
            if (txtDescription.Equals("គ្មានការបរិយាយ")) txtDescription.Clear(); 
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!isAdded)
            {
                var newRow = this.insuranceBindingSource.AddNew() as DataRowView;
                if (newRow != null)
                {
                    newRow.Row["InsuranceID"] = -1;
                    txtInsuranceID.Text = "បង្កើតស្វ័យប្រវត្តិ";
                }
            }
            isAdded = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateUtil.ValidateTextBox(txtCompanyName, "Warning", "មិនមានព័ត៌មានគ្រប់គ្រាន់ដើម្បីរក្សាទុក") ||
               !ValidateUtil.ValidateTextBox(txtPolicyNumber, "Warning", "មិនមានព័ត៌មានគ្រប់គ្រាន់ដើម្បីរក្សាទុក") ||
               !ValidateUtil.ValidateTextBox(txtPatientID, "Warning", "មិនមានព័ត៌មានគ្រប់គ្រាន់ដើម្បីរក្សាទុក") ||
               !ValidateUtil.ValidateTextBox(txtAmount, "Warning", "មិនមានព័ត៌មានគ្រប់គ្រាន់ដើម្បីរក្សាទុក")) return;

            if (string.IsNullOrWhiteSpace(dateTimeEffectiveDate.Text) ||
             string.IsNullOrWhiteSpace(dateTimeExpirationDate.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសកាលបរិច្ឆេទមានប្រសិទ្ធភាពនិងកាលបរិច្ឆេទផុតកំណត់", Color.Yellow);
                dateTimeEffectiveDate.Focus();
                return;
            }
            if (dateTimeEffectiveDate.Value > dateTimeExpirationDate.Value)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសកាលបរិច្ឆេទប្រសិទ្ធភាពនិងផុតកំណត់អោយបានត្រឹមត្រូវ", Color.Yellow);
                dateTimeEffectiveDate.Focus();
                return;
            }

            if (isAdded)
            {
                //check if policy number exists
                SqlCommand cmdCheck = new SqlCommand($"SELECT dbo.fnCheckInsurancePolicyNumber('{txtPolicyNumber.Text}')",
                    this.connection);
                cmdCheck.Connection.Open();
                var result = cmdCheck.ExecuteScalar();
                if ((bool)result == true)
                {
                    NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសលេខ​ Policy សារជាថ្មី,​ ទិទ្នន័យត្រូវបានរកឃើងក្នុងប្រព័ន្អ", Color.Yellow);
                    cmdCheck.Connection.Close();
                    return;
                }
                cmdCheck.Connection.Close();
            }

            //check if patient ID exists
            SqlCommand cmd = new SqlCommand($"EXEC spSearchPatientInfoByPreciseID '{txtPatientID.Text}'", this.connection);
            cmd.Connection.Open(); 
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (!dataReader.Read())
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសលេខកូដអ្នកជំងឺអោយបានត្រឹមត្រូវ", Color.Yellow);
                cmd.Connection.Close();
                return;
            }
            cmd.Connection.Close();

            this.insuranceBindingSource.EndEdit();
            this.insuranceAdapter.Update(dataSet, VIEW_INSURANCE_INFO);

            if (isAdded) 
                NotificationUtil.AlertNotificationInsert();
            else
                NotificationUtil.AlertNotificationEdit();

            isAdded = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (insuranceBindingSource.Count == 0)
            {
                NotificationUtil.AlertNotificationWarning("warning", "មិនមានព័ត៌មានដែលត្រូវលុប", Color.Yellow);
                return;
            }

            var current = insuranceBindingSource.Current as DataRowView;
            CustomMessageBox result = new CustomMessageBox($"តើអ្នកពិតជាចង់លុបព័ត៌មានដែលមានលេខសំគាល់ប័ណ្ណ ({current.Row["InsuranceID"]}) មែនទេ?");
            if (result.ShowDialog() == DialogResult.OK)
            {
                this.insuranceBindingSource.RemoveCurrent();
                this.insuranceBindingSource.EndEdit();

                this.insuranceAdapter.Update(dataSet, VIEW_INSURANCE_INFO);

                NotificationUtil.AlertNotificationDelete();
            }

            isAdded = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.insuranceBindingSource.CancelEdit();
            isAdded = false;
        }

        private void txtSearchEntry_TextChanged(object sender, EventArgs e)
        {
            dataSet.Tables[VIEW_INSURANCE_INFO ].Clear();
            if (!string.IsNullOrWhiteSpace(txtSearchEntry.Text))
            {
                insuranceAdapter.SelectCommand = new SqlCommand()
                {
                    CommandText = "spSearchInsuranceInfo",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                insuranceAdapter.SelectCommand.Parameters.Add("@Search", SqlDbType.NVarChar, 255);
                insuranceAdapter.SelectCommand.Parameters["@Search"].Value = txtSearchEntry.Text;
                insuranceAdapter.Fill(dataSet); 
            }
        }

        private void dgvInsurance_Paint(object sender, PaintEventArgs e)
        {
            if (dgvInsurance.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "ព័ត៌មានមិនត្រូវបានស្វែងរកឃើញទេ...",
                    new Font(dgvInsurance.Font.FontFamily, 12, FontStyle.Regular),
                    dgvInsurance.ClientRectangle,
                    dgvInsurance.ForeColor,
                    dgvInsurance.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }
    }
}
