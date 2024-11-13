
namespace CoffeeClasses
{
    public class Barista
    {
        public void StartOrdering()
        {
            List<Coffee> coffeeOrders = new List<Coffee>();

            Console.WriteLine("Welcome to the Coffee Shop!");

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
            Console.WriteLine("Thank you for your orders!");
        }

        private Americano OrderAmericano()
        {
            Console.WriteLine("Ordering an Americano.");
            Intensity intensity = SelectIntensity();
            int mlOfWater = SelectMlOfWater();
            Americano americano = new Americano(intensity, mlOfWater);
            return americano.MakeAmericano();
        }

        private Cappuccino OrderCappuccino()
        {
            Console.WriteLine("Ordering a Cappuccino.");
            Intensity intensity = SelectIntensity();
            int mlOfMilk = SelectMlOfMilk();
            Cappuccino cappuccino = new Cappuccino(intensity, mlOfMilk);
            return cappuccino.MakeCappuccino();
        }

        private SyrupCappuccino OrderSyrupCappuccino()
        {
            Console.WriteLine("Ordering a Syrup Cappuccino.");
            Intensity intensity = SelectIntensity();
            int mlOfMilk = SelectMlOfMilk();
            SyrupType syrup = SelectSyrup();
            SyrupCappuccino syrupCappuccino = new SyrupCappuccino(intensity, mlOfMilk, syrup);
            return syrupCappuccino.MakeSyrupCappuccino();
        }

        private PumpkinSpiceLatte OrderPumpkinSpiceLatte()
        {
            Console.WriteLine("Ordering a Pumpkin Spice Latte.");
            Intensity intensity = SelectIntensity();
            int mlOfMilk = SelectMlOfMilk();
            int mgOfPumpkinSpice = SelectMgOfPumpkinSpice();
            PumpkinSpiceLatte pumpkinSpiceLatte = new PumpkinSpiceLatte(intensity, mlOfMilk, mgOfPumpkinSpice);
            return pumpkinSpiceLatte.MakePumpkinSpiceLatte();
        }


        private Intensity SelectIntensity()
        {
            Console.WriteLine("Select intensity:");
            foreach (Intensity intensity in Enum.GetValues(typeof(Intensity)))
            {
                Console.WriteLine($"{(int)intensity + 1}. {intensity}");
            }
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine()) - 1;

            return (Intensity)choice;
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
            {
                Console.WriteLine($"{(int)syrup + 1}. {syrup}");
            }
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine()) - 1;

            return (SyrupType)choice;
        }

        private int SelectMgOfPumpkinSpice()
        {
            Console.WriteLine("Enter the amount of pumpkin spice in mg: ");
            return int.Parse(Console.ReadLine());
        }
    }

}