/* 
Знакомство с языками программирования (семинары)
Урок 5. Двумерные Массивы. 
*/
// ДОМАШНЕЕ ЗАДАНИЕ №5. (Проверка преподавателем)
/*
=== ЗАДАЧА №1 ====
Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.
*/

internal class Program
{
    private static void Main(string[] args)
    {
    /* 
    Знакомство с языками программирования (семинары)
    Урок 5. Двумерные Массивы. 
    */
    // ДОМАШНЕЕ ЗАДАНИЕ №5. (Проверка преподавателем)
    /*
    //----------------------------------------------------------------
    === ЗАДАЧА №1 ====
    //----------------------------------------------------------------
                
    Напишите программу, которая на вход принимает позиции элемента
    в двумерном массиве, и возвращает значение этого элемента или же указание,
    что такого элемента нет.
    */
        //Console.Clear();
    /*
        Console.Write("Введите размеры матрицы: ");
        int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        int[,] myArray = new int[size[0], size[1]];
        Random random = new Random();
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                myArray[i, j] = random.Next(20);
                Console.Write(myArray[i, j] + "\t"); 
            }
            Console.WriteLine();
        } 
        Console.WriteLine("Введите позицию элемента двумерного массива: ");
        Console.Write("Строка №: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Столбец №: ");
        int col = Convert.ToInt32(Console.ReadLine());
        int rows = myArray.GetLength(0);
        int columns = myArray.GetLength(1);

        if ( row >= 0 && row < rows && col >= 0 && col < columns)
        {
            int element = myArray[row, col];
            Console.WriteLine("Значение элемента: " + element);
        }
        else
        {
            Console.WriteLine("Такого элемента не существует!");
        }
    */
    //----------------------------------------------------------------------
    // === ЗАДАЧА №2 ===
    //---------------------------------------------------------------------
    /*
    Задайте двумерный массив. Напишите программу, 
    которая поменяет местами первую и последнюю строку 
    массива. 
    */

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
            int row = matrix.GetLength(0)-1;
            int temp;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                temp = matrix[0, i];
                matrix[0, i] = matrix[row, i];
                matrix[row, i] = temp;
            }
            
        }

        Console.Clear();
        Console.Write("Введите размеры массива: ");
        int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        int[,] matrix = new int[size[0], size[1]];
        
        InputMatrix(matrix);
        Console.WriteLine("Изначальный массив: ");
        PrintMatrix(matrix);
        Console.WriteLine("Измененный массив: ");
        RealiseMatrix(matrix);
        PrintMatrix(matrix);




    }
} 
