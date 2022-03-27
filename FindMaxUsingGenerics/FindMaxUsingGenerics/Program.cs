using System;

namespace FindMaxUsingGenerics
{
    public class Program
    {    
        
        public static void Main(string[] args)
        {
            int[] intArray = {10,44,33,88,444,11,8,};
            float[] floatArray = { 66.5f, 15.33f, 33.44f, 15.55f, 111.2f};
            string[] stringArray = { "Apple", "Peach", "Banana", "swaraj", "pawan", "vishal"};

            MaxGeneric<int> intValue = new MaxGeneric<int>(intArray);
            Console.WriteLine(intValue.testMaximum());
            MaxGeneric<float> floatValue = new MaxGeneric<float>(floatArray);
            Console.WriteLine(floatValue.testMaximum());
            MaxGeneric<string> strValue = new MaxGeneric<string>(stringArray);
            Console.WriteLine(strValue.testMaximum()); 
        }

    }
}
