printKeuzeMenu();
string userInput = Console.ReadLine().ToUpper();
List<string> TODOlist = new List<string>();

while (userInput != "E")
{
    switch (userInput)
    {
        case "S":
            if (TODOlist.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
                break;
            }
            else
            {
                printTODOlist();
                break;
            }

        case "A":
            do
            {
                Console.WriteLine("Enter a TODO description: ");
                userInput = Console.ReadLine();

                if (userInput == string.Empty)
                {
                    Console.WriteLine("The description cannot be empty.");
                }
                else if (TODOlist.Contains(userInput))
                {
                    Console.WriteLine("The description must be unique.");
                }
                else
                {
                    TODOlist.Add(userInput);
                    Console.WriteLine("TODO succesfully added: " + userInput);
                    break;
                }
            } while (true);
            break;

        case "R":
            Console.WriteLine("Select the index of the TODO you want to remove");
            printTODOlist();
            bool isValid = int.TryParse(Console.ReadLine(), out int TODOremover);

            if (isValid)
            {
                Console.WriteLine("Valid integer: " + TODOremover);
                string tijdelijkeWaarde = TODOlist[TODOremover - 1];
                TODOlist.Remove(TODOlist[TODOremover - 1]);
                Console.WriteLine("TODO removed: " + tijdelijkeWaarde);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            break;


        default:
            Console.WriteLine("default");
            break;
    }
    printKeuzeMenu();
    userInput = Console.ReadLine().ToUpper();
}

void printKeuzeMenu()
{
    Console.WriteLine();
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

void printTODOlist()
{
    if (TODOlist.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
    }
    else
    {
        for (int i = 0; i < TODOlist.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {TODOlist[i]}");
        }
    }

}