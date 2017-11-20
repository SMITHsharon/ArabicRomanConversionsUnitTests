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
        public void when_9_is_passed_VIII_should_be_returned()
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
    }
}
