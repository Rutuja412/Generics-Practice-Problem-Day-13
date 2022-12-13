using System;

namespace ArrayUsingGenericClass
{

    class Program
    {
        public static void toPrint<T>(T[] inputarray)
        {
            foreach (var element in inputarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------");
        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubleArray = { 1.1, 2.2, 2.3, 2.4, 2.9 };
            char[] charArray = { 'a', 'b', 'c', 'd' };

            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<char>(charArray);
        }
    }
}
