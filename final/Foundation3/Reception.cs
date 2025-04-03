class Reception : Event {

    private string _email;

    public Reception() : base() {

        _title = "";
        _description = "";
        _date = "";
        _time = "";
        _address = "";
        _email = "";
    }
    public Reception(string title, string description, string date, string time, string address, string email) : base(title, description, date, time, address) {

        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _email = email;
    }

    public void DisplayFullDetail() {

        Console.WriteLine("Reception:");
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        Console.WriteLine(_address);
        Console.WriteLine(_email);
    }public void DisplayShortDescription() {
        
        Console.WriteLine("Reception:");
        Console.WriteLine(_title); 
        Console.WriteLine(_date);
    }
}