// Клеточное поле размером n*n (n – константа на ваш выбор) состоит из 0 («ноликов») и 1 («крестиков»).
// Проверить, выиграли ли «крестики»?
// Считается, что «крестики» выиграли, если на поле найдется горизонталь, вертикали или диагональ из «крестиков».

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 3; // Размер поля (можно изменить)
            int[,] field = new int[size, size];
            Random rand = new Random();

            // Заполнение поля случайными 0 и 1 (для примера)
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    field[i, j] = rand.Next(0, 2);

            // Вывод поля
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(field[i, j] == 1 ? "X " : "O ");
                Console.WriteLine();
            }

            bool win = false;

            // Проверка строк и столбцов
            for (int i = 0; i < size; i++)
            {
                bool rowWin = true, colWin = true;
                for (int j = 0; j < size; j++)
                {
                    if (field[i, j] != 1) rowWin = false;
                    if (field[j, i] != 1) colWin = false;
                }
                if (rowWin || colWin)
                    win = true;
            }

            // Проверка диагоналей
            bool diag1 = true, diag2 = true;
            for (int i = 0; i < size; i++)
            {
                if (field[i, i] != 1) diag1 = false;
                if (field[i, size - 1 - i] != 1) diag2 = false;
            }
            if (diag1 || diag2)
                win = true;

            Console.WriteLine(win ? "Крестики выиграли!" : "Крестики не выиграли");
        }
    }
}
