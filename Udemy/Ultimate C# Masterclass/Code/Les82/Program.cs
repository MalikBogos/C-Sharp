// var person = new Person("John", 1981);

//var person1 = new Person("Johnny")
//{
//    YearOfBirth = 1999
//};

var person2 = new Person // use object initializers when it's ok to have some default values, otherwise constructor
{
    Name = "John",
    YearOfBirth = 1982
};

Console.WriteLine(person2.YearOfBirth);
Console.WriteLine(person2.Name);


Console.ReadKey();


class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; init; } // init only lets you assign a value to the property during object construction

    //public Person(string name)
    //{
    //    Name = name; 
    //}

    //public Person (string name, int yearOfBirth) 
    //{
    //    Name = name;
    //    YearOfBirth = yearOfBirth;
    //}
}