using System.IO;

class Manager {
    
    private List<Goal> _goals = new List<Goal>();
    private string _fileName;

    public Manager() {

        _goals = [];
        _fileName = "";
    }
    public Manager(List<Goal> goals, string fileName) {

        _goals = goals;
        _fileName = fileName;
    }

    public void CreateGoal() {

        int userChoice = 0;

        while (userChoice != 1 || userChoice != 2 || userChoice != 3) {

        Console.WriteLine("The types of goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal do you want to create?");
        userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1) {
                // Create Goal

                SimpleGoal goal = new SimpleGoal();
                goal.SetGoal();
                _goals.Add(goal);
            }
            else if (userChoice == 2) {
                // List Goals

                EternalGoal goal = new EternalGoal();
                goal.SetGoal();
                _goals.Add(goal);
            }
            else if (userChoice == 3) {
                // Save Goals
                
                ChecklistGoal goal = new ChecklistGoal();
                goal.SetGoal();
                _goals.Add(goal);
            }

        //_goals.Add(goal);
        
        }
    }

    public void DisplayGoal() {

        string isCompleteChar = "";
        int i = 0;

        foreach (Goal goal in _goals) {

            i += 1;

            goal.Display(i, isCompleteChar);

            // if (goal._isComplete == true) {

            //     isCompleteChar = "/";
            // }
            // else {

            //     isCompleteChar = " ";
            // }

            // i += 1;

            // Console.WriteLine($"{i}. [{isCompleteChar}] {goal._name} ({goal._description})");
        }
    }

    public void SaveGoals() {

        Console.Write("What is the filename for the goal file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName)) {
            
            //outputFile.WriteLine(goal._totalPoints);
            foreach (Goal goal in _goals) {

                goal.Save(outputFile);
            }
        }

        // using (StreamWriter outputFile = new StreamWriter(_fileName)) {

        //     foreach (Goal goal in _goals) {

        //         goal.Save();
        //         //outputFile.WriteLine($"{goal}:{goal._name}:{goal._description}:{goal._pointValue}:{goal._isComplete}");
        //     }
        // }
    }

    public void LoadGoals() {

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines) {
            
            // split between {goal}:{goal._name}:{goal._description}:{goal._pointValue}:{goal._isComplete}
            if (line.Contains(":")) {

                string[] parts = line.Split(":");

                string name = parts[0];
                string description = parts[1];
                int pointValue = int.Parse(parts[2]);
                bool isComplete = bool.Parse(parts[3]);
            }
            else {

                int totalPonts = int.Parse(line);
            }

            // Goal goal = new Goal(name, description, pointValue, isComplete, totalPoints);
            // _goals.Add(goal);
        }
    }

    public void RecordEvent() {

    }
}