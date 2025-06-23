// Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60].

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Введите число от 20 до 60: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number < 20 || number > 60)
                {
                    Console.WriteLine("Число вне диапазона! Попробуйте еще раз.");
                }
            }
            while (number < 20 || number > 60);

            Console.WriteLine($"Вы ввели корректное число: {number}");
        }
    }
}
