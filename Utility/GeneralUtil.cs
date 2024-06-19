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
    }
}
