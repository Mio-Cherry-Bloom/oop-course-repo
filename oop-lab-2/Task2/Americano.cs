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
    }