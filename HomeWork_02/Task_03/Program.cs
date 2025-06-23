// Длина отрезка задана в дюймах (1 дюйм = 2,54 см).
// Перевести значение длины в метрическую систему, то есть выразить ее в метрах, сантиметрах и миллиметрах.
// Например, 21 дюйм = 0 м 53 см 3,4 мм.

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину в дюймах: ");
            double inches = Convert.ToDouble(Console.ReadLine());

            // Переводим в миллиметры
            const double inchesFactor= 25.4;
            double totalMillimeters = inches * inchesFactor;

            // Вычисляем метры, сантиметры и миллиметры
            int meters = (int)(totalMillimeters / 1000);
            int centimeters = (int)((totalMillimeters % 1000) / 10);
            double remainingMillimeters = totalMillimeters % 10;

            // F1 - формат вывода вещественных чисел (выводит с одной цифрой после запятой)
            Console.WriteLine($"{inches} дюймов = {meters} м {centimeters} см {remainingMillimeters:F1} мм");
        }
    }
}
