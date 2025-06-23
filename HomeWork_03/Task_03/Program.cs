// Вводятся четыре числа. Вывести большее из них.

namespace Task_03
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
            Console.Write("Введите четвертое число: ");
            double d = Convert.ToDouble(Console.ReadLine());

            // Первый вариант - с использованием оператора if
            // Аналогично предыдущей задаче

            double max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
             if (d > max)
                max = d;

            // Второй вариант - с использованием метода Math.Max()
            // double max = Math.Max(Math.Max(a, b), Math.Max(c, d));
            Console.WriteLine($"Наибольшее число: {max}");
        }
    }
}
