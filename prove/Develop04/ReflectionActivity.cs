class ReflectionActivity : Activity {

    private List<string> _prompts = new List<string>() {"Think of a time when you did something really difficult.",
                                                        "Think of a time when you helped someone in need.", 
                                                        "Think of a time when you did something truly selfless.",
                                                        "Think of a time when you stood up for someone else."};
    private List<string> _questions = new List<string>() {"Why was this experience meaningful to you?", 
                                                          "Have you ever done anything like this before?", 
                                                          "How did you get started?", 
                                                          "How did you feel when it was complete?", 
                                                          "What made this time different than other times when you were not as successful?", 
                                                          "What is your favorite thing about this experience?", 
                                                          "What could you learn from this experience that applies to other situations?", 
                                                          "What did you learn about yourself through this experience?",
                                                          "How can you keep this experience in mind in the future?"};

    public ReflectionActivity() : base() {

        _name = "";
        _description = "";
        _duration = 0;
    }
    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration) {

        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DoActivity() {
        
        RunIntro();
        PromptDuration();

        ShowGetReady();
        ShowAnimation();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        
        Console.WriteLine(GetRandomPrompt(_prompts));
        Console.WriteLine("");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("Now ponder on each of the following questions as they are related to the experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        Console.Clear();
        Console.WriteLine(GetRandomPrompt(_questions));
        ShowAnimation();

        Console.WriteLine(GetRandomPrompt(_questions));
        ShowAnimation();

        DisplayWellDone();
        ShowAnimation();
        Console.Clear();
    }
}