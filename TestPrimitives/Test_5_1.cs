namespace TestPrimitives
{
    using System;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using EpiProblems;


    [TestClass]
    public class Test_5_1
    {
        [TestMethod]
        public void Test_5_1_OddParity()
        {
            // ‭0001 0010 1101 0101 1011 0100‬
            var res = _5_1.FindParity("1234356");
            var res1 = _5_1.FindParity_1(1234356);
            var res2 = _5_1.FindParity_2(1234356);
            Assert.IsTrue(res == 1);
            Assert.IsTrue(res == res1);
            Assert.IsTrue(res2 == res1);
        }

        [TestMethod]
        public void Test_5_1_EvenParity()
        {
            // 111100011
            var res = _5_1.FindParity("483");
            var res1 = _5_1.FindParity_1(483);
            var res2 = _5_1.FindParity_2(483);
            Assert.IsTrue(res == 0);
            Assert.IsTrue(res == res1);
            Assert.IsTrue(res2 == res1);
        }

        [TestMethod]
        public void Test_5_1_For_Zero()
        {
            // 0
            var res = _5_1.FindParity("0");
            var res1 = _5_1.FindParity_1(0);
            var res2 = _5_1.FindParity_2(0);
            Assert.IsTrue(res == 0);
            Assert.IsTrue(res == res1);
            Assert.IsTrue(res2 == res1);
        }

        [TestMethod]
        public void Test_5_1_For_One()
        {
            // 0
            var res = _5_1.FindParity("1");
            var res1 = _5_1.FindParity_1(1);
            var res2 = _5_1.FindParity_2(1);
            Assert.IsTrue(res == 1);
            Assert.IsTrue(res == res1);
            Assert.IsTrue(res2 == res1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void Test_5_1_For_Null()
        {
            // 0
            var res = _5_1.FindParity("");
        }
    }
}
