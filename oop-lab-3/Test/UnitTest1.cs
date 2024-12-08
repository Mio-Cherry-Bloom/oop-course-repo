using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarService; 
using System.Text.Json;

namespace CarServiceTests
{
    [TestClass]
    public class CarServiceTests
    {
        private CarService.Semaphore semaphore; 
        private CarStation electricPeopleStation;
        private CarStation electricRobotStation;
        private CarStation gasPeopleStation;
        private CarStation gasRobotStation;

        [TestInitialize]
        public void Setup()
        {
            electricPeopleStation = new CarStation(
                new PeopleDinner(),
                new ElectricStation(),
                new ArrayCarQueue(),
                "Electric + People"
            );

            electricRobotStation = new CarStation(
                new RobotDinner(),
                new ElectricStation(),
                new ListCarQueue(),
                "Electric + Robots"
            );

            gasPeopleStation = new CarStation(
                new PeopleDinner(),
                new GasStation(),
                new LinkedListCarQueue(),
                "Gas + People"
            );

            gasRobotStation = new CarStation(
                new RobotDinner(),
                new GasStation(),
                new ArrayCarQueue(),
                "Gas + Robots"
            );

            semaphore = new CarService.Semaphore(
                electricPeopleStation,
                electricRobotStation,
                gasPeopleStation,
                gasRobotStation
            );
        }

        [TestMethod]
        public void TestCarDistributionToStations()
        {
            var electricPeopleCar = new Car(1, "ELECTRIC", "PEOPLE", true, 50);
            var electricRobotCar = new Car(2, "ELECTRIC", "ROBOTS", false, 60);
            var gasPeopleCar = new Car(3, "GAS", "PEOPLE", true, 70);
            var gasRobotCar = new Car(4, "GAS", "ROBOTS", false, 80);

            semaphore.GuideCar(JsonSerializer.Serialize(electricPeopleCar));
            semaphore.GuideCar(JsonSerializer.Serialize(electricRobotCar));
            semaphore.GuideCar(JsonSerializer.Serialize(gasPeopleCar));
            semaphore.GuideCar(JsonSerializer.Serialize(gasRobotCar));

            Assert.AreEqual(1, electricPeopleStation.CarCount);
            Assert.AreEqual(1, electricRobotStation.CarCount);
            Assert.AreEqual(1, gasPeopleStation.CarCount);
            Assert.AreEqual(1, gasRobotStation.CarCount);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestInvalidCarDistribution()
        {
            var invalidCar = new Car(5, "INVALID", "ROBOTS", false, 80);
            semaphore.GuideCar(JsonSerializer.Serialize(invalidCar));
        }

        [TestMethod]
        public void TestConsumptionTracking()
        {
            var electricCar = new Car(6, "ELECTRIC", "PEOPLE", false, 100);
            var gasCar = new Car(7, "GAS", "PEOPLE", false, 150);

            semaphore.GuideCar(JsonSerializer.Serialize(electricCar));
            semaphore.GuideCar(JsonSerializer.Serialize(gasCar));

            electricPeopleStation.ServeCars();
            gasPeopleStation.ServeCars();

            Assert.AreEqual(100, electricPeopleStation.electricConsumption);
            Assert.AreEqual(150, gasPeopleStation.gasConsumption);
        }

        [TestMethod]
        public void TestNoDiningCarDistribution()
        {
            var noDiningElectricCar = new Car(8, "ELECTRIC", "PEOPLE", false, 120);  
            var noDiningGasCar = new Car(9, "GAS", "PEOPLE", false, 130);  

            semaphore.GuideCar(JsonSerializer.Serialize(noDiningElectricCar));
            semaphore.GuideCar(JsonSerializer.Serialize(noDiningGasCar));

            electricPeopleStation.ServeCars();
            gasPeopleStation.ServeCars();

            Assert.AreEqual(120, electricPeopleStation.electricConsumption);
            Assert.AreEqual(130, gasPeopleStation.gasConsumption);
        }

        [TestMethod]
        public void TestCarCountAfterServing()
        {
            var car1 = new Car(10, "ELECTRIC", "PEOPLE", true, 50);
            var car2 = new Car(11, "GAS", "PEOPLE", true, 70);

            semaphore.GuideCar(JsonSerializer.Serialize(car1));
            semaphore.GuideCar(JsonSerializer.Serialize(car2));

            electricPeopleStation.ServeCars();
            gasPeopleStation.ServeCars();

            Assert.AreEqual(0, electricPeopleStation.CarCount);
            Assert.AreEqual(0, gasPeopleStation.CarCount);
        }

        [TestMethod]
        public void TestInvalidCarType()
        {
            var invalidTypeCar = new Car(12, "HYBRID", "PEOPLE", true, 50);  

            Assert.ThrowsException<InvalidOperationException>(() =>
                semaphore.GuideCar(JsonSerializer.Serialize(invalidTypeCar))
            );
        }

        [TestMethod]
        public void TestCorrectCarCountAcrossStations()
        {
            var electricPeopleCar = new Car(13, "ELECTRIC", "PEOPLE", true, 50);
            var electricRobotCar = new Car(14, "ELECTRIC", "ROBOTS", false, 60);
            var gasPeopleCar = new Car(15, "GAS", "PEOPLE", true, 70);
            var gasRobotCar = new Car(16, "GAS", "ROBOTS", false, 80);

            semaphore.GuideCar(JsonSerializer.Serialize(electricPeopleCar));
            semaphore.GuideCar(JsonSerializer.Serialize(electricRobotCar));
            semaphore.GuideCar(JsonSerializer.Serialize(gasPeopleCar));
            semaphore.GuideCar(JsonSerializer.Serialize(gasRobotCar));

            Assert.AreEqual(1, electricPeopleStation.CarCount);
            Assert.AreEqual(1, electricRobotStation.CarCount);
            Assert.AreEqual(1, gasPeopleStation.CarCount);
            Assert.AreEqual(1, gasRobotStation.CarCount);
        }
    }
}
