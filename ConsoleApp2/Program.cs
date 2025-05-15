using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        delegate double MinMax(double a, double b);

        static void Main(string[] args)
        {

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            MinMax delegmin = new MinMax(Min);
            MinMax delegmax = new MinMax(Max);
            Console.WriteLine($"Минимальное число: {delegmin(a, b)}");
            Console.WriteLine($"Максимальное число: {delegmax(a, b)}");

            Console.Read();
        }
        public static double Min(double a, double b)
        {
            return a < b ? a : b;
        }
        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }
    }
}
