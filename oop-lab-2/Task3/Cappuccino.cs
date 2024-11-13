public class Cappuccino : Coffee
{
    public int MlOfMilk { get; set; }
    public override string Name => "Cappuccino";
    public Cappuccino(Intensity intensity, int mlOfMilk) : base(intensity)
    {
        MlOfMilk = mlOfMilk;
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Milk: {MlOfMilk} ml");
    }

    public Cappuccino MakeCappuccino()
    {
        base.MakeCoffee();
        Console.WriteLine($"Adding {MlOfMilk} ml of milk");
        return this;
    }
}
