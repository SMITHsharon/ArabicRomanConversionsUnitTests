using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    class RomanNumeralConverter
    {
        public string Convert(int numberToConvert)
        {
            if (numberToConvert == 1)
            {
                return "I";
            }
            else if (numberToConvert == 2)
            {
                return "II";
            }
            else if (numberToConvert == 3)
            {
                return "III";
            }

            return "";

        }
    }
}

