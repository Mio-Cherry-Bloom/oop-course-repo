public class SyrupCappuccino : Cappuccino
    {
        public SyrupType Syrup { get; private set; }
        public const string Coffee = "SyrupCappuccino";

        internal SyrupCappuccino(Intensity intensity, int mlOfMilk, SyrupType syrup) 
            : base(intensity, mlOfMilk)
        {
            Syrup = syrup;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($" - Type: {Coffee}");
            Console.WriteLine($" - Milk: {MlOfMilk} ml");
            Console.WriteLine($" - Syrup: {Syrup}");
        }
    }