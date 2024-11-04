public class Americano : Coffee
    {
        public int MlOfWater { get; private set; }
        public const string CoffeeName = "Americano";

        internal Americano(Intensity intensity, int mlOfWater) : base(intensity)
        {
            MlOfWater = mlOfWater;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($" - Type: {CoffeeName}");
            Console.WriteLine($" - Water: {MlOfWater} ml");
        }
    }