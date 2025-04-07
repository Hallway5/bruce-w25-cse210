class Activity {

    protected double _laps;
    protected double _time;
    protected string _date;

    public Activity() {

        _laps = 0;
        _time = 0;
        _date = "";
    }
    public Activity(int laps, int time, string date) {

        _laps = laps;
        _time = time;
        _date = date;
    }

    public virtual double GetDistance() {

        double distance = _laps / 4;
        return distance;
    }

    public virtual double GetSpeed(double distance) {

        double speed = distance / _time * 60;
        return speed;
    }

    public virtual double GetPace(double distance) {

        double pace = _time / distance;
        return pace;
    }

    public virtual string GetSummary(double distance, double speed, double pace) {

        string summary = $"{_date} Activity ({_time} min.)- Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min. per mile";
        return summary;
    }
}