namespace TrafficSimulation {

    public enum TrafficLightColor {
        None,
        Green,
        Orange,
        Red
    }

    public class TrafficLight {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor){
            switch(currentColor){
                case TrafficLightColor.Green:
                    return TrafficLightColor.Orange;
                case TrafficLightColor.Orange:
                    return TrafficLightColor.Red;
                case TrafficLightColor.Red:
                    return TrafficLightColor.Green;
                default:
                    return TrafficLightColor.None;
            }
        }
    }
}
