// Вводится длина трубы в метрах. Округлить длину до целых в большую сторону. Например, 
// 17,0  -> 17
// 17,3  -> 18
// 17,7  -> 18

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы в метрах: ");
            double length = Convert.ToDouble(Console.ReadLine());

            int roundedLength = (int)Math.Ceiling(length);

            Console.WriteLine($"Округленная длина: {roundedLength}");
        }
    }
}
