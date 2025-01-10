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