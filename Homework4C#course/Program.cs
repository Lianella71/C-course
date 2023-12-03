// Домашнее задание №4. Самопроверка
// == Задача № 1 == 
/* Напишите программу, которая бесконечно запрашивает
целые числа с консоли. Программа завершается при вводе
символа ‘q’ или при вводе числа, сумма цифр которого чётная.
*/
/*
Console.Clear();
while (true) 
{
    Console.Write("Введите число или (q) для выхода: ");
    string input = Console.ReadLine(); 
    if (input == "q") 
    {
        Console.WriteLine("[Завершение программы]");
        break; 
    }
    int number;
    if (int.TryParse(input, out number))
    {
        int sum = 0;
    while (number > 0) // Вычисление суммы цифр числа
    {
        sum += number % 10; // Добавление последней цифры к сумме
        number /= 10; // Удаление последней цифры из числа
    }
    if (sum % 2 == 0) 
    {
        Console.WriteLine("[Остановка программы]");
        break;
    }
}
else 
{
Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
}
}
*/

//------------------------------------------------------------------------

// == ЗАДАЧА № 2 ==

/*
Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел
в массиве.
*/
/*
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randA = new int[a];
Random random = new Random();
int count = 0;
for (int i = 0; i < randA.Length; i++)
{
    randA[i] = random.Next(100,1000);
    Console.Write(randA[i] + " , ");
    if(randA[i]%2==0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {count}");
*/

//-------------------------------------------------------------------------------------------

// == ЗАДАЧА № 3 == 
/*
Напишите программу, которая перевернёт одномерный массив
(первый элемент станет последним, второй – предпоследним и т.д.) 
*/
/*
Console.Clear();
Console.Write("Введите количество элементов массива: "); // Ввести размер с консоли
int a = Convert.ToInt32(Console.ReadLine());
int[] randA = new int[a];  // Сздала массив 
Random random = new Random(); // Массив будет из случайных чисел
int temporary;   // Ввела переменную для временного хранения
for (int i = 0; i < randA.Length; i++)
{
    randA[i] = random.Next(1,100); // создан массив из случайных чисел в диапазоне
    Console.Write(randA[i] + "  ");
   
}
for (int i = 0; i < randA.Length / 2; i++) // Переворачиваем массив
{
    temporary = randA[i]; // заменила переменую
    randA[i] = randA[randA.Length - 1 - i];
    randA[randA.Length - 1 - i] = temporary;
}

Console.Write("\nПеревернутый массив: ");
Console.WriteLine();
foreach (int x in randA)
{
    Console.Write(x + "  ");
}

*/

