// Можно ли на прямоугольном участке застройки размером a * b метров
// разместить два дома размером в плане p * q и r * s метров?
// Дома можно располагать только параллельно сторонам участка.
// Дома могу стоять «вплотную» друг к другу.

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину участка (a): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину участка (b): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину первого дома (p): ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину первого дома (q): ");
            double q = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго дома (r): ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину второго дома (s): ");
            double s = Convert.ToDouble(Console.ReadLine());

            bool canFit =
                // Оба дома вдоль длины участка
                (Math.Max(p, r) <= a && q + s <= b) ||
                // Оба дома вдоль ширины участка
                (Math.Max(q, s) <= b && p + r <= a) ||
                // Первый дом вдоль длины, второй вдоль ширины
                (p <= a && r <= b && q <= b - s) ||
                // Первый дом вдоль ширины, второй вдоль длины
                (q <= b && s <= a && p <= a - r);

            Console.WriteLine(canFit ? "Да" : "Нет");
        }
    }
}
