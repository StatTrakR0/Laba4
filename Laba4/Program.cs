using System;

namespace Lab04
{
    class Program
    {
        static double Func2(double x1, double x2)
        {
            double b, c, d; 
            b = Math.Log10(x2 / x1);
            c = Math.Pow(Math.Cos(b), 2);
            d = 45 + x2;

            return c / d;
        }



        static void Main(string[] args)
        {
            double startX = 1, dx = 0.5;
            const int size = 500;
            double[] arr = ClassLibraryLab04.Class1.CreateArrayFromTemplate(startX, dx, size, x => Func2(x * 2.76, x * 0.5));
            ClassLibraryLab04.Class1.PrintArray(arr);
            ClassLibraryLab04.Class1.BubbleSort(arr);
            ClassLibraryLab04.Class1.PrintArray(arr);

            ClassLibraryLab04.Class1.ProcessArray(arr, out double min, out double max, out double avg);

            Console.WriteLine("Min={0:#0.####}, Max={1:#0.####}, Avg={2:#0.####}", min, max, avg);

            int count = ClassLibraryLab04.Class1.PostProcessArray(arr, x => x >= 0.9 * avg && x <= 1.1 * avg);
            Console.WriteLine("R={0}", count);
            Console.WriteLine();

        }
    }
}