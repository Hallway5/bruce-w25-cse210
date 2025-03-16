class ChecklistGoal : Goal {

    private int _bonusPointValue;
    private int _tasksSet;
    private int _tasksCompleted;

    public ChecklistGoal() {

        
        _bonusPointValue = 0;
        _tasksSet = 0;
        _tasksCompleted = 0;

        _name = "";
        _description = "";
        _pointValue = 0;
        _isComplete = false;
        _totalPoints = 0;
    }
    public ChecklistGoal(int bonusPointValue, int tasksSet, int tasksCompleted, string name, string description, int pointValue, bool isComplete, int totalPoints) : base(name, description, pointValue, isComplete, totalPoints) {

        _bonusPointValue = bonusPointValue;
        _tasksSet = tasksSet;
        _tasksCompleted = tasksCompleted;

        _name = name;
        _description = description;
        _pointValue = pointValue;
        _isComplete = isComplete;
        _totalPoints = totalPoints;
    }

    public override void SetGoal() {

        Console.Write("What is the name of your goal?" );
        _name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _pointValue = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _tasksSet = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for acomplishing it that many times? ");
        _bonusPointValue = int.Parse(Console.ReadLine());
    }
}