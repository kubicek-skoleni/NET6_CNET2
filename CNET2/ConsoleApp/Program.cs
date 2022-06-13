using Data;
using Model;
using System.Linq;

Console.WriteLine("Hello, World!");


var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var strings = new[] { "zero", "one", "two", "three", "four",
    "five", "six", "seven", "eight", "nine" };

// vypište čísla v poli numbers jako slova





//Console.WriteLine(string.Join(", ", result));

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}






static void FreqWords()
{
    var booksdir = @"C:\Users\StudentEN\source\repos\kubicek-skoleni\Books";
    var files = Directory.EnumerateFiles(booksdir, "*.txt");

    foreach (var file in files)
    {
        var result = FreqAnalysis.FreqAnalysisFromFile(file);

        var fileInfo = new FileInfo(file);
        Console.WriteLine(fileInfo.Name);

        var orderedTop10 = result.Words.OrderByDescending(kv => kv.Value).Take(10);

        foreach (var item in orderedTop10)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine();
    }
}