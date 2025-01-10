//RandomNumberGenerator number = new RandomNumberGenerator();

GenerateRandomNumber number = new GenerateRandomNumber();
int randomNumber = number.Number;
number.DisplayNumber();
GenerateMessage.RolledDie();

Input input = new Input();
int userInput = input.ReadInput();

Check check = new Check();
check.Validation(userInput, randomNumber);


Console.ReadKey();

public class Input
{
    public int ReadInput()
    {
        string input = Console.ReadLine();
        if(int.TryParse(input, out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 0.");
            return 0;
        }
        
    }  
}

public class Check
{
    public void Validation(int input, int randomNumber)
    {
        if (input == 0)
        {
            Console.WriteLine("Input is zero.");
        } 
        else if (input == randomNumber)
        {
            GenerateMessage.YouWin();
        }
        else
        {
            Console.WriteLine($"Input is: {input}");
        }
    }
}