// Вводится n. Определить количество цифр в числе.

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Количество цифр: 1");
                return;
            }

            int count = 0;

            // Нужно не забыть про то, что числа могут быть отрицательные
            int temp = Math.Abs(n);

            while (temp > 0)
            {
                temp /= 10;
                count++;
            }

            Console.WriteLine($"Количество цифр: {count}");
        }
    }
}
