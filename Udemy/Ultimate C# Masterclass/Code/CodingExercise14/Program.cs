public class CodingExercise14
{
    public List<string> GetOnlyUpperCaseWords(List<string> words)
    {
        var capital = new List<string>();

        foreach (string woord in words)
        {
            if (capital.Contains(woord))
            {
                continue;
            }
            else if (woord.All(char.IsUpper))
            {
                capital.Add(woord);
            }
        }
        return capital;
    }


    //-------------------------------------------------------------
    //public List<string> GetOnlyUpperCaseWords(List<string> words)
    //{
    //    var result = new List<string>();
    //    foreach (var word in words)
    //    {
    //        if (result.Contains(word))
    //        {
    //            continue;
    //        }
    //        bool isWordUpperCase = true;
    //        foreach (char letter in word)
    //        {
    //            if (!char.IsUpper(letter))
    //            {
    //                isWordUpperCase = false;
    //                break;
    //            }
    //        }
    //        if (isWordUpperCase)
    //        {
    //            result.Add(word);
    //        }
    //    }
    //    return result;
    //}


    // -----------------------------------------------------------
    //public List<string> GetOnlyUpperCaseWords(List<string> words)
    //{
    //    var result = new List<string>();
    //    foreach(var word in words)
    //    {
    //        if(result.Contains(word))
    //        {
    //            continue;
    //        }
    //        if (isUpperCase(word))
    //        {
    //            result.Add(word);
    //        }
    //    }
    //    return result;
    //}

    //bool isUpperCase(string word)
    //{
    //    foreach (var letter in word)
    //    {
    //        if (!char.IsUpper(letter))
    //        {
    //            return false;
    //        }
    //    }
    //    return true;
    //}


    public static void Main(String[] args)
    {
        var list = new List<String> { "one", "TWO", "THREE", "four", "TWO"};

        var result = new CodingExercise14().GetOnlyUpperCaseWords(list);
        foreach (var word in result)
        {
            Console.WriteLine(word);
        }
        Console.ReadKey();
    }
}