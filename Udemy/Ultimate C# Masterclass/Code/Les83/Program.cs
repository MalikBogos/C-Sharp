var rectangle1 = new Rectangle(5, 10);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.GetHeight());
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

Console.WriteLine(rectangle1.Description);
Console.WriteLine(rectangle1.LongDescription);
Console.ReadKey();

class Rectangle
{


    public static int GetOne() => 1;

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
    }

    //private int _width;

    //public int Width
    //{
    //    get
    //    {
    //        return _width;
    //    }
    //    set
    //    {
    //        if (value > 10)
    //        {
    //            _width = value;
    //        }
    //        _width = value;
    //    }
    //}

    // ^^^ same as:
    public int Width { get; }


    public int _height;

    public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
    }


    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;
    }


    public int CalculateCircumference() => 2 * Width + 2 * _height;  // expression-bodied method

    public int CalculateArea() => Width * _height;  // expression-bodied method

    public string Description => $"A rectangle with width {Width} " + $"and height {_height}";

    public string LongDescription
    {
        get 
        {
            var result = "";
            for (int i = 0; i < 100000; i++) {
                result += i;
            }
            return result;
        }
    }
}

//class ShapesMeasurementsCalculator
//{

//}