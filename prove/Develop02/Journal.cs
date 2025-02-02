using System.IO;

public class Journal {

    public List<string> _entries = new List<string>();

    public void SaveJournal(string journalName) {

        using (StreamWriter outputFile = new StreamWriter(journalName)) {

            foreach (string entry in _entries) {

                outputFile.WriteLine(entry);
            }
        }
    }

    public void LoadJournal(string journalName) {

        string[] lines = System.IO.File.ReadAllLines(journalName);

        foreach (string line in lines) {

            _entries.Add(line);
        }
    }

    public void DisplayJournal(string journalName) {

        string[] lines = System.IO.File.ReadAllLines(journalName);

        foreach (string line in lines) {

            Console.WriteLine(line);
        }
    }

    public void DisplayEntries() {

        foreach (string entry in _entries) {

            Console.WriteLine(entry);
        }
    }
}