public class Input
{
    public int ReadInput()
    {
        string input;
        int result;

        // Continuously prompt the user until the input is valid
        while (true)
        {
            input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                break; // Exit the loop if parsing succeeds
            }
            else
            {
                GenerateMessage.IncorrectInput();
            }
        }

        return result;
        
    }  
}
