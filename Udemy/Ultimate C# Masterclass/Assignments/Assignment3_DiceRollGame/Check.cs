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
            GenerateMessage.EnterNumber();
            Input userInput = new Input();

            int attempts = 1;
            while (input != randomNumber && attempts < 3)
            {
                input = userInput.ReadInput();
                if (input == randomNumber)
                {
                    GenerateMessage.YouWin();
                    return;
                }
                else if(attempts < 2)
                {
                    GenerateMessage.WrongNumber();
                    GenerateMessage.EnterNumber();
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