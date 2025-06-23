// Создайте обобщенный класс Book<T, U>, который представляет книгу со следующими свойствами://    Code - уникальный код книги (тип T)
//    Title - название книги (тип string)
//    PublicationYear - год публикации (тип U)
//    Author - автор книги (тип string)

// Реализуйте в классе:
//    Конструктор, принимающий все параметры
//    Переопределенный метод ToString(), возвращающий информацию в формате:
//    Код: {Code} ({тип T}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({тип U})

// Создайте обобщенный метод FindBook, который:
//    Принимает массив книг Book<T, U>[] и код книги code типа T
//    Возвращает книгу с указанным кодом или null, если книга не найдена

// В методе Main продемонстрируйте работу:
//    Создайте два массива книг:
//        Первый массив: Code - string (шифр книги), PublicationYear - int
//        Второй массив: Code - int (инвентарный номер), PublicationYear - string (исторические периоды)
//    Найдите и выведите информацию о книгах:
//        Книгу с кодом "F-1234" из первого массива
//        Книгу с кодом 42 из второго массива

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Первый массив книг: Code - string, PublicationYear - int
            Book<string, int>[] libraryBooks = new Book<string, int>[]
            {
                new Book<string, int>("F-1234", "Война и мир", 1869, "Лев Толстой"),
                new Book<string, int>("D-5678", "Преступление и наказание", 1866, "Фёдор Достоевский"),
                new Book<string, int>("P-9012", "Отцы и дети", 1862, "Иван Тургенев")
            };

            // Второй массив книг: Code - int, PublicationYear - string
            Book<int, string>[] archiveBooks = new Book<int, string>[]
            {
                new Book<int, string>(42, "Мастер и Маргарита", "XX век", "Михаил Булгаков"),
                new Book<int, string>(17, "Евгений Онегин", "XIX век", "Александр Пушкин"),
                new Book<int, string>(99, "Герой нашего времени", "XIX век", "Михаил Лермонтов")
            };

            // Поиск и вывод книги с кодом "F-1234" из первого массива
            var foundBook1 = FindBook(libraryBooks, "F-1234");
            Console.WriteLine("Найденная книга в библиотеке:");
            Console.WriteLine(foundBook1?.ToString() ?? "Книга не найдена");

            Console.WriteLine();

            // Поиск и вывод книги с кодом 42 из второго массива
            var foundBook2 = FindBook(archiveBooks, 42);
            Console.WriteLine("Найденная книга в архиве:");
            Console.WriteLine(foundBook2?.ToString() ?? "Книга не найдена");
        }

        // Обобщенный метод для поиска книги по коду
        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (var book in books)
            {
                if (book.Code.Equals(code))
                    return book;
            }
            return null;
        }
    }

    // Обобщенный класс Book
    public class Book<T, U>
    {
        public T Code { get; set; }
        public string Title { get; set; }
        public U PublicationYear { get; set; }
        public string Author { get; set; }

        public Book(T code, string title, U publicationYear, string author)
        {
            Code = code;
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
        }

        public override string ToString()
        {
            return $"Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
        }
    }
}
