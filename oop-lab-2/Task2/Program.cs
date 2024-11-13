
class Program
{
    static void Main()
    {
        Americano americano = new Americano(Intensity.NORMAL, 100);
        Cappuccino cappuccino = new Cappuccino(Intensity.STRONG, 50);
        SyrupCappuccino syrupCappuccino = new SyrupCappuccino(Intensity.LIGHT, 40, SyrupType.VANILLA);
        PumpkinSpiceLatte pumpkinSpiceLatte = new PumpkinSpiceLatte(Intensity.NORMAL, 60, 20);




        Console.WriteLine("Americano:");
        americano.PrintDetails();
        Console.WriteLine();
        Console.WriteLine("Cappuccino:");
        cappuccino.PrintDetails();
        Console.WriteLine();
        Console.WriteLine("Syrup Cappuccino:");
        syrupCappuccino.PrintDetails();
        Console.WriteLine();
        Console.WriteLine("Pumpkin SpiceLatte:");
        pumpkinSpiceLatte.PrintDetails();
    }
}

