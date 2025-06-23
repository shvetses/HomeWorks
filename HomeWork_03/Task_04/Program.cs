// Вводятся три разных числа. Вывести медиану.
// Медиана - это число, которое в отсортированном ряду стоит "посередине".
// Например, для чисел 3, 0, 9 медианой будет 3.

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Часто медиану путают со средним арифметическим. 
            // Медиана - это число, которое в отсортированном ряду стоит "посередине".
            // Т.е. для чисел 3, 0, 9 медианой будет 3

            double median = (a + b + c) - Math.Min(a, Math.Min(b, c)) - Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"Медиана: {median}");
        }
    }
}
