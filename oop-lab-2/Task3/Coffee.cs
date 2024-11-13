public class Coffee
{
    public Intensity CoffeeIntensity { get; set; }
    public virtual string Name => "Coffee";

    public Coffee(Intensity coffeeIntensity)
    {
        CoffeeIntensity = coffeeIntensity;
    }
    public virtual void PrintDetails()
    {
        Console.WriteLine($" - Intensity: {CoffeeIntensity}");
    }
    public Coffee MakeCoffee()
    {
        Console.WriteLine($"Making {Name}");
        Console.WriteLine($"Intensity set to {CoffeeIntensity}");
        return this;
    }
}

