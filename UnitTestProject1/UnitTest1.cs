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
    }
}
