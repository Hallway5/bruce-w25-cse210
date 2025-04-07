class StationaryBike : Activity {

    public StationaryBike() : base() {

        _laps = 0;
        _time = 0;
        _date = "";
    }
    public StationaryBike(int laps, int time, string date) : base(laps, time, date) {

        _laps = laps;
        _time = time;
        _date = date;
    }

    public override string GetSummary(double distance, double speed, double pace) {

        string summary = $"{_date} Stationary Bike ({_time} min.)- Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min. per mile";
        return summary;
    }
}