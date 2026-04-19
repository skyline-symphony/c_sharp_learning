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

        }
    }
}
