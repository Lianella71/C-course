internal class Program
{
    /* 
    Знакомство с языками программирования (семинары)
    Урок 5. Массивы и строки
    */
    // ДОМАШНЕЕ ЗАДАНИЕ №6. (Самопроверка)
    
    //----------------------------------------------------------------
    //             === ЗАДАЧА №1 ====
    //----------------------------------------------------------------
    /* 
    Задайте двумерный массив символов (тип char [,]). 
    Создать строку из символов этого массива.
    */   
    /* 
    public static void Main(string[] args)
    {
        Console.Clear();
        char[,] myArray = new char[,]{{'H', 'e', 'l', 'l', 'o'}, {'W', 'o', 'r', 'l', 'd'}};
        string result = CreateStringFrom2DArray(myArray);
        Console.WriteLine(result);

    }
   public static string CreateStringFrom2DArray(char[,] array)
    {
        string result = ""; 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                result += array[i, j];
            }
        }
        return result;

    }
    */
    //----------------------------------------------------------------
    //             === ЗАДАЧА №2 ====
    //----------------------------------------------------------------
    /* 
    Задайте строку, содержащую латинские буквы в обоих регистрах. 
    Сформируйте строку, в которой все заглавные буквы заменены 
    на строчные.
    */
    /*
    public static void Main(string[] args)
    {
        Console.Clear();
        string input = "HeLLo WoRld";
        string result = input.ToLower();
        Console.WriteLine(result);

    }
    */
    //----------------------------------------------------------------
    //             === ЗАДАЧА №3 ====
    //----------------------------------------------------------------
    /* 
    Задайте произвольную строку. Выясните, является ли она палиндромом.
    */
    /*
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите строку/слово на проверку: ");
        string input = Console.ReadLine();
        
        bool isPalindrome = IsPalindrome(input);
        Console.Write("Результат проверки: ");
        Console.WriteLine(isPalindrome ? "Yes" : "No");

    }
    public static bool IsPalindrome(string str)
    {
        string normal = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return normal.SequenceEqual(normal.Reverse());
    }
    */
}
