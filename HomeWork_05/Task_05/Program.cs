// Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50].
// Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
// Вывести отсортированный таким образом массив на экран.

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            Random rand = new Random();
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 51);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            // Первый вариант - с помощью циклов

            for (int i = 0; i < array.Length / 2 - 1; i++)
            {
                for (int j = i; j < array.Length / 2; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

            for (int i = array.Length / 2; i < array.Length - 1; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

            // Второй вариант - использование методов Sort и Reverse
            // Array.Sort(array, 0, 5); // Сортировка первых 5 по возрастанию
            // Array.Sort(array, 5, 5); // Сортировка вторых 5
            // Array.Reverse(array, 5, 5); // Разворот вторых 5 для убывания

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
        }
    }
}
