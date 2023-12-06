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