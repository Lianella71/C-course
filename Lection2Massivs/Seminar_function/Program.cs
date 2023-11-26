/*
Console.Clear();

int max_func(int a, int b)
{
    if (a > b)
        return a;
    Console.WriteLine("!!!!!!!!!!!!!!!");
    return b;    
}

int maxxy = max_func(1, 10);
Console.WriteLine(maxxy);
// return возвращает значение при обращении к функции и прекращает ее работу
*/
/*
Console.Clear();
void f(ref int a) // Добавление ref это ссылка на ячейку.
{
    Console.WriteLine(a);
    a = a + 1;
    Console.WriteLine(a);
}
int x = 10;
Console.WriteLine(x);
f(ref x);
Console.WriteLine(x);
// Все что выше это ПРОЦЕДУРА (не функция). Ключевое слово процедуры void. В функции присутствует return (возврат данных)
*/
// -------------------------------------------------------------------------
/* Задайте одномерный массив, заполненный случайными
числами. Определите количество простых чисел в этом
массиве.
Примеры
[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13] => 3
*/
/*
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 20);
}

// 17 -> 1, 17
// 12 -> 1, 2, 3, 4, 6, 12
// 15 -> 1, 3, 5, 15
// 19 -> 1, 19
bool CheckPros(int x)
{
    for(int i = 2; i < x; i++)
        if (x % i == 0)
            return false;
    return true;
}

void ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (CheckPros(array[i]) == true)
            count ++;

    Console.WriteLine(count);
}


Console.Clear();
Console.Write("Введите число элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine(string.Join(", ", array));
ReleaseArray(array);
*/
// ----------------------------------------------------------------------------------------------
/* Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и
делятся нацело на 7.
Пример
[1 5 11 21 81 4 0 91 2 3]
=> 2
*/

// Меняем только кусок
/*
bool CheckPros(int x)
{
    if (x % 10 == 1 && x % 7 == 0)
        return true;
    return false;
}
*/
// ----------------------------------------------------------------------------------------
/* Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231
*/
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 10);
// }




// int ArrayToNumber (int[] array)
// {
//     int x = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         x = x * 10 + array[i];
    
//     }
//     return x;
// }
// // [5, 4, 3, 1]
// // 5
// // 50 + 4 = 54
// // 54 * 10 + 3 = 543
// // 541

// Console.Clear();
// Console.Write("Введите число элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine(string.Join(", ", array));
// int res = ArrayToNumber(array);
// Console.WriteLine(res);
// Console.WriteLine(res.GetType());

// int res2 = Convert.ToInt32(string.Join("", array));
// Console.WriteLine(res2);
// Console.WriteLine(res2.GetType());