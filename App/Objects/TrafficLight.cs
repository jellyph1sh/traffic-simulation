namespace TrafficSimulation.Objects
{
    public class TrafficLight {
        private int _wayId;
        private TrafficLightColor _color = TrafficLightColor.Red;
        
        public TrafficLight(int wayId)
        {
            this._wayId = wayId;
        }

        public int wayId
        {
            get { return _wayId; }
        }

        public TrafficLightColor Color
        {
            get { return _color; }
        }

        public void SetNextTrafficLightColor()
        {
            switch(this._color){
                case TrafficLightColor.Green:
                    this._color = TrafficLightColor.Orange;
                    break;
                case TrafficLightColor.Orange:
                    this._color = TrafficLightColor.Red;
                    break;
                case TrafficLightColor.Red:
                    this._color = TrafficLightColor.Green;
                    break;
                default:
                    this._color = TrafficLightColor.None;
                    break;
            }
            Console.WriteLine(String.Format("Trafficlight way {0}, turn on {1}.", this._wayId, this._color));
        }
    }
}
