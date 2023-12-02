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
/*
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int x = Convert.ToInt32(Console.ReadLine());
double[] mas = new double[x];
Random r = new Random();

for (int i = 0; i < x; i++)
{
    mas[i] = r.Next(1, 10) + Math.Round(r.NextDouble(), 0);
    Console.Write($"{mas[i]} ");
}
double min = mas[0];
double max = mas[0];
for (int i = 0; i < x; i++)
{
    if (min > mas[i]) min = mas[i];
    if (max < mas[i]) max = mas[i];
}
Console.WriteLine($"\n Минимальный элемент: {min}\n Максимальный элемент: {max}");
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {(max - min):F2}");
*/

//------------------------------------------------------------------------------------------------

// == ЗАДАЧА № 4** == 

/* Дано натуральное число в диапазоне от 1 до 100 000. 
Создайте массив, состоящий из цифр этого числа. 
Старший разряд числа должен располагаться на 0-м индексе массива, 
младший – на последнем.
Размер массива должен быть равен количеству цифр.
*/
/*
Console.Clear();
int a = new Random().Next (1, 100000);
Console.WriteLine("Random = " + a);
string str = a.ToString();
int[] x = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
    x[i] = int.Parse(str[i].ToString());
}
int length = x.Length;
Console.WriteLine("Размер массива: = " + length);
// Console.WriteLine("Массив:  " + х);
Console.WriteLine(string.Join(", ", x)); 
*/



