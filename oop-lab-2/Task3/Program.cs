class Program
{
    static void Main(string[] args)
    {
        Americano americano = new Americano(Intensity.STRONG, 200);
        americano.MakeAmericano();
        Console.WriteLine();

        Cappuccino cappuccino = new Cappuccino(Intensity.NORMAL, 150);
        cappuccino.MakeCappuccino();
        Console.WriteLine();

        SyrupCappuccino syrupCappuccino = new SyrupCappuccino(Intensity.LIGHT, 120, SyrupType.VANILLA);
        syrupCappuccino.MakeSyrupCappuccino();
        Console.WriteLine();

        PumpkinSpiceLatte pumpkinSpiceLatte = new PumpkinSpiceLatte(Intensity.NORMAL, 100, 50);
        pumpkinSpiceLatte.MakePumpkinSpiceLatte();

    }
}

