using DelegateAndEvents;

var numbers = new List<string> { "1", "5", "3", "9", "2" };
var max = numbers.GetMax(x => float.Parse(x));
Console.WriteLine($"Максимальное число: {max}");

var explorer = new FileExplorer();
explorer.FileFound += (sender, e) =>
{
    Console.WriteLine($"Найден файл: {e.FileName}");
    if (e.StopSearch) explorer.CancelSearch();
};

var cancellationTokenSource = new CancellationTokenSource();
CancellationToken cancellationToken = cancellationTokenSource.Token;

explorer.ExploreDirectory("C:\\");