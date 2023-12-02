// ЗАДАЧА № 1
// Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов массива,
// значения которых лежат в отрезке [20,90].

Console.Clear();

int n = 10; 
int[] mas = new int[n]; 
            
Random r = new Random();
for (int i = 0; i < n; i++)
    {
        mas[i] = r.Next(1, 100);  
        Console.Write($"{mas[i]} "); 
    }
Console.WriteLine();
 
int A = 20;  
int B = 90; 
int count = 0;
 
for (int i = 0; i < n; i++) 
    if ((mas[i] >= A) && (mas[i] <= B)) count++;
    Console.WriteLine("Количество элементов лежащих в отрезке [20,90] - " + count);
    
