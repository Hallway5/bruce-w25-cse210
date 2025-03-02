class ListingActivity : Activity {

    private List<string> _prompts = new List<string>() {"Who are people that you appreciate?", 
                                                        "What are personal strengths of yours?", 
                                                        "Who are people that you have helped this week?", 
                                                        "When have you felt the Holy Ghost this month?", 
                                                        "Who are some of your personal heroes?"};
    private List<string> _entries = new List<string>();

    public ListingActivity() : base() {

        _name = "";
        _description = "";
        _duration = 0;
    }
    public ListingActivity(string name, string description, int duration) : base(name, description, duration) {

        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DoActivity() {
        
        RunIntro();
        PromptDuration();

        ShowGetReady();
        ShowAnimation();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt(_prompts));
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine("Write:");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime <= endTime) {

            string entry = Console.ReadLine();
            _entries.Add(entry);
            
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {_entries.Count} items!");
        Console.WriteLine("");
        
        DisplayWellDone();
        ShowAnimation();
        Console.Clear();
    }
}