namespace TestPrimitives
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using EpiProblems;
    /// <summary>
    /// Summary description for Test_5_7
    /// </summary>
    [TestClass]
    public class Test_5_7
    {
        public Test_5_7()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Test_5_7_Power()
        {
            double ans = _5_7.pow(2, 3);
            double ans1 = _5_7.pow1(2, 3);
            Console.WriteLine(ans);
            Assert.IsTrue(ans == 8);
            Assert.IsTrue(ans == ans1);

        }
        [TestMethod]
        public void Test_5_7_Power1()
        {
            double ans = _5_7.pow(25, 6);
            double ans1 = _5_7.pow1(25, 6);
            Console.WriteLine(ans);
            Assert.IsTrue(ans == 244140625);
            Assert.IsTrue(ans == ans1);
        }
    }
}
