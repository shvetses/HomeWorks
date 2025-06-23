// Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? "Да" : "Нет");
        }
    }
}
