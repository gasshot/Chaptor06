using System;

namespace Overloading
{
    class MainApp
    {
        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int,int)...");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int,int,int)...");
            return a + b + c;
        }

        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling double Plus(double,double)...");
            return a + b; 
        }

        static double Plus(int a, double b)
        {
            Console.WriteLine("Calling double Plus(int,double)...");
            return a + b;
        }
        static float Plus(int a, float b)
        {
            Console.WriteLine("Calling double Plus(int,float)...");
            return (int)(a + b); // (int)(a + b) : 반환 형식 int 강제
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));
            Console.WriteLine(Plus(1, 2.4f));
        }
    }
}
