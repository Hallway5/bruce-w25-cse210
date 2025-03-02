class Activity {

    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity() {

        _name = "";
        _description = "";
        _duration = 0;
    }
    public Activity(string name, string description, int duration) {

        _name = name;
        _description = description;
        _duration = duration;
    }

    public void RunIntro() {

        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
    }

    public void PromptDuration() {

        Console.Write("How long, in seconds, would you like for your duration? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public string GetRandomPrompt(List<string> promptList) {

        Random random = new Random();
        int randNumber = random.Next(promptList.Count);
        string prompt = promptList[randNumber];
        return prompt;
    }

    public void ShowGetReady() {

        Console.Clear();
        Console.WriteLine("Get ready...");
    }

    public void ShowAnimation() {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        DateTime currentTime = DateTime.Now;

        while (currentTime <= endTime) {

            Console.Write("*");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("+");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("x");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("+");
            Thread.Sleep(250);
            Console.Write("\b \b");

            currentTime = DateTime.Now;
        }
    }

    public void ShowCountdown(int countdownDuration) {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(countdownDuration);
        DateTime currentTime = DateTime.Now;

        int countdownNumber = countdownDuration;

        while (currentTime <= endTime) {

            Console.Write(countdownNumber);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            countdownNumber -= 1;
            
            currentTime = DateTime.Now;
        }
    }

    public void DisplayWellDone() {

        Console.WriteLine("Well done!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
}