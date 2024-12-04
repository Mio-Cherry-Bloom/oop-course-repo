namespace CarServiceTests
{
    [TestClass]
    public class CarServiceStationTests
    {
        [TestMethod]
        public void TestElectricCarServed()
        {
            IDineable dineService = new PeopleDinner();
            IRefuelable fuelService = new ElectricStation();
            var station = new CarServiceStation(dineService, fuelService);

            station.ServeCar("1", "ELECTRIC", "PEOPLE", true);

            Assert.AreEqual(1, station.GetElectricCarsServed());
            Assert.AreEqual(0, station.GetGasCarsServed());
            Assert.AreEqual(1, station.GetPeopleServed());
            Assert.AreEqual(0, station.GetRobotsServed());
        }

        [TestMethod]
        public void TestGasCarServed()
        {
            IDineable dineService = new RobotDinner();
            IRefuelable fuelService = new GasStation();
            var station = new CarServiceStation(dineService, fuelService);

            station.ServeCar("2", "GAS", "ROBOTS", true);

            Assert.AreEqual(0, station.GetElectricCarsServed());
            Assert.AreEqual(1, station.GetGasCarsServed());
            Assert.AreEqual(0, station.GetPeopleServed());
            Assert.AreEqual(1, station.GetRobotsServed());
        }

        [TestMethod]
        public void TestNoDining()
        {
            IDineable dineService = new PeopleDinner();
            IRefuelable fuelService = new ElectricStation();
            var station = new CarServiceStation(dineService, fuelService);

            station.ServeCar("3", "ELECTRIC", "PEOPLE", false);

            Assert.AreEqual(1, station.GetElectricCarsServed());
            Assert.AreEqual(0, station.GetGasCarsServed());
            Assert.AreEqual(0, station.GetPeopleServed());
            Assert.AreEqual(0, station.GetRobotsServed());
        }

        [TestMethod]
        public void TestMixedService()
        {
            IDineable dineService = new RobotDinner();
            IRefuelable fuelService = new GasStation();
            var station = new CarServiceStation(dineService, fuelService);

            station.ServeCar("4", "GAS", "ROBOTS", true);
            station.ServeCar("5", "ELECTRIC", "PEOPLE", true);
            station.ServeCar("6", "GAS", "PEOPLE", false);

            Assert.AreEqual(1, station.GetElectricCarsServed());
            Assert.AreEqual(2, station.GetGasCarsServed());
            Assert.AreEqual(1, station.GetPeopleServed());
            Assert.AreEqual(1, station.GetRobotsServed());
        }
    }
}
