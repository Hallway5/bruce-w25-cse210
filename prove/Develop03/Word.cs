class Word {
    
    private string _word;
    private bool _hidden;

    public Word() {

        _word = "foo";
        _hidden = false;
    }
    public Word(string text) {

        _word = text;
        _hidden = false;
    }

    public bool IsHidden() {

        if (_hidden == true) {
            
            return true;
        }
        else {
            return false;
        }
    }

    public string HideWord() {

        _word = "____";
        _hidden = true;
        return _word;
    }

    // public void IsFinished() {

    // }
}