using System;

namespace UC1_MaxIntCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum number");

            int output = MaximumNumberCheck.MaximumIntegerNumber(100, 200, 300);
            Console.WriteLine(output);
        }
    }
}
