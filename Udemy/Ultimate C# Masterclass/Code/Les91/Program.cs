﻿//global using System.Diagnostics; // used to import the namespace in all files

//using System.Diagnostics; 

var stopwatch = Stopwatch.StartNew();

for (int i = 0; i < 1000; i++)
{
    Console.WriteLine($"Loop number {i}");
}

stopwatch.Stop();

Console.WriteLine("Time in ms: " + stopwatch.ElapsedMilliseconds);

Console.ReadKey();


//var names = new Names();
//var path = new NamesFilePathBuilder().BuildFilePath();
//var stringsTextualRepository = new StringsTextualRepository();
//if (File.Exists(path))
//{
//    Console.WriteLine("Names file already exists. Loading names.");
//    var stringsFromFile = stringsTextualRepository.Read(path);
//    names.AddNames(stringsFromFile);
//}
//else
//{
//    Console.WriteLine("Names file does not yet exist");

//    //let's imagine they are given by the user
//    names.AddName("John");
//    names.AddName("not a valid name");
//    names.AddName("Claire");
//    names.AddName("123 definitely not a valid name");

//    Console.WriteLine("Saving names to a file");
//    stringsTextualRepository.Write(path, names.All);
//}
//Console.WriteLine(new NamesFormatter().Format(names.All));
//Console.ReadKey();
