using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncDecrOps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инкремент - увеличение значения на единицу
            // Декремент - уменьшение значения на единицу

            int a = 0;
            Console.WriteLine("Initial a = " + a);

            a++;
            Console.WriteLine("a++ = " + a);

            a--;
            Console.WriteLine("a-- = " + a);

            //Операция постфиксного инкрмента (напр. a++) имеет наименьший приоритет
            //Операция префиксного инкремента (напр. ++a) имеет наибольший приоритет

            int b = 1;
            int c = 1;

            b = ++b * b; //данное выражение вернёт 4, так как сначала выполнит ++b (т.е. b = b+1), после чего b станет равно 2.
                         //По итогу получаем b = 2 * 2

            c = c++ * c; //данное выражение вернёт 2, так как сначала выполнится умножение (1*1), а уже потом прибавится 1.

            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
