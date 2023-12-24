//Задача 3: Проверка строки на палиндром
public class Task3
{
    public static void Main(string[] args)
    {
        string input = "level";
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine(isPalindrome ? "yes" : "no");
    }
    public static bool IsPalindrome(string str)
    {
        string normalized = new
        string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return normalized.SequenceEqual(normalized.Reverse());
    }
}