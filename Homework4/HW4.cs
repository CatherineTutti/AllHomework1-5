using System;

namespace Homework4
{
    public class HW4
    {

    }
    class Program
    {
        static void Main()
        {
            int[] nums = Tasks.generateArray();
            Tasks.printArray(Tasks.sort(nums));
        }
    }


    public static class Tasks
    {

        static int[] generateArray(int length)
        {
            int[] nums = new int[length];
            //заполняешь массив
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {

                nums[i] = rnd.Next(-90, 100);

                Console.WriteLine(nums[i]);
            }
            return nums;
        }

        static int[] sort(int[] array)
        {
            //сортируешь массив
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return array;
        }

        static void printArray(int[] array)
        {
            //печатаешь массив, возвращать ничего не надо т.к. тип VOID
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}
