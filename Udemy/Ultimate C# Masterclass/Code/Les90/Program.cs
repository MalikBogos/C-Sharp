var names = new Names();
var path = new NamesFilePathBuilder().BuildFilePath();
var stringsTextualRepository = new StringsTextualRepository();
if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    var stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
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
    stringsTextualRepository.Write(path, names.All);
}
Console.WriteLine(new NamesFormatter().Format(names.All));
Console.ReadKey();

class NamesFilePathBuilder
{
    public string BuildFilePath()
    {
        // we could imagine this is much more complicated,
        // for example provided by the user and validated
        return "names.txt";
    }
}

class NamesFormatter
{
    public string Format(List<string> names)
    {
        return string.Join(Environment.NewLine, names);
    }
}