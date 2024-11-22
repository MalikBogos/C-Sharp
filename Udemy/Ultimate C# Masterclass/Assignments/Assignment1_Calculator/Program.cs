Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");
var firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number");
var secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("What do you want to do with these numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
var userInput = Console.ReadLine().ToUpper();

//if(userInput == "A")
//{
//    Addition(firstNumber, secondNumber);
//} else if(userInput == "S")
//{
//    Subtraction(firstNumber, secondNumber);
//} else if(userInput == "M")
//{
//    Multiplication(firstNumber, secondNumber);
//} else
//{
//    Console.WriteLine("Invalid option");
//}
//Console.WriteLine("Press any key to close");
//Console.ReadKey();

switch (userInput)
{
    case "A":
        Addition(firstNumber, secondNumber);
        break;

    case "S":
        Subtraction(firstNumber, secondNumber);
        break;

    case "M":
        Multiplication(firstNumber, secondNumber);
        break;

    default:
        Console.WriteLine("Invalid option");
        break;
}

Console.WriteLine("Press any key to close");
Console.ReadKey();


static void Addition(int firstNumber, int secondNumber)
{
    var sum = firstNumber + secondNumber;
    Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
}

static void Subtraction(int firstNumber, int secondNumber)
{
    var difference = firstNumber - secondNumber;
    Console.WriteLine($"{firstNumber} - {secondNumber} = {difference}");
}

static void Multiplication(int firstNumber, int secondNumber)
{
    var product = firstNumber * secondNumber;
    Console.WriteLine($"{firstNumber} * {secondNumber} = {product}");
}