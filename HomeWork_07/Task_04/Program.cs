// Напишите метод FindMax, который принимает переменное количество чисел и возвращает максимальное значение.
// Используйте ключевое слово params.

// Пример вызова:
// int maxNumber = FindMax(10, 25, 5, 30, 15);
// Console.WriteLine($"Max number: {maxNumber}"); // Вывод: Max number: 30

namespace Task_04
{
    internal class Program
    {
        static void Main()
        {
            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}");
        }

        static int FindMax(params int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
                if (num > max) max = num;
            return max;
        }
    }
}
