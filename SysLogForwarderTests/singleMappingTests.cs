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
    public class singleMappingTests
    {
        [TestMethod()]
        public void toStringTest()
        {
            singleMapping sm = new singleMapping();

            // a blank map
            String ik = sm.toString();
            Assert.AreEqual(ik, "mapping;0;False;;");

            // send a bad map
            bool res = sm.fromString("qwer;qwer;qwer;qwer;qwer");
            Assert.AreEqual(false, res);

            // send a good map
            bool res2 = sm.fromString("mapping;0;true;locallog;.*");
            Assert.AreEqual(true, res2);

            // assert returned value
            String v = sm.toString();
            Assert.AreEqual(v, "mapping;0;True;locallog;.*");

            // test filter set
            sm.setFilter("!^a.*");
            bool ar1 = sm.tryFilter("its me");
            Assert.AreEqual(ar1, true);

            // test does match
            bool ar2 = sm.tryFilter("abcjdlkj");
            Assert.AreEqual(ar2, false);

            // test filter set 2 NICE!
            sm.setFilter("^a.*");
            bool ar3 = sm.tryFilter("its me");
            Assert.AreEqual(ar3, false);

            // test does match
            bool ar4 = sm.tryFilter("abcjdlkj");
            Assert.AreEqual(ar4, true);
        }
    }
}