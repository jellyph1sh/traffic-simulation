namespace TrafficSimulation
{
    public class Crossroads
    {
        Way[] ways;
        Footpath[] footpaths;
        public Crossroads()
        {
            this.ways = new Way[0];
            this.footpaths = new Footpath[0];
        }

        public Crossroads(Way[] ways, Footpath[] footpaths)
        {
            this.ways = ways;
            this.footpaths = footpaths;
        }
    }

    public class Way
    {
        int id;
        TrafficLight trafficLight;
        Vehicule[] vehicules;
        public Way()
        {
            this.id = 0;
            this.trafficLight = new TrafficLight();
            this.vehicules = new Vehicule[0];
        }

        public Way(int id, TrafficLight trafficLight, Vehicule[] vehicules)
        {
            this.id = id;
            this.trafficLight = trafficLight;
            this.vehicules = vehicules;
        }
    }

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