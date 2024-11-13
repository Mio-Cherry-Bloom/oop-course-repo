 namespace CoffeeClasses{
internal class Americano : Coffee
{
    internal int MlOfWater { get; set; }
    internal override string Name => "Americano";
    public Americano(Intensity intensity, int mlOfWater) : base(intensity)
    {
        MlOfWater = mlOfWater;
    }
    internal override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Water: {MlOfWater} ml");
    }

    internal Americano MakeAmericano()
    {
        base.MakeCoffee();
        Console.WriteLine($"Adding {MlOfWater} ml of water");
        return this;
    }

}
 }