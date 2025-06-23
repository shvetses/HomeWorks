// Создайте абстрактный класс Animal с:
//        абстрактным свойством Name (string),
//        абстрактным методом Say(), который возвращает строку-звук, который издает животное,
//        неабстрактным методом ShowInfo(), который возвращает строку, содержащую последовательно название, а затем звук (вызывая метод Say()).

// Реализуйте два класса-наследника:
//     Dog (собака), который переопределяет Say() (выводит "Гав!") и задает название животного,
//     Cat (кошка), который переопределяет Say() (выводит "Мяу!") и задает название животного.

// В методе Main продемонстрируйте:
//     создание массива, содержащего объекты обоих типов,
//     использование полиморфизма (вызовите для каждого элемента в массиве метод ShowInfo()).

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] { new Dog(), new Cat() };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ShowInfo());
            }
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; }
        public abstract string Say();

        public string ShowInfo()
        {
            return $"{Name} говорит {Say()}";
        }
    }

    class Dog : Animal
    {
        public override string Name => "Собака";

        public override string Say()
        {
            return "Гав!";
        }
    }

    class Cat : Animal
    {
        public override string Name => "Кошка";

        public override string Say()
        {
            return "Мяу!";
        }
    }
}
