// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10]. Перевернуть массив, т.е. переставить элементы массива в обратном порядке.

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            Random rand = new Random();
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0, 11);

            Console.WriteLine($"Исходный: [{string.Join(", ", array)}]");
            Array.Reverse(array);
            Console.WriteLine($"Перевернутый: [{string.Join(", ", array)}]");
        }
    }
}
