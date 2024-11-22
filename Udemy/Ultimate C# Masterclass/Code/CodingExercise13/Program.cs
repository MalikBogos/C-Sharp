

public class CodingExercise13
{
    static bool IsAnyWordLongerThan(int length, string[] words)
    {
        foreach (var word in words)
        {
            if (word.Length > length)
            {
                return true;
            }
        }
        return false;
    }
    public static void Main(string[] args)
    {
        //string[] woorden = { "hallo", "paard", "dingen", "appel", "huis", "ja", "tentoonstelling" };
        string[] woorden = { "aaa", "bbb", "ccc" };

        Console.WriteLine(IsAnyWordLongerThan(14, woorden));
        Console.ReadKey();
    }
}