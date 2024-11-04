
    class Program
    {
        static void Main(string[] args)
        {

            var cappuccino = Cappuccino.MakeCappuccino(Intensity.NORMAL, 150);
            cappuccino.PrintDetails();

            Console.WriteLine();

            var pumpkinSpiceLatte = PumpkinSpiceLatte.MakePumpkinSpiceLatte(Intensity.STRONG, 200, 30);
            pumpkinSpiceLatte.PrintDetails();

            Console.WriteLine();

            var syrupCappuccino = SyrupCappuccino.MakeSyrupCappuccino(Intensity.LIGHT, 100, SyrupType.VANILLA);
            syrupCappuccino.PrintDetails();
        }
    }

