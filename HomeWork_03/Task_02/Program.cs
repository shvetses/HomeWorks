// Вводятся три числа. Вывести большее их них.

namespace Task_02
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

            // Первый вариант - с использованием оператора if
            // Чем больше будет чисел для сравнения, тем проще запутаться в условиях.
            // Поэтому было бы круто придумать более или менее универсальный алгоритм,
            // который бы легко было модифицировать для большего количества чисел.
            // Например, можно так

            double max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;

            // Теперь, даже если чисел будет больше, алгоритм легко изменить и он останется довольно читаемым

            // Второй вариант - с использованием метода Math.Max()
            // double max = Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"Наибольшее число: {max}");
        }
    }
}
