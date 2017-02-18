using Microsoft.VisualStudio.TestTools.UnitTesting;
using SysLogForwarder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogForwarder.Tests
{
    [TestClass()]
    public class singleSyslogHostTests
    {
        [TestMethod()]
        public void testloadTests()
        {
            // first load something invalid
            singleSyslogHost sl = new singleSyslogHost();

            bool res1 = sl.fromString("sqwer;qewr;qwer;qweer");

            Assert.AreEqual(res1, false);

            // load dsomething valid
            bool res2 = sl.fromString("sysloghost;1;514;1;somename");

            Assert.AreEqual(res2, true);

            // get it back
            String val1 = sl.toString();

            Assert.AreEqual(val1, "sysloghost;1;514;1;somename");

            // are not equal
            String val2 = sl.toString();

            Assert.AreNotEqual(val2, "syslost;1;514;1;somename");

        }
    }
}