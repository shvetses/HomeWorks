// Напишите метод PrintNumbers, который выводит на экран числа из массива.
// У метода должен быть необязательный параметр reverse, который по умолчанию равен false.
// Если reverse равен true, числа выводятся в обратном порядке.

// Пример вызова:
// int[] numbers = { 1, 2, 3, 4, 5 };
// PrintNumbers(numbers); // Вывод: 1 2 3 4 5
// PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1

namespace Task_03
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintNumbers(numbers);
            PrintNumbers(numbers, true);
            Console.ReadKey();
        }

        static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (!reverse)
            {
                foreach (int num in numbers)
                    Console.Write(num + " ");
            }
            else
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                    Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
