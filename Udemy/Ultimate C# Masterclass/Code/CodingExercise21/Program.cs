using System.Runtime.CompilerServices;
class something
{
    public static void Main(String[] args)
    {
        StringsTransformator.TransformSeperators("dit.is.een.test", ".", "+");
        Console.ReadKey();
    }

    

}

public static class StringsTransformator
{
    public static string TransformSeperators
    (
        string input,
        string originalSeperator, 
        string targetSeperator)
    {
        string[] result = input.Split(originalSeperator);
       

        return result;
    }
}