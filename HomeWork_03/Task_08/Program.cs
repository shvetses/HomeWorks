// Вводится число. Вывести «Да», если оно попадает в диапазон [-10,10], и «Нет» в противном случае.

namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num >= -10 && num <= 10 ? "Да" : "Нет");
        }
    }
}
