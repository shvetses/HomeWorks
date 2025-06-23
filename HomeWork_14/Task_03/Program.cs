// Разработайте систему управления подписчиками, используя HashSet<string> для хранения email-адресов.
// Система должна обеспечивать уникальность подписчиков и поддерживать основные операции с множествами.
// Требования:
//    Создайте HashSet для хранения email-подписчиков с регистронезависимым сравнением
//    Реализуйте следующий функционал:
//        Добавление новых подписчиков:
//            alice@example.com
//            bob@example.com
//            charlie@example.com
//        Попытку добавления дубликата с выводом результата операции
//        Проверку наличия подписчиков в системе
//    Создайте второе множество newSubscribers с подписчиками:
//        bob@example.com (существующий)
//        dave@example.com (новый)
//        eve@example.com (новый)
//    Выполните операции с множествами:
//        Объединение множеств (добавление новых подписчиков)
//        Поиск пересечения (общих подписчиков)
//    Реализуйте:
//        Удаление подписчика
//        Проверку на подмножество
//        Очистку всей коллекции

// Пример вывода:
// Дубликат alice@example.com добавлен? False
// Есть ли bob@example.com в подписчиках? True
// Есть ли dave@example.com в подписчиках? False
// Подписчики после объединения:
// - alice@example.com
// - bob@example.com
// - charlie@example.com
// - dave@example.com
// - eve@example.com
// Общие подписчики:
// - bob@example.com
// Удалили charlie@example.com? True
// Всего подписчиков: 4
// testGroup является подмножеством? True
// Подписчиков после очистки: 0

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание HashSet с регистронезависимым сравнением
            HashSet<string> subscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Добавление подписчиков
            subscribers.Add("alice@example.com");
            subscribers.Add("bob@example.com");
            subscribers.Add("charlie@example.com");

            // Попытка добавления дубликата
            Console.WriteLine($"Дубликат alice@example.com добавлен? {subscribers.Add("alice@example.com")}");

            // Проверка наличия подписчиков
            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {subscribers.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {subscribers.Contains("dave@example.com")}");

            // Создание второго множества
            HashSet<string> newSubscribers = new HashSet<string> { "bob@example.com", "dave@example.com", "eve@example.com" };

            // Объединение множеств
            HashSet<string> unionSubscribers = new HashSet<string>(subscribers);
            unionSubscribers.UnionWith(newSubscribers);

            Console.WriteLine("Подписчики после объединения:");
            foreach (var email in unionSubscribers)
            {
                Console.WriteLine($"- {email}");
            }

            // Поиск пересечения
            HashSet<string> commonSubscribers = new HashSet<string>(subscribers);
            commonSubscribers.IntersectWith(newSubscribers);

            Console.WriteLine("Общие подписчики:");
            foreach (var email in commonSubscribers)
            {
                Console.WriteLine($"- {email}");
            }

            // Удаление подписчика
            Console.WriteLine($"Удалили charlie@example.com? {subscribers.Remove("charlie@example.com")}");
            Console.WriteLine($"Всего подписчиков: {subscribers.Count}");

            // Проверка на подмножество
            HashSet<string> testGroup = new HashSet<string> { "bob@example.com", "alice@example.com" };
            Console.WriteLine($"testGroup является подмножеством? {testGroup.IsSubsetOf(subscribers)}");

            // Очистка коллекции
            subscribers.Clear();
            Console.WriteLine($"Подписчиков после очистки: {subscribers.Count}");
            Console.ReadKey();
        }
    }
}
