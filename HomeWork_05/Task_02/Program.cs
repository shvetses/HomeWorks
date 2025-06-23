// Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20]. Определить количество положительных, отрицательных и равных нулю элементов.

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[10];
            int pos = 0, neg = 0, zero = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-20, 21);
                if (array[i] > 0) pos++;
                else if (array[i] < 0) neg++;
                else zero++;
            }

            Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
            Console.WriteLine($"Положительных: {pos}, Отрицательных: {neg}, Нулей: {zero}");
        }
    }
}
