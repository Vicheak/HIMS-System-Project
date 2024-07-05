using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS.Utility
{
    internal class GeneralUtil
    {
        public static string GenerateRandomSixDigitString()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString("D6");
        }

        public static bool ContainsAlphabetsAndSpecialChars(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false; // Empty or null string doesn't contain alphabets or special characters
            }

            foreach (char c in str)
            {
                if (char.IsLetter(c) && !char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
