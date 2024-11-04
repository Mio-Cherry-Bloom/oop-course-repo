public class Cappuccino : Coffee
    {
        public int MlOfMilk { get; set; }
        public const string Coffee = "Cappuccino";

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($" - Type: {Coffee}");
            Console.WriteLine($" - Milk: {MlOfMilk} ml");
        }

        public static Cappuccino MakeCappuccino(Intensity intensity, int mlOfMilk)
        {
            Console.WriteLine($"Making {Coffee}...");
            Console.WriteLine($"- Brew the coffee with intensity {intensity}.");
            Console.WriteLine($"- Steam and froth {mlOfMilk} ml of milk.");
            var cappuccino = new Cappuccino { CoffeeIntensity = intensity, MlOfMilk = mlOfMilk };
            return cappuccino;
        }
    }