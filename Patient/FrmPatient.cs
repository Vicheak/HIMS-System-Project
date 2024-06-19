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
using HIMS.Helper;
using HIMS.RoomBed;
using HIMS.Utility;

namespace HIMS.Patient
{
    public partial class FrmPatient : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection(); 

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter patientAdapter = new SqlDataAdapter();
        protected BindingSource patientBindingSource = new BindingSource();

        public static string VIEW_PATIENT_INFO = "vPatientInfo";

        public FrmPatient()
        {
            InitializeComponent();
            setUpCommand();
            FillData();
            setUpBinding();
        }

        protected void setUpCommand()
        {
            //set up command for tbPatient
            patientAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopPatientRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            patientAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            patientAdapter.InsertCommand = new SqlCommand
            {
                CommandText = "spInsertPatientInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            patientAdapter.InsertCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6, "PatientID")
                .Direction = ParameterDirection.Input;
            patientAdapter.InsertCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName")
                .Direction = ParameterDirection.Input;
            patientAdapter.InsertCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName")
                .Direction = ParameterDirection.Input;
            patientAdapter.InsertCommand.Parameters.Add("@Gender", SqlDbType.NChar, 1, "Gender")
                .Direction = ParameterDirection.Input;
            patientAdapter.InsertCommand.Parameters.Add("@BirthDate", SqlDbType.Date, 0, "BirthDate")
                .Direction = ParameterDirection.Input;
            patientAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255, "Address")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.InsertCommand.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 20, "PhoneNumber")
                .Direction = ParameterDirection.Input;
            patientAdapter.InsertCommand.Parameters.Add(new SqlParameter("@EmergencyName", SqlDbType.NVarChar, 50, "EmergencyName")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.InsertCommand.Parameters.Add(new SqlParameter("@EmergencyRelation", SqlDbType.NVarChar, 50, "EmergencyRelation")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.InsertCommand.Parameters.Add(new SqlParameter("@EmergencyNumber", SqlDbType.NVarChar, 20, "EmergencyNumber")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.InsertCommand.Parameters.Add(new SqlParameter("@NationalCardID", SqlDbType.NVarChar, 50, "NationalCardID")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.InsertCommand.Parameters.Add("@IsInpatient", SqlDbType.Bit, 0, "IsInpatient")
                .Direction = ParameterDirection.Input;
            patientAdapter.InsertCommand.Parameters.Add(new SqlParameter("@MedicalHistory", SqlDbType.NVarChar, 255, "MedicalHistory")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.InsertCommand.Parameters.Add("@PatientIDOutput", SqlDbType.Char, 6)
                .Direction = ParameterDirection.Output;

            patientAdapter.UpdateCommand = new SqlCommand
            {
                CommandText = "spUpdatePatientInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            patientAdapter.UpdateCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6, "PatientID")
                .Direction = ParameterDirection.Input;
            patientAdapter.UpdateCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName")
                .Direction = ParameterDirection.Input;
            patientAdapter.UpdateCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName")
                .Direction = ParameterDirection.Input;
            patientAdapter.UpdateCommand.Parameters.Add("@Gender", SqlDbType.NChar, 1, "Gender")
                .Direction = ParameterDirection.Input;
            patientAdapter.UpdateCommand.Parameters.Add("@BirthDate", SqlDbType.Date, 0, "BirthDate")
                .Direction = ParameterDirection.Input;
            patientAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255, "Address")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.UpdateCommand.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 20, "PhoneNumber")
                .Direction = ParameterDirection.Input;
            patientAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@EmergencyName", SqlDbType.NVarChar, 50, "EmergencyName")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@EmergencyRelation", SqlDbType.NVarChar, 50, "EmergencyRelation")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@EmergencyNumber", SqlDbType.NVarChar, 20, "EmergencyNumber")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@NationalCardID", SqlDbType.NVarChar, 50, "NationalCardID")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            patientAdapter.UpdateCommand.Parameters.Add("@IsInpatient", SqlDbType.Bit, 0, "IsInpatient")
                .Direction = ParameterDirection.Input;
            patientAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@MedicalHistory", SqlDbType.NVarChar, 255, "MedicalHistory")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });

            patientAdapter.DeleteCommand = new SqlCommand
            {
                CommandText = "spDeletePatientInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            patientAdapter.DeleteCommand.Parameters.Add("@PatientID", SqlDbType.Char, 6, "PatientID")
                .Direction = ParameterDirection.Input;
        }

        protected void FillData()
        {
            patientAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 5;
            patientAdapter.TableMappings.Add("Table", VIEW_PATIENT_INFO);
            patientAdapter.Fill(dataSet);
            patientBindingSource.DataSource = dataSet;
            patientBindingSource.DataMember = VIEW_PATIENT_INFO;
        }

        protected void setUpBinding()
        {
            //bind to control
            dgvPatient.DataSource = patientBindingSource;
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            cbFilterTopPatientRecord.Items.AddRange(new object[] {
                "ជម្រើស ៥ កំណត់ត្រាដំបូង",
                "ជម្រើស ១០ កំណត់ត្រាដំបូង"
            });
            cbFilterTopPatientRecord.SelectedIndex = 0;

            cbSearchCriteria.Items.AddRange(new object[]
            {
                "ស្វែករកតាមលេខកូដអ្នកជំងឺ",
                "ស្វែករកតាមឈ្មោះអ្នកជំងឺ",
                "ស្វែករកតាមអាស័យដ្ឋានអ្នកជំងឺ",
                "ស្វែករកតាមលេខទូរស័ព្ទអ្នកជំងឺ",
                "ស្វែករកតាមព័ត៌មានទាក់ទងបន្ទាន់",
                "ស្វែករកតាមអាស័យដ្ឋានអីមែល",
                "ស្វែករកតាមលេខអត្តសញ្ញាណប័ត្រ",
                "ស្វែករកតាមប្រវត្តិវិជ្ជសាស្រ្ត",
            });
            cbSearchCriteria.SelectedIndex = 0;

            cbFilterPatientGender.Items.AddRange(new object[] {
                "--",
                "ប្រុស",
                "ស្រី"
            });
            cbFilterPatientGender.SelectedIndex = 0;

            cbFilterPatientIsInpatient.Items.AddRange(new object[] {
                "--",
                "ស្នាក់នៅក្នុងមន្ទីរពេទ្យ",
                "ស្នាក់នៅក្រៅមន្ទីរពេទ្យ"
            });
            cbFilterPatientIsInpatient.SelectedIndex = 0; 

            ListChangePatientBindingSource();
            patientBindingSource.ListChanged += PatientBindingSource_ListChanged;
        }

        private void cbFilterTopPatientRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            patientAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopPatientRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            patientAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            patientAdapter.SelectCommand.Parameters["@numberOfRecords"].Value =
                    cbFilterTopPatientRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_PATIENT_INFO].Clear();
            patientAdapter.Fill(dataSet);
        }

