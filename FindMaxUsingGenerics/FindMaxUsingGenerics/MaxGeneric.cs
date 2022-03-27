using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    public class MaxGeneric<T> where T : IComparable
    {
        public T value_1, value_2, value_3;
        public MaxGeneric(T value_1, T value_2, T value_3)
        {
            this.value_1 = value_1;
            this.value_2 = value_2;
            this.value_3 = value_3;
        }

        public void testMaximum()
        {
            T max = value_1;
            if (value_1.CompareTo(value_2) > 0 && value_1.CompareTo(value_3) > 0)
            {
                max = value_1;
                Console.Write("Maximum is = {0}\n", max);
            }
            else if (value_2.CompareTo(value_1) > 0 && value_2.CompareTo(value_3) > 0)
            {
                max = value_2;
                Console.Write("Maximum is = {0}\n", max);
            }
            else if (value_3.CompareTo(value_1) > 0 && value_3.CompareTo(value_2) > 0)
            {

                max = value_3;
                Console.Write("Maximum is = {0}\n", max);
            }
            else
            {
                Console.WriteLine("all are same");
            }            
        }
    }
}
