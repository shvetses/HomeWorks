// Напишите метод ValidateAge, проверяющий корректность возраста. Если возраст:
//•    < 0 - выбросить ArgumentException("Возраст не может быть отрицательным"),
//•    > 150 - выбросить ArgumentOutOfRangeException("Слишком большой возраст").

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());

                ValidateAge(age);
                Console.WriteLine("Возраст корректен!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным");

            if (age > 150)
                throw new ArgumentOutOfRangeException("Слишком большой возраст");
        }
    }
}
