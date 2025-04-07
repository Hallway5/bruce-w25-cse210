class Running : Activity {

    public Running() : base() {

        _laps = 0;
        _time = 0;
        _date = "";
    }
    public Running(int laps, int time, string date) : base(laps, time, date) {

        _laps = laps;
        _time = time;
        _date = date;
    }

    public override string GetSummary(double distance, double speed, double pace) {

        string summary = $"{_date} Running ({_time} min.)- Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min. per mile";
        return summary;
    }
}