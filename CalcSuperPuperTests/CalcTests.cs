using CalcSuperPuper;

namespace CalcSuperPuperTests
{
    [TestClass]
    public sealed class CalcTests
    {
        [TestMethod]
        public void Display_ShouldBeZero_WhenStart()
        {
            var calc = new Calc();

            Assert.AreEqual("0", calc.Display);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var calc = new Calc();

            calc.SetChar('1');

            Assert.AreEqual("1", calc.Display);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var calc = new Calc();

            calc.SetChar('1');
            calc.SetChar('2');

            Assert.AreEqual("12", calc.Display);
        }

        [TestMethod]
        public void TestMethod123()
        {
            var calc = new Calc();

            calc.SetChar('1');
            calc.SetChar('2');
            calc.SetChar('+');

            Assert.AreEqual("12", calc.Display);
        }

        [TestMethod]
        public void TestMethod1234()
        {
            var calc = new Calc();

            calc.SetChar('1');
            calc.SetChar('2');
            calc.SetChar('+');
            calc.SetChar('3');

            Assert.AreEqual("3", calc.Display);
        }

        [TestMethod]
        public void TestMethod12345()
        {
            var calc = new Calc();

            calc.SetChar('1');
            calc.SetChar('2');
            calc.SetChar('+');
            calc.SetChar('3');
            calc.SetChar('4');

            Assert.AreEqual("34", calc.Display);
        }

        [TestMethod]
        public void TestMethod123456()
        {
            var calc = new Calc();

            calc.SetChar('1');
            calc.SetChar('2');
            calc.SetChar('+');
            calc.SetChar('3');
            calc.SetChar('4');
            calc.SetChar('=');

            Assert.AreEqual("46", calc.Display);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var calc = new Calc();

            calc.SetChar('1');
            calc.SetChar('2');
            calc.SetChar('+');
            calc.SetChar('3');
            calc.SetChar('4');
            calc.SetChar('=');
            calc.SetChar('=');

            Assert.AreEqual("80", calc.Display);
        }
    }
}
