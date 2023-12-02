// ЗАДАЧА № 1
// Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов массива,
// значения которых лежат в отрезке [20,90].
/*
Console.Clear();
int n = 10;
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
   array[i] = new Random().Next(1, 101);  // [1,100]
Console.WriteLine(string.Join(", ", array));
}

int a = int.Parse (20);
int b = int.Parse (90);
int count = 0;
for (int i =0; i < n; i++)
    if ((array[i] >= a) && (array[i] <= b)) count++;
Console.WriteLine("Количество элементов в диапазоне " + count);
Console.ReadKey();
*/

int n = int.Parse(Console.ReadLine()); // вводим размер массива
            int[] mas = new int[n]; //создаем массив
            
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1, 100);  //заполняем массив числами от 1 до 100
                Console.Write("{0,4}", mas[i]); // выводим массив на экран для контроля
            }
            Console.WriteLine();
 
            int A = int.Parse(Console.ReadLine());  // вводим с клавиатуры  A
            int B = int.Parse(Console.ReadLine()); // вводим с клавиатуры В
            int count = 0; //создаем счетчик
 
            for (int i = 0; i < n; i++) 
                if ((mas[i] >= A) && (mas[i] <= B)) count++;  // считаем кол-во элементов mas[i] в диапазоне
            Console.WriteLine("Количество элементов в диапазоне " + count); //выводим на экран



    
