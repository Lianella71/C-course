/*
Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

Console.WriteLine("Введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1,10]
Console.WriteLine(string.Join(",  ", array));  
*/
/* ЗАДАЧА 
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да
*/  
/*
int[] array = new int[x];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1,10]
Console.WriteLine(string.Join(",  ", array)); 
int k = new Random().Next(1, 11);
bool flag = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == k)
    flag = true;
    Console.WriteLine("yes");
    break;
}
if (flag == false)
    Console.WriteLine("no");
    */

// --------------------------------------------------------------------------------------
/* Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]
*/
/*
 Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11);  // [-10, 10]
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < array.Length; i++)
    array[i] *= (-1); //  array[i] =  array[i] * (-1)

Console.WriteLine(string.Join(", ", array));
*/

// ---------------------------------------------------------------------------------
/* Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/
/*
Console.Clear();
Console.WriteLine("Введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1,10]
Console.WriteLine(string.Join(",  ", array));  
int[] new_array = new int [array.Length / 2];
for (int i = 0; i < array.Length /2; i++)
new_array[i] = array[i] * array[array.Length -1 -i];
Console.WriteLine(string.Join(",  ", new_array));  
// 0 1 2 3 4 5
//[1 2 3 4 5 6 ]    
// array[0]* array[array.Length -1 -0]
// array[1]* array[array.Length -1 -1]
// array[2]* array[array.Length -1 -2]
*/
// -----------------------------------------------------------------------------------------
/* Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4]
781 => [1 8 7]
*/
/*
Console.Clear();
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    int[] array1 = new int[3]; // Задана длина массива
    for(int i=0; i<3; i++)   // Задали условие
    {
        array1[i] = x%10; // определили последнее число
        x=x/10;           // определили первое число
    }
    Console.WriteLine(string.Join(", ", array1));
    */

//  Решение от преподавателя
Console.Clear();
int[] array = new int[3];

int k =  new Random().Next(100, 1000);  
Console.WriteLine(k);

for (int i = 0; i < array.Length; i++)
{
    array[i] = k % 10;
    k /= 10;
}
Console.WriteLine(string.Join(", ", array));    


