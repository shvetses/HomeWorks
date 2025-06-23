// Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num % 10 == 0 ? "Да" : "Нет");
        }
    }
}
