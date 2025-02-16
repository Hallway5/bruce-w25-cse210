using System.Reflection;

class Scripture {

    private string _reference;
    private string _verses;

    public Scripture() {

        _reference = "Proverbs 3:5-6";
        _verses = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
    }
    public Scripture(string reference) {

        _reference = reference;
        _verses = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
    }
    public Scripture(string reference, string verses) {

        _reference = reference;
        _verses = verses;
    }

    public void Display() {

        Console.WriteLine(_reference + ": " + _verses);
    }

    public void HideWord() {

        Verse verse = new Verse();
        _verses = verse.HideWord();
    }
}