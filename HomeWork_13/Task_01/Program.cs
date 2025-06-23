// Реализуйте метод Transform, который принимает массив чисел и делегат для преобразования элементов.
// Метод должен возвращать новый массив с преобразованными значениями.
// Требования:
//    Создайте делегат Transformer, принимающий число и возвращающий число.
//    Реализуйте метод Transform, который:
//        Принимает массив int[] и делегат Transformer
//        Возвращает новый массив, где каждый элемент преобразован через делегат
//    Продемонстрируйте работу:
//        Удвоение всех чисел
//        Возведение в квадрат
//        Замена чисел на их модули

namespace Task_01
{
    internal class Program
    {
        // Объявляем делегат
        delegate int Transformer(int x);

        // Метод для преобразования массива
        static int[] Transform(int[] array, Transformer transformer)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = transformer(array[i]);
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] numbers = { -3, -2, -1, 0, 1, 2, 3 };

            // Удвоение чисел
            var doubled = Transform(numbers, x => x * 2);
            Console.WriteLine("Удвоенные: " + string.Join(", ", doubled));

            // Возведение в квадрат
            var squared = Transform(numbers, x => x * x);
            Console.WriteLine("Квадраты: " + string.Join(", ", squared));

            // Модули чисел
            var absolute = Transform(numbers, x => Math.Abs(x));
            Console.WriteLine("Модули: " + string.Join(", ", absolute));
        }
    }
}
