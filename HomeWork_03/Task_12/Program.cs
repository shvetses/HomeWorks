// Дано целое число в диапазоне 100–999.
// Вывести строку-описание данного числа,
// например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».
// Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.

namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 100 до 999: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: число должно быть в диапазоне 100-999");
                return;
            }

            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int units = number % 10;

            string result = "";

            // Обработка сотен
            switch (hundreds)
            {
                case 1: result += "сто "; break;
                case 2: result += "двести "; break;
                case 3: result += "триста "; break;
                case 4: result += "четыреста "; break;
                case 5: result += "пятьсот "; break;
                case 6: result += "шестьсот "; break;
                case 7: result += "семьсот "; break;
                case 8: result += "восемьсот "; break;
                case 9: result += "девятьсот "; break;
            }

            // Обработка десятков и единиц
            if (tens == 1)
            {
                switch (units)
                {
                    case 0: result += "десять"; break;
                    case 1: result += "одиннадцать"; break;
                    case 2: result += "двенадцать"; break;
                    case 3: result += "тринадцать"; break;
                    case 4: result += "четырнадцать"; break;
                    case 5: result += "пятнадцать"; break;
                    case 6: result += "шестнадцать"; break;
                    case 7: result += "семнадцать"; break;
                    case 8: result += "восемнадцать"; break;
                    case 9: result += "девятнадцать"; break;
                }
            }
            else
            {
                switch (tens)
                {
                    case 2: result += "двадцать "; break;
                    case 3: result += "тридцать "; break;
                    case 4: result += "сорок "; break;
                    case 5: result += "пятьдесят "; break;
                    case 6: result += "шестьдесят "; break;
                    case 7: result += "семьдесят "; break;
                    case 8: result += "восемьдесят "; break;
                    case 9: result += "девяносто "; break;
                }

                switch (units)
                {
                    case 1: result += "один"; break;
                    case 2: result += "два"; break;
                    case 3: result += "три"; break;
                    case 4: result += "четыре"; break;
                    case 5: result += "пять"; break;
                    case 6: result += "шесть"; break;
                    case 7: result += "семь"; break;
                    case 8: result += "восемь"; break;
                    case 9: result += "девять"; break;
                }
            }

            Console.WriteLine(result.Trim());
        }
    }
}
