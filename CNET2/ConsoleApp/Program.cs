﻿using Data;
using Model;
using System.Linq;

Console.WriteLine("Hello, World!");

var dataset = Data.Serialization.LoadFromXML();

Console.WriteLine(dataset.Count());

// kolik lidi ma nejakou smlouvu
//var result = dataset.Where(p => p.Contracts.Any()).Count();
//Console.WriteLine($"počet lidí s alespoň jednou smlouvou:{result}"); 

// kolik lidi je z Brna
//var result = dataset.Where(p => p.HomeAddress.City == "Brno").Count();
//Console.WriteLine($"počet lidí s alespoň jednou smlouvou:{result}");

// vypiste lidi z Brna
// var result = dataset.Where(p => p.HomeAddress.City == "Brno");


//// 1. zjistěte jak se jmenuje nejstatrší klient a kolik má let
//// 2. zjistěte jak se jmenuje nejmladší klient a kolik má let
//var result = dataset.OrderBy(p => p.DateOfBirth);
//var nejstarsi = result.First();
//var nejmladsi = result.Last();

//Console.WriteLine($"nejmladší je {nejmladsi.FullName} ({nejmladsi.Age()})");
//Console.WriteLine($"nejstarší je {nejstarsi.FullName} ({nejstarsi.Age()})");

// anonymni typ
//var result_anon = dataset.Select(p => new { p.FullName, Age = p.Age() });

//tuple
//var result_tuple = dataset.Select(p => (p.FullName, Age: p.Age()));

//GROUPBY
var result = dataset.GroupBy(p => p.HomeAddress.City);

// kolik lidi v jakem meste
foreach (var g in result)
{
    Console.WriteLine();
    Console.WriteLine($"Město: {g.Key}, počet lidí: {g.Count()}");

    foreach(var person in g)
    {
        Console.WriteLine(person);
    }
}

// vypiste lidi podle mest
















//foreach (var item in result)
//{
//    Console.WriteLine($"{item}");
//}