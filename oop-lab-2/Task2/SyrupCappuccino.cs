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
    }