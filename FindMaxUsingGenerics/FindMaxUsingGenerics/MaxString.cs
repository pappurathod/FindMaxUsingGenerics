using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class MaxString
    {
        public string largeString(string str_1, string str_2, string str_3)
        {
            Console.WriteLine("Three Strings are : str1 = {0} , str2 = {1} , str3 = {2} ", str_1, str_2, str_3);
            if (str_1.CompareTo(str_2) > 0 && str_1.CompareTo(str_3) > 0)
            {
                Console.Write("Max String = ");
                return str_1;
            }
            else if (str_2.CompareTo(str_1) > 0 && str_2.CompareTo(str_3) > 0)
            {
                Console.Write("Max String = ");
                return str_2;
            }
            else if (str_3.CompareTo(str_1) > 0 && str_3.CompareTo(str_2) > 0)
            {
                Console.WriteLine("Max String = ");
                return str_3;
            }
            else
            {
                Console.WriteLine("all string are equal");
            }return null;
        }
        

    }
}
