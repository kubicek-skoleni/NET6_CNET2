using Model;

Console.WriteLine("Hello, World!");


FAResult fAResult = new FAResult()
{
    Source = "file",
    SourceType = SourceType.FILE
};

var dict = new Dictionary<string, int>();
dict["key"] = 1;

Console.WriteLine(fAResult);

fAResult.Words = dict;
fAResult.Source = "soubor.txt";
fAResult.SourceType = SourceType.FILE;

Console.WriteLine(fAResult);