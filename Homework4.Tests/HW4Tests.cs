using NUnit.Framework;

namespace Homework4.Tests
{
    public class HW4Tests
    {
        private HW4 _hw4;
        [SetUp]
        public void Setup()
        {
            _hw4 = new HW4();
        }

       

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] {0 }, new int[] {0 })]
        [TestCase(new int[] {2,2,2 }, new int[] { 2,2,2})]
        [TestCase(new int[] {1,2,3,4 }, new int[] { 4,3,2,1})]
        [TestCase(new int[] {1,2,3,4,5 }, new int[] {5,4, 3, 2, 1 })]
       

        public void ReverseArrayTests(int[] array, int[] expected)
        {
            //arrange


            //act
            _hw4.ReverseArray(array);

            //assert
            Assert.AreEqual(expected, array);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 })]
       

        public void CountEvenNumbers(int[] array, int[] expected)
        {
            //arrange


            //act
            _hw4.CountEvenNumbers(array);

            //assert
            Assert.AreEqual(expected, array);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1,2 })]


        public void SwitchHalfsOfTheArray(int[] array, int[] expected)
        {
            //arrange


            //act
            _hw4.SwitchHalfsOfTheArray(array);

            //assert
            Assert.AreEqual(expected, array);
        }
        //up
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { -2, 1, 4, 0 }, new int[] { -2, 0, 1, 4 })]
        [TestCase(new int[] { -1, 2, 3, 4, -5 }, new int[] { -5, -1, 2, 3, 4 })]


        public void DoSelectSort(int[] array, int[] expected)
        {
            //arrange


            //act
            _hw4.DoSelectSort(array);

            //assert
            Assert.AreEqual(expected, array);
        }
        //dowm
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { -2, 0, 1, 4 }, new int[] { 4, 1, 0, -2 })]
        [TestCase(new int[] { -1, 2, 3, 4,-5 }, new int[] { 4, 3, 2, -1, -5 })]


        public void DoBubbleSort(int[] array, int[] expected)
        {
            //arrange


            //act
            _hw4.DoBubbleSort(array);

            //assert
            Assert.AreEqual(expected, array);
        }


    }
}