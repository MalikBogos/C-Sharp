public class Exercise
{
    public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
    {
        //switch(wordToBeChecked)
        //{
        //    case "one":
        //    case "two":
        //    case "three":
        //        return true;
        //    default:
        //        return false;
        //}

        //string[] array = { "one", "two", "three" };
        //switch (wordToBeChecked)
        //{
        //    case "one":
        //    case "two":
        //    case "three":
        //        return true;
        //    default:
        //        return false;
        //}

        for (var i = 0; i < words.Length; i++)
        {
            if (words[i] == wordToBeChecked)
            {
                return true;
            }
        }
        return false;
    }

    public static void Main(String[] args)
    {
        string[] rij = { "one", "two", "three" };
        Console.WriteLine(IsWordPresentInCollection(rij, "one"));
        Console.ReadKey();
    }
}