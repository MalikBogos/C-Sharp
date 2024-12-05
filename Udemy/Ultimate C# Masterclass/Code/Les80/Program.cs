var rectangle1 = new Rectangle(5, 10);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.GetHeight());
Console.WriteLine("Area is " + rectangle1.CalculateRectangleArea(rectangle1));
Console.WriteLine("Circumference is " + rectangle1.CalculateRectangleCircumference(rectangle1));

//rectangle1.Width = -10; // cannot be used with readonly variable
Console.ReadKey();

class Rectangle
{
    public readonly int Width;
    public int _height;

    public static int GetOne() => 1;

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
    }

    public int GetHeight() => _height;  // essentially getter method

    public void SetHeight(int value)  // essentially setter method
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

    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle._height;  // expression-bodied method

    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle._height;  // expression-bodied method
}

//class ShapesMeasurementsCalculator
//{

//}