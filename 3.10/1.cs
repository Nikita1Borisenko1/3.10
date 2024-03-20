using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace example_3_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите число, которое нужно проверить на четность");
            int number = int.Parse(ReadLine());
            if (number % 2 == 0) WriteLine("Четное число");
            else WriteLine("Число нечетное");
            ReadKey();
        }
    }
}