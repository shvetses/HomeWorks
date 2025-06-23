// Составить регулярное выражение для проверки корректности номера телефона.
// Корректный номер имеет формат +7(123)456-78-90.

using System.Text.RegularExpressions;

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер телефона: ");
            string phone = Console.ReadLine();

            Regex regex = new Regex(@"^\+7\(\d{3}\)\d{3}-\d{2}-\d{2}$");
            bool isValid = regex.IsMatch(phone);

            Console.WriteLine(isValid ? "Номер корректен" : "Номер некорректен");
        }
    }
}
