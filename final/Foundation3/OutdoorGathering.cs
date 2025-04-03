class OutdoorGathering : Event {

    private string _weather;

    public OutdoorGathering() : base() {

        _title = "";
        _description = "";
        _date = "";
        _time = "";
        _address = "";
        _weather = "";
    }
    public OutdoorGathering(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address) {

        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _weather = weather;
    }

    public void DisplayFullDetail() {

        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address);
        Console.WriteLine(_weather);
    }public void DisplayShortDescription() {
        
        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(_title); 
        Console.WriteLine(_date);
    }
}