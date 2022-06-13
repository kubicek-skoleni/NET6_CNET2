using Model;

Console.WriteLine("Hello, World!");


FAResult fAResult = new FAResult()
{
    Source = "file",
    SourceType = SourceType.FILE
};


Console.WriteLine(fAResult);

fAResult.Words = new Dictionary<string, int>();

Console.WriteLine(fAResult);