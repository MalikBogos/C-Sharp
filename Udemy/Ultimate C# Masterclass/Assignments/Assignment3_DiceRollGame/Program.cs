//RandomNumberGenerator number = new RandomNumberGenerator();

GenerateRandomNumber number = new GenerateRandomNumber();
number.DisplayNumber();
GenerateMessage.RolledDie();

Input input = new Input();
input.ReadInput();

Console.ReadKey();

class Input
{
    public void ReadInput()
    {
        int.Parse(Console.ReadLine());
    }  
}

public class Check
{
    void userInput(Input input)
    {
        if (input < 0)
        {
            GenerateMessage.IncorrectInput();
        }
    }
}