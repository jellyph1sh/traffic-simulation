using System.IO.Compression;
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

        private bool CheckIfWaysIsEmpty()
        {
            foreach (var way in this.Ways)
            {
                if (!way.IsEmpty) return false;
            }
            return true;
        }

        private bool HaveWayEmpty()
        {
            foreach (var way in this.Ways)
            {
                if (way.VehiclesQueue.Count == 0) return true;
            }
            return false;
        }

        public void EmptyVehicleQueue(int wayId)
        {
            Vehicle veh = this.Ways[wayId - 1].VehiclesQueue.ElementAt(0);
            Console.WriteLine(veh.ToStringInfos());
            this.RemoveVehicleInQueue(wayId);
        }

        public void AddVehicleInQueue(Vehicle veh)
        {
            Way way = this.Ways[veh.Way-1];
            way.VehiclesQueue.Add(veh);
            if (way.VehiclesQueue.Count > 0)
            {
                way.IsEmpty = false;
            }
        }

        public void RemoveVehicleInQueue(int wayId)
        {
            Way way = this.Ways[wayId-1];
            way.VehiclesQueue.RemoveAt(0);
            if (way.VehiclesQueue.Count == 0)
            {
                way.IsEmpty = true;
            }
        }

        public virtual void Run()
        {
            // Generate vehicles
            this._traffic.GenerateRandomVehicles();
            Thread.Sleep(1000);
            Console.WriteLine("");

            while (!_traffic.Stop)
            {
                int way = 1;
                // Check all ways if is full to define priority
                if (!this.HaveWayEmpty())
                {
                    this.EmptyVehicleQueue(way);
                    Thread.Sleep(1000);
                }

                // Do left priority
                while (way <= 4)
                {
                    int checkWay = way - 1;
                    if (way == 1)
                    {
                        checkWay = 4;
                    }
                    while (this.Ways[checkWay - 1].VehiclesQueue.Count == 0 && this.Ways[way - 1].VehiclesQueue.Count > 0)
                    {
                        this.EmptyVehicleQueue(way);
                        Thread.Sleep(1000);
                    }

                    way++;
                }

                // If situation ended ask user:
                if (CheckIfWaysIsEmpty())
                {
                    if (!this._traffic.StopMenu())
                    {
                        return;
                    }
                    Console.WriteLine("");

                    // Regenerate vehicles
                    this._traffic.GenerateRandomVehicles();
                    Thread.Sleep(1000);
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
        }
    }
}