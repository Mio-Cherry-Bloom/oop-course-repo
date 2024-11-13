namespace CoffeeClasses
{
    public class Barista
    {
        public void StartOrdering()
        {
            List<Coffee> coffeeOrders = new List<Coffee>();

            Console.WriteLine("Welcome to the Maid Cafe!");

            while (true)
            {
                Console.WriteLine("\nPlease choose your coffee:");
                Console.WriteLine("1. Americano");
                Console.WriteLine("2. Cappuccino");
                Console.WriteLine("3. Syrup Cappuccino");
                Console.WriteLine("4. Pumpkin Spice Latte");
                Console.WriteLine("5. Finish Ordering");
                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    break;
                }

                Coffee coffee = null;

                switch (choice)
                {
                    case 1:
                        coffee = OrderAmericano();
                        break;
                    case 2:
                        coffee = OrderCappuccino();
                        break;
                    case 3:
                        coffee = OrderSyrupCappuccino();
                        break;
                    case 4:
                        coffee = OrderPumpkinSpiceLatte();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                coffeeOrders.Add(coffee);

                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine("Your coffee is added to the order. Would you like to order another one?");
                Console.WriteLine("-----------------------------------------------\n");
            }

            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("All your coffee orders:");
            Console.WriteLine("-----------------------------------------------");
            foreach (var order in coffeeOrders)
            {
                Console.WriteLine("\n-----------------------------------------------");
                order.PrintDetails();
                Console.WriteLine("-----------------------------------------------");
            }
            Console.WriteLine("Thank you for visiting our cafe.");
        }

        private Coffee OrderAmericano()
        {
            Console.WriteLine("Ordering an Americano.");
            Intensity intensity = SelectIntensity();
            int mlOfWater = SelectMlOfWater();
            Americano americano = new Americano(intensity, mlOfWater);
            return (Coffee)americano.MakeAmericano();
        }

        private Coffee OrderCappuccino()
        {
            Console.WriteLine("Ordering a Cappuccino.");
            Intensity intensity = SelectIntensity();
            int mlOfMilk = SelectMlOfMilk();
            Cappuccino cappuccino = new Cappuccino(intensity, mlOfMilk);
            return (Coffee)cappuccino.MakeCappuccino();
        }

        private Coffee OrderSyrupCappuccino()
        {
            Console.WriteLine("Ordering a Syrup Cappuccino.");
            Intensity intensity = SelectIntensity();
            int mlOfMilk = SelectMlOfMilk();
            SyrupType syrup = SelectSyrup();
            SyrupCappuccino syrupCappuccino = new SyrupCappuccino(intensity, mlOfMilk, syrup);
            return (Coffee)syrupCappuccino.MakeSyrupCappuccino();
        }

        private Coffee OrderPumpkinSpiceLatte()
        {
            Console.WriteLine("Ordering a Pumpkin Spice Latte.");
            Intensity intensity = SelectIntensity();
            int mlOfMilk = SelectMlOfMilk();
            int mgOfPumpkinSpice = SelectMgOfPumpkinSpice();
            PumpkinSpiceLatte pumpkinSpiceLatte = new PumpkinSpiceLatte(intensity, mlOfMilk, mgOfPumpkinSpice);
            return (Coffee)pumpkinSpiceLatte.MakePumpkinSpiceLatte();
        }

        private Intensity SelectIntensity()
        {
            Console.WriteLine("Select intensity:");
            foreach (Intensity intensity in Enum.GetValues(typeof(Intensity)))
                Console.WriteLine($"{(int)intensity + 1}. {intensity}");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Enum.GetValues(typeof(Intensity)).Length)
                Console.WriteLine("Invalid choice.");

            return (Intensity)(choice - 1);
        }

        private int SelectMlOfWater()
        {
            Console.WriteLine("Enter the amount of water in ml for your Americano: ");
            return int.Parse(Console.ReadLine());
        }

        private int SelectMlOfMilk()
        {
            Console.WriteLine("Enter the amount of milk in ml: ");
            return int.Parse(Console.ReadLine());
        }

        private SyrupType SelectSyrup()
        {
            Console.WriteLine("Select syrup flavor:");
            foreach (SyrupType syrup in Enum.GetValues(typeof(SyrupType)))
                Console.WriteLine($"{(int)syrup + 1}. {syrup}");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Enum.GetValues(typeof(SyrupType)).Length)
                Console.WriteLine("Invalid choice.");

            return (SyrupType)(choice - 1);
        }

        private int SelectMgOfPumpkinSpice()
        {
            Console.WriteLine("Enter the amount of pumpkin spice in mg: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
