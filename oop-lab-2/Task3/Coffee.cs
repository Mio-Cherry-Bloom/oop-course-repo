 public class Coffee
    {
        public Intensity CoffeeIntensity { get; set; }
        public const string Name = "Coffee";

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Coffee Details: ");
            Console.WriteLine($" - Name: {Name}");
            Console.WriteLine($" - Intensity: {CoffeeIntensity}");
        }
    }