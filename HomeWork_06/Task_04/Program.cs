// Запросите у пользователя имя, возраст и город.
// Сформируйте строку в формате: "Имя: [имя], Возраст: [возраст], Город: [город]" с использованием StringBuilder.

using System.Text;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            string age = Console.ReadLine();

            Console.Write("Введите город: ");
            string city = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("Имя: ").Append(name)
              .Append(", Возраст: ").Append(age)
              .Append(", Город: ").Append(city);

            Console.WriteLine(sb.ToString());
        }
    }
}
