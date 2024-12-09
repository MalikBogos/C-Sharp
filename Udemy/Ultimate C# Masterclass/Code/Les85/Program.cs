var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle(50, 100);

Console.WriteLine("Count of rectangle objects is: " + Rectangle.CountOfInstances);
//Console.WriteLine(Rectangle.DescribeGenerally());
//Console.WriteLine("Number of sides is " + Rectangle.NumberOfSides);
//Console.WriteLine("Width is " + rectangle1.Width);
//Console.WriteLine("Height is " + rectangle1.GetHeight());
//Console.WriteLine("Area is " + rectangle1.CalculateArea());
//Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

//Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
//Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
//Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");

Console.ReadKey();

static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}

class Rectangle
{
    // static fields, properties, constructors
    public static int CountOfInstances { get; private set; }

    private static DateTime _firstUsed;

    static Rectangle()
    {
        _firstUsed = DateTime.Now;
    }

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
        ++CountOfInstances;
    }
    public static int GetOne() => 1;

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
            for (int i = 0; i < 100000; i++)
            {
                result += i;
            }
            return result;
        }
    }

    public static string DescribeGenerally() => $"A plane figure with four straight sides and four right angles.";

    public string NotUsingAnyState() => "abc";
    public const int NumberOfSides = 4;

    // if a private method doesn't use instance data, make it static
    // all const fields are implicitly static
}