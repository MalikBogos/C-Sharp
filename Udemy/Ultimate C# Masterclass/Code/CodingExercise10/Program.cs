Console.WriteLine(BuildHelloString());
Console.ReadKey();

//public static string BuildHelloString()
//{
//    char[] letters = new char[5];
//    var result = "";
//    for (int i = 0; i < letters.Length; ++i)
//    {
//        string woord = "hello";
//        result += woord[i];
//    }
//    return result;
//}

static string BuildHelloString()
{
    char[] letters = new char[] { 'h', 'e', 'l', 'l', 'o' };
    var result = "";
    for (int i = 0; i < letters.Length; ++i)
    {
        result += letters[i];
    }
    return result;
}