using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class HW2
    {

        //Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
        public void SolveTask1()
        {
            int a = GetNumberFromUser("a =");
            int b = GetNumberFromUser("b =");
            int result = CalcFormula1(a, b);
            Console.WriteLine($"Результат первой задачи: {result}");


        }
        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int CalcFormula1(int a, int b)
        {
            if (a > b)
            {
                int sum = a + b;
                return sum;
            }
            if (a < b)
            {
                int substr = a - b;
                return substr;
            }
            if (a == b)
            {
                int multi = a * b;
                return multi;
            }
            return 0;
        }


        //Пользователь вводит 2 числа(X и Y). Определить какой четверти принадлежит точка с координатами(X, Y).

        public void SolveTask2()
        {

            int x = GetNumberFromUser2("x =");
            int y = GetNumberFromUser2("y =");
            int result1 = QuarterP(x, y);
            string result = CalcFormula2( result1);
            
            Console.WriteLine($"Результат второй задачи: {result}");


        }
        public int GetNumberFromUser2(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public  int QuarterP(int x, int y)
        {
            int result1 = -1;
            if((x == 0) || (y == 0))
            {
                throw new ArgumentException("Точка лежит на оси x или y");
            }
            if ((x > 0) && (y > 0))
            {
                result1 = 1;
            }
            else if ((x < 0) && (y > 0))
            {
                result1 = 2;
            }
            else if ((x < 0) && (y < 0))
            {
                result1 = 3;
            }
            else if ((x > 0) && (y < 0))
            {
                result1 = 4;
            }
            return result1;
        }

        public string CalcFormula2(int result1)
        {
            string result = " ";
            if ((result1==1))
            {
                result = " I четверть";
                
            }

            else if ((result1==2))
            {
                result = "II четверть";
               
            }

            else if ((result1==3))
            {
                result = "III четверть";
                
            }
            else if ((result1==4))
            {
                result = "IV четверть";
               
            }
            
            return  result ;
        }



        //Пользователь вводит 3 числа(A, B и С). Выведите их в консоль в порядке возрастания.
        public void SolveTask3()
        {

            int a = GetNumberFromUser3("a =");
            int b = GetNumberFromUser3("b =");
            int c = GetNumberFromUser3("c =");
            string result = CalcFormula3(a, b, c);
            Console.WriteLine($"Результат третьей задачи: {result}");


        }
        public int GetNumberFromUser3(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string CalcFormula3(int a, int b, int c)
        {
            string result = " ";
            if (a > b && a > c)
            {
                if (b > c)
                {
                    result = $"{c}{b}{a}";
                }
                else
                {
                    result = $"{b}{c}{a}";
                }
            }
            else
            {
                if (b > c)
                {
                    if (c > a)
                    {
                        result = $"{a}{c}{b}";

                    }
                    else
                    {

                        result = $"{c}{a}{b}";
                    }
                }
                else
                {
                    if (b > a)
                    {
                        result = $"{a}{b}{c}";
                    }
                    else
                    {

                        result = $"{b}{a}{c}";
                    }
                }

            }
            return result;
        }


        //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.

        public void SolveTask4()
        {

            int a = GetNumberFromUser4("a =");
            int b = GetNumberFromUser4("b =");
            int c = GetNumberFromUser4("c =");
            string result = CalcFormula4(a, b, c);
            Console.WriteLine($"Результат четвертой задачи: {result}");


        }
        public int GetNumberFromUser4(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string CalcFormula4(int a, int b, int c)
        {
            double x1, x2;
            //дискриминант
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            string result = " ";
            if (discriminant < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет корней");
            }
            else
            {
                if (discriminant == 0) // два одинаковых корня
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else // два разных корня
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                //корни
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }
            return result;
        }


       // Пользователь вводит двузначное число.Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.

        public void SolveTask5()
        {

            int N = GetNumberFromUser5("N =");

            string result = CalcFormula5(N);
            Console.WriteLine($"Результат пятой задачи: {result}");


        }
        public int GetNumberFromUser5(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string CalcFormula5(int N)
        {
            int result = N % 10;
            int result2 = N / 10;
            string ans = " ";

            if (N >= 10 && N < 20)
            {
                switch (N)
                {
                    case 0:
                        Console.WriteLine("десять");
                        break;
                    case 1:
                        Console.WriteLine("одинадцать");
                        break;
                    case 2:
                        Console.WriteLine("двенадцать");
                        break;
                    case 3:
                        Console.WriteLine("тринадцать");
                        break;
                    case 4:
                        Console.WriteLine("четырнадцать");
                        break;
                    case 5:
                        Console.WriteLine("пятнадцать");
                        break;
                    case 6:
                        Console.WriteLine("шеснадцать");
                        break;
                    case 7:
                        Console.WriteLine("семнадцать");
                        break;
                    case 8:
                        Console.WriteLine("восемнадцать");
                        break;
                    case 9:
                        Console.WriteLine("девятнадцать");
                        break;
                    default:
                        break;
                }
            }

            else
            {
                switch (result2)
                {
                    case 2:
                        ans = "Двадцать";
                        break;
                    case 3:
                        ans = "Тридцать";
                        break;
                    case 4:
                        ans = "Сорок";
                        break;
                    case 5:
                        ans = "Пятьдесят";
                        break;
                    case 6:
                        ans = "Шестьдесят";
                        break;
                    case 7:
                        ans = "Семьдесят";
                        break;
                    case 8:
                        ans = "Восемьдесят";
                        break;
                    case 9:
                        ans = "Девяносто";
                        break;
                    default:
                        break;

                }
                switch (result)
                {
                    case 1:
                        ans = ans + "один";
                        break;
                    case 2:
                        ans = ans + "два";
                        break;
                    case 3:
                        ans = ans + "три";
                        break;
                    case 4:
                        ans = ans + "четыре";
                        break;
                    case 5:
                        ans = ans + "пять";
                        break;
                    case 6:
                        ans = ans + "шесть";
                        break;
                    case 7:
                        ans = ans + "семь";
                        break;
                    case 8:
                        ans = ans + "восемь";
                        break;
                    case 9:
                        ans = ans + "девять";
                        break;
                    default:
                        break;
                }


            }
             return ans;
        }

    }
}