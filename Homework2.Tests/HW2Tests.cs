using NUnit.Framework;

namespace Homework2.Tests
{
    public class HW2Tests
    {
        private HW2 _hw2;

        [SetUp]
        public void Setup()
        {
            _hw2 = new HW2();
        }

        [Test]
        public void CalcFormulaTest1()
        {
            //arrange
            int a = 5;
            int b = 9;
            double expected = -4;

            //act
            double actual = _hw2.CalcFormula1(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            //arrange
            int x = -5;
            int y = 5;
            int expected = 2;

            //act
            int actual = _hw2.QuarterP(x,y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            //arrange
            int a = -3;
            int b = 9;
            int c = 8;
            string expected = "-389";

            //act
            string actual = _hw2.CalcFormula3(a,b,c);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test4()
        {
            //arrange
            int a = -3;
            int b = 9;
            int c = 8;
            string expected = "-389";

            //act
            string actual = _hw2.CalcFormula3(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            //arrange
            int N = 25;
            
            string expected = "Двадцатьпять";

            //act
            string actual = _hw2.CalcFormula5(N);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}