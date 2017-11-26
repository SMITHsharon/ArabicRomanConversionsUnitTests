using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    class ArabicConverter
    {
        public int Convert(string arabicToConvert)
        {
            while (arabicToConvert.Length > 0)
            {
                    return GetDigit(arabicToConvert);
            }

            return -1;
        }

        public int GetDigit(string strToConvert)
        {
            int strLength = strToConvert.Length;
            int digitValue = 1;
            int strIndex = 0;

            if ((strLength > 1) && (strToConvert[0] == 'I') && (strToConvert[1] == 'V'))
            {
               return 4; // digitValue
            }

            if ((strLength > 1) && (strToConvert[0] == 'I') && (strToConvert[1] == 'X'))
            {
                return 9; // digitValue
            }

            if (strToConvert[0] == 'V')
            {
                digitValue = 5; // value returns if strLength = 1
            }

            // counts 1, 2, 3, 6, 7, 8
            while (strLength > 1)
            {
                if ((strToConvert[strIndex] == strToConvert[strIndex + 1]) || 
                    (strToConvert[0] == 'V') && (strToConvert[1] == 'I'))
                {
                    digitValue++;
                    strLength--;
                    strIndex++;
                }
            }

            return digitValue;

        }

    }
}
