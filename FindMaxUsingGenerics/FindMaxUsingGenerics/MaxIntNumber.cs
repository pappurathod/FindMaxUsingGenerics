using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class MaxIntNumber
    {
        public int NumberMax(int num1, int num2, int num3)
        {
            Console.WriteLine("Three numbers are num1 = {0} , num2 = {1} , num3 = {2} ", num1, num2, num3);

            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                Console.WriteLine("Max = ");
                return num1;
            }
            else if (num2.CompareTo(num3) > 0 && num2.CompareTo(num1) > 0)
            {
                Console.WriteLine("Max = ");
                return num2;
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                Console.WriteLine("Max = ");
                return num3;
            }
            else
            {
                Console.WriteLine("all numbers are equal");
            }return 0;
        }
    }
}
