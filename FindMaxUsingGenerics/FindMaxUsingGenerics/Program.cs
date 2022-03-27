using System;

namespace FindMaxUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaxGeneric<int> maxGenericInt = new MaxGeneric<int>();
            maxGenericInt.maxLength(10, 10, 10);

            MaxGeneric<float> maxGenericFloat = new MaxGeneric<float>();
            maxGenericFloat.maxLength(10.55f, 55.55f, 33.54f);

            MaxGeneric<string> maxGenericStr = new MaxGeneric<string>();
            maxGenericStr.maxLength("Apple", "Peach", "Banana");
        }
    }
}
