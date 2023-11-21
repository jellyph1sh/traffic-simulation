namespace TrafficSimulation
{   
    interface IEntitie
    {
        int Direction { get; set; }
        int Way { get; set; }
        string ToStringInfos();
    }
    public abstract class Entitie {
        public int id;
        public int way;
        public int direction;

        public Entitie(){
            this.id = 0;
            this.way = 1;
            this.direction = 1;
        }
        public Entitie(int id, int way, int direction){
            this.id = id;
            this.way = way;
            this.direction = direction;
        }

        public virtual string ToStringInfos(){
            return String.Format("The entitie {0} take the {1} direction to move on the {2} way.", this.id, this.direction, this.way);
        }
    }
}