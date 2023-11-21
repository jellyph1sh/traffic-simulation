namespace TrafficSimulation.Run
{
    class Program
    {
        static Traffic traffic;
        static void Main(string[] str)
        {
            int intersection = SelectIntersectionMenu();
            traffic = new Traffic(intersection);
        }

        private static int SelectIntersectionMenu()
        {
            int intersectionNb = 0;
            do
            {
                Console.Write("Which intersection you want ? (1: TrafficLight / 2: GiveAway) >> ");
                string line = Console.ReadLine() ?? "";
                try
                {
                    intersectionNb = Int32.Parse(line);
                    if (intersectionNb < 1 || intersectionNb > 2)
                    {
                        intersectionNb = 0;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Invalid answer!");
                }
            } while (intersectionNb == 0);

            return intersectionNb;
        }
    }
}
