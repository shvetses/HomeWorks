// Два треугольника заданы длинами своих сторон.
// Определите, площадь какого из них больше (создайте метод Square для вычисления площади треугольника по длинам его сторон).
// Для решения задачи можно использовать формулу Герона.

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Для упрощения ввода используемся метод Array.ConvertAll().
            // Этот метод преобразует все элементы массива из одного типа в другой.
            // Принимает два параметра:
            //    Исходный массив (в нашем случае - массив строк, полученный после Split())
            //    Функцию преобразования (в нашем случае - double.Parse)

            Console.WriteLine("Введите стороны первого треугольника (a b c):");
            double[] triangle1 = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            Console.WriteLine("Введите стороны второго треугольника (a b c):");
            double[] triangle2 = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            double area1 = Square(triangle1[0], triangle1[1], triangle1[2]);
            double area2 = Square(triangle2[0], triangle2[1], triangle2[2]);

            if (area1 > area2)
                Console.WriteLine("Площадь первого треугольника больше");
            else if (area2 > area1)
                Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("Площади треугольников равны");
        }

        static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}