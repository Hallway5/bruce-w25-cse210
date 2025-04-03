class Lecture : Event {

    private string _speaker;
    private string _capacity;

    public Lecture() : base() {

        _title = "";
        _description = "";
        _date = "";
        _time = "";
        _address = "";
        _speaker = "";
        _capacity = "";
    }
    public Lecture(string title, string description, string date, string time, string address, string speaker, string capacity) : base(title, description, date, time, address) {

        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayFullDetail() {

        Console.WriteLine("Lecture:");
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address);
        Console.WriteLine(_speaker);
        Console.WriteLine(_capacity);
    }

    public void DisplayShortDescription() {
        
        Console.WriteLine("Lecture:");
        Console.WriteLine(_title); 
        Console.WriteLine(_date);
    }
}