using TrafficSimulation.Entities.Vehicle;

namespace TrafficSimulation.Road.Ways
{
    public class Way
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
        public bool IsEmpty = true;
        public List<Vehicle> vehiclesQueue;

        public Way(int id)
        {
            this._id = id;
            this.vehiclesQueue = new List<Vehicle>();
        }
    }
}