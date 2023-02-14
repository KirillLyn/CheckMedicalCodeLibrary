using CheckMedicalCodeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CheckMedicalCodeTests
{
    [TestClass]
    public class CheckMedicalCodeTestClass
    {
        /// <summary>
        /// Проверка на пустую строку
        /// </summary>
        [TestMethod]
        public void CheckMedicalCode_Empty_False()
        {
            //arrange
            string textString = string.Empty;
            //act
            CheckMedicalCodeClass obj = new CheckMedicalCodeClass();
            bool actual = obj.CheckMedicalCode(textString);
            //assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на нормальную снилс
        /// </summary>
        [TestMethod]
        public void CheckMedicalCode_Norm_True()
        {
            //arrange
            string textString = "112-233-445 95";
            //act
            CheckMedicalCodeClass obj = new CheckMedicalCodeClass();
            bool actual = obj.CheckMedicalCode(textString);
            //assert
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Проверка малое количество цифр
        /// </summary>
        [TestMethod]
        public void CheckMedicalCode_333_False()
        {
            //arrange
            string textString = "333";
            //act
            CheckMedicalCodeClass obj = new CheckMedicalCodeClass();
            bool actual = obj.CheckMedicalCode(textString);
            //assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка большого количества цифр
        /// </summary>
        [TestMethod]
        public void CheckMedicalCode_More11_False()
        {
            //arrange
            string textString = "999999999999999999999";
            //act
            CheckMedicalCodeClass obj = new CheckMedicalCodeClass();
            bool actual = obj.CheckMedicalCode(textString);
            //assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка 15795916329 на правильность. Возвращает true
        /// </summary>
        [TestMethod]
        public void CheckMedicalCode_15795916329_True()
        {
            //arrange
            string textString = "15795916329";
            //act
            CheckMedicalCodeClass obj = new CheckMedicalCodeClass();
            bool actual = obj.CheckMedicalCode(textString);
            //assert
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Проверка  15795916311 на правильность. Возвращает false
        /// </summary>
        [TestMethod]
        public void CheckMedicalCode_15795916311_False()
        {
            //arrange
            string textString = "15795916311";
            //act
            CheckMedicalCodeClass obj = new CheckMedicalCodeClass();
            bool actual = obj.CheckMedicalCode(textString);
            //assert
            Assert.IsFalse(actual);
        }
    }
}
