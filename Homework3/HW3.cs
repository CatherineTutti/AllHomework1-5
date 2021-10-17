using System;

namespace Homework3
{
    public class HW3
    {
        public void SolveTask8()
        {
            Console.WriteLine("Пользователь вводит целое положительное число, которое является кубом целого числа N.\n" +
                "Найдите число N методом половинного деления");
            int num = cc.GetIntNumFromUser("Введите число: ");

            Console.WriteLine($"Результат: {MethOfHalfs(num)}");
            Console.WriteLine();
        }
        int MethOfHalfs(int num)
        {
            int left = 0;
            int mid = 0;
            int right = 0;

            while (Math.Pow(mid, 3) != num)
            {

                if (left < right)
                {
                    mid = (left + right) / 2;
                    if (Math.Pow(mid, 3) > num)
                        right = mid;
                    else if (Math.Pow(mid, 3) < num)
                        left = mid;
                }
                else if (left > right)
                {
                    mid = left;
                    mid = (mid + right) / 2;
                }
            }
            return mid;
        }
    }
}
