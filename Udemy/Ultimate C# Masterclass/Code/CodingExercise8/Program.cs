public class CodingExercise8
{
    public static string RepeatCharacter(char character, int targetLength)
    {
        string tekst = "";
        do
        {
            tekst = tekst + character;
        } while (tekst.Length < targetLength);

        return tekst;
    }

    public static void Main(String[] args)
    {
        Console.WriteLine(RepeatCharacter('p', 9));
        Console.ReadKey();
    }
}