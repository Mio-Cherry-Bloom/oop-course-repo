public class SyrupCappuccino : Cappuccino
{
    public SyrupType Syrup { get; set; }
    public const string Coffee = "SyrupCappuccino";
    public SyrupCappuccino(Intensity intensity, int mlOfMilk, SyrupType syrup) : base(intensity, mlOfMilk)
    {
        Syrup = syrup;
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Syrup: {Syrup}");
    }
}