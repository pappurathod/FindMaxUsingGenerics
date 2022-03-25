using System;

namespace FindMaxUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
             MaxIntNumber maxintnum = new MaxIntNumber();
             Console.WriteLine(maxintnum.NumberMax(10,80,10));
        }
    }
}