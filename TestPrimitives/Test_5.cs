namespace TestPrimitives
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using EpiProblems;

    [TestClass]
    public class Test_5
    {
        [TestMethod]
        public void Test_5_1_CorrectParity()
        {
            _5.FindParity("1234356");
        }

        [TestMethod]
        public void Test_5_1_InCorrectParity()
        {
        }
    }
}
