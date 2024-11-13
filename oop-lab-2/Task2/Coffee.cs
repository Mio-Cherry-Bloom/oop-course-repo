public class Coffee
{
    public Intensity CoffeeIntensity { get; set; }
    public const string Name = "Coffee";
    public Coffee(Intensity intensity)
    {
        CoffeeIntensity = intensity;
    }
    public virtual void PrintDetails()
    {
        Console.WriteLine($" - Intensity: {CoffeeIntensity}");
    }
}