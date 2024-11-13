public class PumpkinSpiceLatte : Cappuccino
{
    public int MgOfPumpkinSpice { get; set; }
    public override string Name => "PumpkinSpiceLatte";
    public PumpkinSpiceLatte(Intensity intensity, int mlOfMilk, int mgOfPumpkinSpice) : base(intensity, mlOfMilk)
    {
        MgOfPumpkinSpice = mgOfPumpkinSpice;
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Pumpkin Spice: {MgOfPumpkinSpice} mg");
    }

    public PumpkinSpiceLatte MakePumpkinSpiceLatte()
    {
        base.MakeCappuccino();
        Console.WriteLine($"Adding {MgOfPumpkinSpice} mg of pumpkin spice");
        return this;
    }
}