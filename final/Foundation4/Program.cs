using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>();

        Running run = new Running(4, 9, "3/7/23");
        activities.Add(run);

        StationaryBike bike = new StationaryBike(12, 10, "2/9/24");
        activities.Add(bike);

        PoolSwimming swim = new PoolSwimming(5, 12, "5/17/25");
        activities.Add(swim);

        foreach (Activity activity in activities) {

            Console.WriteLine(activity.GetSummary(activity.GetDistance(), activity.GetSpeed(activity.GetDistance()), activity.GetPace(activity.GetDistance())));
        }
    }
}