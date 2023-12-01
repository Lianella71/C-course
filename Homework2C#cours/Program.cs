// Задача №1
// Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.
/*
Console.Clear();
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 7 == 0)
{
    Console.WriteLine($"Число `{x}` кратно 7");
}
else Console.WriteLine($"Число `{x}` не кратно 7");

if (x % 23 == 0)
{
    Console.WriteLine($"Число `{x}` кратно 23");
}
else Console.WriteLine($"Число `{x}` не кратно 23");
    
*/

// Задача №2
/* Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
номер координатной четверти плоскости, в которой находится
 эта точка.
*/
/*
Console.Clear();
Console.WriteLine("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y: ");
int y = Convert.ToInt32(Console.ReadLine());

if ((x > 0) && (y > 0))
                Console.WriteLine("Первая (I) четверть плоскости");
            else
            {
                if ((x < 0) && (y > 0))
                    Console.WriteLine("Вторая (II) четверть плоскости");
                else
                {
                    if ((x < 0) && (y < 0))
                        Console.WriteLine("Третья (III) четверть плоскости");
                    else
                    {
                        if ((x > 0) && (y < 0))
                            Console.WriteLine("Четвертая (IV) четверть плоскости");
                    }
                    Console.ReadKey();
                }
            }
*/

// Задача № 3
/* 
Напишите программу, которая принимает на вход целое
число из отрезка [10, 99] и показывает наибольшую
цифру числа.
*/
/*
Console.Clear();
int max = 0;
int a = new Random().Next (10, 99);
Console.WriteLine("Random = " + a);
while (a > 0)

{
    if (max < a % 10) max = a % 10;
        a /= 10;
}
Console.WriteLine(max);

Console.ReadKey();
*/
// Задача №4
/* Напишите программу, которая на вход принимает 
натуральное число N, а на выходе показывает его
цифры через запятую.
*/
Console.Clear();
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string str = N.ToString();
int[] a = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
    a[i] = int.Parse(str[i].ToString());

}
Console.WriteLine(string.Join(", ", a)); 
