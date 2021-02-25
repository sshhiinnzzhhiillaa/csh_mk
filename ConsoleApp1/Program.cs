using System;
using MyMatrixLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int res, m = 0, n = 0;

            Console.WriteLine("Enter m");
            while (int.TryParse(Console.ReadLine(), out res))
            {
                m = res;
                break;
            }

            Console.WriteLine("Enter n");
            while (int.TryParse(Console.ReadLine(), out res))
            {
                n = res;
                break;
            }

            Matrix a = new Matrix(m, n);
            a.ReadMatrix();
            Console.WriteLine("increased: " + a.NumberOfRowsIncreased());
            Console.WriteLine("decreased: " + a.NumberOfRowsDecreased());
            Console.WriteLine("equal: " + a.NumberOfRowsWithEqualElements());
            Console.WriteLine("disordered: " + a.NumberOfRowsDisordered());
        }
    }
}