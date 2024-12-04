Dog ding = new Dog("Lucky", "german shepherd", 40);
Dog hond = new Dog("Tina", "shar pei", 25);


Console.WriteLine(hond.Describe());
Console.WriteLine(ding.Describe());
Console.ReadKey();

//public class Dog
//{
//    private string _name;
//    private string _breed;
//    private int _weight;

//    public Dog(string name, string breed, int weight)
//    {
//        _name = name;
//        _breed = breed;
//        _weight = weight;
//    }

//    public Dog(string name, int weight, string breed = "mixed-breed")
//    {
//        _name = name;
//        _breed = breed;
//        _weight = weight;
//    }

//    public string Describe()
//    {
//        string size;
//        if (_weight < 5)
//        {
//            size = "tiny";
//        }
//        else if (_weight >= 5 && _weight < 30)
//        {
//            size = "medium";
//        }
//        else
//        {
//            size = "large";
//        }

//        return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {size} dog.";
//    }
//}

public class Dog // correct version
{
    private string _name;
    private string _breed;
    private int _weight;

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog(string name, int weight) : this(name, "mixed-breed", weight)
    {
    }

    public string Describe()
    {
        return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {DescribeSize()} dog.";
    }

    private string DescribeSize()
    {
        if (_weight < 5)
        {
            return "tiny";
        }
        else if (_weight >= 5 && _weight < 30)
        {
            return "medium";
        }
        else
        {
            return "large";
        }
    }
}