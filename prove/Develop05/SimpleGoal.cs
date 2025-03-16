class SimpleGoal : Goal {

    public SimpleGoal() : base() {

        _name = "";
        _description = "";
        _pointValue = 0;
        _isComplete = false;
        _totalPoints = 0;
    }

    public SimpleGoal(string name, string description, int pointValue, bool isComplete, int totalPoints) : base(name, description, pointValue, isComplete, totalPoints) {

        _name = name;
        _description = description;
        _pointValue = pointValue;
        _isComplete = isComplete;
        _totalPoints = totalPoints;
    }
}