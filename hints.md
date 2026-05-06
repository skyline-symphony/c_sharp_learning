**Преобразование типов**
```
string c = "1";
int c_conv = Convert.ToInt16(c);
int c_parsed = int.Parse(c);
int c_int = (int) c;
```

**Сортировка строки:**
```
string test = "кгуде";
string test_sorted = new string(test.OrderByDescending(x => x).ToArray());
//Вывод - "укедг"
```

**Объединение элементов массива в строку**
```
string result = string.Join(", ", arr);
```

**Полезные функции для работы с массивами**
```
Console.WriteLine("Размерность массива dArr = " + dArr.Rank); //Выведет количество измерений массива
Console.WriteLine("Кол-во элементов в массиве dArr = " + dArr.Length); //Выведет количество всех элементов массива во всех измерениях
Console.WriteLine("Кол-во элементов в 0-м измерении dArr = " + dArr.GetLength(0)); //Выведет количество элементов в 0-м измерении
Console.WriteLine("Макс. значение массива = " + urArr.Max());
Console.WriteLine("Мин. значение массива = " + urArr.Min());
Console.WriteLine("Сумма элементов массива = " + urArr.Sum());
Console.WriteLine("Сумма элементов массива = " + urArr.Where(i => i%2 == 0).Sum()); //Метод Where позволяет взять подмножество элементов, соответствующее условию
```

**Генерация рандомных чисел
```
Random random = new Random();
int rand_val = Random.Next(); //Можно задать в скобках мин. и макс. число для генерации.
```