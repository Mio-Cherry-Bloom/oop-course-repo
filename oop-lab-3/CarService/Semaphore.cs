using System.Text.Json;

namespace CarService
{
    public class Semaphore
    {
        private CarStation electricPeopleStation;
        private CarStation electricRobotStation;
        private CarStation gasPeopleStation;
        private CarStation gasRobotStation;

        public Semaphore(
            CarStation electricPeopleStation,
            CarStation electricRobotStation,
            CarStation gasPeopleStation,
            CarStation gasRobotStation)
        {
            this.electricPeopleStation = electricPeopleStation;
            this.electricRobotStation = electricRobotStation;
            this.gasPeopleStation = gasPeopleStation;
            this.gasRobotStation = gasRobotStation;
        }

        public void GuideCar(string carJson)
        {
            var car = JsonSerializer.Deserialize<Car>(carJson);

            if (car == null)
                throw new ArgumentException("Invalid car JSON data.");

            if (car.Type == "ELECTRIC" && car.PassengerType == "PEOPLE")
            {
                electricPeopleStation.AddCar(car);
            }
            else if (car.Type == "ELECTRIC" && car.PassengerType == "ROBOTS")
            {
                electricRobotStation.AddCar(car);
            }
            else if (car.Type == "GAS" && car.PassengerType == "PEOPLE")
            {
                gasPeopleStation.AddCar(car);
            }
            else if (car.Type == "GAS" && car.PassengerType == "ROBOTS")
            {
                gasRobotStation.AddCar(car);
            }
            else
            {
                throw new InvalidOperationException("Unsupported car type or passenger type.");
            }
        }

        public void ServeAllStations()
        {
            electricPeopleStation.ServeCars();
            electricRobotStation.ServeCars();
            gasPeopleStation.ServeCars();
            gasRobotStation.ServeCars();
        }
    }
}
