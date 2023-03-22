using System;

namespace UsingOut
{
    class MainApp
    {
        static void Divide(int a, int b, out int quotient, out int remider)
        {
            quotient = a / b;
            remider = a % b;
        }
 
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            //int c;
            //int d;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a}, b:{b}, a/b:{c},a%b:{d}");
        }
    }
}
