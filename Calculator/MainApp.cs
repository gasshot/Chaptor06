using System;

namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b)  // int는 반환형식 Plus는 메서드의 이름
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class MainApp
    {
        public static void Main()
        {
            int result = Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);
        }
    }
}
