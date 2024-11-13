
public class PumpkinSpiceLatte : Cappuccino
{
    public int MgOfPumpkinSpice { get; set; }
    public const string Name = "PumpkinSpiceLatte";
    public PumpkinSpiceLatte(Intensity intensity, int mlOfMilk, int mgOfPumpkinSpice) : base(intensity, mlOfMilk)
    {
        MgOfPumpkinSpice = mgOfPumpkinSpice;
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Pumpkin Spice: {MgOfPumpkinSpice} mg");
    }
}