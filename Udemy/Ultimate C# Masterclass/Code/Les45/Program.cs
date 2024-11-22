string word;

do
{
    Console.Write("Enter text longer than 10 letters");
    word = Console.ReadLine();
} while (word.Length < 10);