using TrafficSimulation.Entities.Vehicle;
using TrafficSimulation.Road.Intersections;
using TrafficSimulation.Run;

namespace TrafficSimulation
{
    public class Traffic
    {
        private Intersection _intersection;
        private bool _stop = false;
        private int _idCar = 0;
        private int _idTruck = 0;
        private int _idBus = 0;
        private int _idMotorcycle = 0;

        public Traffic(int intersection)
        {
            switch (intersection)
            {
                case 1:
                    this._intersection = new InterTrafficLight(this);
                    break;
                case 2:
                    this._intersection = new Intersection(this);
                    break;
                default:
                    this._intersection = new Intersection(this);
                    break;
            }
            this._intersection.Run();
        }

        public bool Stop
        {
            get { return _stop; }
            set { _stop = value; }
        }

        public int IdCar
        {
            get { return _idCar; }
            set
            {
                if (value < 0) return;
                _idCar = value;
            }
        }

        public int IdTruck
        {
            get { return _idTruck; }
            set
            {
                if (value < 0) return;
                _idTruck = value;
            }
        }

        public int IdBus
        {
            get { return _idBus; }
            set
            {
                if (value < 0) return;
                _idBus = value;
            }
        }

        public int IdMotorcycle
        {
            get { return _idMotorcycle; }
            set
            {
                if (value < 0) return;
                _idMotorcycle = value;
            }
        }

        public bool StopMenu()
        {
            Console.Write("Do you want to continue ? (y/N) >> ");
            string line = Console.ReadLine() ?? "";
            if (line == "" || line == "n" || line == "N")
            {
                Console.Clear();
                int intersection = Program.SelectIntersectionMenu();
                Traffic traffic = new Traffic(intersection);
                this._intersection.Run();
                this._stop = true;
                return false;
            }
            else if (line == "y" || line == "Y")
            {
                Console.Clear();
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
            int nbVehicles = rnd.Next(1, 11);
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
                        _idTruck++;
                        id = _idTruck;
                        break;
                    case VehicleType.Bus:
                        _idBus++;
                        id = _idBus;
                        break;
                    case VehicleType.Motorcycle:
                        _idMotorcycle++;
                        id = _idMotorcycle;
                        break;
                    default:
                        _idCar++;
                        id = _idCar;
                        break;
                }
                this._intersection.AddVehicleInQueue(new Vehicle(id, type, way, direction));
                Thread.Sleep(250);
            }
        }
    }
}