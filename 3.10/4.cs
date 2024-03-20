using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace example_3_10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = 0;
            Write("Введите число");
            int firstnumber = int.Parse(Console.ReadLine());
            Write("Введите число");
            int secondnumber = int.Parse(Console.ReadLine());
            Write("Введите число");
            int thirdnumber = int.Parse(Console.ReadLine());
            Write("Введите число");
            int fournumber = int.Parse(Console.ReadLine());

            if (((firstnumber < secondnumber) && (firstnumber < thirdnumber) && (firstnumber < fournumber)))
            {
                minValue = firstnumber;
            }
            else
            {
                if (((firstnumber > secondnumber) && (secondnumber < thirdnumber) && (secondnumber < fournumber)))
                { minValue = secondnumber; }
                else
                {
                    if (((firstnumber > secondnumber) && (secondnumber > thirdnumber) && (thirdnumber < fournumber)))
                    { minValue = thirdnumber; }
                    else
                    {
                        if (((firstnumber > secondnumber) && (secondnumber < thirdnumber) && (secondnumber > fournumber)))
                        {
                            minValue = fournumber;
                        }

                        WriteLine($"Минимальное значение = {minValue}");
                    }
                }
            }
        }
    }
}