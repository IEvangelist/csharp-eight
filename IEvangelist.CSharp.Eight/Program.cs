using System;

namespace IEvangelist.CSharp.Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int Fib(int number) => number switch
        {
            0 => 0,
            1 => 1,
            _ => number >= 0 
                ? Fib(number - 1) + Fib(number - 2) 
                : throw new ArgumentOutOfRangeException()
        };
    }
}