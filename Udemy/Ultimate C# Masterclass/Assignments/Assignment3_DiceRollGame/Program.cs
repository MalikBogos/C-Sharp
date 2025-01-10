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
        if(!int.TryParse(input, out int result))
        {
            GenerateMessage.IncorrectInput();
            input = Console.ReadLine();
        }
        return result;
        
    }  
}

public class Check
{
    public void Validation(int input, int randomNumber)
    {
        if (input == randomNumber)
        {
            GenerateMessage.YouWin();
        }
        else
        {
            GenerateMessage.WrongNumber();
            Input userInput = new Input();

            int attempts = 1;
            while (input != randomNumber && attempts < 3)
            {
                Console.WriteLine($"Attempt {attempts + 1}:");
                input = userInput.ReadInput();
                if (input == randomNumber)
                {
                    GenerateMessage.YouWin();
                    return;
                }
                else
                {
                    GenerateMessage.WrongNumber();
                    
                }
                attempts++;

                if (input != randomNumber && attempts == 3)
                {
                    GenerateMessage.YouLose();
                }
            }
        }
    }
}