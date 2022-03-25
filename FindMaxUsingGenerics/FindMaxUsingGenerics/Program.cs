using System;

namespace FindMaxUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaxIntNumber maxintnum = new MaxIntNumber();
            Console.WriteLine(maxintnum.NumberMax(10,80,10));
            Console.WriteLine("-------------------------");

            MaxFloatNumber maxfloatnum = new MaxFloatNumber();
            Console.WriteLine(maxfloatnum.FloatNumber(90.4f, 50.6f, 70.7f));
            Console.WriteLine("-------------------------");

            MaxString maxString= new MaxString();
            Console.WriteLine(maxString.largeString("Apple","Peach","Banana"));
        }
    }
}