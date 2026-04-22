using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey consoleKey = Console.ReadKey().Key; //Позволяет сохранить информацию, как конкретно клавиша была нажата на клавиатуре

            switch (consoleKey)
            {
                default:
                    Console.WriteLine("Такой клавиши нет в кейсах");
                    break;
                case ConsoleKey.A:
                    Console.WriteLine("Была нажата клавиша A");
                    break;
                case ConsoleKey.Tab:
                    Console.WriteLine("Была нажата клавиша Tab");
                    break;
            }

            int a = int.Parse(Console.ReadLine());

            switch (a) //В скобки передается значение, на основании которого будет выполняться тот или иной блок кода.
                       //Например, число.
            {
                default: // Дефолтный блок на случай, если полученное на вход значение не соответствует ни одному кейсу.
                    Console.WriteLine("Такого нет!");
                    break;

                case 1:
                    Console.WriteLine("Введено число 1");
                    break;

                case 2:
                    Console.WriteLine("Введено число 2");
                    break;
            }



        }
    }
}
