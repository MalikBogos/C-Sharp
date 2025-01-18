var random = new Random();
var diceRollResult = random.Next(1, 7);
Console.WriteLine(diceRollResult);

Console.ReadKey();

class Dice
{
    //private readonly Random _random;
    //private readonly int SidesCount;

    //public Dice(Random random, int sidesCount)
    //{
    //    SidesCount = sidesCount;
    //    _random = random;
    //}

    //public int Roll() => _random.Next(1, 7);

    //public void Describe()
    //{
    //    Console.WriteLine("This is a dice with 6 sides");
    //}

    private readonly Random _random;
    private const int SidesCount = 6;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll() => _random.Next(1, SidesCount + 1);

    public void Describe() => Console.WriteLine($"This is a dice with {SidesCount} sides");

}