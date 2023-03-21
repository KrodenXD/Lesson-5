using System;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(x));

            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Fibonachi(x));

            //int a = 0;
            //int b = 1;
            //int c = 0;
            //for(int i = 0; i < 10; i++)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;
            //    Console.WriteLine(a);
            //}
        }

        public static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        public static int Factorial(int n)
        {
            if (n == 0 || n == 1) return n;

            return n * Factorial(n - 1);
        }
    }
}
