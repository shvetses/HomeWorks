// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100]. Определить, каких чисел больше – четных или нечетных.

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            Random rand = new Random();
            int[] array = new int[n];

            // Достаточно только одного счетчика, например, для четных чисел
            int evenCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 101);
                if (array[i] % 2 == 0) evenCount++;
            }

            Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
            Console.WriteLine(evenCount > n - evenCount? "Четных больше" :
                             evenCount < n - evenCount ? "Нечетных больше" : "Поровну");
        }
    }
}
