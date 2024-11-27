printKeuzeMenu();
string userInput = Console.ReadLine().ToUpper();

//List<string> TODOlist = new List<string>();
var TODOlist = new List<string>();

while (userInput != "E")
{
    switch (userInput)
    {
        case "S":
            if (TODOlist.Count == 0)
            {
                printTODOlist();
                break;
            }
            else
            {
                printTODOlist();
                break;
            }

        case "A":
            AddTodo();
            break;

        case "R":
            RemoveTODO();
            break;


        default:
            Console.WriteLine("Invalid choice");
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
        return;
    }
    for (int i = 0; i < TODOlist.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {TODOlist[i]}");
    }
}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter a TODO description: ");
        description = Console.ReadLine();
    } while (!IsDescriptionValid(description));
    TODOlist.Add(description);
}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("The description cannot be empty");
        return false;
    }
    else if (TODOlist.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }
    return true;

}

void RemoveTODO()
{
    if (TODOlist.Count == 0)
    {
        printTODOlist();
        return;
    }

    bool validInput = false;
    while (!validInput)
    {
        Console.WriteLine("Select the index of the TODO you want to remove");
        printTODOlist();

        userInput = Console.ReadLine();
        bool isValid = int.TryParse(userInput, out int TODOremover);

        if (!isValid)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            continue;
        }

        if (TODOremover < 1 || TODOremover > TODOlist.Count)
        {
            Console.WriteLine($"Invalid input. Please enter a number between 1 and {TODOlist.Count}.");
            continue;
        }

        validInput = true;
        int ToRemove = TODOremover - 1;
        string tijdelijkeWaarde = TODOlist[ToRemove];
        TODOlist.RemoveAt(ToRemove);
        Console.WriteLine("TODO removed: " + tijdelijkeWaarde);
    }
}