 namespace CoffeeClasses{
internal class PumpkinSpiceLatte : Cappuccino
{
    internal int MgOfPumpkinSpice { get; set; }
    internal override string Name => "PumpkinSpiceLatte";
    public PumpkinSpiceLatte(Intensity intensity, int mlOfMilk, int mgOfPumpkinSpice) : base(intensity, mlOfMilk)
    {
        MgOfPumpkinSpice = mgOfPumpkinSpice;
    }
    internal override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Pumpkin Spice: {MgOfPumpkinSpice} mg");
    }

    internal PumpkinSpiceLatte MakePumpkinSpiceLatte()
    {
        base.MakeCappuccino();
        Console.WriteLine($"Adding {MgOfPumpkinSpice} mg of pumpkin spice");
        return this;
    }
}
 }