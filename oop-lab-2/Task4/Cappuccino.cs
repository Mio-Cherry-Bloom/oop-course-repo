public class Cappuccino : Coffee
    {
        public int MlOfMilk { get; private set; }
        public const string Coffee = "Cappuccino";

        internal Cappuccino(Intensity intensity, int mlOfMilk) : base(intensity)
        {
            MlOfMilk = mlOfMilk;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($" - Type: {Coffee}");
            Console.WriteLine($" - Milk: {MlOfMilk} ml");
        }
    }