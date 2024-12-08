using System.Text.Json;


namespace CarService
{
    class Program
    {
        private static Semaphore semaphore;
        private static bool running = true;

        static async Task Main(string[] args)
        {
            var electricPeopleStation = new CarStation(
                new PeopleDinner(),
                new ElectricStation(),
                new ArrayCarQueue(),
                "Electric + People"
            );

            var electricRobotStation = new CarStation(
                new RobotDinner(),
                new ElectricStation(),
                new ListCarQueue(),
                "Electric + Robots"
            );

            var gasPeopleStation = new CarStation(
                new PeopleDinner(),
                new GasStation(),
                new LinkedListCarQueue(),
                "Gas + People"
            );

            var gasRobotStation = new CarStation(
                new RobotDinner(),
                new GasStation(),
                new ArrayCarQueue(),
                "Gas + Robots"
            );

            semaphore = new Semaphore(
                electricPeopleStation,
                electricRobotStation,
                gasPeopleStation,
                gasRobotStation
            );

            Task readTask = ReadCarsFromQueueFolderPeriodically();
            Task serveTask = ServeCarsPeriodically();

            Console.WriteLine("Press Enter to stop the program...");
            Console.ReadLine();

            running = false;

            await Task.WhenAll(readTask, serveTask);
            electricPeopleStation.PrintStatistics();
            electricRobotStation.PrintStatistics();
            gasPeopleStation.PrintStatistics();
            gasRobotStation.PrintStatistics();

int totalGasConsumption= gasPeopleStation.gasConsumption+ gasRobotStation.gasConsumption;
int totalElectricConsumption=electricPeopleStation.electricConsumption + electricRobotStation.electricConsumption;
int totalDining= electricPeopleStation.diningCount + electricRobotStation.diningCount+ gasPeopleStation.diningCount+ gasRobotStation.diningCount;
int totalNotDining= electricPeopleStation.notDiningCount + electricRobotStation.notDiningCount+ gasPeopleStation.notDiningCount+ gasRobotStation.notDiningCount;
int totalCars= electricPeopleStation.electricCarCount + electricRobotStation.electricCarCount+ gasPeopleStation.gasCarCount+ gasRobotStation.gasCarCount;
int totalPeople= electricPeopleStation.peopleCount + electricRobotStation.peopleCount+ gasPeopleStation.peopleCount+ gasRobotStation.peopleCount;
int totalRobots= electricPeopleStation.robotsCount + electricRobotStation.robotsCount+ gasPeopleStation.robotsCount+ gasRobotStation.robotsCount;
             Console.WriteLine($"\nGeneral Stats:");
    Console.WriteLine($"CARS: {totalCars}");
    Console.WriteLine($"PEOPLE: {totalPeople}");
    Console.WriteLine($"ROBOTS: {totalRobots}");
    Console.WriteLine($"DINING: {totalDining}");
    Console.WriteLine($"NOT DINING: {totalNotDining}");
    Console.WriteLine($"ELECTRIC CONSUMPTION: {totalElectricConsumption}");
    Console.WriteLine($"GAS CONSUMPTION: {totalGasConsumption}");
    
        }

        private static int lastProcessedCarId = 0;

        private static async Task ReadCarsFromQueueFolderPeriodically()
        {
            string queueFolder = Path.Combine(Directory.GetCurrentDirectory(), @"..\queue");
            if (!Directory.Exists(queueFolder))
            {
                Console.WriteLine($"Folder '{queueFolder}' does not exist.");
                return;
            }
            while (running)
            {
                var carFiles = Directory.GetFiles(queueFolder, "*.json");

                foreach (var carFile in carFiles)
                {
                    try
                    {
                        string json = File.ReadAllText(carFile);
                        var car = JsonSerializer.Deserialize<Car>(json);

                        if (car != null)
                        {
                            semaphore.GuideCar(json);
                        }

                        File.Delete(carFile);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error processing file {carFile}: {ex.Message}");
                    }
                }

                await Task.Delay(2000);
            }
        }

        private static async Task ServeCarsPeriodically()
        {
            while (running)
            {
                semaphore.ServeAllStations();
                await Task.Delay(2000);
            }
        }
    }
}
