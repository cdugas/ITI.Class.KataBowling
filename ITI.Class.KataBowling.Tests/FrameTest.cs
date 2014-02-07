using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ITI.Class.BowlORama.Domain;


namespace ITI.Class.BowlORama.Tests
{
    [TestClass]
    public class FrameTest
    {
        Frame target;

        [TestInitialize]
        public void Init()
        {
            target = new Frame();

        }
        //PinsScored Tests
        [TestMethod]
        public void PinsScored_Returns2When1_1()
        {
            //Arrange
            int expected = 2;
            target.Roll1 = 1;
            target.Roll2 = 1;


            //Act
            int actual = target.PinsScored();

            //Assert
            Assert.AreEqual(expected, actual);
        }

         //
        [TestMethod]
        public void SettingRoll1To10SetsStriketoTrue()
        {
            //Arrange
            bool expected = true;
            target.Roll1 = 10;


            //Act
            bool actual = target.IsStrike;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
