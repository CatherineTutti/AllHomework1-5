using System;

namespace Homework4
{
    public class HW4
    {
        //Найти минимальный элемент массива
        public void SolveTask1()
        {
            int[] myArray = { 10, 15, 12345, 100, -100 };

            int minValue = myArray[0];
        }

        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public void ElevateUserNumber(int[] myArray, int minValue)
        {
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
        }

        // 6. Сделать реверс массива(массив в обратном направлении)
        public void SolveTask6()

        { 
            int[] array = GenerateRandomArray();
            ReverseArray(array);
            PrintArray(array);
        }

       
        public int[] GenerateRandomArray()
        {
            Console.WriteLine("Укажите размер массива:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Random rnd = new Random();
            Console.WriteLine("Массив:");
            for (int i = 0; i < length; i++)
            {

                array[i] = rnd.Next(1, 99);

                Console.Write($"{array[i]} ");
            }
            return array;
        }
        public void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int _= array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = _;

            }
        }
        public void PrintArray(int[] array)
        {
            Console.Write($"\nОтсортированный массив:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        // 7* Посчитать количество нечетных элементов массива
        public void SolveTask7()
        {
            int[] array = GenerateRandomArray();
            int count = CountEvenNumbers(array);
            Console.WriteLine();
            Console.WriteLine($"Количество нечетных элементов: {count}");
        }
        public int CountEvenNumbers(int[] array)
        {
            int count = 0;
            foreach (int x in array)
            {
                if (x % 2 == 1)
                {
                    count++;
                }

            }
            return count;
        }

        //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        public void SolveTask8()
        {
            int[] array = GenerateRandomArray();
            SwitchHalfsOfTheArray(array);
            PrintArray(array);
        }
        public void SwitchHalfsOfTheArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[i + array.Length - array.Length / 2];
                array[i + array.Length - array.Length / 2] = tmp;
            }
        }

        // Отсортировать массив по возрастанию одним из способов:   выбором(Select)
        public void SolveTask9()// ошибка что-то с интом из-за мина
        {
            int[] array = GenerateRandomArray();
            DoSelectSort(array);
            PrintArray(array);


        }

        public void DoSelectSort(int[] array) 
        {
            int min = array[0];
            int temp = 0;
            int idx = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                idx = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[idx] > array[j])
                    {

                        idx = j;
                    }

                }
                temp = array[i];
                array[i] = array[idx];
                array[idx] = temp;



            }

        }

        //Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  пузырьком(Bubble)

        public void SolveTask10() //// - исправлено
        {
            int[] array = GenerateRandomArray();
            DoBubbleSort(array);
            PrintArray(array);

        }
        public void DoBubbleSort(int[] array)
        {
            int a, tmp;
            for (a = 0; a < array.Length; a++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }

                }
            }
        }
    }




    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] nums = Tasks.generateArray();
    //        Tasks.printArray(Tasks.sort(nums));
    //    }
    //}


    //public static class Tasks
    //{

    //    static int[] generateArray(int length)
    //    {
    //        int[] nums = new int[length];
    //        //заполняешь массив
    //        Random rnd = new Random();

    //        for (int i = 0; i < length; i++)
    //        {

    //            nums[i] = rnd.Next(-90, 100);

    //            Console.WriteLine(nums[i]);
    //        }
    //        return nums;
    //    }

    //    static int[] sort(int[] array)
    //    {
    //        //сортируешь массив
    //        int temp;
    //        for (int i = 0; i < nums.Length - 1; i++)
    //        {
    //            for (int j = i + 1; j < nums.Length; j++)
    //            {
    //                if (nums[i] < nums[j])
    //                {
    //                    temp = nums[i];
    //                    nums[i] = nums[j];
    //                    nums[j] = temp;
    //                }
    //            }
    //        }
    //        return array;
    //    }

    //    static void printArray(int[] array)
    //    {
    //        //печатаешь массив, возвращать ничего не надо т.к. тип VOID
    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            Console.WriteLine(nums[i]);
    //        }
    //        Console.ReadLine();
    //}

}
