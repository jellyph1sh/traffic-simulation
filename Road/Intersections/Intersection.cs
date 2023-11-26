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

        public void Run()
        {
            int[] green = new int[]{0, 2};
            int[] red = new int[]{1, 3};
            int[] temp = new int[]{};
            Console.WriteLine("All trafficlights is red!\n");
            this._traffic.GenerateRandomVehicles();
            Console.WriteLine("");
            int cycle = 0;
            while (!_traffic.stop)
            {
                cycle++;
                // 2 ways turn green
                TrafficLightsNextCycle(green, 5000);
                // 2 ways turn orange
                TrafficLightsNextCycle(green, 1000);
                // 2 ways turn red
                TrafficLightsNextCycle(green, 0);

                temp = red;
                red = green;
                green = temp;
                if (cycle == 2)
                {
                    if (!this._traffic.StopMenu())
                    {
                        return;
                    }
                    this._traffic.GenerateRandomVehicles();
                    Console.WriteLine("");
                    cycle = 0;
                }
            }
        }

        public void AddVehicleInQueue(Vehicle veh)
        {
            this.Ways[veh.Way-1].vehiclesQueue.Add(veh);
        }

        public void RemoveVehicleInQueue(int wayId)
        {
            this.Ways[wayId].vehiclesQueue.RemoveAt(0);
        }
    }
}