// Вводится число. Вывести его в зеркальном виде. Количество цифр в числе заранее неизвестно. Не использовать строки.

namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int mirrored = 0;
            int temp = Math.Abs(n);

            while (temp > 0)
            {
                mirrored = mirrored * 10 + temp % 10;
                temp /= 10;
            }

            if (n < 0)
            {
                mirrored = -mirrored;
            }

            Console.WriteLine($"Зеркальное число: {mirrored}");
        }
    }
}
