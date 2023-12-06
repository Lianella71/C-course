// ПРАКТИКА НА C#. САМООБРАЗОВАНИЕ.
// Пишем калькулятор с помощью if/else & switch

// КАЛЬКУЛЯТОР С ПОМОЩЬЮ switch
/*

while(true)
{
    Console.Clear();
    double firstValue, secondValue;  // Введем две переменные первая переменная и вторая переменная
    string action;
    try // Используем этот цикл что бы исключить обрушивание при вводе символов вместо чисел
    {
        Console.WriteLine("Введите число 1");
        firstValue = double.Parse(Console.ReadLine());
                                                        // Запрашивает ввод
        Console.WriteLine("Введите число 2");
        secondValue = double.Parse(Console.ReadLine());
    }
    catch (System.Exception)
    {
        
        Console.WriteLine("Не удалось конвертировать строку в число!"); // Выводит сообщение об ошибке при вводе абракадабры
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("Выберете операцию: `+` `-` `*` `/`"); // указываем подсказку какие могут быть операции
    action = Console.ReadLine(); // Считаем с консоли что введет пользователь

    switch (action)
    {
        case "+":
            Console.WriteLine(firstValue + secondValue);
            break;
        case "-":
            Console.WriteLine(firstValue - secondValue);
            break;
        case "*":
            Console.WriteLine(firstValue * secondValue);
            break;
        case "/":
            if (secondValue == 0) // Проверяем делимое на нуль
                Console.WriteLine(0); // если там нуль, значит выводим 0
            else 
                Console.WriteLine(firstValue / secondValue); // если нет, то производим деление
            break;

        default:
            Console.WriteLine("Ошибка! Неизвестное действие");
            break;
    }
    Console.ReadLine();
}
*/


// КАЛЬКУЛЯТО  с помощью if/else

/*Console.Clear();
double firstValue, secondValue;  // Введем две переменные первая переменная и вторая переменная
    string action;

    Console.WriteLine("Введите число 1");
    firstValue = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите число 2");
    secondValue = double.Parse(Console.ReadLine());

    Console.WriteLine("Выберете операцию: `+` `-` `*` `/`"); // указываем подсказку какие могут быть операции
    action = Console.ReadLine(); // Считаем с консоли что введет пользователь

    if (action == "+")
    {
        Console.WriteLine(firstValue + secondValue);
    }
    else if (action == "-")
    {
        Console.WriteLine(firstValue - secondValue);
    }
    else if (action == "*")
    {
        Console.WriteLine(firstValue * secondValue);
    }
    else if (action == "/")
    {
        if (secondValue == 0) // Проверяем делимое на нуль
                Console.WriteLine(0); // если там нуль, значит выводим 0
            else
                Console.WriteLine(firstValue / secondValue); // если нет, то производим деление       
    }
    else
    {
        Console.WriteLine("Ошибка! Неизвестное действие");
    }
*/

// Сумма и количество четных и нечетных чисел в указанном диапазоне
/*

Console.Clear();
uint oddNumbersCount = 0; //Счетчик под нечетные числа odd - переводится как нечетное
uint evenNumbersCount = 0; // Счетчик под четные  even - переводится как четное

int oddNumbersSum = 0;
int evenNumbersSum = 0;

Console.WriteLine("Введите первое число диапазона");
int currentValue = int.Parse(Console.ReadLine()); // начало нашего диапазона
Console.WriteLine("Введите последнее число диапазона");
int limit = int.Parse(Console.ReadLine()); // конец диапазона

while (currentValue <= limit)
{
    if (currentValue % 2 == 0)
    {
        
        evenNumbersCount++;
        evenNumbersSum = evenNumbersSum + currentValue; 
    }
    else
    {
        oddNumbersSum = oddNumbersSum + currentValue;
        oddNumbersCount++;
    }
    currentValue++;
}

Console.WriteLine("Количество нечетных чисел: " + oddNumbersCount);
Console.WriteLine("Количество четных чисел: " + evenNumbersCount);
Console.WriteLine("Сумма нечетных чисел: " + oddNumbersSum);
Console.WriteLine("Сумма четных чисел: " + evenNumbersSum);
Console.ReadLine();
*/

// ВЛОЖЕННЫЕ ЦИКЛЫ
// Рисуем прямоугольник/квадрат
/*
Console.Clear();
Console.Write("Введите высоту прямоугольника: ");
int height = int.Parse(Console.ReadLine());

Console.Write("Введите ширину прямоугольника: ");
int width = int.Parse(Console.ReadLine());

for (int j = 0; j < height; j++)
{
    
    for (int i = 0; i < width; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadLine();
*/

// РИСУЕМ ТРЕУГОЛЬНИКИ В КОНСОЛИ

/* 
*
**
***
****
*****

Console.Clear();
Console.Write("Введите высоту треугольника: ");
int height = int.Parse(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadLine();
*/

/* 
*****
****
***
**
*


Console.Clear();
Console.Write("Введите высоту треугольника: ");
int height = int.Parse(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    for (int j = height; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadLine();
*/

/*
        *
       **
      ***
     ****
    *****

Console.Clear();
Console.Write("Введите высоту треугольника: ");
int height = int.Parse(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    for (int j = height; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadLine();
*/
