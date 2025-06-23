// Вводятся три числа.
// Обменять их местами циклически.
// Например, вводятся a=1, b=2, c=3.
// После обмена в переменных должны оказаться значения a=3, b=1, c=2.

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Циклический обмен с помощью дополнительной переменной
            int t = c;
            c = b;
            b = a;
            a = t;

            // Второй вариант - обмен с использованием кортежей
            // (a, b, c) = (c, a, b);

            Console.WriteLine($"После обмена: a = {a}, b = {b}, c = {c}");
        }
    }
}
