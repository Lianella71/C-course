// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         if (firstNumber == secondNumber)
//         {
//             Console.WriteLine($"Введенные числа равны `{firstNumber}`");
//         }
//         else if (firstNumber > secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
//         }
//         else if (firstNumber < secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
//         }
//     }

//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//             firstNumber = 5;
//             secondNumber = 6;
//         }

//         CompareNumbers(firstNumber, secondNumber);
//     }
// }


// using System;

// public class Answer {
//     static int FindMax(int a, int b, int c)
//     {
//       int max = a;
//         if (max < b)
//         {
//             max = b;
//         }
//         if (max < c)
//         {
//             max = c;
//         }
//         return max;
//     }

//     static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//             a = int.Parse(args[0]);
//             b = int.Parse(args[1]);
//             c = int.Parse(args[2]);
//         } else {
//             a = 5;
//             b = 6;
//             c = 7;
//         }

//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }

using System;

class Answer {
    static void CheckIfEven(int number)
    {
       int number = Convert.ToInt32(Console.ReadLine());
        if(number % 2 == 0);
        {
            Console.WriteLine("Число четное");
        }
        else
        {
            Console.WriteLine("Число нечетное");
        }   

    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}