        private void btnFilterPatientGroupGender_Click(object sender, EventArgs e)
        {
            //validate
            if (cbFilterPatientGender.Text.Equals("--"))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសភេទអ្នកជំងឺ", Color.Yellow);
                cbFilterPatientGender.Focus();
                return;
            }
            
            patientAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterPatientInfoByTopGender",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            patientAdapter.SelectCommand.Parameters.Add("@Gender", SqlDbType.NVarChar, 5)
               .Direction = ParameterDirection.Input;
            patientAdapter.SelectCommand.Parameters.Add("@Offset", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;
            patientAdapter.SelectCommand.Parameters.Add("@NumberOfRecord", SqlDbType.Int, 0)
               .Direction = ParameterDirection.Input;

            patientAdapter.SelectCommand.Parameters["@Gender"].Value = cbFilterPatientGender.Text; 
            patientAdapter.SelectCommand.Parameters["@Offset"].Value = numericUpDownPatientOffset.Value - 1;
            patientAdapter.SelectCommand.Parameters["@NumberOfRecord"].Value = numericUpDownFilterPatientGroupByGenderAmount.Value;

            dataSet.Tables[VIEW_PATIENT_INFO].Clear();
            patientAdapter.Fill(dataSet);
        }

        private void btnFilterPatientGroupIsInpatient_Click(object sender, EventArgs e)
        {
            //validate
            if (cbFilterPatientIsInpatient.Text.Equals("--"))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសការស្នាក់នៅរបស់អ្នកជំងឺ", Color.Yellow);
                cbFilterPatientIsInpatient.Focus();
                return;
            }

            patientAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterPatientInfoByTopIsInpatient",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            patientAdapter.SelectCommand.Parameters.Add("@IsInpatient", SqlDbType.Bit, 0)
               .Direction = ParameterDirection.Input;
            patientAdapter.SelectCommand.Parameters.Add("@Offset", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;
            patientAdapter.SelectCommand.Parameters.Add("@NumberOfRecord", SqlDbType.Int, 0)
               .Direction = ParameterDirection.Input;

            patientAdapter.SelectCommand.Parameters["@IsInpatient"].Value = cbFilterPatientIsInpatient.SelectedIndex == 1 ? 1 : 0; 
            patientAdapter.SelectCommand.Parameters["@Offset"].Value = numericUpDownPatientOffset.Value - 1;
            patientAdapter.SelectCommand.Parameters["@NumberOfRecord"].Value = numericUpDownFilterPatientGroupByIsInpatientAmount.Value;

            dataSet.Tables[VIEW_PATIENT_INFO].Clear();
            patientAdapter.Fill(dataSet);
        }
        
        private void btnFilterPatientGroupBirthDate_Click(object sender, EventArgs e)
        {
            //validate
            if (string.IsNullOrWhiteSpace(dateTimeFilterPatientStartBirthDate.Text) ||
                string.IsNullOrWhiteSpace(dateTimeFilterPatientEndBirthDate.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសថ្ងៃខែឆ្នាំកំណើតរបស់អ្នកជំងឺ", Color.Yellow);
                dateTimeFilterPatientStartBirthDate.Focus();
                return;
            }
            if(dateTimeFilterPatientStartBirthDate.Value.Day > dateTimeFilterPatientEndBirthDate.Value.Day)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សួមជ្រើសរើសថ្ងៃខែឆ្នាំកំណើតរបស់អ្នកជំងឺអោយបានត្រឹមត្រូវ", Color.Yellow);
                dateTimeFilterPatientStartBirthDate.Focus();
                return;
            }

            patientAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterPatientInfoByBirthDate",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            patientAdapter.SelectCommand.Parameters.Add("@StartBirthDate", SqlDbType.Date, 0)
               .Direction = ParameterDirection.Input;
            patientAdapter.SelectCommand.Parameters.Add("@EndBirthDate", SqlDbType.Date, 0)
                .Direction = ParameterDirection.Input;

            patientAdapter.SelectCommand.Parameters["@StartBirthDate"].Value = dateTimeFilterPatientStartBirthDate.Value;
            patientAdapter.SelectCommand.Parameters["@EndBirthDate"].Value = dateTimeFilterPatientEndBirthDate.Value; 

            dataSet.Tables[VIEW_PATIENT_INFO].Clear();
            patientAdapter.Fill(dataSet);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbFilterPatientGender.SelectedIndex = 0;
            cbFilterPatientIsInpatient.SelectedIndex = 0;
            dateTimeFilterPatientStartBirthDate.Text = "";
            dateTimeFilterPatientEndBirthDate.Text = "";

            cbFilterTopPatientRecord_SelectedIndexChanged(null, EventArgs.Empty);
        }

