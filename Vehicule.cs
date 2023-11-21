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
    public class Vehicule : Entitie, IEntitie
    {   
        public VehiculeType type = VehiculeType.Car;
        public Vehicule():base()
        {
            this.type = VehiculeType.Car;
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
        public override string ToStringInfos()
        {
            return String.Format("The {0} {1} takes the {2} exit and ends up on the {3} way", this.type, this.id, this.direction, this.way);
        }
    }
}