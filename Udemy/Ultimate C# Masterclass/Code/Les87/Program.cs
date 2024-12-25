var names = new Names();
var path = names.BuildFilePath();
if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    names.ReadFromTextFile();
}
else
{
    Console.WriteLine("Names file does not yet exist");

    //let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to a file");
    names.WriteToTextFile();
}
Console.WriteLine(names.Format);
Console.ReadKey();

class NamesValidator
{
    public bool IsValid(string name)
    {
        return name.Length >= 2 && name.Length < 25 && char.IsUpper(name[0]) && name.All(char.IsLetter);
    }
}

class NamesRepository
{
    public List<string> ReadFromTextFile(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Environment.NewLine).ToList();
    }

    public void WriteToTextFile(string filePath, string textToBeSaved)
    {
        File.WriteAllText(filePath, textToBeSaved);
    }
}

class Names
{
    private List<string> _names = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();

    public void AddName(string name)
    {
        if (new NamesValidator().IsValid(name))
        {
            _names.Add(name);
        }
    }

    

    

    public string BuildFilePath()
    {
        // we could imagine this is much more complicated,
        // for example provided by the user and validated
        return "names.txt";
    }

    public string Format()
    {
        return string.Join(Environment.NewLine, _names);
    }
}