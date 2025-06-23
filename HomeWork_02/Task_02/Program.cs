// Угол а задан в градусах, минутах и секундах. Найти его величину в радианах.

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите градусы: ");
            int degrees = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            // Переводим в десятичные градусы
            double decimalDegrees = degrees + (minutes / 60.0) + (seconds / 3600.0);
            // Переводим в радианы
            double radians = decimalDegrees * Math.PI / 180;

            Console.WriteLine($"Угол в радианах: {radians:F6}");
        }
    }
}
