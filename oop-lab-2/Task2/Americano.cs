public class Americano : Coffee
{
    public int MlOfWater { get; set; }
    public const string CoffeeName = "Americano";

    public Americano(Intensity intensity, int mlOfWater) : base(intensity)
    {
        MlOfWater = mlOfWater;
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Water: {MlOfWater} ml");
    }
}