        private void PatientBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangePatientBindingSource();
        }

        private void ListChangePatientBindingSource()
        {
            toolStripLblTotalPatient.Text = patientBindingSource.Count.ToString();

            int countFemalePatient = 0;
            int countInpatient = 0; 
            foreach (DataRow dataRow in dataSet.Tables[VIEW_PATIENT_INFO].Rows)
            {
                if (dataRow.RowState == DataRowState.Deleted) continue;
                try
                {
                    if (Convert.ToString(dataRow["Gender"]).Equals("ស្រី")) countFemalePatient++;
                    if (Convert.ToBoolean(dataRow["IsInpatient"]) == true) countInpatient++; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            toolStripLblPatientFemale.Text = countFemalePatient.ToString();
            toolStripLblInPatient.Text = countInpatient.ToString();
        }

        private void dgvPatient_Paint(object sender, PaintEventArgs e)
        {
            if (dgvPatient.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "ព័ត៌មានមិនត្រូវបានស្វែងរកឃើញទេ...",
                    new Font(dgvPatient.Font.FontFamily, 12, FontStyle.Regular),
                    dgvPatient.ClientRectangle,
                    dgvPatient.ForeColor,
                    dgvPatient.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //validate
            if (string.IsNullOrWhiteSpace(txtSearchEntry.Text)) return;

            if (cbSearchCriteria.SelectedIndex == 0)
            {
                patientAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchPatientInfoByID",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                patientAdapter.SelectCommand.Parameters.Add("@PatientID", SqlDbType.VarChar, 6)
                   .Direction = ParameterDirection.Input;

                patientAdapter.SelectCommand.Parameters["@PatientID"].Value = txtSearchEntry.Text;
            }
            else if (cbSearchCriteria.SelectedIndex == 1)
            {
                patientAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchPatientInfoByName",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                patientAdapter.SelectCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50)
                   .Direction = ParameterDirection.Input;

                patientAdapter.SelectCommand.Parameters["@Name"].Value = txtSearchEntry.Text;
            }
            else if (cbSearchCriteria.SelectedIndex == 2)
            {
                patientAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchPatientInfoByAddress",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                patientAdapter.SelectCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 255)
                   .Direction = ParameterDirection.Input;

                patientAdapter.SelectCommand.Parameters["@Address"].Value = txtSearchEntry.Text;
            }
            else if (cbSearchCriteria.SelectedIndex == 3)
            {
                patientAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchPatientInfoByPhoneNumber",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                patientAdapter.SelectCommand.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 50)
                   .Direction = ParameterDirection.Input;

                patientAdapter.SelectCommand.Parameters["@PhoneNumber"].Value = txtSearchEntry.Text;
            }
            else if (cbSearchCriteria.SelectedIndex == 4)
            {
                patientAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchPatientInfoByEmergency",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                patientAdapter.SelectCommand.Parameters.Add("@Emergency", SqlDbType.NVarChar, 50)
                   .Direction = ParameterDirection.Input;

                patientAdapter.SelectCommand.Parameters["@Emergency"].Value = txtSearchEntry.Text;
            }
            else if (cbSearchCriteria.SelectedIndex == 5)
            {
                patientAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchPatientInfoByEmail",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                patientAdapter.SelectCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50)
                   .Direction = ParameterDirection.Input;

                patientAdapter.SelectCommand.Parameters["@Email"].Value = txtSearchEntry.Text;
            }
            else if (cbSearchCriteria.SelectedIndex == 6)
            {
                patientAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchPatientInfoByNationalCardID",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                patientAdapter.SelectCommand.Parameters.Add("@NationalCardID", SqlDbType.NVarChar, 50)
                   .Direction = ParameterDirection.Input;

                patientAdapter.SelectCommand.Parameters["@NationalCardID"].Value = txtSearchEntry.Text;
            }
            else if (cbSearchCriteria.SelectedIndex == 7)
            {
                patientAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchPatientInfoByMedicalHistory",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                patientAdapter.SelectCommand.Parameters.Add("@MedicalHistory", SqlDbType.NVarChar, 255)
                   .Direction = ParameterDirection.Input;

                patientAdapter.SelectCommand.Parameters["@MedicalHistory"].Value = txtSearchEntry.Text;
            }

            dataSet.Tables[VIEW_PATIENT_INFO].Clear();
            patientAdapter.Fill(dataSet);
        }

        private void txtSearchEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch_Click(null, EventArgs.Empty);
                txtSearchEntry.Clear();
            }
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ColumnIindex = 0 (Detail), 1 (Update), 2 (Delete)
            if (e.RowIndex == -1) return; 
            if(e.ColumnIndex == 0)
            {
                FrmPatientDetail frmPatientDetail = new FrmPatientDetail();
                frmPatientDetail.dataSet = dataSet; 
                frmPatientDetail.patientAdapter = patientAdapter; 
                frmPatientDetail.patientBindingSource = patientBindingSource; 
                frmPatientDetail.ShowDialog(); 
            }else if (e.ColumnIndex == 1)
            {
                FrmAddOrModifyPatient frmAddOrModifyPatient = new FrmAddOrModifyPatient();
                frmAddOrModifyPatient.patientBindingSource = patientBindingSource;
                frmAddOrModifyPatient.isAdded = false;
                frmAddOrModifyPatient.ShowDialog();

                if (frmAddOrModifyPatient.DialogResult == DialogResult.OK)
                {
                    patientBindingSource.EndEdit();
                    //refresh patient record
                    patientBindingSource.ResetCurrentItem(); 
                    patientAdapter.Update(dataSet, VIEW_PATIENT_INFO);

                    NotificationUtil.AlertNotificationEdit();
                }
            }
            else if(e.ColumnIndex == 2)
            {
                if (patientBindingSource.Count == 0) return;

                var currentRow = patientBindingSource.Current as DataRowView;
                string patientID = Convert.ToString(currentRow.Row["PatientID"]);

                CustomMessageBox result = new CustomMessageBox($"តើលោកអ្នកពិតជាចង់លុប​ព័ត៌មានអ្នកជំងឺ #{patientID} មែនដែរឬទេ?");
                result.ShowDialog();
                if (result.DialogResult == DialogResult.OK)
                {
                    patientBindingSource.RemoveCurrent();
                    patientBindingSource.EndEdit();

                    patientAdapter.Update(dataSet, VIEW_PATIENT_INFO);

                    NotificationUtil.AlertNotificationDelete();
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyPatient frmAddOrModifyPatient = new FrmAddOrModifyPatient();
            frmAddOrModifyPatient.patientBindingSource = patientBindingSource;
            frmAddOrModifyPatient.isAdded = true;
            frmAddOrModifyPatient.ShowDialog();

            if (frmAddOrModifyPatient.DialogResult == DialogResult.OK)
            {
                patientBindingSource.EndEdit();
                patientAdapter.Update(dataSet, VIEW_PATIENT_INFO);

                string patientID = Convert.ToString(patientAdapter.InsertCommand.Parameters["@PatientIDOutput"].Value);

                NotificationUtil.AlertNotificationInsert();

                patientAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = "spSearchPatientInfoByID",
                    CommandType = CommandType.StoredProcedure,
                    Connection = this.connection
                };
                patientAdapter.SelectCommand.Parameters.Add("@PatientID", SqlDbType.VarChar, 6)
                   .Direction = ParameterDirection.Input;

                var currentRow = patientBindingSource.Current as DataRowView;

                patientAdapter.SelectCommand.Parameters["@PatientID"].Value = patientID; 

                dataSet.Tables[VIEW_PATIENT_INFO].Clear();
                patientAdapter.Fill(dataSet);
            }
        }
    }
}
