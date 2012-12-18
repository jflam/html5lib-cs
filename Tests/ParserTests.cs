using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Html5Lib;

namespace Tests
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var parser = new HtmlParser();
            parser.Parse("<pre>\nx\n&gt;\n</pre>");
        }

        public void TestMethod2()
        {

        }
    }
}
