 public class Coffee
    {
        public Intensity CoffeeIntensity { get; private set; }
        public const string Name = "Coffee";

        protected Coffee(Intensity intensity)
        {
            CoffeeIntensity = intensity;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Coffee Details: ");
            Console.WriteLine($" - Name: {Name}");
            Console.WriteLine($" - Intensity: {CoffeeIntensity}");
        }
    }