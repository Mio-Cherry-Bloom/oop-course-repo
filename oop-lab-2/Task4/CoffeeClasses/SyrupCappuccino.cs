 namespace CoffeeClasses{

internal class SyrupCappuccino : Cappuccino
{
    internal SyrupType Syrup { get; set; }
    internal override string Name => "SyrupCappuccino";
    public SyrupCappuccino(Intensity intensity, int mlOfMilk, SyrupType syrup) : base(intensity, mlOfMilk)
    {
        Syrup = syrup;
    }
    internal override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Syrup: {Syrup}");
    }

    internal SyrupCappuccino MakeSyrupCappuccino()
    {
        base.MakeCappuccino();
        Console.WriteLine($"Adding syrup flavor: {Syrup}");
        return this;
    }
}
 }