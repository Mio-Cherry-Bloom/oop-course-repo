public class PumpkinSpiceLatte : Cappuccino
    {
        public int MgOfPumpkinSpice { get; set; }
        public const string Name = "PumpkinSpiceLatte";

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($" - Type: {Name}");
            Console.WriteLine($" - Milk: {MlOfMilk} ml");
            Console.WriteLine($" - Pumpkin Spice: {MgOfPumpkinSpice} mg");
        }

        public static PumpkinSpiceLatte MakePumpkinSpiceLatte(Intensity intensity, int mlOfMilk, int mgOfPumpkinSpice)
        {
            Console.WriteLine($"Making {Name}...");
            Console.WriteLine($"- Brew the coffee with intensity {intensity}.");
            Console.WriteLine($"- Steam and froth {mlOfMilk} ml of milk.");
            Console.WriteLine($"- Add {mgOfPumpkinSpice} mg of pumpkin spice.");
            var pumpkinSpiceLatte = new PumpkinSpiceLatte { CoffeeIntensity = intensity, MlOfMilk = mlOfMilk, MgOfPumpkinSpice = mgOfPumpkinSpice };
            return pumpkinSpiceLatte;
        }
    }