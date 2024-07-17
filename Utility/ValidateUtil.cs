using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool IsValidEmail(string email)
        {
            // Regex pattern for a valid email address
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public static bool IsValidNumericInput(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
