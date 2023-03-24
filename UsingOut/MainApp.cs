using System;

namespace UsingOut
{
    class MainApp
    {
        static void Divide(int a, int b, out int quotient, out int remainder) // 인스턴스가 아닌 클래스에 직접 한정됨
        {
            quotient = a / b;
            remainder = a % b;
            //int[] abc = new int[2];
            //abc[0] = a / b;
            //abc[1] = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            //int[] cde;
            //int c;
            //int d;

            Divide(a, b, out int c, out int d);
            //Divide(a, b, int[] cde[0], out int d);

            Console.WriteLine($"a:{0}, b:{1}, a/b:{2},a%b:{3}", a, b, c, d);
        }
    }
}
