// Нужно создать отчёт, который будет содержать информацию о продажах за определённый период.
// Отчёт должен быть отформатирован следующим образом:
//    Название отчёта: "Отчёт о продажах за [месяц] [год]".
//    Информация о продажах:
//        Общая сумма продаж.
//        Количество проданных товаров.
//        Средняя стоимость одного товара.

// Общая сумма продаж должна быть отформатирована как денежная величина (с разделителями тысяч и двумя знаками после запятой).
// Средняя стоимость товара должна быть отформатирована с двумя знаками после запятой.

// Пример данных:
//    Месяц: "Март"
//    Год: 2025
//    Общая сумма продаж: 1234567.89
//    Количество проданных товаров: 1234

// Пример отчёта:

// --------------------------------
// Отчёт о продажах за Март 2025
// --------------------------------
// Общая сумма продаж: 1 234 567,89 р.
// Количество проданных товаров: 1 234 шт.
// Средняя стоимость товара: 1 000,46 р.
// --------------------------------

using System.Globalization;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите общую сумму продаж: ");
            double totalSales = double.Parse(Console.ReadLine());

            Console.Write("Введите количество проданных товаров: ");
            int itemsSold = int.Parse(Console.ReadLine());

            double averagePrice = totalSales / itemsSold;

            string separator = new string('-', 40);
            Console.WriteLine(separator);
            Console.WriteLine($"Отчёт о продажах за {month} {year}");
            Console.WriteLine(separator);
            Console.WriteLine($"Общая сумма продаж: {totalSales:N2} р.");
            Console.WriteLine($"Количество проданных товаров: {itemsSold:N0} шт.");
            Console.WriteLine($"Средняя стоимость товара: {averagePrice:N2} р.");
            Console.WriteLine(separator);
        }
    }
}
