using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpiProblems;

namespace TestPrimitives
{
    [TestClass]
    public class Test_5_8
    {
        [TestMethod]
        public void Test_5_8_ConvertBase()
        {
            string ans = _5_8.ConvertBase("7FF", 16, 2);
        }
        [TestMethod]
        public void Test_5_8_ConvertBase1()
        {
            _5_8.ConvertFromDecimal(127,16);
        }
    }
}
