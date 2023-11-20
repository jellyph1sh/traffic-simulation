using System;
namespace TrafficSimulation
{
    public enum VehiculeType
    {
        Car,
        Truck,
        Bus,
        Motorcycle
    }
    interface IVehicule
    {
        int Direction { get; set; }
        int Way { get; set; }
        string ToStringInfos();
    }
    public class Vehicule : IVehicule
    {   
        public int id;
        public VehiculeType type = VehiculeType.Car;
        public int way;
        public int direction;
        public Vehicule()
        {
            this.id = 0;
            this.type = VehiculeType.Car;
            this.way = 1;
            this.direction = 1;
        }
        public Vehicule(int id, VehiculeType type, int way, int direction)
        {
            this.id = id;
            this.type = type;
            this.way = way;
            this.direction = direction;
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
        public string ToStringInfos()
        {
            return String.Format("The {0} {1} takes the {2} exit and ends up on the {3} way", this.type, this.id, this.direction, this.way);
        }
    }
}