using System;
using Proj;

namespace Laba
{
    class Program
    { 
        static void Main(string[] args)
        {
            double result_div = MyLibrary.Divide(3,5);
            Console.WriteLine(result_div);

            double result_add = MyLibrary.Add(3, 5);
            Console.WriteLine(result_add);

            double result_sub = MyLibrary.Substract(3, 5);
            Console.WriteLine(result_sub);

            double result_mult = MyLibrary.Multiply(3, 5);
            Console.WriteLine(result_mult);
        }
    }
}