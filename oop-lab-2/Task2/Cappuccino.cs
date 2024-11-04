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
    }