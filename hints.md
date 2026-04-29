**Сортировка строки:**
```
string test = "кгуде";
string test_sorted = new string(test.OrderByDescending(x => x).ToArray());
//Вывод - "укедг"
```