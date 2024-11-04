public class PumpkinSpiceLatte : Cappuccino
    {
        public int MgOfPumpkinSpice { get; private set; }
        public const string Name = "PumpkinSpiceLatte";

        internal PumpkinSpiceLatte(Intensity intensity, int mlOfMilk, int mgOfPumpkinSpice) 
            : base(intensity, mlOfMilk)
        {
            MgOfPumpkinSpice = mgOfPumpkinSpice;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($" - Type: {Name}");
            Console.WriteLine($" - Milk: {MlOfMilk} ml");
            Console.WriteLine($" - Pumpkin Spice: {MgOfPumpkinSpice} mg");
        }
    }