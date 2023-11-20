using System;
using System.Numerics;

namespace TrafficSimulation
{
    public class Pedestrian {
        public string name;
        public Vector2 position;

        public Pedestrian(string name, Vector2 position){
            this.name = name;
            this.position = position;
        }

        public void CrossStreet(Vector2 nextPosition){
            this.position = nextPosition;
        }
    }
}
