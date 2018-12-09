using Microsoft.VisualStudio.TestTools.UnitTesting;
using deploy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deploy.Tests
{
    [TestClass()]
    public class DefaultTests
    {
        [TestMethod()]
        public void YeniCustomerTest()
        {
            Default def = new Default();

            def.YeniCustomer(5);


            Assert.AreEqual(5,5);
        }
        [TestMethod()]
        public void EskiCustomerTest()
        {
            Default def = new Default();

            def.EskiCustomer(5);


            Assert.AreEqual(5, 5);
        }
    }
}