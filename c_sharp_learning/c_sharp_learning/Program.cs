using System;

// Однострочный комментарий

/*
 * Многострочный 
 * комментарий
*/

/*
 * Особые типы данных:
 * object - может хранить в себе абсолютно любой тип данных
 * dynamic - почти то же самое, что и object. Динамически типу dynamic можно присваивать всё, что угодно, а object - только один раз
*/

// Console.WriteLine() - метод для аутпута в консоль
// Console.ReadLine() - метод для инпута в консоль

// Convert - класс для конвертации одного типа данных в другой
// parse - метод для конвертации, работает исключительно со строками
// tryparse - аналог parse, но с встроенным try-catch. Если метод ловит ошибку, в аутпутную переменную записывается значение 0. Сам метод возвращает булево значение


namespace c_sharp_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int a, b;
            // a = 100;
            // b = 10;
            
            string c, d, e;
            c = "1";
            d = "1";
            e = "dasdafasdasdaa";

            int cint, dint, eint;

            // string greeting = "Hello,";
            // string data = Console.ReadLine();
            // Console.WriteLine(greeting + " " + data + "!");
            //Console.WriteLine("100 - 10 = " + (a-b));       

            Console.WriteLine("c+d = " + (c + d));
            Console.WriteLine("converted c+d = "+(Convert.ToInt16(c) + Convert.ToInt16(d)));
            Console.WriteLine("parsed c + d = "+(int.Parse(c) + int.Parse(d)));

            int.TryParse(c, out cint);
            int.TryParse(d, out dint);
            int.TryParse(e, out eint);

            Console.WriteLine("tryparsed c + d = " + (cint+dint));
            Console.WriteLine("tryparsed e = eint = " + eint);

        }
    }
}
