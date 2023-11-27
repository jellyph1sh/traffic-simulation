namespace TrafficSimulation.Run
{
    class Program
    {
        private static Traffic? traffic;
        static void Main(string[] str)
        {
            int intersection = SelectIntersectionMenu();
            Program.traffic = new Traffic(intersection);
        }

        public static int SelectIntersectionMenu()
        {
            int intersectionNb = 0;
            do
            {
                Console.Write("Which intersection you want ? (1: TrafficLight / 2: GiveAway / 3: Exit) >> ");
                string line = Console.ReadLine() ?? "";
                try
                {
                    intersectionNb = Int32.Parse(line);
                    if (intersectionNb == 3)
                    {
                        Console.Clear();
                        System.Environment.Exit(0);
                    }
                    else if (intersectionNb < 1 || intersectionNb > 2)
                    {
                        intersectionNb = 0;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid answer!");
                }
            } while (intersectionNb == 0);

            Console.Clear();
            return intersectionNb;
        }
    }
}
