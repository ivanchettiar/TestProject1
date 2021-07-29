using ConsoleApp1;
using NUnit.Framework;
using Moq;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}
        Empl obj;
        Mock<Empl> m;

        [SetUp]
        public void First() {
            obj = new Empl();
            m = new Mock<Empl>();
        }


        [Test]
        public void TestAdd()
        {
            int actual = obj.Add(4, 5);
            Assert.AreEqual(9, actual);
        }

        [Test]
        public void TestMessage()
        {
            string msg = obj.Message("World");
            string expected = "Hello World";
            Assert.AreEqual(expected, msg);
        }


        Account acc = new Account();
        [Test]
        public void TestWithdraw()
        {
            int actual = acc.Withdraw(100);
            Assert.AreEqual(19900, actual);
        }
        [Test]
        public void TestDeposit()
        {
            int actual = acc.Deposit(100);
            Assert.AreEqual(20100, actual);
        }

        [Test]
        public void calacamtTest()
        {
            float f = obj.calcamt(3, 4);
            Assert.AreEqual(f, 12);
        }
        [Test]
        public void checkAddTestPass()
        {
            m.Setup(x => x.calcamt(4, 5)).Returns(20);
            bool b = obj.checkAdd(4, 5);
                Assert.AreEqual(true, b);
        }


    }
}