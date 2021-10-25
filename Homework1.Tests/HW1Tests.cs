using NUnit.Framework;

namespace Homework1.Tests
{
    public class HW1Tests
    {
        private HW1 _hw1;


        [SetUp]
        public void Setup()
        {
            _hw1 = new HW1();
        }

        [Test]
        public void CalcFormulaTest()
        {
            //arrange
            int a = 5;
            int b = 9;
            double expected = 26.5;

            //act
            double actual = _hw1.CalcFormula(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test2()
        {
            //arrange
            int operand1 = 5;
            int operand2 = 5;
            int expected = 1;

            //act
            int actual = _hw1.CalkFormula3(operand1, operand2);

            //assert
            Assert.AreEqual(expected,actual);
        }


        [Test]
        public void Test3()
        {
            //arrange
            int operand1 = 190;
            int operand2 = 189;
            double expected = 1;

            //act
            double actual = _hw1.CalkFormula4(operand1, operand2);

            //assert
            Assert.AreEqual(expected, actual);
        }



        [Test]

        public void Test4()
        {            
             //arrange
             int operand1 = 5;
             int operand2 = 5;
             int operand3 = 25;
             double expected = 4;

             //act
              double actual = _hw1.CalkFormula2(operand1, operand2, operand3);

             //assert
              Assert.AreEqual(expected, actual);
            
        }

        public void Test5()
        {
            //arrange
            int operand1 = 5;
            int operand2 = 5;
            int operand3 = 25;
            double expected = 4;

            //act
            double actual = _hw1.CalkFormula2(operand1, operand2, operand3);

            //assert
            Assert.AreEqual(expected, actual);

        }


    }



}