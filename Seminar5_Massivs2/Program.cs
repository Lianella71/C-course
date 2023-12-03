/*
// Способ задачи одномерного массива с введением цифр в строке
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// 5 4 1 2   Console.ReadLine(). Вводится последовательность значений в строку через пробел
// "5 4 1 2" Split(" ") преобразует в такой вид
// "5", "4", "1", "2"
// 5, 4, 1, 2
// [5, 4, 1, 2]  ToArray(); Преобразование в массив
// Select(x => int.Parse(x)) - Задает значение х внутри скобок. Присваивает каждому элементу значение х.
Console.WriteLine(string.Join(", ", array));
*/

//-------------------------------------------------------------------------------------

// == ДВУМЕРНЫЕ МАССИВЫ=================    

/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
*/
//------------------------------------------------------------------------------
// ==== ЗАДАЧА №1========

/* Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты.
Пример
2 3 4 3           4 3 16 3
4 3 4 1 =>        4 3 4 1
2 9 5 4           4 9 25 4
*/

/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

void RealiseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if(i % 2==0 && j % 2 == 0)
            Console.Write(matrix[i, j] * matrix[i, j] + "\t");
            else
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Новый массив: ");
RealiseMatrix(matrix);
*/

//--------------------------------------------------------------------------------------
// ==== ЗАДАЧА №2 ===========

/*
Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и
т.д.
Пример
2 3 4 3
4 3 4 1 => 2 + 3 + 5 = 10
2 9 5 4 
*/
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

void RealiseMatrix(int[,] matrix)
{
    int summa = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (i == j)
                summa = summa + matrix[i, j];
        }
    }
    Console.WriteLine(summa);
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
//Console.WriteLine("Новый массив: ");
RealiseMatrix(matrix);
*/

//------------------------------------------------------------------------------

// ===== ЗАДАЧА № 3 ========
/*
Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива.
Пример
2 3 4 3
4 3 4 1 => [3 3 5]
2 9 5 4
*/
/*
void InputMatrix(int[,] matrix) // Метод создания матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
    }
}

void PrintMatrix(int[,] matrix) // Метод вывода матрицы на печать
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

int[] RealiseMatrix(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int summa = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            summa = summa + matrix[i, j];
        }
        array[i] = summa / matrix.GetLength(1);
    }
    return array;
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] array = new int[size[0]];
InputMatrix(matrix);
PrintMatrix(matrix);

array = RealiseMatrix(matrix);
Console.WriteLine(string.Join(", ", array));
*/
