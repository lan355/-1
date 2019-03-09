using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int X, Y;

            Console.WriteLine("X:");

            X = int.Parse(Console.ReadLine());

            Console.WriteLine("Y:");

            Y = int.Parse(Console.ReadLine());

            Console.WriteLine($"X: {X} Y: {Y}");

            double res = Square(X, Y);

            Console.WriteLine("Ответ: {0} ", res);

            Console.ReadLine();
        }

        static double Square(double x, double y)
        {
            double sum = x - y;

            double result = sum * sum;

            return result;
        }
    }
}
