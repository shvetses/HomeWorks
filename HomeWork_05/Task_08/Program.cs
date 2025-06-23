// Сформировать одномерный массив из 5 случайных чисел из диапазона [0, 10].
// Найти два наибольших элемента.
// Например, среди чисел {4, 8, 0, 9, 3} два наибольших числа – 9 и 8.
// Среди чисел {5, 9, 1, 9, 3} два наибольших числа – 9 и 9.

namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int n = 5;
            int[] array = new int[n];
            int first = int.MinValue, second = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 11);
                Console.Write($"{array[i]} ");
                if (array[i] > first)
                {
                    second = first;
                    first = array[i];
                }
                else if (array[i] > second)
                {
                    second = array[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Два наибольших: {first} и {second}");
        }
    }
}
