namespace TrafficSimulation.Entities
{
    public abstract class Entity {
        protected int _id = 0;
        protected int _way = 1;
        protected int _direction = 1;

        public Entity(int id, int way, int direction)
        {
            this._id = id;
            this._way = way;
            this._direction = direction;
        }

        public virtual string ToStringInfos()
        {
            return String.Format("The entity {0} take the {1} direction to move on the {2} way.", this._id, this._direction, this._way);
        }
    }
}