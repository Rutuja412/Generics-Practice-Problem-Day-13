using System;

namespace UC_2MaxFloatNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Number");
            double doubleOutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 12.2, 10.2);
            Console.WriteLine(doubleOutput);
        }
    }
}
