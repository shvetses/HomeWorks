// Разработать метод для формирования массива и метод для расчета среднего арифметического всех чисел в массиве
// (в методах сделать искусственную задержку - имитация длительных вычислений).
// В методе Main выполнить проверку работы методов 2мя способами - сначала используя задачи продолжения,
// затем - с помощью async/await.

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало работы программы");

            // Способ 1: Использование задач продолжения
            Console.WriteLine("\nСпособ 1: Использование задач продолжения");
            Task<int[]> generateTask1 = Task.Run(() => GenerateArray(10));

            generateTask1.ContinueWith(task =>
            {
                int[] array = task.Result;
                Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));

                Task<double> calculateTask = Task.Run(() => CalculateAverage(array));
                calculateTask.ContinueWith(calcTask =>
                {
                    Console.WriteLine($"Среднее арифметическое: {calcTask.Result:F2}");
                });
            });

            // Способ 2: Использование async/await
            // Console.WriteLine("\nСпособ 2: Использование async/await");
            // CallWithAsyncAwait().Wait();

            // Console.WriteLine("\nЗавершение работы программы");          
        }

        // Метод для генерации массива с задержкой
        static int[] GenerateArray(int size)
        {
            Console.WriteLine($"Начало генерации массива из {size} элементов...");
            Thread.Sleep(2000); // Искусственная задержка

            Random rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, 100);
            }

            Console.WriteLine("Генерация массива завершена");
            return array;
        }

        // Метод для расчета среднего арифметического с задержкой
        static double CalculateAverage(int[] array)
        {
            Console.WriteLine("Начало расчета среднего арифметического...");
            Thread.Sleep(1500); // Искусственная задержка

            double average = array.Average();
            Console.WriteLine("Расчет среднего завершен");
            return average;
        }

        // Асинхронный метод для второго способа
        static async Task CallWithAsyncAwait()
        {
            int[] array = await Task.Run(() => GenerateArray(10));
            Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));

            double average = await Task.Run(() => CalculateAverage(array));
            Console.WriteLine($"Среднее арифметическое: {average:F2}");
        }
    }
}
