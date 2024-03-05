using Tpoas_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3;
            int expected = 28;

            int actual = Area.Rad(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 1;
            int expected = 3;

            int actual = Area.Rad(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = 2;
            int expected = 12;

            int actual = Area.Rad(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a = 4;
            int expected = 50;

            int actual = Area.Rad(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int a = 5;
            int expected = 78;

            int actual = Area.Rad(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int a = 12;
            int expected = 452;

            int actual = Area.Rad(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int a = 8;
            int expected = 201;

            int actual = Area.Rad(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int a = 6;
            int expected = 113;

            int actual = Area.Rad(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            int a = 7;
            int expected = 153;

            int actual = Area.Rad(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            int a = 10;
            int expected = 314;

            int actual = Area.Rad(a);
            Assert.AreEqual(expected, actual);
        }
    }
}