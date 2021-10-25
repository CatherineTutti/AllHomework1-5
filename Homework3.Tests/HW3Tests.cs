using NUnit.Framework;

namespace Homework3.Tests
{
    public class HW3Tests
    {
        private HW3 _hw3;

        [SetUp]
        public void Setup()
        {
            _hw3 = new HW3();
        }
        //[Test]
        //public void Test5CalcFormul3()
        //{
        //    //arrange
        //    int a = 8;
            
        //    string expected = "4";

        //    //act
        //    int actual = _hw3.CalcFormul3(a);

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}

        [Test]
        public void Test5CalcFormul5()
        {
            //arrange
            int A = 7;
            int B = 21;
            int expected = 42;

            //act
            int actual = _hw3.CalcFormul5(A, B);

            //assert
            Assert.AreEqual(expected, actual);
        }


        //[Test]
        //public void Test6CalcFormul6()
        //{
        //    //arrange
        //    int valueG = 11;
        //    int fiboG = 1;
        //    int first = 0;
        //    int second = 1;

        //    string expected = 10;

        //    //act
        //    string actual = _hw3.CalcFormul6(valueG, fiboG, first, second);

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}


        [Test]
        public void Test7CalcFormul7()
        {
            //arrange
            int a = 10;
            int b = 12;
            int nod = 1;
            int tmp = 0;
            int expected = 2;

            //act
            int actual = _hw3.CalcFormul7( a, b,  tmp,  nod);

            //assert
            Assert.AreEqual(expected, actual);
        }


        //[Test]
        //public void Test8SearchSqare()
        //{
        //    //arrange
        //    double number = 2;

        //    double expected = 4;

        //    //act
        //    double actual = _hw3.SearchSqare(number);

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        [Test]
        public void Test9AmouthOddDigit()
        {
            //arrange
            int number = 12341010;
            int count = 0;
            int expected = 4;

            //act
            int actual = _hw3.AmountOddDigit(number, count);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test10MirrorDigit()
        {
            //arrange
            int numb = 12341010;
            int result1 = 0;
            int expected = 01014321;

            //act
            int actual = _hw3.MirrorDigit(numb, result1);

            //assert
            Assert.AreEqual(expected, actual);

        }
              //[Test]
//        public void Test11SumOfEvenGreatOdd()
//        {
//            //arrange
//            int a = 10;
//            string result = SumOfEvenGreatOdd(a);
//            int expected = 5;

//            //act
//            int actual = _hw3.SumOfEvenGreatOdd(a);

//            //assert
//            Assert.AreEqual(expected, actual);
//        }


//        [Test]
//        public void Test12IdenticalNumb()
//        {
//            //arrange
//            int v = 10;
//            int b = 123;
//            string result = IdenticalNumb(v, b);
//            string expected = "да";

//            //act
//            string actual = _hw3.IdenticalNumb(v,b);

//            //assert
//            Assert.AreEqual(expected, actual);
    }
} 