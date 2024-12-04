public class CarStation
{
    private IDineable diningService;
    private IRefuelable refuelingService;
    private Queue<Car> queue;

    public CarStation(IDineable diningService, IRefuelable refuelingService)
    {
        this.diningService = diningService;
        this.refuelingService = refuelingService;
        this.queue = new Queue<Car>();
    }

    public void AddCar(Car car)
    {
        queue.Enqueue(car);
    }

    public void ServeCars()
    {
        while (queue.Count > 0)
        {
            var car = queue.Dequeue();
            if (car.Type == "ELECTRIC" || car.Type == "GAS")
            {
                refuelingService.Refuel(car.Id);
            }

            if (car.IsDining)
            {
                if (car.Passengers == "PEOPLE" || car.Passengers == "ROBOTS")
                {
                    diningService.ServeDinner(car.Id);
                }
            }
        }

        Console.WriteLine("All cars have been served.");
    }
}