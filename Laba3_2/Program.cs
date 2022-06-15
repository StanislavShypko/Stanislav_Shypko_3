using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

var dict = new Dictionary<string, int>()
{
    {"перший", 1},
    {"другий", 2},
    {"третiй", 3},
    {"четвертий", 4},
    {"пятий", 5},
};

foreach (var key in dict.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine("\nSorted:");
foreach (var key in dict.Keys.OrderBy(key => key))
{
    Console.WriteLine(key);
}

var options = new JsonSerializerOptions
{
    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
    WriteIndented = true
};

var json = JsonSerializer.Serialize(dict, options);
Console.WriteLine(json);