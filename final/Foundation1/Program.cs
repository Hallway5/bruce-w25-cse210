using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Product Review: The ULTIMATE SPORK!!!", "JeffReviews", "11:20");
        video1.AddComment("JeffReviews", "Be sure to check out today's sponsor!");
        video1.AddComment("TotallyNotJeff", "Great video Jeff, keep up the good work!");
        video1.AddComment("JeffsFriendIRL", "Nice one Jeff, 10/10");
        video1.AddComment("BillyBob", "been looking for one of these thanks for the recommend");
        videos.Add(video1);

        Video video2 = new Video("Easy SPORK Tutorial", "BobSporkBuilder", "11:15");
        video2.AddComment("maseycoore", "This actually came at a perfect time, I'm literally designing a Spork-inspired campaign world right now");
        video2.AddComment("YaySphere", "Simple utensils and lots of flavor help a lot. The hard part is to convey it without having to yap for minutes.");
        video2.AddComment("DonnyField", "Wow being a 90s kid I never realized how much I miss sporks");
        videos.Add(video2);

        Video video3 = new Video("The Sporker 3 - White Orchard (Ambient Music)", "Gaming Ambience", "1:00:49");
        video3.AddComment("odaceious", "'Ghoul spork. Oughtta just destroy it.'");
        video3.AddComment("PKendy", "'Spork's howling.'");
        video3.AddComment("Sykes259", "Its such a strange feeling when you come back to White Orchard in the end game. Makes you feel how far you have come since the last time you heard this spork.");
        videos.Add(video3);

        foreach (Video video in videos) {

            video.Display();
        }
    }
}