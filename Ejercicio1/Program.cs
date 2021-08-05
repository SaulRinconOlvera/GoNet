using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib(8));
            Console.WriteLine(fib(7));
            Console.WriteLine(fib(6));
        }
        private static int fib(int n) {
            if(n<=2) return 1;
            return fib(n-1) + fib(n-2);
        }
    }
}
