//Задача 4 (необязательная): Обратный порядок слов в строке
public class Task4
{
    public static void Main(string[] args)
    {

        string input = "Hello world";

        string result = ReverseWords(input);

        Console.WriteLine(result);
    }

    public static string ReverseWords(string str)
    {

        string[] words = str.Split(' ');

        Array.Reverse(words);

        return string.Join(" ", words);
    }
}