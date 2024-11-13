 namespace CoffeeClasses{
internal class Coffee
{
    internal Intensity CoffeeIntensity { get; set; }
    internal virtual string Name => "Coffee";

    public Coffee(Intensity coffeeIntensity)
    {
        CoffeeIntensity = coffeeIntensity;
    }
    internal virtual void PrintDetails()
    {
        Console.WriteLine(Name);
        Console.WriteLine($" - Intensity: {CoffeeIntensity}");
    }
    internal Coffee MakeCoffee()
    {
        Console.WriteLine($"Making {Name}");
        Console.WriteLine($"Intensity set to {CoffeeIntensity}");
        return this;
    }
}
 }
