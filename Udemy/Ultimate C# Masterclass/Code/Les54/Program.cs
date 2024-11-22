//List<string> words = new List<string> { 
//    "one", "two"
//};

var words = new List<string>
{
    "one", "two"
};


words[0] = "uno";
words[1] = "due";

//var moreWords = new[] { "three", "four", "five" };
//words.AddRange(moreWords);

words.AddRange(new[] { "three", "four", "five" });
Console.WriteLine("Index of element four is: " + words.IndexOf("four"));

Console.WriteLine("Index of element seven is: " + words.IndexOf("seven"));


Console.WriteLine("Contains five? " + words.Contains("five"));
Console.WriteLine("Contains seven? " + words.Contains("seven"));


words.Clear();
Console.WriteLine("Count of elements is: " + words.Count);

words.Add("hello");
Console.WriteLine("Count of elements is " + words.Count);

Console.WriteLine();
Console.WriteLine("Removing an item");
words.Remove("Twenty two"); // will not do anything since there is no such word
words.RemoveAt(0);

foreach (var word in words)
{
    Console.WriteLine(word);
}

//for(int i = 0; i < words.Count; i++)
//{
//    Console.WriteLine(words[i]);    
//}

Console.ReadKey();