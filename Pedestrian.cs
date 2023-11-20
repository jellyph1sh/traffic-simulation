namespace TrafficSimulation
{
    public class Pedestrian {
        public int id;
        public int spwan { get; set;}
        public int direction { get; set;}

        public Pedestrian(int id, int spwan, int direction){
            this.id = id;
            this.spwan = spwan;
            this.direction = direction;
        }

        public string ToCross(){
            return String.Format("The pedestrian {0} cross the street to footpath {1}.", this.id, this.direction);
        }
    }
}
