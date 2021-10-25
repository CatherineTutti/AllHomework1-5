using System;

namespace Homework3
{
    public class HW3
    {
        //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.


        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            ElevateUserNumber(a, b);
        }

        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public void ElevateUserNumber(int a, int b)
        {
            if (b >= 0)
            {
                Console.WriteLine($"{ElevateUserNumberInAPositiveExponent(a, b)}");
            }

            if (b < 0)
            {
                Console.WriteLine($"{ElevateUserNumberUserNumberInANegativeExponent(a, b)}");
            }
        }

        public int ElevateUserNumberInAPositiveExponent(int a, int b)
        {
            int c = 1;
            for (int i = 1; i <= b; i++)
            {
                c = c * a;
            }

            return c;
        }

        public double ElevateUserNumberUserNumberInANegativeExponent(int a, int b)
        {
            double z = 1;
            for (int i = 1; i <= -(b); i++)
            {
                z = z / a;
            }

            return z;
        }


        //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

        public void SolveTask2()
        {
            int a = GetNumberFromUser2("a =");
            string result = CalcFormula1(a);
            Console.WriteLine($"Результат второй задачи: {result}");


        }
        public int GetNumberFromUser2(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string CalcFormula1(int a)
        {
            string result = " ";

            for (int i = 1; i >= 1000; i += a)
            {
                result = $"{i}";
            }
            return result;
        }


        //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.

        public void SolveTask3()
        {
            int a = GetNumberFromUser3("a =");
            string result = CalcFormula3(a);
            Console.WriteLine($"Результат третей задачи: {result}");


        }
        public int GetNumberFromUser3(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string CalcFormula3(int a)
        {
            string result = " ";
            int Positive = 0;
            for (int i = 1; i < a; i++)
            {
                if (i * i < a)
                {
                    result = $"{Positive++}";
                }
            }
            return result;
        }



        ////Пользователь вводит 1 число(A). Вывести наибольший делитель(кроме самого A) числа A.
        //public void SolveTask4()
        //{
        //    int A = GetNumberFromUser4("a =");

        //    string result = CalcFormula4(A);
        //    Console.WriteLine($"Результат четвертой задачи: {result}");
        //}
        //public int GetNumberFromUser4(string message)
        //{
        //    Console.WriteLine(message);
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    return number;
        //}
        //public string CalcFormula4(int A)
        //{
        //    string result = " ";

        //    for (int i = A - 1; i > 0; i--)
        //    {

        //        if (A % i == 0)
        //        {
        //            result = $"{ i}";

        //        }
        //    }
        //    return result;
        //}

        //public void SolveTask5()
        //{
        //    int A = GetNumberFromUser4("a =");

        //    string result = CalcFormula4(A);
        //    Console.WriteLine($"Результат четвертой задачи: {result}");
        //}
        //public int GetNumberFromUser4(string message)
        //{
        //    Console.WriteLine(message);
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    return number;
        //}

        //Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        public void SolveTask5()
        {
            int A = GetNumberFromUser5("a =");
            int B = GetNumberFromUser5("b =");

            int result = CalcFormul5(A, B);
            Console.WriteLine($"Результат пятой задачи: {result}");


        }
        public int GetNumberFromUser5(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int CalcFormul5(int A, int B)
        {

            int sum = 0;

            if (A < B)
            {
                for (int i = A; i <= B; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            else if (A > B)
            {
                for (int i = B; i <= A; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }

            return sum;
        }

        //Пользователь вводит 1 положительное число(N). Выведите N-ое число ряда фибоначчи.В ряду фибоначчи каждое следующее число является суммой двух предыдущих.Первое и второе считаются равными 1.
        public void SolveTask6()
        {

            int valueG = GetNumberFromUser6("G =");
            int fiboG = 1;
            int first = 0;
            int second = 1;
            string result = CalcFormul6(valueG, first, fiboG, second);
            Console.WriteLine($"Результат шестой задачи: {result}");

        }
        public int GetNumberFromUser6(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string CalcFormul6(int fiboG, int first, int second, int valueG)
        {
            string result = " ";
            for (int i = 1; i < valueG; i++)
            {
                fiboG = first + second;
                first = second;
                second = fiboG;
            }
            return result ;
        }


        //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
        public void SolveTask7()
        {
            int a = GetNumberFromUser7("a =");
            int b = GetNumberFromUser7("b =");
            int nod = 1;
            int tmp = 0;
            int result = CalcFormul7(a, b, tmp, nod);
            Console.WriteLine($"Результат седьмой задачи: {result}");


        }
        public int GetNumberFromUser7(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int CalcFormul7(int a, int b, int tmp, int nod)
        {
            if (a > b)
            {
                while (a != b)
                {

                    a = a - b;
                    if (a < b)
                    {
                        tmp = b;
                        b = a;
                        a = tmp;
                    }
                }
                nod = b;
            }
            else if (a < b)
            {
                while (a != b)
                {
                    b = b - a;
                    if (b < a)
                    {
                        tmp = b;
                        b = a;
                        a = tmp;
                    }
                }
                nod = b;
            }
            else
            {
                nod = a;
            }
            return nod;
        }


        ////("Пользователь вводит целое положительное число, которое является кубом целого числа N. " +            "Найдите число N методом половинного деления");
        public void SolveTask8()
        {
            
            double number;
            
        }
        public string NegativeOrPositive (double number)
        {
            do
            {
                number = GetNumberFromUser("Введите положительное число:");

                if (number < 0)
                {
                    return ("Число отрицательное");
                }
            } while (number < 0);
            return ($"Целое положительное число, которое является кубом целого числа {number} будет равным {SearchSqare(number)}");
        }
        public double SearchSqare(double number)
        {
            double rightLimit = number;
            double leftLimit = 0;
            double result = 0;

            while (rightLimit - leftLimit > 0.001)
            {
                result = (rightLimit + leftLimit) / 2;
                if (result * result * result > number)
                {
                    rightLimit = result;

                }
                else
                {
                    leftLimit = result;
                }
            }
            return result;
        }
        //public void SolveTask8()
        //{

        //    double number;
        //    do
        //    {
        //          number = GetNumberFromUser8("Введите положительное число:");
        //        if (number < 0)
        //        {
        //            Console.WriteLine("Число отрицательное.");
        //        }
        //    } while ( number < 0);
        //    Console.WriteLine($"Целое положительное число, которое является кубом целого числа {number} будет равным {SearchSqare(number)}");
        //}

        //public double GetNumberFromUser8(string message)
        //{
        //    Console.WriteLine(message);
        //    double number = Convert.ToInt32(Console.ReadLine());
        //    return number;
        //}
        //public double SearchSqare(double number)
        //{
        //    double rangeMax = number;
        //    double rangeMin = 0;
        //    double result = 0;

        //    while (rangeMax - rangeMin > 1)
        //    {
        //        result = (rangeMax + rangeMin) / 2;
        //        if (result * result > number)
        //        {
        //            rangeMax = result;
        //        }
        //        else
        //        {
        //            rangeMin = result;
        //        }
        //    }
        //    return result;
        //}


        // Пользователь вводит 1 число.Найти количество нечетных цифр этого числа.
        public void SolveTask9()
        {

            int number = GetNumberFromUser9("введите число");  //12341010   number %= 10
            int count = 0;                                        // number /= 10 

            int result = AmountOddDigit(number, count);
            Console.WriteLine($"Результат шестой задачи: {result}");

        }
        public int GetNumberFromUser9(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int AmountOddDigit(int number, int count)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 != 0)
                {
                    count++;
                }
                number /= 10;
            }
            return count;
        }



        //Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.
        public void SolveTask10()
        {
            int numb = GetNumberFromUser10("введите число");
            int result1 = 0;
            int result = MirrorDigit(numb, result1);
            Console.WriteLine($"Результат шестой задачи: {result}");

        }
        public int GetNumberFromUser10(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int MirrorDigit(int numb, int result1)
        {
            while (numb > 0)
            {
                result1 = result1 * 10;
                result1 = result1 + (numb % 10);
                numb = numb / 10;
            }
            return result1;
        }


        //Пользователь вводит целое положительное  число(N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
        public void SolveTask11()
        {
            int a = GetNumberFromUser11("Введите число");
            string result = SumOfEvenGreatOdd(a);
            Console.WriteLine($"Решение одинадцатой задачи: {result}");
        }
        public int GetNumberFromUser11(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public  string SumOfEvenGreatOdd(int a)
        {
            string result = " ";
            int tmp1 = 0;
            int tmp2 = 0;
            int sumOdd = 0;
            int sumEven = 0;
            
            for (int i = 1; i <= a; i++)
            {
                tmp2 = i;
                sumOdd = 0;
                sumEven = 0;

                do
                {
                    tmp1 = tmp2 % 10;
                    tmp2 = tmp2 / 10;
                    if (tmp1 % 2 == 0)
                    {
                        sumEven = sumEven + tmp1;
                    }
                    else
                    {
                        sumOdd = sumOdd + tmp1;
                    }
                }
                while (tmp2 > 0);
                if (sumEven > sumOdd)
                {
                    result += i + " ";
                }
                

            }
            return result;


        }


        //Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
        public void SolveTask12()
        {
            
            int b = GetNumberFromUser12("Введите число");

            int v = GetNumberFromUser12("Введите число");
            string result = IdenticalNumb(v,b);
            Console.WriteLine($"Решение одинадцатой задачи: {result}");
        }
        public int GetNumberFromUser12(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string IdenticalNumb(int v, int b)
        {
            string result = " ";
            while (v > 0)
            {
                while (b > 0)
                {
                    if (v % 10 == b % 10)
                    {
                        result = "да";
                        return result;
                    }
                    b /= 10;
                }
                v /= 10;

            }
            result = "нет";
            return result;
        }



    }
}


 



