using HIMS.Helper;
using HIMS.Patient;
using HIMS.RoomBed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS
{
    public partial class Dashboard : Form
    {
        public static Form currentForm = new Form(); 

        public Dashboard()
        {
            InitializeComponent();
        }

        private void PopUpForm(Form form)
        {
            currentForm = form; 

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(form);

            form.Show();
        }

        public static void QuitApp()
        {
            Application.Exit(); 
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            FrmExit frmExit = new FrmExit(); 
            frmExit.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear(); 
        }

        private void btnListBed_Click(object sender, EventArgs e)
        {
            FrmBed frmBed = new FrmBed();
            PopUpForm(frmBed);
        }

        private void btnAddNewBed_Click(object sender, EventArgs e)
        {
            FrmBed frmBed; 
            if (mainPanel.Controls.Contains(currentForm))
            {
                if (!(currentForm is FrmBed))
                {
                    frmBed = new FrmBed(); 
                    PopUpForm(frmBed);
                    frmBed.btnAddNew.PerformClick();
                    return; 
                }
                frmBed = currentForm as FrmBed;
                frmBed.btnAddNew.PerformClick();
                return; 
            }
            frmBed = new FrmBed();
            PopUpForm(frmBed); 
            frmBed.btnAddNew.PerformClick(); 
        }

        private void btnListPatient_Click(object sender, EventArgs e)
        {
            FrmPatient frmPatient = new FrmPatient(); 
            PopUpForm(frmPatient);
        }
    }
}
