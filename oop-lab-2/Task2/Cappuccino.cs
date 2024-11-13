public class Cappuccino : Coffee
{
    public int MlOfMilk { get; set; }
    public const string Coffee = "Cappuccino";
    public Cappuccino(Intensity intensity, int mlOfMilk) : base(intensity)
    {
        MlOfMilk = mlOfMilk;
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Milk: {MlOfMilk} ml");
    }
}