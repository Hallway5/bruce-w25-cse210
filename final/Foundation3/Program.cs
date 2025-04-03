using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        Lecture lecture = new Lecture("Art Seminar", "Illustration presentation from a professional artist.", "4/3/25", "7:15 p.m.", "48 S 2nd E, Rexburg, ID 83440", "Jess Smart Smiley", "240");
        lecture.DisplayStandardDetail();
        lecture.DisplayFullDetail();
        lecture.DisplayShortDescription();

        Reception reception = new Reception("Wedding Reception", "Reception for the union of John and Jane Doe.", "4/12/25", "6:00 p.m.", "1650 E 2600 N, North Logan, UT 84341", "johndoe@emailaddress.com");
        reception.DisplayStandardDetail();
        reception.DisplayFullDetail();
        reception.DisplayShortDescription();

        OutdoorGathering gathering = new OutdoorGathering("Geocacheing Expedition", "Join up with professional geocachers and learn the hobby!", "3/29/25", "8:00 a.m.", "Ridgeline Trailhead, North Logan, UT 84341", "Cloudy");
        gathering.DisplayStandardDetail();
        gathering.DisplayFullDetail();
        gathering.DisplayShortDescription();
    }
}