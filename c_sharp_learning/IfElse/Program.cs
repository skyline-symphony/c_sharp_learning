using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
