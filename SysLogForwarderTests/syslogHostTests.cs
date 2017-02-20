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
    public class syslogHostTests
    {
        [TestMethod()]
        public void syslogHostTest()
        {
            syslogHost sh = new syslogHost();

            singleSyslogHost ssh = new singleSyslogHost();

            sh.addHost(ssh);

            // should have one host
            Assert.AreEqual(sh.getNMaps(), 1);

            sh.addHost(ssh);

            // should have two hosts
            Assert.AreEqual(sh.getNMaps(), 2);


            // add 6
            sh.addHost(ssh);
            sh.addHost(ssh);
            sh.addHost(ssh);
            sh.addHost(ssh);
            sh.addHost(ssh);
            sh.addHost(ssh);

            // should be 8
            Assert.AreEqual(sh.getNMaps(), 8);

            // noew remove no 6
            Assert.AreEqual(sh.removeHost(6), true);
            // noew remove no 6
            Assert.AreEqual(sh.removeHost(6), true);
            // noew remove no 6 - should now fail
            Assert.AreEqual(sh.removeHost(6), false);
            // noew remove no 6 - should now fail
            Assert.AreEqual(sh.removeHost(6), false);

            // things and stuff
            String ilk = sh.toString();
            syslogHost hhg = new syslogHost();
            hhg.fromString(ilk);

            // and we test weather a load and dump works
            Assert.AreEqual(ilk, hhg.toString());
        }

    }
}