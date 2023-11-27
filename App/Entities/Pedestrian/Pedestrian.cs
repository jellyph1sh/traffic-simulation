namespace TrafficSimulation.Entities.Pedestrian
{
    public class Pedestrian : Entity, IEntity 
    {
        public Pedestrian(int id, int way, int direction) : base(id, way, direction) {}

        public int Id
        {
            get { return this._id; }
            set
            {
                if (value < 0) return;
                _id = value;
            }
        }

        public int Way
        {
            get { return _way; }
            set
            {
                if (value < 1 || value > 4) return;
                _way = value;
            }
        }

        public int Direction
        {
            get { return _direction; }
            set
            {
                if (value < 1 || value > 4) return;
                _direction = value;
            }
        }

        public override string ToStringInfos()
        {
            return String.Format("The pedestrian {0} take the {1} footpath to move on the {2} way and exit the intersection.", this._id, this._direction, this._way);
        }
    }
}
