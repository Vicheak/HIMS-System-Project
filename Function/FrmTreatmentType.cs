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
    public partial class FrmTreatmentType : Form
    {
        SqlConnection conn = ConnectionUtil.GetConnection();
        SqlDataAdapter TreatmentTypeAdapter = new SqlDataAdapter();
        BindingSource TreatmentTypeBindingSource = new BindingSource();
        DataSet TreatmentTypeDataset = new DataSet();
        public FrmTreatmentType()
        {
            InitializeComponent();
            SetUp();
            BindingControl();
            Del_Update();
        }
        protected void SetUp()
        {
            TreatmentTypeAdapter.SelectCommand = new SqlCommand("select *from vTreatmentType", conn);
            TreatmentTypeAdapter.Fill(TreatmentTypeDataset, "vTreatmentType");
            TreatmentTypeBindingSource.DataSource = TreatmentTypeDataset;
            TreatmentTypeBindingSource.DataMember = "vTreatmentType";
            dgv.DataSource = TreatmentTypeBindingSource;
        }
        protected void BindingControl()
        {
            txtID.DataBindings.Add(new Binding("Text", TreatmentTypeBindingSource, "TreatmentTypeID"));
            txtName.DataBindings.Add(new Binding("Text", TreatmentTypeBindingSource, "TreatmentTypeName"));
            txtDesc.DataBindings.Add(new Binding("Text", TreatmentTypeBindingSource, "Description"));
        }
        protected void Del_Update()
        {
            // INSERT
            TreatmentTypeAdapter.InsertCommand = new SqlCommand()
            {
                CommandText = "spInsertTreatmentType",
                Connection = conn,
                CommandType = CommandType.StoredProcedure
            };
            TreatmentTypeAdapter.InsertCommand.Parameters.Add("@TreatmentTypeID", SqlDbType.TinyInt, 0, "TreatmentTypeID").Direction = ParameterDirection.Output;

            TreatmentTypeAdapter.InsertCommand.Parameters.Add("@TreatmentTypeName", SqlDbType.NVarChar, 50, "TreatmentTypeName");
            TreatmentTypeAdapter.InsertCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 255, "Description");
            // DELETE
            TreatmentTypeAdapter.DeleteCommand = new SqlCommand()
            {
                CommandText = "SpDeleteTreatmentType",
                Connection = conn,
                CommandType = CommandType.StoredProcedure
            };
            TreatmentTypeAdapter.DeleteCommand.Parameters.Add("@TreatmentTypeID", SqlDbType.TinyInt, 0, "TreatmentTypeID");

            // UPDATE 
            TreatmentTypeAdapter.UpdateCommand = new SqlCommand()
            {
                CommandText = "SpUpdateTreatmentType",
                CommandType = CommandType.StoredProcedure,
                Connection = conn
            };
            TreatmentTypeAdapter.UpdateCommand.Parameters.Add("@TreatmentTypeID", SqlDbType.TinyInt, 0, "TreatmentTypeID");

            TreatmentTypeAdapter.UpdateCommand.Parameters.Add("@TreatmentTypeName", SqlDbType.NVarChar, 50, "TreatmentTypeName");
            TreatmentTypeAdapter.UpdateCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 255, "Description");
        }
        private void TreatmentType_Load(object sender, EventArgs e)
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                NotificationUtil.AlertNotificationWarning("Warning", "មិនអាចរក្សាទុកបាន", Color.Red);
                return;
            }
            TreatmentTypeBindingSource.EndEdit();
            TreatmentTypeAdapter.Update(TreatmentTypeDataset, "vTreatmentType");
            NotificationUtil.AlertNotificationInsert();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.TreatmentTypeBindingSource.AddNew();
            txtID.Text = "កើនដោយស្វ័យប្រវត្ត";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (TreatmentTypeBindingSource.Count == 0)
            {
                NotificationUtil.AlertNotificationWarning("warning", "មិនមានព័ត៌មានដែលត្រូវលុប", Color.Yellow);
                return;
            }
            var current = TreatmentTypeBindingSource.Current as DataRowView;
            CustomMessageBox result = new CustomMessageBox($"តើអ្នកពិតជាចង់លុបព័ត៌មានដែលមានលេខសំគាល់ ({current.Row["TreatmentTypeID"]}) មែនទេ?");
            if (result.ShowDialog() == DialogResult.OK)
            {
                this.TreatmentTypeBindingSource.RemoveCurrent();
                this.TreatmentTypeBindingSource.EndEdit();

                this.TreatmentTypeAdapter.Update(TreatmentTypeDataset, "vTreatmentType");
            }
        }

    }
}
