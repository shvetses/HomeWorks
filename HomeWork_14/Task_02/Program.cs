﻿// Разработайте программу для управления складом магазина электроники, используя коллекцию Dictionary<string, int>, где:
//    Ключ — артикул товара (например, "A001")
//    Значение — количество единиц товара на складе
// Требования:
//    Создайте словарь и добавьте в него 3 товара:
//        Ноутбуки ("A001") — 10 шт.
//        Смартфоны ("B205") — 25 шт.
//        Наушники ("C307") — 15 шт.
//    Реализуйте следующие операции:
//        Проверьте наличие товара с артикулом "B205" (ContainsKey).
//        Обновите количество ноутбуков до 8 (продали 2 шт.) через индексатор.
//        Получите количество наушников безопасным способом (TryGetValue).
//        Увеличьте количество смартфонов на 5 (новый завоз).
//        Удалите наушники из инвентаря (Remove).
//    Выведите текущий инвентарь в формате:
//       Артикул: A001, Количество: 8  
//       Артикул: B205, Количество: 30  
//    Проверьте, пуст ли словарь (Count), затем полностью очистите инвентарь (Clear).

// Пример вывода:
// Есть ли товар с артикулом B205? True 
// Количество наушников: 15  
// Текущие товары:  
// Артикул: A001, Количество: 8 
// Артикул: B205, Количество: 30  
// Список пуст? False  
// Количество товаров после очистки: 0 

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> merchandises = new Dictionary<string, int>();

            // Добавление товаров
            merchandises.Add("A001", 10); // Ноутбуки
            merchandises.Add("B205", 25); // Смартфоны
            merchandises.Add("C307", 15); // Наушники

            // Проверка наличия товара
            Console.WriteLine($"Есть ли товар с артикулом B205? {merchandises.ContainsKey("B205")}");

            // Обновление количества
            merchandises["A001"] = 8;

            // Безопасное получение количества
            if (merchandises.TryGetValue("C307", out int headphonesCount))
            {
                Console.WriteLine($"Количество наушников: {headphonesCount}");
            }

            // Увеличение количества
            merchandises["B205"] += 5;

            // Удаление товара
            merchandises.Remove("C307");

            // Вывод товара
            Console.WriteLine("Текущие товары:");
            foreach (var item in merchandises)
            {
                Console.WriteLine($"Артикул: {item.Key}, Количество: {item.Value}");
            }

            // Проверка на пустоту
            Console.WriteLine($"Список пуст? {merchandises.Count == 0}");

            // Очистка
            merchandises.Clear();
            Console.WriteLine($"Количество товаров после очистки: {merchandises.Count}");
        }
    }
}
