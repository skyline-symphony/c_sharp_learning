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

**Функции для получения статистики и меты о массивах и списках**
```
- Console.WriteLine("Размерность массива dArr = " + dArr.Rank); //Выведет количество измерений массива
- Console.WriteLine("Кол-во элементов в массиве dArr = " + dArr.Length); //Выведет количество всех элементов массива во всех измерениях
- Console.WriteLine("Кол-во элементов в 0-м измерении dArr = " + dArr.GetLength(0)); //Выведет количество элементов в 0-м измерении
- Console.WriteLine("Макс. значение массива = " + urArr.Max());
- Console.WriteLine("Мин. значение массива = " + urArr.Min());
- Console.WriteLine("Сумма элементов массива = " + urArr.Sum());
```

**Функции для модификации массивов и списков**
```
- data.RemoveAll(x => x==0); //Удаление элементов по определенному условию. В данном примере удаляются все нули
- urArr.Where(i => i%2 == 0); //Метод Where позволяет взять подмножество элементов, соответствующее условию
- data.Add(data[i]); //Добавление элемента в конец массива
- data.AddRange(Enumerable.Repeat(0, toAdd)); //Добавление диапазона элементов в конец массива
- colors.Insert(1, "green"); //Вставка элемента по индексу
- data.InsertRange(0, Enumerable.Repeat(0, toAdd)); //Добавление диапазона элементов, начиная с какого-то индекса
- fruits.RemoveAt(1); //Удаление элемента по индексу
- fruits.RemoveRange(0, 2); //Удаление элементов, индексы которых попадают в диапазон. В данном примере удаляются 2 элемента, начиная с индекса 0
- fruits.Clear(); //Очистка всего массива
```

**Генерация рандомных чисел**
```
Random random = new Random();
int rand_val = Random.Next(); //Можно задать в скобках мин. и макс. число для генерации.
```