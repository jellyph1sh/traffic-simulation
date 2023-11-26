using TrafficSimulation.Entities.Vehicle;
using TrafficSimulation.Road.Ways;

namespace TrafficSimulation.Road.Intersections
{
    public class Intersection
    {
        protected Traffic _traffic;
        public Way[] Ways;
        public Intersection(Traffic traffic)
        {
            this._traffic = traffic;
            this.Ways = new Way[]{new Way(1), new Way(2), new Way(3), new Way(4)};
        }

        public virtual void Run()
        {
            this._traffic.GenerateRandomVehicles();
            Thread.Sleep(1000);
            Console.WriteLine("");
            while (!_traffic.stop)
            {
                if (!this.HaveWayEmpty())
                {
                    Vehicle veh = this.Ways[0].vehiclesQueue.ElementAt(0);
                    Console.WriteLine(veh.ToStringInfos());
                    this.RemoveVehicleInQueue(1);
                    this.Ways[0].IsEmpty = true;
                }
                int way = 1;
                while (way <= 4)
                {
                    int checkWay = way - 1;
                    if (way == 1)
                    {
                        checkWay = 4;
                    }
                    while (this.Ways[checkWay - 1].vehiclesQueue.Count == 0 && this.Ways[way - 1].vehiclesQueue.Count > 0)
                    {
                        Vehicle veh = this.Ways[way - 1].vehiclesQueue.ElementAt(0);
                        Console.WriteLine(veh.ToStringInfos());
                        this.RemoveVehicleInQueue(way);
                        Thread.Sleep(1000);
                    }

                    way++;
                }

                if (CheckIfWaysIsEmpty())
                {
                    if (!this._traffic.StopMenu())
                    {
                        return;
                    }
                    Console.WriteLine("");
                    this._traffic.GenerateRandomVehicles();
                    Thread.Sleep(1000);
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
        }

        public void AddVehicleInQueue(Vehicle veh)
        {
            Way way = this.Ways[veh.Way-1];
            way.vehiclesQueue.Add(veh);
            if (way.vehiclesQueue.Count > 0)
            {
                way.IsEmpty = false;
            }
        }

        public void RemoveVehicleInQueue(int wayId)
        {
            Way way = this.Ways[wayId-1];
            way.vehiclesQueue.RemoveAt(0);
            if (way.vehiclesQueue.Count == 0)
            {
                way.IsEmpty = true;
            }
        }

        public bool CheckIfWaysIsEmpty()
        {
            foreach (var way in this.Ways)
            {
                if (!way.IsEmpty) return false;
            }
            return true;
        }

        public bool HaveWayEmpty()
        {
            foreach (var way in this.Ways)
            {
                if (way.vehiclesQueue.Count == 0) return true;
            }
            return false;
        }
    }
}