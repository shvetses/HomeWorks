// Ввести с клавиатуры предложение.
// Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
// Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
// (пример палиндрома – «А роза упала на лапу Азора»).

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            string cleaned = input.Replace(" ", "").ToLower();
            bool isPalindrome = true;

            for (int i = 0; i < cleaned.Length / 2; i++)
            {
                if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? "Это палиндром" : "Это не палиндром");
        }
    }
}
