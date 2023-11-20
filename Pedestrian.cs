using System;
using System.Numerics;

namespace TrafficSimulation
{
    public class Pedestrian {
        public string name;
        public int spwan;
        public int direction;

        public Pedestrian(string name, int spwan, int direction){
            this.name = name;
            this.spwan = spwan;
            this.direction = direction;
        }

        public void ToCross(){
            Console.WriteLine("{0} cross the street to footpath {1}.", this.name, this.direction);
        }
    }
}
