// Составить регулярное выражение для проверки корректности пароля.
// Пароль должен состоять минимум из 14 символов и иметь в составе
// минимум одну цифру, заглавную букву, строчную букву и специальный символ из набора !#;%:?*.
// Запрашивать у пользователя пароль до тех пор, пока он не введет пароль, удовлетворяющий регулярному выражению.

using System.Text.RegularExpressions;

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!#;%:?\*]).{14,}$");
            string password;

            do
            {
                Console.Write("Введите пароль (минимум 14 символов, цифра, заглавная, строчная, спецсимвол): ");
                password = Console.ReadLine();

                if (!passwordRegex.IsMatch(password))
                {
                    Console.WriteLine("Пароль не соответствует требованиям!");
                }
            }
            while (!passwordRegex.IsMatch(password));

            Console.WriteLine("Пароль принят!");
        }
    }
}
