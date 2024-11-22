var words = new[] { "one", "two", "three", "four" };


//for(var i = 0; i < words.Length; i++)
//{
//    Console.Write(words[i]);
//}

foreach(var word in words)
{
    Console.WriteLine(word);
}
Console.ReadKey();