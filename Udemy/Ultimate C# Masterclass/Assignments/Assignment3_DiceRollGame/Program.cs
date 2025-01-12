GenerateRandomNumber number = new GenerateRandomNumber();
int randomNumber = number.Number;
number.DisplayNumber();
GenerateMessage.RolledDie();

Input input = new Input();
int userInput = input.ReadInput();

Check check = new Check();
check.Validation(userInput, randomNumber);

Console.ReadKey();