Cat newCat = new Cat("Garfield", "ginger");
Console.WriteLine($"{newCat.Name} wantsa rub on its belly.");

while (newCat.BellyFull > 0)
{
    newCat.Sleep();
}
newCat.Meow();
newCat.ShowCatData();

class Cat
{
    private string _name;
    private string _color;
    private int _bellyFull;
    public Cat(string name, string color)
    {
        _name = name;
        _color = color;
        _bellyFull = 10;
        Console.WriteLine($"A {color} cat {name} has been created.");
    }

    //getter
    public string Name
    {
        get { return _name; }
    } 

    public string Color
    {
        get { return _color; }
    }

    public int BellyFull
    {
        get { return _bellyFull; }
    }

    public void Sleep()
    {
        _bellyFull--;
        Console.WriteLine($"{_name} says: Z-z-Z-Z-z");
    }

    public void Meow()
    {
        Console.WriteLine($"{_name} says: Meow!");
    }

    public void ShowCatData()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Level of hungriness: {_bellyFull}");
    }
}