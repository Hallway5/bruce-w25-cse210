class Verse {

    private List<Word> _words = new List<Word>();
    private int _totalHiddenCount;

    public Verse() {

        Word word = new Word();
        _words.Add(word);
    }
    public Verse(string text) {

        string[] words = text.Split(" ");
        foreach (string strword in words) {

            Word word = new Word(strword);
            _words.Add(word);
        }
    }

    public string HideWord() {
            
        var random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < 3) {
            foreach (Word word in _words) {
                var coin = random.Next(2);
                if (coin == 0 && hiddenCount < 3) {
                
                    word.HideWord();
                    hiddenCount += 1;
                    _totalHiddenCount += 1;
                }
            }
        }

        string joinedString = string.Join(" ", _words);
        return joinedString;
    }

    public bool IsFinished() {

        int wordCount = 0;
        foreach (Word word in _words) {

            wordCount += 1;
        }
        if (_totalHiddenCount >= wordCount) {

            return true;
        }
        else {

            return false;
        }
    }
}