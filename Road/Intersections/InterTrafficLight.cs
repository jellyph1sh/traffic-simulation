using TrafficSimulation.Road.Ways;

namespace TrafficSimulation.Road.Intersections
{
    public class InterTrafficLight
    {
        Way[] ways;
        Footpath[] footpaths;
        public InterTrafficLight()
        {
            this.ways = new Way[]{};
            this.footpaths = new Footpath[]{};

            
        }
    }
}