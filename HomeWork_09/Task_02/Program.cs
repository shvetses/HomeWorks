// Создайте класс BankAccount, который моделирует банковский счет:
//    Статическое поле:
//        _totalAccounts (общее количество созданных счетов, private)
//    Автосвойства:
//        AccountNumber (номер счета, readonly)
//        Balance (public геттер, private сеттер)
//    Конструктор:
//        Увеличивает _totalAccounts и генерирует AccountNumber (например, случайный 4-значный номер).
//    Методы:
//        Deposit(decimal amount) – пополняет баланс.
//        Withdraw(decimal amount) – снимает деньги (если хватает средств, иначе выбрасывает исключение).
//        ShowTotalAccounts() - выводит общее количество созданных счетов.

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount account1 = new BankAccount();
                account1.Deposit(1000);
                Console.WriteLine($"Счет {account1.AccountNumber}: {account1.Balance} руб.");

                BankAccount account2 = new BankAccount();
                account2.Deposit(500);
                account2.Withdraw(200);
                Console.WriteLine($"Счет {account2.AccountNumber}: {account2.Balance} руб.");

                BankAccount.ShowTotalAccounts();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }

    class BankAccount
    {
        private static int _totalAccounts = 0;

        public int AccountNumber { get; }
        public decimal Balance { get; private set; }

        public BankAccount()
        {
            Random rnd = new Random();
            AccountNumber = rnd.Next(1000, 10000);
            Balance = 0;
            _totalAccounts++;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной");

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной");

            if (amount > Balance)
                throw new InvalidOperationException("Недостаточно средств");

            Balance -= amount;
        }

        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"Всего счетов: {_totalAccounts}");
        }
    }
}
