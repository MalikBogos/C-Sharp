public class CodingExercise9
{
    public static int Factorial(int number)
    {
        int berekening = 1;
        for (int i = 1; i <= number; i++)
        {
            berekening *= i;
        }

        return berekening;
    }

    public static void Main(String[] args)
    {
        Console.WriteLine(Factorial(1));
        Console.ReadKey();
    }
}

