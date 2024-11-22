int userNumber;
do
{
    Console.WriteLine("Enter a number larger than 10: ");
    var userInput = Console.ReadLine();

    if (userInput == "stop")
    {
        break;
    }
    bool isParsableToInt = userInput.All(char.IsDigit);
    if(!isParsableToInt)
    {
        userNumber = 0;
        continue;
    }
    userNumber = int.Parse(userInput);

} while (userNumber <= 10);

Console.WriteLine("The loop is finished");
Console.ReadKey();