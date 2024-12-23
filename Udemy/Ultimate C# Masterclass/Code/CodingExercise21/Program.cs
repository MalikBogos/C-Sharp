Console.WriteLine(StringsTransformator.TransformSeperators("dit.is.een.test", ".", "+"));
Console.ReadKey();

public static class StringsTransformator
{
    public static string TransformSeperators
    (
        string input,
        string originalSeperator, 
        string targetSeperator)
    {
        var stringPieces = input.Split(originalSeperator);
        return string.Join(targetSeperator, stringPieces);

        // string inputString = "this,is,some,string";
        // var result = inputString.Replace(',', '+');
        // return input.Replace(originalSeperator, targetSeperator);
    }
}