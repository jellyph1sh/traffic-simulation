using TrafficSimulation.Entities.Vehicle;

namespace TrafficSimulation.Road.Ways
{
    public abstract class Way
    {
        private int _id = 0;
        public int Id
        {
            get
            {
                return _id; 
            }
            set
            {
                _id = value;
            }
        }
        public Vehicle[] vehiclesQueue;

        public Way(int id, Vehicle[] vehiclesQueue)
        {
            this._id = id;
            this.vehiclesQueue = vehiclesQueue;
        }
    }
}