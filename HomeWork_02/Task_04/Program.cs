// Вводится четырехзначное число. Поменять местами 2-ую и 4-ую цифру.

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Разбиваем число на цифры
            int digit1 = number / 1000;
            int digit2 = (number / 100) % 10;
            int digit3 = (number / 10) % 10;
            int digit4 = number % 10;

            // Меняем местами 2-ую и 4-ую цифры
            int newNumber = digit1 * 1000 + digit4 * 100 + digit3 * 10 + digit2;

            Console.WriteLine($"Результат: {newNumber}");
        }
    }
}
