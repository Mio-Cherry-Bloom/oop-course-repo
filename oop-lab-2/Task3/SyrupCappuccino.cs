public class SyrupCappuccino : Cappuccino
    {
        public SyrupType Syrup { get; set; }
        public const string Coffee = "SyrupCappuccino";

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($" - Type: {Coffee}");
            Console.WriteLine($" - Milk: {MlOfMilk} ml");
            Console.WriteLine($" - Syrup: {Syrup}");
        }

        public static SyrupCappuccino MakeSyrupCappuccino(Intensity intensity, int mlOfMilk, SyrupType syrup)
        {
            Console.WriteLine($"Making {Coffee}...");
            Console.WriteLine($"- Brew the coffee with intensity {intensity}.");
            Console.WriteLine($"- Steam and froth {mlOfMilk} ml of milk.");
            Console.WriteLine($"- Add {syrup} syrup.");
            var syrupCappuccino = new SyrupCappuccino { CoffeeIntensity = intensity, MlOfMilk = mlOfMilk, Syrup = syrup };
            return syrupCappuccino;
        }
    }