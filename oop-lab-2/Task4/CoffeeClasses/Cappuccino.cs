 namespace CoffeeClasses{
internal class Cappuccino : Coffee
{
    internal int MlOfMilk { get; set; }
    internal override string Name => "Cappuccino";
    public Cappuccino(Intensity intensity, int mlOfMilk) : base(intensity)
    {
        MlOfMilk = mlOfMilk;
    }
    internal override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" - Milk: {MlOfMilk} ml");
    }

    internal Cappuccino MakeCappuccino()
    {
        base.MakeCoffee();
        Console.WriteLine($"Adding {MlOfMilk} ml of milk");
        return this;
    }
}
 }