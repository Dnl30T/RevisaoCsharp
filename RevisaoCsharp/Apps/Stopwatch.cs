using RevisaoCsharp;

namespace RevisaoCsharp.Apps
{
    internal class Stopwatch
    {

        public Stopwatch()
        {
        }
        public static void Menu()
        {
            string?[] userLog = new string[3];
            string? answer;
            Console.Clear();
            Console.WriteLine("Enter the time range to start the stopwatch or 0 to exit:");
            try
            {
                //Hour
                Console.WriteLine("Minutes: ");
                answer = Console.ReadLine();
                userLog[0] = answer;
                float time = float.Parse(answer ?? "10") * 3600;
                //Minute
                Console.WriteLine("Seconds:");
                answer = Console.ReadLine();
                userLog[1] = answer;
                time += float.Parse(answer ?? "10") * 60;
                //Second
                Console.WriteLine("Miliseconds: ");
                answer = Console.ReadLine();
                userLog[2] = answer;
                time += float.Parse(answer ?? "10");
                if (time == 0)
                    Environment.Exit(0);
                new Stopwatch().StartRegressive(time);
            }
            catch (Exception)
            {
                Tools.NonFloatInputError("Reading error, check if you input valid numbers", userLog);
                Menu();
            }
        }
        protected void StartRegressive(float time)
        {
            float targetTime = 0;
            while (time > targetTime)
            {
                Console.Clear();
                Console.Write($"{TimeSpan.FromSeconds(time)} ");
                time -= 1f;
                Thread.Sleep(1);
            }
            Console.Clear();
            Console.WriteLine("0" + "\nTime is over");
            Thread.Sleep(2000);
            Menu();
        }

    }
}
