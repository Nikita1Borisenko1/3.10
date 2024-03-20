using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace example_3_10_3 ///не понял математически как прописать задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите number ");
            int N = int.Parse(ReadLine());
            bool determinate = true;
            while (1 >= N - 1)
            {
                if (N % 2 == 0) N = +1;
                else determinate = false;

            }
            ReadKey();
        }
    }
}