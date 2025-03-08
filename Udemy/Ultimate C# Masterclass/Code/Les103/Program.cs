//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozarella());
//pizza.AddIngredient(new TomatoSauce());

//Console.WriteLine(pizza.Describe());


var ingredient = new Ingredient();
ingredient.PublicField = 10;

var cheddar = new Cheddar();
cheddar.PublicField = 20;

Console.WriteLine("Value in ingredient: " + ingredient.PublicField);
Console.WriteLine("Value in cheddar: " + cheddar.PublicField);

//var cheddar = new Cheddar();
//Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.ProtectedMethod());
//Console.WriteLine(cheddar.PrivateMethod());

Console.ReadKey();

public class Pizza // problem to be solved with polymorphism
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public string Describe() =>
        $"This is a pizza with {String.Join(", ", _ingredients)}";
}

public class Ingredient
{
    public int PublicField;

    public string PublicMethod() =>
        "This method is PUBLIC in the Ingredient class.";

    protected string ProtectedMethod() =>
        "This method is PROTECTED in the Ingredient class";

    private string PrivateMethod() =>
        "This method is PRIVATE in the Ingredient class";
}

public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        //Console.WriteLine(PrivateMethod());
    }
}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }
}

public class Mozarella : Ingredient
{
    public string Name => "Mozarella";
    public bool IsLight { get; }
}
