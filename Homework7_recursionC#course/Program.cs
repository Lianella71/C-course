// === РЕКУРСИЯ====
// ---- ДОМАШНЕЕ ЗАДАНИЕ № 7------(ПРОВЕРКА ПРЕПОДАВАТЕЛЕМ)-----
// === ЗАДАЧА № 1 =======
/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные
числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
*/
/*
internal class Program
{
    
    
    static string rec(int n, int m)
    {
        if (n < m)
            return "";
        return rec(n - 1, m) + $"{n} ";
        
    }
    static void Main(string[] args)   
    {
        
        Console.Clear();
        Console.Write("Введите число m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(rec(n, m));
        
    }
}
*/
// === ЗАДАЧА № 2 =======
/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int Akkerman(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (n == 0) return Akkerman(m - 1, 1);
            else return Akkerman(m - 1, Akkerman(m, n - 1));
        }

        Console.Write($"Функция Аккермана равно {Akkerman(m, n)} ");
    }
}
*/
// === ЗАДАЧА № 3 =======
/*
Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int[] randA = {2, 4, 8, 9, 0, 15};  // Сздала массив 
        PrintArray(randA);

        static void PrintArray (int [] randA, int i = 0)
        {
            if (i < randA.Length)
            {
                Console.Write(randA[i] + " ");
                PrintArray(randA, i + 1);
            }
        }
    }
}