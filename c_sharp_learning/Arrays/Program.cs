using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr;        //Массивы в C# являются ссылочными типами. По сути, пока мы не использовали new, в массиве ничего нет, он равен null.

            myArr = new int[5]; //Благодаря new в оперативе выделяется место под 5 элементов типа int.
                                //В myArr возвращается ссылка на место в оперативе.

            myArr[0] = 1; //Присваивание элементу массива с индексом 0 значения 1.

            int[] urArr = new int[5] { 1, 2, 3, 4, 5 }; //Альтернативный способ инициализации массива.
                                                        //Если в фин. скобках не отразить все 5 элементов, вылезет ошибка.

            int[] hisArr = new int[] { 1, 2, 3 }; //Создали массив без явного указания кол-ва элементов.
                                                  //При таком способе инициализации создастся массив длиной в соответствии с кол-вом символов в скобках.
                                                  //На нашем примере это будет как hisArr = new int[3];

            int[] herArr = new [] { 1, 2, 3 }; //Тип данных тоже можно не указывать, так как он автоматически определяется из элементов.

            int[] ourArr = { 1, 2, 3 }; //И так тоже можно.

            int[] theirArr = Enumerable.Repeat(5, 10).ToArray(); //Массив из 10-ти чисел 5. 

            int[] someonesArr = Enumerable.Range(4, 10).ToArray(); //Массив из 10-ти чисел, начиная с 4-х. 

            //МЕТОДЫ ДЛЯ РАБОТЫ С МАССИВАМИ

            Console.WriteLine("Макс. значение массива = " + urArr.Max());
            Console.WriteLine("Мин. значение массива = " + urArr.Min());
            Console.WriteLine("Сумма элементов массива = " + urArr.Sum());
            Console.WriteLine("Сумма элементов массива = " + urArr.Where(i => i%2 == 0).Sum()); //Метод Where позволяет взять подмножество элементов, соответствующее условию
            
            int[] urArrDist = urArr.Distinct().ToArray(); //Distinct позволяет отобрать только уникальные элементы массива
                                                          //ToArray преобразует результат в массив

            int[] urArrSortedAsc = urArr.OrderBy(i => i).ToArray(); //Сортировка по возрастанию
            int[] urArrSortedDesc = urArr.OrderByDescending(i => i).ToArray(); //Сортировка по убыванию

            //Как вариант, можно обратиться к классу Array и использовать его методы. В аргументы методам скрамливаются уже инициализированные массивы
            
            Array.Sort(urArrSortedAsc); //Как пример, сортировка по возрастанию.
            Array.ForEach(urArrSortedAsc, i => Console.WriteLine(i)); //Вывод каждого значения массива

        }
    }
}
