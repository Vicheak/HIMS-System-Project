using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS.Patient
{
    public partial class FrmTreatment : Form
    {
        public FrmTreatment()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyTreatment frmAddOrModifyTreatment = new FrmAddOrModifyTreatment();
            frmAddOrModifyTreatment.ShowDialog(); 
        }
    }
}
