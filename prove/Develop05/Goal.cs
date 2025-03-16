using System.IO;

class Goal {

    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected bool _isComplete;
    protected int _totalPoints;

    public Goal() {

        _name = "";
        _description = "";
        _pointValue = 0;
        _isComplete = false;
        _totalPoints = 0;
    }

    public Goal(string name, string description, int pointValue, bool isComplete, int totalPoints) {

        _name = name;
        _description = description;
        _pointValue = pointValue;
        _isComplete = isComplete;
        _totalPoints = totalPoints;
    }

    public virtual void SetGoal() {

        Console.Write("What is the name of your goal?" );
        _name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _pointValue = int.Parse(Console.ReadLine());
    }

    public void Display(int i, string isCompleteChar) {

        if (_isComplete == true) {

            isCompleteChar = "/";
        }
        else {

            isCompleteChar = " ";
        }

        Console.WriteLine($"{i}. [{isCompleteChar}] {_name} ({_description})");
    }

    public virtual void Save(StreamWriter outputFile) {

        outputFile.WriteLine($"{_name}:{_description}:{_pointValue}:{_isComplete}");
    }

    public void Load() {

    }
}