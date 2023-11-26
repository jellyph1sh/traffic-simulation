using TrafficSimulation.Entities.Vehicle;
using TrafficSimulation.Objects;
using TrafficSimulation.Road.Ways;

namespace TrafficSimulation.Road.Intersections
{
    public class InterTrafficLight : Intersection
    {
        public InterTrafficLight(Traffic traffic) : base(traffic)
        {
            this.Ways = new Way[]{new WayTrafficLight(1), new WayTrafficLight(2), new WayTrafficLight(3), new WayTrafficLight(4)};
        }

        public override void Run()
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

        public void TrafficLightsNextCycle(int[] trafficlights, int time)
        {
            for (int i = 0; i < trafficlights.Length; i++)
            {
                Way way = this.Ways[trafficlights[i]];
                TrafficLight tf = ((WayTrafficLight)way).trafficLight;
                tf.SetNextTrafficLightColor();
                Thread.Sleep(250);
                int pass = 0;
                while (tf.Color == TrafficLightColor.Green && way.vehiclesQueue.Count > 0 && pass <= 2)
                {
                    Vehicle veh = way.vehiclesQueue.ElementAt(0);
                    Console.WriteLine(veh.ToStringInfos());
                    this.RemoveVehicleInQueue(trafficlights[i] + 1);
                    pass++;
                }
            }
            Thread.Sleep(time);
            Console.WriteLine("");
        }
    }
}