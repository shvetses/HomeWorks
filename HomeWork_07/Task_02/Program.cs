// Создайте метод CalcCube для вычисления объема и площади поверхности куба по длине его ребра.
// Метод должен иметь 3 параметра - длина ребра, out-параметр для объема и out-параметр для площади поверхности.

// Пример вызова:
// double edgeLength = 5;
// CalcCube(edgeLength, out volume, out surfaceArea);
// Console.WriteLine($"Объем куба: {volume}"); // Объем куба: 125
// Console.WriteLine($"Площадь поверхности куба: {surfaceArea}"); // Площадь поверхности куба: 150

namespace Task_02
{
    internal class Program
    {
        static void Main()
        {
            double edgeLength = 5;
            CalcCube(edgeLength, out double volume, out double surfaceArea);

            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}");
        }

        static void CalcCube(double edge, out double volume, out double surfaceArea)
        {
            volume = Math.Pow(edge, 3);
            surfaceArea = 6 * Math.Pow(edge, 2);
        }
    }
}
