public class Barista
    {
        public void MakeCoffees(List<string> coffeeOrders)
        {
            foreach (var order in coffeeOrders)
            {
                Coffee coffee = null;
                switch (order.ToLower())
                {
                    case "cappuccino":
                        coffee = MakeCappuccino(Intensity.NORMAL, 150);
                        break;
                    case "pumpkinspicelatte":
                        coffee = MakePumpkinSpiceLatte(Intensity.STRONG, 200, 30);
                        break;
                    case "syrupcappuccino":
                        coffee = MakeSyrupCappuccino(Intensity.LIGHT, 100, SyrupType.VANILLA);
                        break;
                    default:
                        Console.WriteLine($"Sorry, we do not make {order}.");
                        continue;
                }
                coffee.PrintDetails();
                Console.WriteLine();
            }
        }

        private Cappuccino MakeCappuccino(Intensity intensity, int mlOfMilk)
        {
            Console.WriteLine($"Making Cappuccino...");
            Console.WriteLine($"- Brew the coffee with intensity {intensity}.");
            Console.WriteLine($"- Steam and froth {mlOfMilk} ml of milk.");
            return new Cappuccino(intensity, mlOfMilk);
        }

        private PumpkinSpiceLatte MakePumpkinSpiceLatte(Intensity intensity, int mlOfMilk, int mgOfPumpkinSpice)
        {
            Console.WriteLine($"Making PumpkinSpiceLatte...");
            Console.WriteLine($"- Brew the coffee with intensity {intensity}.");
            Console.WriteLine($"- Steam and froth {mlOfMilk} ml of milk.");
            Console.WriteLine($"- Add {mgOfPumpkinSpice} mg of pumpkin spice.");
            return new PumpkinSpiceLatte(intensity, mlOfMilk, mgOfPumpkinSpice);
        }

        private SyrupCappuccino MakeSyrupCappuccino(Intensity intensity, int mlOfMilk, SyrupType syrup)
        {
            Console.WriteLine($"Making SyrupCappuccino...");
            Console.WriteLine($"- Brew the coffee with intensity {intensity}.");
            Console.WriteLine($"- Steam and froth {mlOfMilk} ml of milk.");
            Console.WriteLine($"- Add {syrup} syrup.");
            return new SyrupCappuccino(intensity, mlOfMilk, syrup);
        }
    }