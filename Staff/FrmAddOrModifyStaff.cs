using HIMS.Helper;
using HIMS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS.Staff
{
    public partial class FrmAddOrModifyStaff : Form
    {
        protected SqlConnection connection = ConnectionUtil.GetConnection();
        public BindingSource staffBindingSource;
        public SqlDataAdapter staffAdapter;

        protected DataSet dataSet = new DataSet();


        public SqlDataAdapter staffPositionAdapter = new SqlDataAdapter();
        public BindingSource staffPositionBindingSource = new BindingSource();

        public SqlDataAdapter staffSelectAdapter = new SqlDataAdapter();
        public BindingSource staffSelectBindingSource = new BindingSource();

        public SqlDataAdapter staffSearchAdapter = new SqlDataAdapter();
        public BindingSource staffSearchBindingSource = new BindingSource();

        public SqlDataAdapter departmentAdapter = new SqlDataAdapter();
        public BindingSource departmentBindingSource = new BindingSource();

        public SqlDataAdapter specialistAdapter = new SqlDataAdapter();
        public BindingSource specialistBindingSource = new BindingSource();

        public SqlDataAdapter acadeDegreeAdapter = new SqlDataAdapter();
        public BindingSource acadeDegreeBindingSource = new BindingSource();

        public static string VIEW_STAFF_POSITION_SELECT = "vStaffPositionSelect";
        public static string VIEW_STAFF_SELECT = "vStaffSelect";
        public static string FUNCTION_STAFF_SEARCH = "fnSearchStaff";
        public static string VIEW_DEPARTMENT_SELECT = "vDepartmentSelect";
        public static string VIEW_SPECIALIST_SELECT = "vSpecialistSelect";
        public static string VIEW_ACADEMIC_DEGREE_SELECT = "vAcademicDegreeSelect";


        public bool isAdded = false;
        protected bool isValidPhone = false;
        public byte[] photoData = null;
        public byte[] certificateData = null;
        public string gender = "";
        public byte[] fileData = null;


        public FrmAddOrModifyStaff()
        {
            InitializeComponent();
            SetUpCommand();
            FillData();
            SetUpBinding();
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            txtPhoneNumber.Leave += txtPhoneNumber_Leave;
            txtPhoneNumber.Click += txtPhoneNumber_TextChanged;
            linkLabelViewCertificate.Click += LinkLabelViewCertificate_Click;

        }

        private void LinkLabelViewCertificate_Click(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                FrmViewCertificate frmViewCertificate = new FrmViewCertificate(fileData);
                frmViewCertificate.ShowDialog();
            }
            else
            {
                MessageBox.Show("No certificate found for this staff member.");
            }
        }
        protected void SetUpCommand()
        {
            //set up command for tbStaffPosition
            staffPositionAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {VIEW_STAFF_POSITION_SELECT}", this.connection);

            departmentAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {VIEW_DEPARTMENT_SELECT}", this.connection);
            specialistAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {VIEW_SPECIALIST_SELECT}", this.connection);
            acadeDegreeAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {VIEW_ACADEMIC_DEGREE_SELECT}", this.connection);

        }
        protected void FillData()
        {
            // Staff Position
            staffPositionAdapter.TableMappings.Add("Table", VIEW_STAFF_POSITION_SELECT);
            staffPositionAdapter.Fill(dataSet);
            staffPositionBindingSource.DataSource = dataSet;
            staffPositionBindingSource.DataMember = VIEW_STAFF_POSITION_SELECT;


            // Department
            departmentAdapter.TableMappings.Add("Table", VIEW_DEPARTMENT_SELECT);
            departmentAdapter.Fill(dataSet);
            departmentBindingSource.DataSource = dataSet;
            departmentBindingSource.DataMember = VIEW_DEPARTMENT_SELECT;

            // Specialist
            specialistAdapter.TableMappings.Add("Table", VIEW_SPECIALIST_SELECT);
            specialistAdapter.Fill(dataSet);
            specialistBindingSource.DataSource = dataSet;
            specialistBindingSource.DataMember = VIEW_SPECIALIST_SELECT;

            // Academic Degree
            acadeDegreeAdapter.TableMappings.Add("Table", VIEW_ACADEMIC_DEGREE_SELECT);
            acadeDegreeAdapter.Fill(dataSet);
            acadeDegreeBindingSource.DataSource = dataSet;
            acadeDegreeBindingSource.DataMember = VIEW_ACADEMIC_DEGREE_SELECT;

        }
        protected void SetUpBinding()
        {
            cbPosition.DisplayMember = "StaffPositionName";
            cbPosition.ValueMember = "StaffPositionID";
            cbPosition.DataSource = staffPositionBindingSource;

            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DataSource = departmentBindingSource;

            cbSpecialist.DisplayMember = "SpecialistName";
            cbSpecialist.ValueMember = "SpecialistID";
            cbSpecialist.DataSource = specialistBindingSource;

            cbAcadeDegree.DisplayMember = "AcadeDegreeName";
            cbAcadeDegree.ValueMember = "AcadeDegreeID";
            cbAcadeDegree.DataSource = acadeDegreeBindingSource;

            cbWorkShift.Items.AddRange(new object[]
            {
                "វេនថ្ងៃ",
                "វេនយប់"
            });
            cbWorkShift.SelectedIndex = -1;
        }
        protected string GetReportedToName(int staffID)
        {
            string reportedToName = null;
            try
            {
                // Create a SqlCommand to call the function
                SqlCommand command = new SqlCommand("SELECT dbo.fnGetReportedToName(@StaffID) AS ReportedToName", connection);
                command.Parameters.AddWithValue("@StaffID", staffID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    reportedToName = reader["ReportedToName"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                Console.WriteLine($"Error retrieving ReportedToName: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return reportedToName;
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            photo.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
            photo.FilterIndex = 2;
            photo.RestoreDirectory = true;

            if (photo.ShowDialog() == DialogResult.OK)
            {
                string filePath = photo.FileName;
                photoData = File.ReadAllBytes(filePath);
                pictureBoxPhoto.Image = Image.FromFile(filePath);
                pictureBoxPhoto.Tag = filePath;

                btnChoosePhoto.Visible = false;
                btnUpdate.Visible = true;
                btnDeletePhoto.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnChoosePhoto_Click(sender, e);
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            CustomMessageBox result = new CustomMessageBox($"តើលោកអ្នកពិតជាចង់លុប​រូបថតបុគ្គលិកនេះ​មែនដែរឬទេ?\n" +
                $"សកម្មភាពនេះមិនអាចត្រលប់មកវិញបានទេ");
            if (result.ShowDialog() == DialogResult.OK)
            {
                photoData = null;
                pictureBoxPhoto.Image.Dispose();
                pictureBoxPhoto.Image = null;

                btnDeletePhoto.Visible = false;
                btnUpdate.Visible = false;
                btnChoosePhoto.Visible = true;
            }
        }

        private void FrmAddOrModifyStaff_Load(object sender, EventArgs e)
        {
            cbPosition.SelectedIndex = -1;
            cbDepartment.SelectedIndex = -1;
            cbSpecialist.SelectedIndex = -1;
            cbAcadeDegree.SelectedIndex = -1;

            if (isAdded)
            {
                //user adds new record
                this.Text = "បញ្ចូលព័ត៌មាន";
                panelTitle.Text = "បញ្ចូលព័ត៌មានបុគ្គលិកថ្មី";
                txtStaffID.TextAlign = HorizontalAlignment.Center;
                txtStaffID.WatermarkText = "កូដនឹងបង្កើតដោយស្វ័យប្រវត្តិ";
            }
            else
            {
                this.Text = "កែប្រែព័ត៌មាន";
                var currentRow = staffBindingSource.Current as DataRowView;

                panelTitle.Text = $"កែប្រែព័ត៌មានបុគ្គលិក #{currentRow.Row["StaffID"]}";
                txtStaffID.TextAlign = HorizontalAlignment.Left;
                txtStaffID.WatermarkText = "";
                txtStaffID.Text = currentRow.Row["StaffID"].ToString();
                txtFirstName.Text = currentRow.Row["FirstName"].ToString();
                txtLastName.Text = currentRow.Row["LastName"].ToString();
                if (currentRow.Row["Gender"].ToString().Equals("ប្រុស"))
                {
                    rdFemale.Checked = false;
                    rdMale.Checked = true;
                }
                else
                {
                    rdMale.Checked = false;
                    rdFemale.Checked = true;
                }
                dateTimeBirthDate.Value = Convert.ToDateTime(currentRow.Row["BirthDate"]);
                txtAddress.Text = currentRow.Row["Address"].ToString();
                txtPhoneNumber.Text = currentRow.Row["PhoneNumber"].ToString();
                dateTimeJoinedDate.Value = Convert.ToDateTime(currentRow.Row["HiredDate"]);
                txtNationalCardID.Text = currentRow.Row["NationalCardID"].ToString();
                txtEmail.Text = currentRow.Row["Email"].ToString().Equals("N/A") ? "" : currentRow.Row["Email"].ToString();
                cbWorkShift.SelectedIndex = currentRow.Row["WorkShift"].ToString().Equals("វេនថ្ងៃ") ? 0 : 1;
                txtSalary.Text = Convert.ToDecimal(currentRow.Row["Salary"]).ToString("0.00");
                txtBankNo.Text = currentRow.Row["BankAccountID"].ToString().Equals("N/A") ? "" : currentRow.Row["BankAccountID"].ToString();
                txtSearchReportedTo.Text = currentRow.Row["ReportTo"].ToString();
                if (currentRow.Row["ReportTo"] != DBNull.Value)
                {
                    txtReportedToName.Text = GetReportedToName(Convert.ToInt16(currentRow["ReportTo"]));
                }
                else
                {
                    txtReportedToName.Text = string.Empty;
                }
                if (Convert.ToByte(currentRow.Row["StopWork"]) == 1) checkBoxStopWork.Checked = true;
                else checkBoxStopWork.Checked = false;
                if (currentRow.Row["LeaveDate"] != DBNull.Value)
                {
                    dateTimeStopWork.Value = Convert.ToDateTime(currentRow.Row["LeaveDate"]);
                }
                cbPosition.SelectedValue = currentRow.Row["StaffPositionID"];
                if (currentRow.Row["AcadeDegreeID"] != DBNull.Value) cbAcadeDegree.SelectedValue = currentRow.Row["AcadeDegreeID"];
                if (currentRow.Row["SpecialistID"] != DBNull.Value) cbSpecialist.SelectedValue = currentRow.Row["SpecialistID"];
                if (currentRow.Row["DepartmentID"] != DBNull.Value) cbDepartment.SelectedValue = currentRow.Row["DepartmentID"];

                if (currentRow.Row["Photo"] != DBNull.Value && currentRow.Row["Photo"] is byte[] photoData)
                {
                    // Convert the byte array to an image
                    using (MemoryStream ms = new MemoryStream(photoData))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBoxPhoto.Image = image;
                    }
                    btnChoosePhoto.Visible = false;
                    btnUpdate.Visible = true;
                    btnDeletePhoto.Visible = true;
                }
                else
                {
                    // Handle the case where there is no photo
                    pictureBoxPhoto.Image = null;
                }

                if (currentRow.Row["Certificate"] != DBNull.Value && currentRow.Row["Certificate"] is byte[] data)
                {
                    fileData = data;
                    linkLabelViewCertificate.Visible = true;

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validation
            if (!ValidateUtil.ValidateTextBox(txtFirstName, "Warning", "សូមវាយបញ្ចូលនាមត្រកូលជាមុនសិន") ||
               !ValidateUtil.ValidateTextBox(txtLastName, "Warning", "សូមវាយបញ្ចូលនាមខ្លួនជាមុនសិន") ||
               !ValidateUtil.ValidateTextBox(txtNationalCardID, "Warning", "សូមវាយបញ្ចូលលេខអត្តសញ្ញាណប័ណ្ណជាមុនសិន"))
            {
                return;
            }

            if (!rdMale.Checked && !rdFemale.Checked)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមបញ្ចូលជ្រើសរើសភេទរបស់បុគ្គលិក", Color.Yellow);
                return;
            }
            if (rdMale.Checked) gender = "M";
            if (rdFemale.Checked) gender = "F";

            if (cbPosition.SelectedIndex == -1)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមបញ្ចូលជ្រើសរើសមុខតំណែងរបស់បុគ្គលិក", Color.Yellow);
                return;
            }
            if (dateTimeBirthDate.Value == null || dateTimeBirthDate.Value == DateTime.MinValue)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមជ្រើសរើសថ្ងៃខែឆ្នាំកំណើតរបស់បុគ្គលិក", Color.Yellow);
                dateTimeBirthDate.Focus();
                return;
            }
            if (dateTimeJoinedDate.Value == null || dateTimeJoinedDate.Value == DateTime.MinValue)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមជ្រើសរើសកាលបរិច្ឆេទចូលបម្រើការងាររបស់បុគ្គលិក", Color.Yellow);
                dateTimeJoinedDate.Focus();
                return;
            }
            if (!isValidPhone && txtPhoneNumber.Text.Length < 8)
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមបញ្ចូលលេខទូរសព្ទឱ្យបានត្រឹមត្រូវ", Color.Yellow);
                txtPhoneNumber.Focus();
                return;
            }

            var addressValue = new object();
            if (string.IsNullOrWhiteSpace(txtAddress.Text) || txtAddress.Text.Equals("N/A"))
                addressValue = DBNull.Value;
            else addressValue = txtAddress.Text;

            var emailValue = new object();

            //&& !ValidateUtil.IsValidEmail(txtEmail.Text)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) )
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមបញ្ចូលអ៊ីម៉ែលឱ្យបានត្រឹមត្រូវ", Color.Yellow);
                txtEmail.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text.Equals("N/A")) emailValue = DBNull.Value;
            else emailValue = txtEmail.Text;

            //&& !ValidateUtil.IsValidNumericInput(txtNationalCardID.Text)
            //if (!string.IsNullOrWhiteSpace(txtNationalCardID.Text) )
            //{
            //    NotificationUtil.AlertNotificationWarning("Warning", "សូមបញ្ចូលលេខអត្តសញ្ញាណបណ្ណឱ្យបានត្រឹមត្រូវ", Color.Yellow);
            //    txtNationalCardID.Focus();
            //    return;
            //}

            var backAccNoValue = new object();

            //&& !ValidateUtil.IsValidNumericInput(txtBankNo.Text)
            if (!string.IsNullOrEmpty(txtBankNo.Text) )
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមបញ្ចូលលេខលេខកុងធនាគារឱ្យបានត្រឹមត្រូវ", Color.Yellow);
                txtBankNo.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtBankNo.Text) || txtBankNo.Text.Equals("N/A")) backAccNoValue = DBNull.Value;
            else backAccNoValue = txtBankNo.Text;

            decimal salaryValue;
            if (!decimal.TryParse(txtSalary.Text, out salaryValue))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "សូមបញ្ចូលចំនួនប្រាក់ខែឱ្យបានត្រឹមត្រូវ", Color.Yellow);
                txtSalary.Focus();
                return;
            }

            var photoValue = new object();
            if (pictureBoxPhoto.Image == null) photoValue = DBNull.Value;
            else photoValue = photoData;

            var certificateValue = new object();
            if (certificateData == null) certificateValue = DBNull.Value;
            else certificateValue = certificateData;

            var stopWorkDateValue = new object();
            if (dateTimeStopWork.Value == DateTime.MinValue || dateTimeStopWork.Value == null) stopWorkDateValue = DBNull.Value;
            else stopWorkDateValue = dateTimeStopWork.Value;

            var reportedToID = new object();

            if (!string.IsNullOrWhiteSpace(txtSearchReportedTo.Text))
            {
                reportedToID = Convert.ToInt16(txtSearchReportedTo.Text);
            }
            else reportedToID = DBNull.Value;
            if (isAdded)
            {
                staffBindingSource.AddNew();

                var newRow = staffBindingSource.Current as DataRowView;
                newRow.Row.ItemArray = new object[]
                {
                    DBNull.Value,
                    txtFirstName.Text,
                    txtLastName.Text,
                    $"{txtFirstName.Text} {txtLastName.Text}",
                    gender,
                    dateTimeBirthDate.Value,
                    txtAddress.Text,
                    txtPhoneNumber.Text,
                    emailValue,
                    txtNationalCardID.Text,
                    cbDepartment.SelectedIndex != -1 ? cbDepartment.SelectedValue : DBNull.Value,
                    certificateValue,
                    dateTimeJoinedDate.Value,
                    checkBoxStopWork.Checked ? 1 : 0,
                    stopWorkDateValue,
                    cbWorkShift.SelectedItem,
                    salaryValue,
                    backAccNoValue,
                    reportedToID,
                    photoValue,
                    cbAcadeDegree.SelectedIndex != -1 ? cbAcadeDegree.SelectedValue : DBNull.Value,
                    cbPosition.SelectedValue,
                    cbSpecialist.SelectedIndex != -1 ? cbSpecialist.SelectedValue : DBNull.Value
                };
            }
            else
            {
                var currentRow = staffBindingSource.Current as DataRowView;
                currentRow.Row.ItemArray = new object[]
                {
                    DBNull.Value,
                    txtFirstName.Text,
                    txtLastName.Text,
                    $"{txtFirstName.Text} {txtLastName.Text}",
                    gender,
                    dateTimeBirthDate.Value,
                    txtAddress.Text,
                    txtPhoneNumber.Text,
                    emailValue,
                    txtNationalCardID.Text,
                    cbDepartment.SelectedIndex != -1 ? cbDepartment.SelectedValue : DBNull.Value,
                    certificateValue,
                    dateTimeJoinedDate.Value,
                    checkBoxStopWork.Checked ? 1 : 0,
                    stopWorkDateValue,
                    cbWorkShift.SelectedItem,
                    salaryValue,
                    backAccNoValue,
                    reportedToID,
                    photoValue,
                    cbAcadeDegree.SelectedIndex != -1 ? cbAcadeDegree.SelectedValue : DBNull.Value,
                    cbPosition.SelectedValue,
                    cbSpecialist.SelectedIndex != -1 ? cbSpecialist.SelectedValue : DBNull.Value
                };
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            staffBindingSource.CancelEdit();
            Close();
        }
        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            string prefix = "+855(0)";
            int actualLength = txtPhoneNumber.Text.Length - prefix.Length;

            if (actualLength <= 0)
            {
                txtPhoneNumber.Text = "";
                isValidPhone = false;
                return;
            }
            else isValidPhone = true;

            if (actualLength < 8 || actualLength > 9)
            {
                isValidPhone = false;
                NotificationUtil.AlertNotificationWarning("Warning", "លេខទូរសព្ទត្រូវមានយ៉ាងតិច8-9ខ្ទង់", Color.Yellow);
                txtPhoneNumber.Focus();
                return;
            }
            else isValidPhone = true;

        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string prefix = "+855(0)";
            if (!txtPhoneNumber.Text.StartsWith(prefix))
            {
                if (txtPhoneNumber.Text.Length == 1 && char.IsDigit(txtPhoneNumber.Text[0]))
                {
                    txtPhoneNumber.Text = prefix + txtPhoneNumber.Text;
                    txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length;
                }
                else if (txtPhoneNumber.Text.Length < prefix.Length)
                {
                    txtPhoneNumber.Text = prefix;
                    txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length;
                }
            }

            int maxLength = prefix.Length + 9;
            if (txtPhoneNumber.Text.Length > maxLength)
            {
                txtPhoneNumber.Text = txtPhoneNumber.Text.Substring(0, maxLength);
                txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length;
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog certificate = new OpenFileDialog())
            {
                certificate.Filter = "All files (*.*)|*.*|Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png;*.gif";
                certificate.FilterIndex = 1;
                certificate.RestoreDirectory = true;
                if (certificate.ShowDialog() == DialogResult.OK)
                {
                    string filePath = certificate.FileName;
                    certificateData = File.ReadAllBytes(filePath);
                    lblCertificateName.Text = Path.GetFileName(filePath);
                    linkLabelViewCertificate.Visible = true;
                }
                else
                {
                    lblCertificateName.Text = "(.png, .jpg, .jpeg)";
                    linkLabelViewCertificate.Visible = false;
                }
            }
        }

        private void txtSearchReportedTo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearchReportedTo.Text)) return;

                if (txtSearchReportedTo.Text.Length > 4)
                {
                    NotificationUtil.AlertNotificationWarning("Warning", "លេខសម្គាល់បុគ្គលិកមិនត្រឹមត្រូវ", Color.Yellow);
                    txtSearchReportedTo.Clear();
                    return;
                }

                // Initialize or reset dataSet and staffSearchAdapter if needed
                DataSet dataSetReportedTo = new DataSet();

                if (staffSearchAdapter == null)
                {
                    staffSearchAdapter = new SqlDataAdapter();
                }

                staffSearchAdapter.SelectCommand = new SqlCommand
                {
                    CommandText = $"SELECT * FROM {FUNCTION_STAFF_SEARCH}(@StaffID)",
                    CommandType = CommandType.Text,
                    Connection = this.connection
                };

                staffSearchAdapter.SelectCommand.Parameters.Add("@StaffID", SqlDbType.SmallInt, 0).Value = Convert.ToInt16(txtSearchReportedTo.Text);

                // Fill dataSet with data
                staffSearchAdapter.Fill(dataSetReportedTo, "tbSearchStaff");

                // Bind dataSet to staffSearchBindingSource
                staffSearchBindingSource.DataSource = dataSetReportedTo;
                staffSearchBindingSource.DataMember = "tbSearchStaff";

                if (staffSearchBindingSource.Count == 0)
                {
                    txtReportedToName.Text = "លេខកូដបុគ្គលិកមិនមានក្នុងប្រព័ន្ធ"; // Display message when no results found
                }
                else
                {
                    RefreshStaffInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshStaffInfo()
        {
            if (staffSearchBindingSource == null || staffSearchBindingSource.Count == 0)
            {
                txtReportedToName.Clear();
                return;
            }

            var currentStaff = staffSearchBindingSource.Current as DataRowView;

            if (currentStaff != null && currentStaff.Row != null)
            {
                txtReportedToName.Text = currentStaff.Row["FullName"].ToString();
            }
            else
            {
                txtReportedToName.Clear();
            }
        }

        private void txtSearchReportedTo_Leave(object sender, EventArgs e)
        {
            if (staffSearchBindingSource.Count == 0)
            {
                txtSearchReportedTo.Clear(); // Clear txtSearchReportedTo only if no search results were found
                txtReportedToName.Clear();
            }
        }

        private void checkBoxStopWork_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStopWork.Checked)
            {
                dateTimeStopWork.Enabled = true;
            }
            else
            {
                dateTimeStopWork.Enabled = false;
            }
        }
    }
}
