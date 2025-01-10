class GenerateRandomNumber
{
    public readonly int Number = new Random().Next(1, 7);

    public void DisplayNumber()
    {
        Console.WriteLine(Number);
    }
}
