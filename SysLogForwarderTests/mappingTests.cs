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
    public class mappingTests
    {
        [TestMethod()]
        public void addMappingTest()
        {
            mapping mymap = new mapping();

            singleMapping sm = new singleMapping();
            int lval = mymap.addMapping(sm);

            Assert.AreEqual(lval, 0);

            singleMapping sm2 = new singleMapping();

            lval = mymap.addMapping(sm2);

            Assert.AreEqual(lval,1);

            // now add a few
            mymap.addMapping(sm2);
            mymap.addMapping(sm2);
            mymap.addMapping(sm2);
            mymap.addMapping(sm2);
            mymap.addMapping(sm2);
            // there are now 7

            Assert.AreEqual(mymap.getNMaps(), 7);
            mymap.dumpMap();

            mymap.removeMapping(3);
            // thre should now be 6
            Assert.AreEqual(mymap.getNMaps(), 6);
            mymap.dumpMap();

            mymap.removeMapping(3);
            // there should now be 5
            Assert.AreEqual(mymap.getNMaps(), 5);
            mymap.dumpMap();

            mymap.removeMapping(3);
            Assert.AreEqual(mymap.getNMaps(), 4);

            mymap.dumpMap();
        
            mymap.removeMapping(3);
            Assert.AreEqual(mymap.getNMaps(), 3);
            mymap.removeMapping(3);
            Assert.AreEqual(mymap.getNMaps(), 3);
            mymap.removeMapping(3);
            Assert.AreEqual(mymap.getNMaps(), 3);
            mymap.dumpMap();
            mymap.removeMapping(0);
            Assert.AreEqual(mymap.getNMaps(), 2);
            mymap.dumpMap();
            mymap.removeMapping(0);
            Assert.AreEqual(mymap.getNMaps(), 1);
            mymap.dumpMap();
            mymap.removeMapping(0);
            Assert.AreEqual(mymap.getNMaps(), 0);
            mymap.dumpMap();

        }

    }
}