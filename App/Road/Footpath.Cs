using TrafficSimulation.Entities.Pedestrian;

namespace TrafficSimulation
{
    public class Footpath
    {
        int id;
        Pedestrian[] pedestrians;
        public Footpath()
        {
            this.id = 0;
            this.pedestrians = new Pedestrian[0];
        }

        public Footpath(int id, Pedestrian[] pedestrians)
        {
            this.id = id;
            this.pedestrians = pedestrians;
        }
    }
}