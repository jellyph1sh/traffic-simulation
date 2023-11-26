using TrafficSimulation.Objects;

namespace TrafficSimulation.Road.Ways
{
    public class WayTrafficLight : Way
    {
        public TrafficLight trafficLight;
        public WayTrafficLight(int id) : base(id)
        {
            this.trafficLight = new TrafficLight(this.Id);
        }
    }
}