namespace TrafficSimulation.Entities
{
    public abstract class Entity {
        public int id;
        public int way;
        public int direction;

        public Entity(){
            this.id = 0;
            this.way = 1;
            this.direction = 1;
        }
        public Entity(int id, int way, int direction){
            this.id = id;
            this.way = way;
            this.direction = direction;
        }

        public virtual string ToStringInfos(){
            return String.Format("The entitie {0} take the {1} direction to move on the {2} way.", this.id, this.direction, this.way);
        }
    }
}