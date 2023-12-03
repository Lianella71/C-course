/* Задайте массив символов (тип char []). Создайте строку из
символов этого массива.
Указание
Конструктор строки вида string(char []) не использовать.
Пример
[‘a’, ‘b’, ‘c’, ‘d’] => “abcd”
*/
// 1 вариант решения
/*
char[] array = new char[]{'a', 'b', 'c', 'd'};
string str = "";
for(int i = 0; i < array.Length; i++)
    str += array[i]; // str = str + array[i]
Console.WriteLine(str);
*/
// Вариант 2. 
/*
char[] array = new char[]{'a', 'b', 'c', 'd'};
string str = "";
foreach(char el in array)
    str += el;
Console.WriteLine(str);
*/
//------------------------------------------------------------
/* На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.
Пример
“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’]
*/
/*
string str = "Hello!";
char[] a = new char[str.Length];

for  (int i = 0; i < str.Length; i++) a[i] = str[i];

for (int i = 0; i < a.Length; i++) Console.Write($"*{a[i]}*, ");
*/

// Решение от преподавателя

// Console.Clear();
// string str = "Hello!";
// char[] res = new char[str.Length];
// for (int i = 0; i < str.Length; i++)
//     res[i] = str[i];

// Console.WriteLine($"'{str}' => [{string.Join(", ", res)}]");

//--------------------------------------------------------

/* Считать строку с консоли, состоящую из латинских
букв в нижнем регистре. Выяснить, сколько среди
введённых букв гласных.
Пример
“hello” => 2
“world” => 1
*/
/* Решение от сокурсника

Console.Clear();
string str = Console.ReadLine();
int gl(string str){
    int count = 0;
    for(int i = 0; i < str.Length; i++){
        if(str[i] == 'o' || str[i] == 'a' || str[i] == 'l' || str[i] == 'e' || str[i] == 'u' ||  str[i] == 'y' )
            count++;
    }
    return count;
}
Console.WriteLine(gl(str));
*/
//-----------------------------------------------------------
/* Решение от преподавателя

Console.Clear();
string str = "hEllO";
int count = 0;
str = str.ToLower();
foreach(char s in str)
    if (s == 'e' || s == 'u' || s == 'o' || s == 'a' || s == 'i')
        count ++;
Console.WriteLine($"'{str}' => {count}");
*/
