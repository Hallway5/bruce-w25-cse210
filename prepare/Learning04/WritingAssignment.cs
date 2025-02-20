class WritingAssignment : Assignment {

    private string _title;

    public WritingAssignment() : base() {

        _studentName = "";
        _topic = "";
        _title = "";
    }
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, title) {

        _studentName = studentName;
        _topic = topic;
        _title = title;
    }

    public string GetWritingInformation() {

        string writingInformation = _title + " by " + _studentName;
        return writingInformation;
    }
}