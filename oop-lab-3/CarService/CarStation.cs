namespace CarService
{
    public class CarStation
    {
        private IDineable diningService;
        private IRefuelable refuelingService;
        private ICarQueue carQueue;

        public string StationType { get; private set; }

        public int electricCarCount = 0;
        public int gasCarCount = 0;
        public int peopleCount = 0;
        public int robotsCount = 0;
        public int diningCount = 0;
        public int notDiningCount = 0;
        public int electricConsumption = 0;
        public int gasConsumption = 0;

        public CarStation(IDineable diningService, IRefuelable refuelingService, ICarQueue carQueue, string stationType)
        {
            this.diningService = diningService;
            this.refuelingService = refuelingService;
            this.carQueue = carQueue;
            StationType = stationType;
        }

        public void AddCar(Car car)
        {
            if ((car.Type == "ELECTRIC" && refuelingService is not ElectricStation) ||
                (car.Type == "GAS" && refuelingService is not GasStation))
            {
                throw new InvalidOperationException($"Station {StationType} cannot serve car type {car.Type}.");
            }

            if ((car.PassengerType == "PEOPLE" && diningService is not PeopleDinner) ||
                (car.PassengerType == "ROBOTS" && diningService is not RobotDinner))
            {
                throw new InvalidOperationException($"Station {StationType} cannot serve dining type {car.PassengerType}.");
            }

            carQueue.Enqueue(car);
        }

        public void ServeCars()
        {
            while (carQueue.Count > 0)
            {
                var car = carQueue.Dequeue();
                refuelingService.Refuel(car.Id.ToString());

                if (car.Type == "ELECTRIC")
                {
                    electricCarCount++;
                    electricConsumption += car.Consumption;
                }
                else if (car.Type == "GAS")
                {
                    gasCarCount++;
                    gasConsumption += car.Consumption;
                }

                if (car.PassengerType == "PEOPLE")
                {
                    peopleCount++;
                }
                else if (car.PassengerType == "ROBOTS")
                {
                    robotsCount++;
                }

                if (car.IsDining)
                {
                    diningService.ServeDinner(car.Id.ToString());
                    diningCount++;
                }
                else
                {
                    notDiningCount++;
                }
            }
        }

        public void PrintStatistics()
{   Console.WriteLine($"STATION: {StationType}");
    Console.WriteLine($"CARS: {electricCarCount+gasCarCount}");
    Console.WriteLine($"DINING: {diningCount}");
    Console.WriteLine($"CONSUMPTION: {electricConsumption+gasConsumption}");
    Console.WriteLine($"------------------------------------------");
}


        public int CarCount => carQueue.Count;
    }
}
