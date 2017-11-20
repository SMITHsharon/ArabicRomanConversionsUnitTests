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
            string romanNumeral = "";
            string onesChar = "I";

            if (numberToConvert >= 1 && numberToConvert <= 3)
            {
                romanNumeral = writeOnes(numberToConvert, romanNumeral, onesChar);
            }

            if (numberToConvert == 4)
            {
                romanNumeral = "IV";
            }

            if (numberToConvert == 5)
            {
                romanNumeral = "V";
            }

            if (numberToConvert >= 6 && numberToConvert <= 9)
            {
                romanNumeral = writeOnes(numberToConvert - 5, "V", onesChar);
            }

            if (numberToConvert == 10)
            {
                romanNumeral = "X";
            }



            return romanNumeral;

        }

        public string writeOnes(int howManyToWrite, string rNumeral, string placeValueChar)
        {
            if (howManyToWrite >= 1 && howManyToWrite <= 3)
            {
                for (var i = 1; i <= howManyToWrite; i++)
                {
                    rNumeral = rNumeral + placeValueChar;
                }
            }
            return rNumeral;
        }
    }
}

