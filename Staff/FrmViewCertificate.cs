using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS.Staff
{
    public partial class FrmViewCertificate : Form
    {
        public FrmViewCertificate(byte[] fileData)
        {
            InitializeComponent();
            LoadFile(fileData);
        }

        public void LoadFile(byte[] fileData)
        {
            using (MemoryStream ms = new MemoryStream(fileData))
            {
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.Visible = true;
            }
        }
    }
}
