using System.Runtime.CompilerServices;

public static class StringsTransformator
{
    public static string TransformSeperators
    (
        string input,
        string originalSeperator, 
        string targetSeperator)
    {
        string result = string.Join(input, originalSeperator, targetSeperator);
    }
}