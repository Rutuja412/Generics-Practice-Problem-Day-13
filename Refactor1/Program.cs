using System;

namespace Refactor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Number!!");
            int[] Array = { 123, 464, 353, };
            GenericMaximum<int> generic = new GenericMaximum<int>(Array);
            generic.PrintMaxValue();

            double[] doubleArray = { 1.1, 1.2, 1.3 };
            GenericMaximum<double> genericMaximum = new GenericMaximum<double>(doubleArray);
            genericMaximum.PrintMaxValue();

            string[] stringArray = { "Apple", "Banana", "Pineapple" };
            GenericMaximum<string> genericMaximum1 = new GenericMaximum<string>(stringArray);
            genericMaximum1.PrintMaxValue();

        }
    }
}
