namespace TrafficSimulation.Entities.Vehicle
{
    public class Vehicle : Entity, IEntity
    {   
        public VehicleType type = VehicleType.Car;
        public Vehicle():base()
        {
            this.type = VehicleType.Car;
        }
        public Vehicle(int id, VehicleType type, int way, int direction)
        {
            this.id = id;
            this.type = type;
            this.way = way;
            this.direction = direction;
            Console.WriteLine(String.Format("{0}{1} arrives on way {2} and stops.", this.type, this.id, this.way));
        }
        public int Direction
        {
            get { return direction; }
            set 
            { 
                direction = value;
                if (direction < 1)
                {
                    direction = 1;
                }
                else if (direction > 4)
                {
                    direction = 4;
                }
            }
        }
        public int Way
        {
            get { return way; }
            set 
            { 
                way = value;
                if (way < 1)
                {
                    way = 1;
                }
                else if (way > 4)
                {
                    way = 4;
                }
            }
        }
        public override string ToStringInfos()
        {
            return String.Format("The {0}{1} on the way {2} moves forward into way {3} and exits the intersection.", this.type, this.id, this.way, this.direction);
        }
    }
}