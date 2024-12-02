public class CodingExercise7
{
    public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
    {
        int currentNumber = firstNumber;
        int sum = 0;

        while (currentNumber <= lastNumber)
        {
            sum += currentNumber;
            currentNumber++;
        }
        return sum;
    }
    public static void Main(String[] args)
    {
        Console.WriteLine(CalculateSumOfNumbersBetween(3, 7));
        Console.ReadKey();
    }
}