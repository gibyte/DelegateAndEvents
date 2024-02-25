// See https://aka.ms/new-console-template for more information
using DelegateAndEvents;

Console.WriteLine("Hello, World!");

var numbers = new List<int> { 1, 5, 3, 9, 2 };
int max = numbers.GetMax(x => x); // Поиск максимального числа в коллекции
Console.WriteLine($"Максимальное число: {max}");

// Пример использования события
var explorer = new FileExplorer();
explorer.FileFound += (sender, e) =>
{
    Console.WriteLine($"Найден файл: {e.FileName}");
    // Допустим, здесь какая-то логика, которая может привести к отмене дальнейшего поиска
};

// Начинаем поиск файлов в указанном каталоге
explorer.ExploreDirectory("C:\\");