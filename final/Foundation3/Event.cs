class Event {

    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event() {

        _title = "";
        _description = "";
        _date = "";
        _time = "";
        _address = "";
    }
    public Event(string title, string description, string date, string time, string address) {

        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetail() {

        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address);
    }
}