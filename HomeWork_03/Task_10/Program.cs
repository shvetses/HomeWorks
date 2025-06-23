// Застройщик построил n домов.
// Вывести фразу «Мы построили n домов», обеспечив правильное согласование числа со словом «дом»,
// например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество домов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int lastDigit = n % 10;
            int lastTwoDigits = n % 100;

            string suffix;
            if (lastTwoDigits >= 11 && lastTwoDigits <= 19)
                suffix = "ов";
            else
            {
                switch (lastDigit)
                {
                    case 1:
                        suffix = "";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        suffix = "а";
                        break;
                    default:
                        suffix = "ов";
                        break;
                }
            }
            Console.WriteLine($"Мы построили {n} дом{suffix}");
        }
    }
}
