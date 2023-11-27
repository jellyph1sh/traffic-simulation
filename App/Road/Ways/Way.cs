using TrafficSimulation.Entities.Vehicle;

namespace TrafficSimulation.Road.Ways
{
    public class Way
    {
        protected int _id = 0;
        private bool _isEmpty = true;
        public List<Vehicle> VehiclesQueue;
        public Way(int id)
        {
            this._id = id;
            this.VehiclesQueue = new List<Vehicle>();
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool IsEmpty
        {
            get { return _isEmpty; }
            set { _isEmpty = value; }
        }
    }
}