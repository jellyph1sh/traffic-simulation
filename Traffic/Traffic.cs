using TrafficSimulation.Entities.Vehicle;
using TrafficSimulation.Road.Intersections;
using TrafficSimulation.Run;

namespace TrafficSimulation
{
    public class Traffic
    {
        Intersection intersection;
        public bool stop = false;

        int idCar = 0;
        int idTruck = 0;
        int idBus = 0;
        int idMotorcycle = 0;
        public Traffic(int intersection)
        {
            if (intersection == 1)
            {
                this.intersection = new InterTrafficLight(this);
            }
            else if (intersection == 2)
            {
                this.intersection = new Intersection(this);
            }
        }

        public bool StopMenu()
        {
            Console.Write("Do you want to continue ? (y/N) >> ");
            string line = Console.ReadLine() ?? "";
            if (line == "" || line == "n" || line == "N")
            {
                int intersection = Program.SelectIntersectionMenu();
                Traffic traffic = new Traffic(intersection);
                this.intersection.Run();
                this.stop = true;
                return false;
            }
            else if (line == "y" || line == "Y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid answer!");
                this.StopMenu();
            }
            return false;
        }

        public void GenerateRandomVehicles()
        {
            Random rnd = new Random();
            int nbVehicles = rnd.Next(11);
            for (int i = 0; i < nbVehicles; i++)
            {
                int way = rnd.Next(1, 5);
                Array types = Enum.GetValues(typeof(VehicleType));
                VehicleType type = (VehicleType)types.GetValue(rnd.Next(types.Length));
                int direction = rnd.Next(1, 5);
                do
                {
                    direction = rnd.Next(1, 5);
                } while (direction == way);
                int id = 0;
                switch (type)
                {
                    case VehicleType.Truck:
                        idTruck++;
                        id = idTruck;
                        break;
                    case VehicleType.Bus:
                        idBus++;
                        id = idBus;
                        break;
                    case VehicleType.Motorcycle:
                        idMotorcycle++;
                        id = idMotorcycle;
                        break;
                    default:
                        idCar++;
                        id = idCar;
                        break;
                }
                this.intersection.AddVehicleInQueue(new Vehicle(id, type, way, direction));
            }
        }
    }
}