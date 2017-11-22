using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberConverter.Test
{
    [TestClass]
    public class ArabicToRomanNumeralsTest
    {
        [TestMethod]
        public void when_1_is_passed_I_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(1);

            //assert
            Assert.AreEqual("I", result);
        }


        [TestMethod]
        public void when_3_is_passed_III_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(3);

            //assert
            Assert.AreEqual("III", result);
        }


        [TestMethod]
        public void when_4_is_passed_IV_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(4);

            //assert
            Assert.AreEqual("IV", result);
        }


        [TestMethod]
        public void when_5_is_passed_V_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(5);

            //assert
            Assert.AreEqual("V", result);
        }


        [TestMethod]
        public void when_6_is_passed_VI_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(6);

            //assert
            Assert.AreEqual("VI", result);
        }


        [TestMethod]
        public void when_8_is_passed_VIII_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(8);

            //assert
            Assert.AreEqual("VIII", result);
        }


        [TestMethod]
        public void when_10_is_passed_X_should_be_returned()
        { 
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(10);

            //assert
            Assert.AreEqual("X", result);
        }


        [TestMethod]
        public void when_23_is_passed_XXIII_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(23);

            //assert
            Assert.AreEqual("XXIII", result);
        }


        [TestMethod]
        public void when_24_is_passed_XXIV_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(24);

            //assert
            Assert.AreEqual("XXIV", result);
        }


        [TestMethod]
        public void when_49_is_passed_XLIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(49);

            //assert
            Assert.AreEqual("XLIX", result);
        }


        [TestMethod]
        public void when_89_is_passed_LXXXIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(89);

            //assert
            Assert.AreEqual("LXXXIX", result);
        }


        [TestMethod]
        public void when_99_is_passed_XCIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(99);

            //assert
            Assert.AreEqual("XCIX", result);
        }


        [TestMethod]
        public void when_111_is_passed_CXI_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(111);

            //assert
            Assert.AreEqual("CXI", result);
        }


        [TestMethod]
        public void when_449_is_passed_CDXLIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(449);

            //assert
            Assert.AreEqual("CDXLIX", result);
        }


        [TestMethod]
        public void when_984_is_passed_CMLXXXIV_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(984);

            //assert
            Assert.AreEqual("CMLXXXIV", result);
        }


        [TestMethod]
        public void when_999_is_passed_CMXCIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(999);

            //assert
            Assert.AreEqual("CMXCIX", result);
        }


        [TestMethod]
        public void when_1000_is_passed_M_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(1000);

            //assert
            Assert.AreEqual("M", result);
        }


        [TestMethod]
        public void when_1066_is_passed_MLXVI_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(1066);

            //assert
            Assert.AreEqual("MLXVI", result);
        }


        [TestMethod]
        public void when_1989_is_passed_MCMLXXXIX_should_be_returned()
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
