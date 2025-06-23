// Сформировать двумерный массив из 10 строк и 5 столбцов.
// Заполнить его случайными числами в диапазоне [0, 10].
// Определить максимальный элемент в каждой строке.

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int rows = 10, cols = 5;
            int[,] matrix = new int[rows, cols];

            // Заполнение и вывод матрицы
            for (int i = 0; i < rows; i++)
            {
                int maxInRow = int.MinValue;
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(0, 11);
                    if (matrix[i, j] > maxInRow) maxInRow = matrix[i, j];
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine($"| Макс: {maxInRow}");
            }
        }
    }
}
