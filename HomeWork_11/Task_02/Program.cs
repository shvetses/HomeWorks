// Создайте интерфейс IFlyable с:
//     методом Fly() (без реализации),
//     свойством MaxAltitude (int, только чтение).

// Реализуйте интерфейс в классе Bird (птица), добавив:
//      реализацию Fly() (выводит "Лечу на высоте {MaxAltitude} метров"),
//      конструктор, принимающий maxAltitude.

// Реализуйте интерфейс в классе Airplane (самолет), добавив:
//     свойство CountPassengers - количество пассажиров (int),
//     реализацию Fly() (выводит "Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров"),
//     конструктор, принимающий maxAltitude и CountPassengers.

// В методе Main продемонстрируйте:
//     создание массива, содержащего объекты обоих типов,
//     использование полиморфизма (вызовите для каждого элемента в массиве метод Fly()).

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyers = new IFlyable[]
            {
                new Bird(1000),
                new Airplane(10000, 150)
            };

            foreach (var flyer in flyers)
            {
                flyer.Fly();
            }
        }
    }

    interface IFlyable
    {
        int MaxAltitude { get; }
        void Fly();
    }

    class Bird : IFlyable
    {
        public int MaxAltitude { get; }

        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
        }
    }

    class Airplane : IFlyable
    {
        public int MaxAltitude { get; }
        public int CountPassengers { get; }

        public Airplane(int maxAltitude, int countPassengers)
        {
            MaxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
        }
    }
}
