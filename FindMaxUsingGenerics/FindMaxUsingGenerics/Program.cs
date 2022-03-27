using System;

namespace FindMaxUsingGenerics
{
    public class Program
    {    
        
        public static void Main(string[] args)
        {
            MaxGeneric<int> intValue = new MaxGeneric<int>(77, 44, 99);
            intValue.testMaximum();
            MaxGeneric<float> floatValue = new MaxGeneric<float>(15.33f, 33.44f, 15.55f);
            floatValue.testMaximum();
            MaxGeneric<string> strValue = new MaxGeneric<string>("Apple", "Peach", "Banana");
            strValue.testMaximum(); 
        }

    }
}
