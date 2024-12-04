var rectangle1 = new Rectangle(5, 10);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.Height);
Console.WriteLine("Area is " + rectangle1.CalculateRectangleArea(rectangle1));
Console.WriteLine("Circumference is " + rectangle1.CalculateRectangleCircumference(rectangle1));

rectangle1.Width = -10;
Console.ReadKey();

class Rectangle
{
    const int NumberOfSides = 4; // must be assigned a value at declaration, value must be known at compile-time
    readonly int numberOfSidesReadonly = 4;
    public readonly int Width;
    public readonly int Height;

    public static int GetOne() => 1;

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        Height = GetLengthOrDefault(height, nameof(Height));
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

    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height;  // expression-bodied method

    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;  // expression-bodied method
}

//class ShapesMeasurementsCalculator
//{

//}