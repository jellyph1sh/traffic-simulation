namespace TrafficSimulation.Entities.Vehicle
{
    public class Vehicle : Entity, IEntity
    {   
        private VehicleType _type = VehicleType.Car;
        public VehicleType Type
        {
            get { return _type; }
        }
        
        public Vehicle(int id, VehicleType type, int way, int direction) : base(id, way, direction)
        {
            this._type = type;
            Console.WriteLine(String.Format("{0}{1} arrives on way {2} and stops.", this._type, this._id, this._way));
        }

        public int Id
        {
            get { return this._id; }
            set
            {
                if (value < 0) return;
                _id = value;
            }
        }

        public int Way
        {
            get { return _way; }
            set
            {
                if (value < 1 || value > 4) return;
                _way = value;
            }
        }

        public int Direction
        {
            get { return _direction; }
            set
            {
                if (value < 1 || value > 4) return;
                _direction = value;
            }
        }

        public override string ToStringInfos()
        {
            return String.Format("The {0}{1} on the way {2} moves forward into way {3} and exits the intersection.", this._type, this._id, this._way, this._direction);
        }
    }
}