// Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите основание a (a > 0): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите степень b (b < 0): ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a <= 0 || b >= 0)
            {
                Console.WriteLine("Ошибка: a должно быть > 0, b должно быть < 0");
                return;
            }

            double result = 1;
            for (int i = 0; i > b; i--)
            {
                result /= a;
            }

            Console.WriteLine($"{a}^{b} = {result:F6}");
        }
    }
}
