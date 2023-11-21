using TrafficSimulation.Objects;
using TrafficSimulation.Entities.Vehicle;

namespace TrafficSimulation.Road.Ways
{
    public class WayTrafficLight : Way
    {
        public TrafficLight TrafficLight = new TrafficLight();
        public WayTrafficLight(int id, Vehicle[] vehiclesQueue) : base(id, vehiclesQueue) {}
    }
}