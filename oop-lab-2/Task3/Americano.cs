public class Americano : Coffee
    {
        public int MlOfWater { get; set; }
        public const string CoffeeName = "Americano";

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($" - Type: {CoffeeName}");
            Console.WriteLine($" - Water: {MlOfWater} ml");
        }

        public static Americano MakeAmericano(Intensity intensity, int mlOfWater)
        {
            Console.WriteLine($"Making {CoffeeName}...");
            Console.WriteLine($"- Brew the coffee with intensity {intensity}.");
            Console.WriteLine($"- Add {mlOfWater} ml of hot water.");
            var americano = new Americano { CoffeeIntensity = intensity, MlOfWater = mlOfWater };
            return americano;
        }
    }