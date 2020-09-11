using Microsoft.VisualStudio.TestTools.UnitTesting;
using BogLib;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using NuGet.Frameworks;

namespace BogLib.Tests
{
    [TestClass()]
    public class BogTests
    {
        private Bog bog;

        [TestInitialize]
        public void Init()
        {
            bog = new Bog();
        }
        [TestMethod()]
        public void BogTitleTest()
        {
            bog.Titel = "Erik Menneskesøn";
            Assert.AreEqual("Erik Menneskesøn", bog.Titel);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bog.Titel = "i");
        }

        [TestMethod]
        public void BogSidetalTest()
        {
            bog.Sidetal = 10;
            Assert.AreEqual(10, bog.Sidetal);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bog.Sidetal = 9);
            bog.Sidetal = 1000;
            Assert.AreEqual(1000, bog.Sidetal);
            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bog.Sidetal = 1001);
        }

        [TestMethod]
        public void Boglsbn13Test()
        {
            bog.Lsbn13 = "1234567890123";
            Assert.AreEqual("1234567890123", bog.Lsbn13);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bog.Lsbn13 = "123456789012" );

        }
        //[TestMethod()]
        //public void ToStringTest()
        //{
        //    Assert.Fail();
        //}
    }
}

