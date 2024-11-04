  class Program
    {
        static void Main(string[] args)
        {
            var barista = new Barista();
            var coffeeOrders = new List<string> { "Cappuccino", "PumpkinSpiceLatte", "SyrupCappuccino", "Americano" };
            barista.MakeCoffees(coffeeOrders);
        }
    }

