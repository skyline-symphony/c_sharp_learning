using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Цикл while

            //int num = int.Parse(Console.ReadLine());
            //int cnt = 0;
            //int chet = 0;
            //int nechet = 0;

            //while (cnt < num)
            //{
            //    cnt++;
            //    if (cnt % 2 == 0)
            //    {
            //        chet++;
            //    }
            //    else
            //    {
            //        nechet++;
            //    }
            //}

            //Console.WriteLine("chet = " + chet);
            //Console.WriteLine("nechet = " + nechet);

            // do {...} while (); - Аналогичен while, но сначала совершается первая итерация, а уже потом идёт проверка на условие.
            // Т.о., цикл отработает как минимум 1 итерацию.

            //Цикл for
            //Переменная i, объявленная внутри цикла for, изолирована от остального кода. Т.е. обращение к данной переменной вне цикла невозможно,
            //так как вне цикла она не существует.

            //int length = 5;

            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine("i is "+i+" now.\n");
            //}

            //Ни одна из секций цикла for не является обязательной!!!

            //for (; ; )
            //{
            //    Console.WriteLine("for is working"); //такой код будет бесконечно работать и выводить строку "for is working"
            //}

            //int height = 10;

            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < height - i; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.Write("\n");
            //}

            Console.WriteLine("\n");

            int width = 10;
            int middle = width / 2 + width % 2;

            for (int i = 0; i < width; i++)
            {
                int l_bound = middle - i;
                int r_bound = middle + i;

                if (l_bound <= 0) { break; }

                for (int j = 0; j <= width; j++)
                {
                    if (j >= l_bound && j <= r_bound)
                    {
                        Console.Write("#");
                    }
                    else { Console.Write(" "); }
                }
                Console.Write("\n");
            }



        }
    }
}
