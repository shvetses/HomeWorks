// Сформировать двумерный массив вида
// 1 0 1 0 1
// 0 1 0 1 0
// 1 0 1 0 1
// 0 1 0 1 0
// 1 0 1 0 1

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 5;
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = (i + j) % 2; // Можно заметить, что значение в массиве зависит от четности суммы индексов

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
