using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberConverter.Test
{
    /********************************************/
    /* TEST ROMAN NUMERAL TO ARABIC CONVERSIONS */
    /********************************************/
    [TestClass]
    public class RomanNumeralsToArabicTests
    {
        [TestMethod]
        public void When_I_is_passed_1_should_be_returned()
        {
            //arrange
            var converter = new ArabicConverter();

            //act
            var result = converter.Convert("I");

            //assert
            Assert.AreEqual(1, result);
        }


        [TestMethod]
        public void When_III_is_passed_3_should_be_returned()
        {
            //arrange
            var converter = new ArabicConverter();

            //act
            var result = converter.Convert("III");

            //assert
            Assert.AreEqual(3, result);
        }


        [TestMethod]
        public void When_IV_is_passed_4_should_be_returned()
        {
            //arrange
            var converter = new ArabicConverter();

            //act
            var result = converter.Convert("IV");

            //assert
            Assert.AreEqual(4, result);
        }


        [TestMethod]
        public void When_V_is_passed_5_should_be_returned()
        {
            //arrange
            var converter = new ArabicConverter();

            //act
            var result = converter.Convert("V");

            //assert
            Assert.AreEqual(5, result);
        }


        [TestMethod]
        public void When_VI_is_passed_6_should_be_returned()
        {
            //arrange
            var converter = new ArabicConverter();

            //act
            var result = converter.Convert("VI");

            //assert
            Assert.AreEqual(6, result);
        }


        [TestMethod]
        public void When_VIII_is_passed_8_should_be_returned()
        {
            //arrange
            var converter = new ArabicConverter();

            //act
            var result = converter.Convert("VIII");

            //assert
            Assert.AreEqual(8, result);
        }


        [TestMethod]
        public void When_IX_is_passed_9_should_be_returned()
        {
            //arrange
            var converter = new ArabicConverter();

            //act
            var result = converter.Convert("IX");

            //assert
            Assert.AreEqual(9, result);
        }

    }



    /********************************************/
    /* TEST ARABIC TO ROMAN NUMERAL CONVERSIONS */
    /********************************************/
    [TestClass]
    public class ArabicToRomanNumeralsTest
    {
        
        [TestMethod]
        public void When_1_is_passed_I_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(1);

            //assert
            Assert.AreEqual("I", result);
        }


        [TestMethod]
        public void When_3_is_passed_III_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(3);

            //assert
            Assert.AreEqual("III", result);
        }


        [TestMethod]
        public void When_4_is_passed_IV_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(4);

            //assert
            Assert.AreEqual("IV", result);
        }


        [TestMethod]
        public void When_5_is_passed_V_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(5);

            //assert
            Assert.AreEqual("V", result);
        }


        [TestMethod]
        public void When_6_is_passed_VI_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(6);

            //assert
            Assert.AreEqual("VI", result);
        }


        [TestMethod]
        public void When_8_is_passed_VIII_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(8);

            //assert
            Assert.AreEqual("VIII", result);
        }


        [TestMethod]
        public void When_10_is_passed_X_should_be_returned()
        { 
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(10);

            //assert
            Assert.AreEqual("X", result);
        }


        [TestMethod]
        public void When_23_is_passed_XXIII_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(23);

            //assert
            Assert.AreEqual("XXIII", result);
        }


        [TestMethod]
        public void When_24_is_passed_XXIV_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(24);

            //assert
            Assert.AreEqual("XXIV", result);
        }


        [TestMethod]
        public void When_49_is_passed_XLIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(49);

            //assert
            Assert.AreEqual("XLIX", result);
        }


        [TestMethod]
        public void When_89_is_passed_LXXXIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(89);

            //assert
            Assert.AreEqual("LXXXIX", result);
        }


        [TestMethod]
        public void When_99_is_passed_XCIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(99);

            //assert
            Assert.AreEqual("XCIX", result);
        }


        [TestMethod]
        public void When_111_is_passed_CXI_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(111);

            //assert
            Assert.AreEqual("CXI", result);
        }


        [TestMethod]
        public void When_449_is_passed_CDXLIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(449);

            //assert
            Assert.AreEqual("CDXLIX", result);
        }


        [TestMethod]
        public void When_984_is_passed_CMLXXXIV_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(984);

            //assert
            Assert.AreEqual("CMLXXXIV", result);
        }


        [TestMethod]
        public void When_999_is_passed_CMXCIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(999);

            //assert
            Assert.AreEqual("CMXCIX", result);
        }


        [TestMethod]
        public void When_1000_is_passed_M_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(1000);

            //assert
            Assert.AreEqual("M", result);
        }


        [TestMethod]
        public void When_1066_is_passed_MLXVI_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(1066);

            //assert
            Assert.AreEqual("MLXVI", result);
        }


        [TestMethod]
        public void When_1989_is_passed_MCMLXXXIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(1989);

            //assert
            Assert.AreEqual("MCMLXXXIX", result);
        }
    }
}
