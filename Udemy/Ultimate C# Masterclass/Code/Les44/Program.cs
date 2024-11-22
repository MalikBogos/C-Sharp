using System;

Console.WriteLine("Enter a word:");
var userInput = Console.ReadLine();

while(userInput.Length < 15)
{
    userInput += "a";
    Console.WriteLine(userInput);
}
Console.WriteLine("The loop is finished");
Console.ReadKey();
