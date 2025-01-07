class GenerateMessage
{
    public static void RolledDie()
    {
        Console.WriteLine("Die rolled. Guess what number it shows in 3 tries.");
    }

    public static void WrongNumber()
    {
        Console.WriteLine("Wrong number");
        Console.WriteLine("Enter number: ");
    }

    public static void YouWin()
    {
        Console.WriteLine("You win");
    }
    public static void YouLose()
    {
        Console.WriteLine("You lose");
    }

    public static void IncorrectInput()
    {
        Console.WriteLine("Incorrect input");
        Console.WriteLine("Enter number:");
        // no chance is being used
    }
}