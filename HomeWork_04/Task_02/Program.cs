// Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n.

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Ошибка: число должно быть натуральным");
                return;
            }

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine($"Сумма ряда: {sum:F4}");
        }
    }
}
