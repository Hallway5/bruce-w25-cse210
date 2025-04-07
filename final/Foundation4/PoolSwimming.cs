class PoolSwimming : Activity {

    public PoolSwimming() : base() {

        _laps = 0;
        _time = 0;
        _date = "";
    }
    public PoolSwimming(int laps, int time, string date) : base(laps, time, date) {

        _laps = laps;
        _time = time;
        _date = date;
    }

    public override double GetDistance() {

        double distance = _laps * 50 / 1000;
        return distance;
    }
    public override string GetSummary(double distance, double speed, double pace) {

        string summary = $"{_date} Activity ({_time} min.)- Distance: {distance} kilometers, Speed: {speed} kmph, Pace: {pace} min. per kilometer";
        return summary;
    }
}