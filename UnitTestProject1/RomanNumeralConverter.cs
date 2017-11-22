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
            string four = "IV";
            string five = "V";
            string nine = "IX";
            string tensChar = "X";
            string forty = "XL";
            string fifty = "L";
            string ninety = "XC";
            string hundredsChar = "C";
            string fourHundred = "CD";
            string fiveHundred = "D";
            string nineHundred = "CM";
            string thousandsChar = "M";
            // the thousands chars would actually appear w a bar above, signifying to mult value by 1000
            string fourThousand = "IV";
            string fiveThousand = "V";
            string nineThousand = "IX";

            int placeValueDigit = 0;

            // thousands place
            if (numberToConvert >= 1000 && numberToConvert <= 9999)
            {
                placeValueDigit = numberToConvert / 1000;
                numberToConvert = numberToConvert % 1000;
                romanNumeral = writePlaceValue(placeValueDigit, thousandsChar, fourThousand, fiveThousand, nineThousand);
            }

            // hundreds place
            if (numberToConvert >= 100 && numberToConvert <= 999)
            {
                placeValueDigit = numberToConvert / 100;
                numberToConvert = numberToConvert % 100;
                romanNumeral += writePlaceValue(placeValueDigit, hundredsChar, fourHundred, fiveHundred, nineHundred);
            }

            // tens place
            if (numberToConvert >= 10 && numberToConvert <= 99)
            {
                placeValueDigit = numberToConvert / 10;
                numberToConvert = numberToConvert % 10;
                romanNumeral += writePlaceValue(placeValueDigit, tensChar, forty, fifty, ninety);
            }

            // ones place
            if (numberToConvert >= 1 && numberToConvert <= 9)
            {
                romanNumeral += writePlaceValue(numberToConvert, onesChar, four, five, nine);
            }
                return romanNumeral;
            
        }


        public string writePlaceValue(int numToConvert, 
            string onesChar, string fourChar, string fiveChar, string nineChar)
        {
            string rNumeral = "";

            if (numToConvert >= 1 && numToConvert <= 3)
                rNumeral = writeOnes(numToConvert, rNumeral, onesChar);

            if (numToConvert == 4) rNumeral = fourChar;

            if (numToConvert == 5) rNumeral = fiveChar;

            if (numToConvert >= 6 && numToConvert <= 9)
                rNumeral = writeOnes(numToConvert - 5, fiveChar, onesChar);

            if (numToConvert == 9) rNumeral = nineChar;

            return rNumeral;
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


        /* CONCISE, RECURSIVE SOLUTION
        private static string ConvertToRoman(int convertThis)
        {
            int leftovers;              //store mod results
            string RomanNumeral = "";   //store roman numeral string
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"M", 1000},  // 1000 = M
                {"CM", 900},  // 900 = CM
                {"D", 500},   // 500 = D
                {"CD", 400},  // 400 = CD
                {"C", 100},   // 100 = C
                {"XC", 90},   // 90 = XC
                {"L", 50},    // 50 = L
                {"XL", 40},   // 40 = XL
                {"X", 10},    // 10 = X
                {"IX", 9},    // 9 = IX
                {"V", 5},     // 5 = V
                {"IV", 4},    // 4 = IV
                {"I", 1},     // 1 = I
            };

            foreach (KeyValuePair<string, int> pair in dict)
            {
                if (convertThis >= pair.Value)
                {
                    leftovers = convertThis % pair.Value;
                    int remainder = (convertThis - leftovers) / pair.Value;
                    convertThis = leftovers;
                    while (remainder > 0)
                    {
                        RomanNumeral += pair.Key; remainder--;
                    }
                }
            }
            return RomanNumeral;
        }
        */
    }
}

