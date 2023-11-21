using TrafficSimulation.Road.Ways;

namespace TrafficSimulation.Road.Intersections
{
    public class Intersection
    {
        Way[] ways;
        Footpath[] footpaths;
        public Intersection()
        {
            this.ways = new Way[0];
            this.footpaths = new Footpath[0];
        }

        public Intersection(Way[] ways, Footpath[] footpaths)
        {
            this.ways = ways;
            this.footpaths = footpaths;
        }
    }
}