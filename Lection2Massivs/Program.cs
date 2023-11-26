// Ищем максимум из 9 чисел
// 1. Стихийный метод
/*
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;
// Введи 9 переменных (целых чисел)
// Определим первую переменную max  в которую положим значение первого аргумента
int max = a1;
// Сравниваем поочередно по принципу Если следующее число больше чем Мах, то мах присвается новое значение.
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
*/
// Решение с помощью функции (метода)
//Будем искать сначала большее из первых трех, потом из второй тройки, потом из третьей, далее ищем большее из полученных значений.
//задаем переменную
// int Max(int arg1, int arg2, int arg3)
// // Задаем тело метода
// {
//     int result = arg1; 
//     // Определяем внутренний результат где будет храниться значение методамаксимального
//     // Задаем условие
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     // Теперь нам надо что бы наш метод возвращал результат
//     return result;
// }
// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 3333;
// int a3 = 13;
// int b3 = 23325;
// int c3 = 313;
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
// Можно итоговые результаты записать кодом в одной строке

// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
// Console.WriteLine(max);

// МАССИВЫ

/* int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
} // Индексы    0    1   2    3   4   5   6   7   8
int [] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};
// теперь для того что бы обратиться к конкретному элементу мы пишем имя нашего массива, в скобках используем  его индекс.
// array[0] = 12; // После срабатывания программы [0] примет значение 12, хотя сейчас 11
// Console.WriteLine(array[4]);
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);
*/ 

// Задача на нахождение индекса

/* Имеется одномерный масиив array из n элементов.Требуется найти элемент массива со значением find.
1. Установить счетчик index в позицию 0
2. Если array[index] = find, алгоритм завершил работу успешно
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно 
*/ 
// задаем массив
/*
int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };
// задаем переменной n количество элементов массива, в нашем случае оператор считывает количество из строчки выше и возвращает значение.
int n = array.Length;
// Задаем значение find, в какой позиции оно будет. 
int find = 18;
// Задаем первичное значение index
int index = 0;
// Далле нам потребуется цикл While с котором мы будем проверять: если индекс меньше n, 

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    // index = index + 1; // Увеличение индекса на единицу
    index ++;
}
*/
/*
// Если в массиве есть несколько искомых чисел
int[] array = { 1, 12, 31, 18, 15, 16, 17, 18 };
int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // Вводим оператора прерывания. Тогда программа остановится напервом найденном элементе с нужным значением
    }
    index ++;
}
*/
/*
//Зададим массив, укажем что там по умолчанию 10 элементов. 

void FillArray(int [] collection)
{
    int length = collection.Length; // Получение длины нашего массива
    int index = 0; // Задаем первичное значение индекса
    // Задаем условия в цикле While. Пока действует условия делаем тело цикла
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // В позицию положить новое случайное число из диапазона (1, 10)
        // index = index + 1;
        index++;
    }
}

void PrintArray(int [] col) // Метод выводит на печать
{
    int count = col.Length; // вывод массива
    int position = 0;  // изменилось имя вместо index
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // Третий метод с возвращением данных.
{
    int count = collection.Length; // определяем количество элементов массива
    int index = 0;
    int position = 0;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;

}
int[] array = new int [10]; 
// Дословно - создай новый массив в котором 10 элементов. По умолчанию он будет наполнен нулями.
// Для того что бы его наполнить воспользуемся методом выше. 
// Метод Void использует когда не нужно возвращать данные. Одновременно с ним не используется return!!

// Тестируем методы: 
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/

