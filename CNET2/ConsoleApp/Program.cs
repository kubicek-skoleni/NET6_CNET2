using Data;
using Model;

Console.WriteLine("Hello, World!");


int[] cisla = { 11, 2, 13, 44, -5, 6, 127, -99, 0, 256 };










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