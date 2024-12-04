[TestClass]
public class CarStationTests
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
    public void TestSingleCar()
    {
        var mockDining = new MockDineable();
        var mockRefueling = new MockRefuelable();
        var carStation = new CarStation(mockDining, mockRefueling);

        var car = new Car
        {
            Id = "1",
            Type = "ELECTRIC",
            Passengers = "PEOPLE",
            IsDining = true
        };

        carStation.AddCar(car);
        carStation.ServeCars();

        Assert.AreEqual(1, mockRefueling.RefueledCars.Count);
        Assert.AreEqual("1", mockRefueling.RefueledCars[0]);
        Assert.AreEqual(1, mockDining.ServedDinners.Count);
        Assert.AreEqual("1", mockDining.ServedDinners[0]);
    }

    [TestMethod]
    public void TestMultipleCars()
    {
        var mockDining = new MockDineable();
        var mockRefueling = new MockRefuelable();
        var carStation = new CarStation(mockDining, mockRefueling);

        var car1 = new Car
        {
            Id = "1",
            Type = "GAS",
            Passengers = "ROBOTS",
            IsDining = true
        };

        var car2 = new Car
        {
            Id = "2",
            Type = "ELECTRIC",
            Passengers = "PEOPLE",
            IsDining = false
        };

        carStation.AddCar(car1);
        carStation.AddCar(car2);
        carStation.ServeCars();

        Assert.AreEqual(2, mockRefueling.RefueledCars.Count);
        CollectionAssert.AreEqual(new List<string> { "1", "2" }, mockRefueling.RefueledCars);
        Assert.AreEqual(1, mockDining.ServedDinners.Count);
        Assert.AreEqual("1", mockDining.ServedDinners[0]);
    }

    [TestMethod]
    public void TestNoDiningCars()
    {
        var mockDining = new MockDineable();
        var mockRefueling = new MockRefuelable();
        var carStation = new CarStation(mockDining, mockRefueling);

        var car1 = new Car
        {
            Id = "1",
            Type = "GAS",
            Passengers = "ROBOTS",
            IsDining = false
        };

        var car2 = new Car
        {
            Id = "2",
            Type = "ELECTRIC",
            Passengers = "PEOPLE",
            IsDining = false
        };

        carStation.AddCar(car1);
        carStation.AddCar(car2);
        carStation.ServeCars();

        Assert.AreEqual(2, mockRefueling.RefueledCars.Count);
        CollectionAssert.AreEqual(new List<string> { "1", "2" }, mockRefueling.RefueledCars);
        Assert.AreEqual(0, mockDining.ServedDinners.Count);
    }
}
