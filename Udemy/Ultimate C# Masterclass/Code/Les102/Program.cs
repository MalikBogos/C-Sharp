var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new Mozarella());
pizza.AddIngredient(new TomatoSauce());

Console.WriteLine(pizza.Describe());

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

}

public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
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
