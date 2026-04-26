using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * + - просто плюс
             * - - просто минус
             * * - просто умножение
             * / - просто деление.
             *     Если хочется хранить дробный результат, стоит дать переменной тип double. 
             *     К тому же, если обе переменные, участвующие в делении, целочисленные, дробной части не будет.
             * % - деление по модулю. Результатом будет остаток от деления.
            */

            // 

            double a = 2;
            int b = 5;
            int c = 9;

            double result = a + b;
            Console.WriteLine(result);

            result = a - b;
            Console.WriteLine(result);

            result = a * b;
            Console.WriteLine(result);

            result = a / b;
            Console.WriteLine(result);

            result = (double) c / b; // в данной строке имеет место операция приведения типов для конвертации c из int в double
            Console.WriteLine(result);

            result = b % a;
            Console.WriteLine(result);

            // Инкремент - увеличение значения на единицу
            // Декремент - уменьшение значения на единицу

            int d = 0;
            Console.WriteLine("Initial d = " + d);

            d++;
            Console.WriteLine("d++ = " + d);

            d--;
            Console.WriteLine("d-- = " + d);

            //Операция постфиксного инкремента (напр. a++) имеет наименьший приоритет
            //Операция префиксного инкремента (напр. ++a) имеет наибольший приоритет

            int bb = 1;
            int cc = 1;

            bb = ++bb * bb; //данное выражение вернёт 4, так как сначала выполнит ++bb (т.е. bb = bb+1), после чего bb станет равно 2.
                         //По итогу получаем bb = 2 * 2

            cc = cc++ * cc; //данное выражение вернёт 2, так как сначала выполнится умножение (1*1), а уже потом прибавится 1.

            Console.WriteLine(bb);
            Console.WriteLine(cc);

        }
    }
}
