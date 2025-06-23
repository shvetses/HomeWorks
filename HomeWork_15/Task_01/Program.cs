// Модель компьютера характеризуется кодом и названием марки компьютера, типом процессора,
// частотой работы процессора, объемом оперативной памяти,
// объемом жесткого диска, объемом памяти видеокарты,
// стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии.
// Создать список, содержащий 6-10 записей с различным набором значений характеристик.

// Определить:
// - все компьютеры с указанным процессором. Название процессора запросить у пользователя;
// - все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
// - вывести весь список, отсортированный по увеличению стоимости;
// - вывести весь список, сгруппированный по типу процессора;
// - найти самый дорогой и самый бюджетный компьютер;
// - есть ли хотя бы один компьютер в количестве не менее 30 штук?

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем список компьютеров
            List<Computer> computers = new List<Computer>
            {
                new Computer { Code = "PC001", Brand = "Dell", ProcessorType = "Intel i5", ProcessorFrequency = 2.5, Ram = 8, Hdd = 512, VideoMemory = 2, Price = 50000, Quantity = 15 },
                new Computer { Code = "PC002", Brand = "HP", ProcessorType = "AMD Ryzen 5", ProcessorFrequency = 3.2, Ram = 16, Hdd = 1000, VideoMemory = 4, Price = 65000, Quantity = 8 },
                new Computer { Code = "PC003", Brand = "Lenovo", ProcessorType = "Intel i7", ProcessorFrequency = 3.0, Ram = 32, Hdd = 2000, VideoMemory = 8, Price = 85000, Quantity = 5 },
                new Computer { Code = "PC004", Brand = "Asus", ProcessorType = "AMD Ryzen 7", ProcessorFrequency = 3.6, Ram = 16, Hdd = 1000, VideoMemory = 6, Price = 75000, Quantity = 12 },
                new Computer { Code = "PC005", Brand = "Acer", ProcessorType = "Intel i5", ProcessorFrequency = 2.8, Ram = 8, Hdd = 512, VideoMemory = 2, Price = 55000, Quantity = 20 },
                new Computer { Code = "PC006", Brand = "MSI", ProcessorType = "Intel i9", ProcessorFrequency = 4.0, Ram = 64, Hdd = 2000, VideoMemory = 12, Price = 120000, Quantity = 3 },
                new Computer { Code = "PC007", Brand = "Apple", ProcessorType = "M1", ProcessorFrequency = 3.2, Ram = 16, Hdd = 512, VideoMemory = 8, Price = 95000, Quantity = 30 },
                new Computer { Code = "PC008", Brand = "Samsung", ProcessorType = "AMD Ryzen 5", ProcessorFrequency = 3.4, Ram = 8, Hdd = 1000, VideoMemory = 4, Price = 60000, Quantity = 10 }
            };

            // 1. Все компьютеры с указанным процессором
            Console.Write("Введите тип процессора для поиска (например, 'Intel i5'): ");
            string processor = Console.ReadLine();
            var byProcessor = computers.Where(c => c.ProcessorType.Equals(processor, StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine("\nКомпьютеры с процессором " + processor + ":");
            byProcessor.ForEach(Console.WriteLine);

            // 2. Все компьютеры с объемом ОЗУ не ниже указанного
            Console.Write("\nВведите минимальный объем ОЗУ (GB): ");
            int minRam = int.Parse(Console.ReadLine());
            var byRam = computers.Where(c => c.Ram >= minRam).ToList();

            Console.WriteLine($"\nКомпьютеры с ОЗУ не менее {minRam}GB:");
            byRam.ForEach(Console.WriteLine);

            // 3. Весь список, отсортированный по стоимости
            Console.WriteLine("\nСписок компьютеров по возрастанию цены:");
            computers.OrderBy(c => c.Price).ToList().ForEach(Console.WriteLine);

            // 4. Список, сгруппированный по типу процессора
            Console.WriteLine("\nСписок компьютеров, сгруппированный по процессору:");
            foreach (var group in computers.GroupBy(c => c.ProcessorType))
            {
                Console.WriteLine($"\nПроцессор: {group.Key}");
                foreach (var computer in group)
                {
                    Console.WriteLine($"  {computer}");
                }
            }

            // 5. Самый дорогой и самый бюджетный компьютер
            var mostExpensive = computers.OrderByDescending(c => c.Price).First();
            var cheapest = computers.OrderBy(c => c.Price).First();

            Console.WriteLine($"\nСамый дорогой компьютер: {mostExpensive}");
            Console.WriteLine($"Самый бюджетный компьютер: {cheapest}");

            // 6. Проверка наличия компьютера в количестве ≥ 30 штук
            bool has30Plus = computers.Any(c => c.Quantity >= 30);
            Console.WriteLine($"\nЕсть ли хотя бы один компьютер в количестве ≥ 30 шт.: {has30Plus}");

            // Для компьютеров с количеством ≥ 30 (если нужно вывести какие именно)
            var computers30Plus = computers.Where(c => c.Quantity >= 30).ToList();
            if (computers30Plus.Any())
            {
                Console.WriteLine("Эти компьютеры есть в количестве ≥ 30 шт.:");
                computers30Plus.ForEach(Console.WriteLine);
            }
        }
    }

    class Computer
    {
        public string Code { get; set; }
        public string Brand { get; set; }
        public string ProcessorType { get; set; }
        public double ProcessorFrequency { get; set; }
        public int Ram { get; set; }
        public int Hdd { get; set; }
        public int VideoMemory { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Code} {Brand}, {ProcessorType} {ProcessorFrequency}GHz, " +
                   $"{Ram}GB RAM, {Hdd}GB HDD, {VideoMemory}GB VRAM, " +
                   $"{Price:C}, {Quantity} шт.";
        }
    }
}
