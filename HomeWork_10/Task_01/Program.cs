// Создайте базовый класс Building (описывает здание) со следующими характеристиками:
//        Поля:
//            _address (строка) - адрес здания
//            _area (double) - площадь в квадратных метрах
//            _yearBuilt (int) - год постройки
//        Конструктор, инициализирующий эти поля
//        Виртуальные методы:
//            CalculateTax() - рассчитывает налог (базовая формула: площадь × 1000)
//            DisplayInfo() - выводит информацию о здании
//        Свойство:
//            BuildingAge (только чтение) - возраст здания в годах

// Создайте производный класс MultiBuilding (многоэтажное здание), который:
//        Добавляет новые поля:
//            _floors (int) - количество этажей
//            _hasElevator (bool) - наличие лифта
//        Модифицирует поведение:
//            Переопределяет CalculateTax() с учетом:
//                Повышающего коэффициента за этажи (1 + (_floors - 1) * 0.05)
//                Доплаты 5000 за наличие лифта
//            Переопределяет DisplayInfo() для вывода дополнительной информации
//        Добавляет новые возможности:
//            Свойство AreaPerFloor (только чтение) - средняя площадь на этаж
//        Запрещает наследование

// В методе Main продемонстрируйте:
//        Создание объектов обоих типов
//        Upcasting (приведение производного класса к базовому)
//        Downcasting (обратное приведение с проверкой типа)
//        Вызов переопределенных методов
//        Использование уникальных методов производного класса

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов
            Building building1 = new Building("ул. Ленина, 10", 500, 1990);
            MultiBuilding multiBuilding1 = new MultiBuilding("пр. Мира, 25", 3000, 2005, 10, true);

            Console.WriteLine("=== Информация о простом здании ===");
            building1.DisplayInfo();

            Console.WriteLine("\n=== Информация о многоэтажном здании ===");
            multiBuilding1.DisplayInfo();

            // Upcasting (приведение к базовому типу)
            Building building2 = multiBuilding1;
            Console.WriteLine("\n=== Upcasting (многоэтажное здание как базовое) ===");
            building2.DisplayInfo(); // Вызовется переопределенный метод

            // Downcasting с проверкой типа
            if (building2 is MultiBuilding)
            {
                MultiBuilding multiBuilding2 = (MultiBuilding)building2;
                Console.WriteLine("\n=== Downcasting (обратное приведение) ===");
                multiBuilding2.DisplayInfo();

                // Использование уникального свойства производного класса
                Console.WriteLine($"\nУникальное свойство: Площадь на этаж = {multiBuilding2.AreaPerFloor:F2} кв.м");
            }

            // Попытка downcasting для объекта базового класса
            if (building1 is MultiBuilding)
            {
                Console.WriteLine("Этот код не выполнится, так как building1 не является MultiBuilding");
            }
            else
            {
                Console.WriteLine("\nbuilding1 не является многоэтажным зданием");
            }
        }
    }

    // Базовый класс Building
    public class Building
    {
        protected string _address;
        protected double _area;
        protected int _yearBuilt;

        public Building(string address, double area, int yearBuilt)
        {
            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;
        }

        // Свойство для возраста здания (только чтение)
        public int BuildingAge => DateTime.Now.Year - _yearBuilt;

        // Виртуальный метод для расчета налога
        public virtual decimal CalculateTax()
        {
            return (decimal)(_area * 1000);
        }

        // Виртуальный метод для вывода информации
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Адрес: {_address}");
            Console.WriteLine($"Площадь: {_area} кв.м");
            Console.WriteLine($"Год постройки: {_yearBuilt}");
            Console.WriteLine($"Возраст здания: {BuildingAge} лет");
            Console.WriteLine($"Налог: {CalculateTax():C}");
        }
    }

    // Производный класс MultiBuilding (запечатанный)
    public sealed class MultiBuilding : Building
    {
        private int _floors;
        private bool _hasElevator;

        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }

        // Свойство для площади на этаж (только чтение)
        public double AreaPerFloor => _area / _floors;

        // Переопределенный метод расчета налога
        public override decimal CalculateTax()
        {
            // Используем родительскую реализацию с помощью base
            decimal baseTax = base.CalculateTax();
            decimal floorsCoefficient = 1 + (decimal)((_floors - 1) * 0.05);
            decimal elevatorFee = _hasElevator ? 5000 : 0;

            return baseTax * floorsCoefficient + elevatorFee;
        }

        // Переопределенный метод вывода информации
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество этажей: {_floors}");
            Console.WriteLine($"Наличие лифта: {(_hasElevator ? "Да" : "Нет")}");
            Console.WriteLine($"Площадь на этаж: {AreaPerFloor:F2} кв.м");
            Console.WriteLine($"Налог с учетом коэффициентов: {CalculateTax():C}");
        }
    }
}
