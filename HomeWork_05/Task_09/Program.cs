// Матрицу A(m,n) (m и n – константы со значением на ваш выбор) заполнить натуральными числами от 1 до n*m по спирали,
// начинающейся в левом верхнем углу и закрученной по часовой стрелке.
// Например,
//  1  2  3  4 5
// 16 17 18 19 6
// 15 24 25 20 7
// 14 23 22 21 8
// 13 12 11 10 9

namespace Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5, m = 5;
            int[,] matrix = new int[n, m];
            int num = 1, top = 0, bottom = n - 1, left = 0, right = m - 1;

            while (num <= n * m)
            {
                for (int i = left; i <= right; i++) matrix[top, i] = num++;
                top++;
                for (int i = top; i <= bottom; i++) matrix[i, right] = num++;
                right--;
                for (int i = right; i >= left; i--) matrix[bottom, i] = num++;
                bottom--;
                for (int i = bottom; i >= top; i--) matrix[i, left] = num++;
                left++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
                Console.WriteLine();
            }
        }
    }
}
