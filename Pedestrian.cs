namespace TrafficSimulation
{
    public class Pedestrian : Entitie, IEntitie 
    {
        public Pedestrian():base()
        {
            this.id = 0;
            this.way = 1;
            this.direction = 1;
        }
        public Pedestrian(int id, int way, int direction){
            this.id = id;
            this.way = way;
            this.direction = direction;
        }

        public int Direction
        {
            get { return direction; }
            set 
            { 
                direction = value;
                if (direction < 1)
                {
                    direction = 1;
                }
                else if (direction > 4)
                {
                    direction = 4;
                }
            }
        }
        public int Way
        {
            get { return way; }
            set 
            { 
                way = value;
                if (way < 1)
                {
                    way = 1;
                }
                else if (way > 4)
                {
                    way = 4;
                }
            }
        }


        public override string ToStringInfos(){
            return String.Format("The pedestrian {0} take the {1} footpath to move on the {2} way.", this.id, this.direction, this.way);
        }
    }
}
