namespace TrafficSimulation.Objects
{
    public class TrafficLight {
        public int wayId;
        public TrafficLightColor Color = TrafficLightColor.Red;
        
        public TrafficLight(int wayId)
        {
            this.wayId = wayId;
        }

        public void SetNextTrafficLightColor()
        {
            switch(this.Color){
                case TrafficLightColor.Green:
                    this.Color = TrafficLightColor.Orange;
                    break;
                case TrafficLightColor.Orange:
                    this.Color = TrafficLightColor.Red;
                    break;
                case TrafficLightColor.Red:
                    this.Color = TrafficLightColor.Green;
                    break;
                default:
                    this.Color = TrafficLightColor.None;
                    break;
            }
            Console.WriteLine(String.Format("Trafficlight way {0}, turn on {1}.", this.wayId, this.Color));
        }
    }
}
