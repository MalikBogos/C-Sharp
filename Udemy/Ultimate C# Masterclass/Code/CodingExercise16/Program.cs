Triangle uitprobering = new Triangle(5, 10);

Console.WriteLine(uitprobering.AsString());
Console.WriteLine(uitprobering.CalculateArea());
Console.ReadKey();

public class Triangle
{
    private int _base;
    private int _height;

    public Triangle(int @base, int height)
    {
        _base = @base;
        _height = height;
    }
    public int CalculateArea()
    {
        int area = ((_base * _height) / 2);
        return area;
    }

    public string AsString ()
    {
        return $"Base is {_base}, height is {_height}";
    }
}