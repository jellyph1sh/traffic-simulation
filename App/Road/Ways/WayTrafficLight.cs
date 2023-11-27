using TrafficSimulation.Objects;

namespace TrafficSimulation.Road.Ways
{
    public class WayTrafficLight : Way
    {
        private TrafficLight _trafficlight;
        public WayTrafficLight(int id) : base(id)
        {
            this._trafficlight = new TrafficLight(this._id);
        }

        public TrafficLight Trafficlight
        {
            get { return _trafficlight; }
        }
    }
}