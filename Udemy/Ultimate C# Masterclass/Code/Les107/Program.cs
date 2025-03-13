var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, 19 };
bool shallAddPositiveOnly = true;

int sum;

if (shallAddPositiveOnly)
{
    sum = new PositiveNumbersSumCalculator().Calculate(numbers);
}
else
{
    sum = new NumbersSumCalculator().Calculate(numbers);
}

Console.WriteLine("Sum is: " + sum);



Console.ReadKey();

public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;

    }
}

public class PositiveNumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if(number > 0)
            {
                sum += number;
            }
        }
        return sum;

    }
}
