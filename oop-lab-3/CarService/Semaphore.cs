public class Semaphore
{
    private readonly CarStation electricCarStation;
    private readonly CarStation gasCarStation;

    public Semaphore(CarStation electricCarStation, CarStation gasCarStation)
    {
        this.electricCarStation = electricCarStation;
        this.gasCarStation = gasCarStation;
    }

    public void RouteCar(Car car)
    {
        if (car.Type == "ELECTRIC")
        {
            electricCarStation.AddCar(car);
        }
        else if (car.Type == "GAS")
        {
            gasCarStation.AddCar(car);
        }
    }

    public void ServeCars()
    {
        electricCarStation.ServeCars();
        gasCarStation.ServeCars();
    }
}