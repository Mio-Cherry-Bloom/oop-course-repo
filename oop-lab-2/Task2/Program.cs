
    public class Barista
    {
        public void PrepareCoffee(Coffee coffee)
        {
            coffee.PrintDetails();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Americano americano = new Americano { CoffeeIntensity = Intensity.NORMAL, MlOfWater = 100 };
            Cappuccino cappuccino = new Cappuccino { CoffeeIntensity = Intensity.STRONG, MlOfMilk = 50 };
            SyrupCappuccino syrupCappuccino = new SyrupCappuccino { CoffeeIntensity = Intensity.LIGHT, MlOfMilk = 40, Syrup = SyrupType.VANILLA };
            PumpkinSpiceLatte pumpkinSpiceLatte = new PumpkinSpiceLatte { CoffeeIntensity = Intensity.NORMAL, MlOfMilk = 60, MgOfPumpkinSpice = 20 };

            Barista barista = new Barista();
            barista.PrepareCoffee(americano);
            barista.PrepareCoffee(cappuccino);
            barista.PrepareCoffee(syrupCappuccino);
            barista.PrepareCoffee(pumpkinSpiceLatte);
        }
    }

