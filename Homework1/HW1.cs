using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class HW1
    {
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



        public void SolveTask3()
        {
            int operand1 = GetNumberOfUser1("Введите число А");
            int operand2 = GetNumberOfUser1("Введите число B");
            int result1 = CalkFormula3(operand1, operand2);
            Console.WriteLine($"целая часть: {result1}");
            double result2 = CalkFormula4(operand1, operand2);
            Console.WriteLine($"остаток от деления: {result2}");
        }
        private int GetNumberOfUser1(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        private int CalkFormula3(int operand1, int operand2)
        {
            int result1 = (operand1) / (operand2);
            return result1;
        }
        private double CalkFormula4(int operand1, int operand2)
        {
            double result2 = (operand1) % (operand2);
            return result2;
        }
                
        public void SolveTask4()
        {
            int operand1 = GetNumberOfUser2("Введите число А");
            int operand2 = GetNumberOfUser2("Введите число B");
            int operand3 = GetNumberOfUser2("Введите число С");
            double result = CalkFormula2(operand1, operand2, operand3);
            Console.WriteLine($"результат четвертой задачи {result}");
        }
        private int GetNumberOfUser2(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        private double CalkFormula2(int operand1, int operand2, int operand3)
        {
            double result = (operand3 - operand2) / operand1;
            return result;
        }

       
        public void SolveTask5()
        {
            int coordX1 = GetNumberOfUser5("введите координату Х1");
            int coordX2 = GetNumberOfUser5("введите координату Х2");
            int coordY1 = GetNumberOfUser5("введите координату Y1");
            int coordY2 = GetNumberOfUser5("введите координату Y2");
            int calculationResult1 = CalkFormula5(coordX1, coordX2, coordY1, coordY2);
            int calculationResult2 = CalkFormula6(coordX1, coordX2, coordY1, coordY2);
            Console.WriteLine($"Результат пятой задачи: y= {calculationResult1} *x + {calculationResult2}");
        }
        private int GetNumberOfUser5(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        private int CalkFormula5(int coordX1, int coordX2, int coordY1, int coordY2)
        {
            int calculationResult1 = (coordY2 - coordY1) / (coordX2 - coordX1);
            return calculationResult1;

        }
        private int CalkFormula6(int coordX1, int coordX2, int coordY1, int coordY2)
        {
            int calcu = (coordY2 - coordY1) / (coordX2 - coordX1);
            int calculationResult2 = (coordY1 - calcu * coordX1);
            return calculationResult2;
        }
    }

}


