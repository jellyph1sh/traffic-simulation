using TrafficSimulation.Entities.Pedestrian;

namespace TrafficSimulation
{
    public class Footpath
    {
        private int _id = 0;
        public List<Pedestrian> Pedestrians;

        public Footpath(int id)
        {
            this._id = id;
            this.Pedestrians = new List<Pedestrian>();
        }

        public int Id
        {
            get { return _id; }
        }
    }
}