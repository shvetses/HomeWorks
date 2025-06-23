// Вводятся два числа. Обменять их местами, не используя третью переменную.

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Обмен без третьей переменной
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"После обмена: a = {a}, b = {b}");
        }
    }
}
