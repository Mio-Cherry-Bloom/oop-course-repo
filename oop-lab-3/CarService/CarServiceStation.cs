public class CarServiceStation
{
    private IDineable dineService;
    private IRefuelable fuelService;

    private int electricCarsServed = 0;
    private int gasCarsServed = 0;
    private int peopleServed = 0;
    private int robotsServed = 0;

    public CarServiceStation(IDineable dineService, IRefuelable fuelService)
    {
        this.dineService = dineService;
        this.fuelService = fuelService;
    }

    public void ServeCar(string carId, string carType, string passengerType, bool isDining)
    {
        if (carType == "ELECTRIC")
        {
            electricCarsServed++;
            fuelService.Refuel(carId);
        }
        else if (carType == "GAS")
        {
            gasCarsServed++;
            fuelService.Refuel(carId);
        }

        if (isDining)
        {
            if (passengerType == "PEOPLE")
            {
                peopleServed++;
                dineService.ServeDinner(carId);
            }
            else if (passengerType == "ROBOTS")
            {
                robotsServed++;
                dineService.ServeDinner(carId);
            }
        }

        PrintStatistics();
    }

    private void PrintStatistics()
    {
        Console.WriteLine($"Electric cars served: {electricCarsServed}");
        Console.WriteLine($"Gas cars served: {gasCarsServed}");
        Console.WriteLine($"People served: {peopleServed}");
        Console.WriteLine($"Robots served: {robotsServed}");
    }

    public int GetElectricCarsServed() => electricCarsServed;
    public int GetGasCarsServed() => gasCarsServed;
    public int GetPeopleServed() => peopleServed;
    public int GetRobotsServed() => robotsServed;
}
