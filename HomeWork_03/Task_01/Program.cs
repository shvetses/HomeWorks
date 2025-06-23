// Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=».

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Первый вариант - с помощью if
            if (a > b) Console.WriteLine(">");
            else if (a < b) Console.WriteLine("<");
            else Console.WriteLine("=");

            // Второй вариант - с помощью тернарного оператора
            // Console.WriteLine( (a > b) ? ">" : (a < b) ? "<" : "=");
        }
    }
}
