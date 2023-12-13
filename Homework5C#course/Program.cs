

internal class Program
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
     /*
    private static void Main(string[] args)
    {  
        Console.Clear();
    
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
    /*
    static void InputMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 50);
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }

    static void RealiseMatrix(int[,] matrix)
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
    private static void Main(string[] args)
    {
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
    */
    //----------------------------------------------------------------------------------------------
    // === ЗАДАЧА № 3 ====
    //----------------------------------------------------------------------------------------------
    /* 
    Задайте прямоугольный двумерный массив.
    Напишите программу, которая будет находить строку
    с наименьшей суммой элементов.
    */ 
     
    /*
    static void InputMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-5, 100);
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }


    static void SummMatrix(int[,] matrix)
    {
        int index = 0;
        int minsum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                sum = sum + matrix[i, j];
            }
            if (i == 0)
            {
                minsum = sum;
            }
            else if (sum < minsum)
            {
                minsum = sum;
                index = i;
            }
        }
    
        Console.WriteLine();
        string line = string.Empty;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            line += matrix[index, j] + " ";
        }
        Console.WriteLine($"Строка с наименьшей суммой: {line}. ");
    }
    private static void Main(string[] args)
    {
    Console.Clear();
    Console.Write("Введите размеры матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];

    InputMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    SummMatrix(matrix);
    Console.WriteLine();
    }
    */

    //-----------------------------------------------------------------------------------------
    // === ЗАДАЧА № 4 ===
    //-----------------------------------------------------------------------------------------
    /*
    (не обязательная): Задайте двумерный массив из целых чисел.
    Напишите программу, которая удалит строку и столбец, на пересечении 
    которых расположен наименьший элемент массива. Под удалением понимается 
    создание нового двумерного массива без строки и столбца
    */  
    /*
    static void InputMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-5, 100);
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }

    static int minNamber;
    static int minRow;
    static int minCol;
    static void MinPosition(int[,] matrix)
    {
        minNamber = matrix[0,0];
        minRow = 0;
        minCol = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                if (matrix[i, j] < minNamber)
                {
                    minNamber = matrix[i, j];
                    minRow = i;
                    minCol = j;    
                }                
            }                
        }       
    }
       
    static void NewMatrix(int[,] matrix, int [,] newMatrix)
    {
        
        int New_row = 0;
       
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == minRow)
            {
                continue;
            } 
            int New_col = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == minCol)
                {
                    continue;
                }    
                newMatrix[New_row, New_col] = matrix[i,j];                           
                New_col++;                           
            }                   
            New_row++;   
                        
        }
    }
       
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите размеры матрицы: ");
        int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        int[,] matrix = new int[size[0], size[1]];
        InputMatrix(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();
        MinPosition(matrix);
        Console.WriteLine($"Минимальное число в массиве: {minNamber}"); 
        int[,] newMatrix = new int[(matrix.GetLength(0)-1), (matrix.GetLength(1)-1)];    
        Console.WriteLine("Новый массив: ");
        NewMatrix(matrix, newMatrix);
        PrintMatrix(newMatrix);
    }   
    */ 
} 
