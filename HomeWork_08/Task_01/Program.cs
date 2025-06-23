// Смоделируйте работу простого калькулятора.
// Программа должна запрашивать 2 целых числа, а затем – код операции
// (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
// После этого на консоль выводится ответ.
// Используйте обработку деления на ноль (DivideByZeroException), нечислового ввода (FormatException).

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - умножение");
                Console.WriteLine("4 - деление");
                Console.Write("Введите код операции (1-4): ");

                int operation = int.Parse(Console.ReadLine());

                int result = operation switch
                {
                    1 => num1 + num2,
                    2 => num1 - num2,
                    3 => num1 * num2,
                    4 => num1 / num2,
                    _ => throw new ArgumentException("Неверный код операции")
                };

                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
        }
    }
}
