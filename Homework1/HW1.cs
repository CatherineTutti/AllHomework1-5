using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class HW1
    {

        //Пользователь вводит 2 числа (A и B). Выведите в консоль решение 5*A+B2B-A
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            double result = CalcFormula(a, b);
            Console.WriteLine($"Результат первой задачи: {result}");
        }

        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public double CalcFormula(int a, int b)
        {
            double result = (5 * a + Math.Pow(b, 2)) / (b - a);
            return result;
        }


        //Пользователь вводит 2 строковых значения(A и B). Поменяйте содержимое переменных A и B местами.

        public void SolveTask2()
        {

            string Signa = GetSignUser("Введите сигнатуру пользователя");
            string Signb = GetSignUser("Введите сигнатуру пользователя");
            SwapStrings(ref Signa, ref Signb);
            string result = (Signa + " " + Signb);
            Console.WriteLine($"Результат второй задачи:{result}");
        }

        string GetSignUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public void SwapStrings(ref string Signa, ref string Signb)
        {
            string tmp = Signa;
            Signa = Signb;
            Signb = tmp;
        }


        //Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.

        public void SolveTask3()
        {
            int operand1 = GetNumberOfUser1("Введите число А");
            int operand2 = GetNumberOfUser1("Введите число B");
            int result1 = CalkFormula3(operand1, operand2);
            Console.WriteLine($"целая часть: {result1}");
            double result2 = CalkFormula4(operand1, operand2);
            Console.WriteLine($"остаток от деления: {result2}");
        }
        public int GetNumberOfUser1(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int CalkFormula3(int operand1, int operand2)
        {
            int result1 = (operand1) / (operand2);
            return result1;
        }
        public double CalkFormula4(int operand1, int operand2)
        {
            double result2 = (operand1) % (operand2);
            return result2;
        }


       // Пользователь вводит 3 не равных 0 числа(A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A* X+B=C.

        public void SolveTask4()
        {
            int operand1 = GetNumberOfUser2("Введите число А");
            int operand2 = GetNumberOfUser2("Введите число B");
            int operand3 = GetNumberOfUser2("Введите число С");
            double result = CalkFormula2(operand1, operand2, operand3);
            Console.WriteLine($"результат четвертой задачи {result}");
        }
        public int GetNumberOfUser2(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public double CalkFormula2(int operand1, int operand2, int operand3)
        {
            double result = (operand3 - operand2) / operand1;
            return result;
        }


       // Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.
        public void SolveTask5()
        {
            int X1 = GetNumberOfUser5("введите координату Х1");
            int X2 = GetNumberOfUser5("введите координату Х2");
            int Y1 = GetNumberOfUser5("введите координату Y1");
            int Y2 = GetNumberOfUser5("введите координату Y2");
            double k = CalkFormula5(X1, X2, Y1, Y2);
            double b = CalkFormula6(X1, X2, Y1, Y2);
            Console.WriteLine($"Результат пятой задачи: y= {k} *x + {b}");
        }
        public int GetNumberOfUser5(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int CalkFormula5(int X1, int X2, int Y1, int Y2)
        {
            double k = (Y1 - Y2) * 1.0 / (X1 - X2);
            
            return  k;

        }
        public int CalkFormula6(int X1, int X2, int Y1, int Y2)
        {
            double b = Y2 - k * X2;
            
            return  b;
        }
    }

}


