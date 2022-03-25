using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class MaxIntNumber
    {
        public int NumberMax(int num_1, int num_2, int num_3)
        {
            Console.WriteLine("Three Integer numbers are : num1 = {0} , num2 = {1} , num3 = {2} ", num_1, num_2, num_3);

            if (num_1.CompareTo(num_2) > 0 && num_1.CompareTo(num_3) > 0)
            {
                Console.Write("Max Integer Number = ");
                return num_1;
            }
            else if (num_2.CompareTo(num_3) > 0 && num_2.CompareTo(num_1) > 0)
            {
                Console.Write("Max Integer Number = ");
                return num_2;
            }
            else if (num_3.CompareTo(num_1) > 0 && num_3.CompareTo(num_2) > 0)
            {
                Console.Write("Max Integer Number = ");
                return num_3;
            }
            else
            {
                Console.WriteLine("all numbers are equal");
            }return 0;
        }
    }
}
