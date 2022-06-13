using Data;
using Model;
using System.Linq;

Console.WriteLine("Hello, World!");


int[] numbers = { 11, 2, 13, 44, -5, 6, 127, -99, 0, 256 };


// 1. zjistete pocet kladnych cisel v poli numbers





Console.WriteLine(string.Join(", ", result));

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