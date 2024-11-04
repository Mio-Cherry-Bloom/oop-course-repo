
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
    }