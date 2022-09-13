using System;

namespace myMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampleData = new SentimentModel.ModelInput();
            if (args.Length != 0)
            {
                sampleData.State = Single.Parse(args[0]);
                sampleData.Num_Infected = Single.Parse(args[1]);
                sampleData.Num_Infected_Nearby = Single.Parse(args[2]);
                sampleData.Times_Traveled = Single.Parse(args[3]);
                sampleData.Total_Spawn_Count = Single.Parse(args[4]);
            } else
            {
                Console.WriteLine("Enter the state:");
                sampleData.State = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter the num infected:");
                sampleData.Num_Infected = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter the num infected nearby:");
                sampleData.Num_Infected_Nearby = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter the times traveled:");
                sampleData.Times_Traveled = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter the total spawn count:");
                sampleData.Total_Spawn_Count = Single.Parse(Console.ReadLine());
            }

            //Load model and predict output
            var result = SentimentModel.Predict(sampleData);
            Console.WriteLine("Risk: " + (1 - result.Score));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
