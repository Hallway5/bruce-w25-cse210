class BreathingActivity : Activity {

    // private int _numberOfBreaths;

    public BreathingActivity() : base() {

        _name = "";
        _description = "";
        _duration = 0;
    }
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration) {

        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DoActivity() {

        RunIntro();
        PromptDuration();

        ShowGetReady();
        ShowAnimation();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime <= endTime) {

            Console.WriteLine("");
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
            
            currentTime = DateTime.Now;
        }

        DisplayWellDone();
        ShowAnimation();
        Console.Clear();
    }
}