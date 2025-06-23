// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50]. Найти и вывести значение максимального, минимального элементов и их индексы.

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[10];
            int max = int.MinValue, min = int.MaxValue;
            int maxIndex = 0, minIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 51);
                if (array[i] > max) { max = array[i]; maxIndex = i; }
                if (array[i] < min) { min = array[i]; minIndex = i; }
            }

            Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
            Console.WriteLine($"Максимум: {max} (индекс {maxIndex}), Минимум: {min} (индекс {minIndex})");
        }
    }
}
