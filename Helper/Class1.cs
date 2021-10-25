using System;

namespace Helper
{
    public class Class1
    {
        public void SolveTask5()
        {
            int coordinateX1 = GetNumberOfUser5("введите координату Х1");
            int coordinateX2 = GetNumberOfUser5("введите координату Х2");
            int coordinateY1 = GetNumberOfUser5("введите координату Y1");
            int coordinateY2 = GetNumberOfUser5("введите координату Y2");
            int calculationResult1 = CalkFormula5(coordinateX1, coordinateX2, coordinateY1, coordinateY2);
            int calculationResult2 = CalkFormula6(coordinateX1, coordinateX2, coordinateY1, coordinateY2);
            Console.WriteLine($"Результат пятой задачи: y= {calculationResult1} *x + {calculationResult2}");
        }
        public int GetNumberOfUser5(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int CalkFormula5(int coordinateX1, int coordinateX2, int coordinateY1, int coordinateY2)
        {
            int calculationResult1 = (coordinateY2 - coordinateY1) / (coordinateX2 - coordinateX1);
            return calculationResult1;

        }
        public int CalkFormula6(int coordinateX1, int coordinateX2, int coordinateY1, int coordinateY2)
        {
            int calcu = (coordinateY2 - coordinateY1) / (coordinateX2 - coordinateX1);
            int calculationResult2 = (coordinateY1 - calcu * coordinateX1);
            return calculationResult2;

        }
    }
}
