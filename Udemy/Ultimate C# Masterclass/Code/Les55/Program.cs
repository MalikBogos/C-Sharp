var numbers = new []{ 10, -8, 2, 12, -17 };
var onlyPositive = GetOnlyPositive(numbers, out int nonPositiveCount);
foreach(var positiveNumber in onlyPositive)
{
    Console.WriteLine(positiveNumber);
}
Console.WriteLine("Count of non positive: " + nonPositiveCount);
Console.ReadKey();
List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    countOfNonPositive = 0;
    var result = new List<int>();

    foreach(var number in numbers)
    {
        if(number > 0)
        {
            result.Add(number);
        } else
        {
            countOfNonPositive++;
        }
    } return result;
}



Console.ReadKey();





/*
 * int test = 5;

var getallen = berekening(test, out int getal2);

Console.WriteLine(getal2);
Console.ReadKey();

int berekening(int getal, out int getal2)
{
    getal2 = 20;
    while (getal < 10)
    {
        getal++;
    }
    return getal;
} 
*/