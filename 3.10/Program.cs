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

namespace example_3_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Добро пожаловать в счетчик карт в игре 21");
            Write("Введите колличество обычных карт в руке");
            int quantity = int.Parse(ReadLine());
            Write("Введите колличество карт - картинок в руке");
            int icons = int.Parse(ReadLine());
            int summ = 0;
            for (int i = 0; i != quantity; i++)
            {
                Write("Введите вес карты");
                summ = summ + int.Parse(ReadLine());
            }
            WriteLine(summ + icons * 10); // зачем прописывать 21 кейс, если это только увеличит код. Я усвоил оператор swift, но в этом задании им делать - копипастить строки
            ReadKey();

        }
    }
}

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

namespace example_3_10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Игра угадайка");
            Random random = new Random();

            int iiNumber = random.Next(1, 1000);
            int count = 0;
            int userNumber;

            for(; ; )
            {
                Write("Введите число: ");
                count++;
                userNumber=Convert.ToInt32(Console.ReadLine());
                if (userNumber < iiNumber)
                {
                    WriteLine("Введенное число меньше загаданного, попробуйте еще");
                }
                else if (userNumber > iiNumber)
                {
                    WriteLine ("Введенное число больше загаданного, попробуйте еще");
                }
                else
                {
                    WriteLine($"Вы угадали! Число попыток: {count}");
                    ReadKey();
                }
            }
        }
    }
}