
    public enum Intensity
    {
        LIGHT,
        NORMAL,
        STRONG
    }

    public enum SyrupType
    {
        MACADAMIA,
        VANILLA,
        COCONUT,
        CARAMEL,
        CHOCOLATE,
        POPCORN
    }

    public class Coffee
    {
        public Intensity CoffeeIntensity { get; set; }
        public const string Name = "Coffee";
    }

    public class Americano : Coffee
    {
        public int MlOfWater { get; set; }
        public const string CoffeeName = "Americano";
    }

    public class Cappuccino : Coffee
    {
        public int MlOfMilk { get; set; }
        public const string Coffee = "Cappuccino";
    }

    public class SyrupCappuccino : Cappuccino
    {
        public SyrupType Syrup { get; set; }
        public const string Coffee = "SyrupCappuccino";
    }

    public class PumpkinSpiceLatte : Cappuccino
    {
        public int MgOfPumpkinSpice { get; set; }
        public const string Name = "PumpkinSpiceLatte";
    }

