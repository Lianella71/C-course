// == ЗАДАЧА № 1==
// Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов массива,
// значения которых лежат в отрезке [20,90].
/*
Console.Clear();

int n = 10; 
int[] mas = new int[n]; 
            
Random r = new Random();
for (int i = 0; i < n; i++)
    {
        mas[i] = r.Next(1, 100);  
        Console.Write($"{mas[i]} "); 
    }
Console.WriteLine();
 
int A = 20;  
int B = 90; 
int count = 0;
 
for (int i = 0; i < n; i++) 
    if ((mas[i] >= A) && (mas[i] <= B)) count++;
    Console.WriteLine("Количество элементов лежащих в отрезке [20,90] - " + count);
   */

//------------------------------------------------------------------------------------

// == ЗАДАЧА №2 ==
/*  Задайте массив на 10 целых чисел.
 Напишите программу, которая определяет 
 количество чётных чисел в массиве.
 */
/*
Console.Clear();
int n = 10;
int [] a = new int [n];
Random r = new Random();
int count = 0;
for (int i = 0; i < n; i++)
{
    a [i] = r.Next(1, 100);
    Console.Write($"{a[i]} ");
    if ((a[i] % 2 == 0))
    count++;
}
Console.WriteLine();
Console.WriteLine(count);
*/

//------------------------------------------------------------------------------

// == ЗАДАЧА № 3 ==
/* Задайте массив из вещественных чисел с ненулевой дробной частью.
 Найдите разницу между максимальным и минимальным элементов массива.
 */

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

// double min = double.MaxValue;
// double max = double.MinValue;
for (int i = 0; i < a; i++)
{
    a[i] = new Random().Next(1, 100);  
    Console.WriteLine(string.Join(", ", a));
}

 
            



/*
Console.WriteLine("Разница между макс и мин: {0}", max - min);
 
Console.ReadKey();
*/

