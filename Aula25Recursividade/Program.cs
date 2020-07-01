using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fi = new Fibonacci();
            fi.GerarFibonacci(0,3,12);
            Console.WriteLine(fi.GerarFatorial(5));
        }
    }
}
