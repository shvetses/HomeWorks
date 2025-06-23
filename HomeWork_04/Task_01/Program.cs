// Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Ошибка: число должно быть натуральным");
                return;
            }

            // Факториал очень быстро "растет".
            // Если n>=21, то для хранения значения уже не хватит целочисленных типов, существующих в C#.
            // Поэтому можно при вводе делать проверку и предупреждать пользователя, если вычислить факториал не удастся.
            if (n >= 21)
            {
                Console.WriteLine("Ошибка: результат слишком большой");
                return;
            }

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"{n}! = {factorial}");
        }
    }
}
