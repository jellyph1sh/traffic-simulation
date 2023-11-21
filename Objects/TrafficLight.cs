namespace TrafficSimulation.Objects
{
    public class TrafficLight {
        public TrafficLightColor Color = TrafficLightColor.Red;
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
        }
    }
}
