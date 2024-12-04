[TestClass]
public class SemaphoreTests
{
    private class MockDineable : IDineable
    {
        public List<string> ServedDinners = new List<string>();

        public void ServeDinner(string carId)
        {
            ServedDinners.Add(carId);
        }
    }

    private class MockRefuelable : IRefuelable
    {
        public List<string> RefueledCars = new List<string>();

        public void Refuel(string carId)
        {
            RefueledCars.Add(carId);
        }
    }

    [TestMethod]
    public void TestGasCarServedByGasStation()
    {
        var mockDining = new MockDineable();
        var mockElectricStation = new MockRefuelable();
        var mockGasStation = new MockRefuelable();

        var electricCarStation = new CarStation(mockDining, mockElectricStation);
        var gasCarStation = new CarStation(mockDining, mockGasStation);

        var semaphore = new Semaphore(electricCarStation, gasCarStation);

        var gasCar = new Car
        {
            Id = "1",
            Type = "GAS",
            Passengers = "PEOPLE",
            IsDining = false
        };

        semaphore.RouteCar(gasCar);
        semaphore.ServeCars();

        Assert.AreEqual(1, mockGasStation.RefueledCars.Count);
        Assert.AreEqual("1", mockGasStation.RefueledCars[0]);
        Assert.AreEqual(0, mockElectricStation.RefueledCars.Count);
    }

    [TestMethod]
    public void TestElectricCarServedByElectricStation()
    {
        var mockDining = new MockDineable();
        var mockElectricStation = new MockRefuelable();
        var mockGasStation = new MockRefuelable();

        var electricCarStation = new CarStation(mockDining, mockElectricStation);
        var gasCarStation = new CarStation(mockDining, mockGasStation);

        var semaphore = new Semaphore(electricCarStation, gasCarStation);

        var electricCar = new Car
        {
            Id = "2",
            Type = "ELECTRIC",
            Passengers = "PEOPLE",
            IsDining = false
        };

        semaphore.RouteCar(electricCar);
        semaphore.ServeCars();

        Assert.AreEqual(1, mockElectricStation.RefueledCars.Count);
        Assert.AreEqual("2", mockElectricStation.RefueledCars[0]);
        Assert.AreEqual(0, mockGasStation.RefueledCars.Count);
    }

    [TestMethod]
    public void TestDiningCarServedCorrectly()
    {
        var mockDining = new MockDineable();
        var mockElectricStation = new MockRefuelable();
        var mockGasStation = new MockRefuelable();

        var electricCarStation = new CarStation(mockDining, mockElectricStation);
        var gasCarStation = new CarStation(mockDining, mockGasStation);

        var semaphore = new Semaphore(electricCarStation, gasCarStation);

        var electricCarWithDining = new Car
        {
            Id = "3",
            Type = "ELECTRIC",
            Passengers = "PEOPLE",
            IsDining = true
        };

        semaphore.RouteCar(electricCarWithDining);
        semaphore.ServeCars();

        Assert.AreEqual(1, mockDining.ServedDinners.Count);
        Assert.AreEqual("3", mockDining.ServedDinners[0]);
    }
}
