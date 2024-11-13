public class Americano : Coffee
{
    public int MlOfWater { get; set; }
    public override string Name => "Americano";
    public Americano(Intensity intensity, int mlOfWater) : base(intensity)
    {
        MlOfWater = mlOfWater;
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Water: {MlOfWater} ml");
    }

    public Americano MakeAmericano()
    {
        base.MakeCoffee();
        Console.WriteLine($"Adding {MlOfWater} ml of water");
        return this;
    }

}