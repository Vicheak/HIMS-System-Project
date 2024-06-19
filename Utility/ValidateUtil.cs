using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS.Utility
{
    internal class ValidateUtil
    {
        public static bool ValidateTextBox(TextBox textBox, string title, string message) 
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                NotificationUtil.AlertNotificationWarning(title, message, Color.Yellow);
                textBox.Focus();
                return false; 
            }
            return true; 
        }
    }
}
