using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ITI.Class.BowlORama.ScoreSheet.Domain;



namespace FrameTest
{
    [TestClass]
    public class UnitTest1
    {
        Frame target;

        [TestInitialize]
        public void Init()
        {
            target = new Frame();
        }
    }
}
