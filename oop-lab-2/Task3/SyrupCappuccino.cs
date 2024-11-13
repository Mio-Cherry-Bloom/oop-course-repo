public class SyrupCappuccino : Cappuccino
{
    public SyrupType Syrup { get; set; }
    public override string Name => "SyrupCappuccino";
    public SyrupCappuccino(Intensity intensity, int mlOfMilk, SyrupType syrup) : base(intensity, mlOfMilk)
    {
        Syrup = syrup;
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Syrup: {Syrup}");
    }

    public SyrupCappuccino MakeSyrupCappuccino()
    {
        base.MakeCappuccino();
        Console.WriteLine($"Adding syrup flavor: {Syrup}");
        return this;
    }
}