using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 * && - сокращенное И - в отличие от "полного И", не проверяет второе условие, если первого уже достаточно, чтобы "сделать вывод".
 *                      Например, если 1-е условие уже False, то нет смысла проверять второе, так как в любое случае конечный результат будет False
 * || - сокращенное ИЛИ - аналогично с сокр. И
 * & - И - фактически не используется, потому что есть сокр. аналог
 * | - ИЛИ - фактически не используется, потому что есть сокр. аналог
 * ! - НЕ (унарный)
*/


namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Четное!");
            }
            else
            {
                Console.WriteLine("Нечетное!");
            }

            string check = null;

            while ((check != "false") && (check != "true"))
            {
                Console.WriteLine("Возможные значения только true или false!");
                check = Console.ReadLine();
            }

            string result = null;

            if (bool.Parse(check))
            {
                result = "Проверка успешна!";
            }
            else
            {
                result = "Проверка ошибочка!";
            }

            Console.WriteLine(result);

        }
    }
}
