// Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num >= 10 && num <= 99 ? "Да" : "Нет");
        }
    }
}
