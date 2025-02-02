public class Menu {

    //public int _userChoice;

    public void DisplayMenu() {
        
        Console.WriteLine("Enter a number:");
        Console.WriteLine("1. Write new entry");
        Console.WriteLine("2. Display entries");
        Console.WriteLine("3. Save journal");
        Console.WriteLine("4. Load journal");
        Console.WriteLine("5. Display journal");
        Console.WriteLine("6. Quit program");
    }
    public string PromptUserChoice() {
        string choice = Console.ReadLine();
        return choice;
    }

    public void Write() {

        Entry entry = new Entry();

        // gets prompt
        PromptGenerator prompt = new PromptGenerator();
        entry._prompt = prompt.GetRandomPrompt();
        
        // displays prompt
        Console.WriteLine(entry._prompt);
        
        // gets user input
        entry._userInput = Console.ReadLine();
        entry.CreateEntry(entry._prompt, entry._userInput);

    }

    public void Save() {

        Console.WriteLine("What would you like to call your journal?");
        string journalName = Console.ReadLine() + ".txt";

        Journal journal = new Journal();
        journal.SaveJournal(journalName);
    }

    public void Load() {

        Console.WriteLine("Which journal would you like to load?");
        string journalName = Console.ReadLine() + ".txt";

        Journal journal = new Journal();
        journal.LoadJournal(journalName);

    }

    public void Display() {

        Console.WriteLine("Which journal would you like to display?");
        string journalName = Console.ReadLine() + ".txt";

        Journal journal = new Journal();
        journal.DisplayJournal(journalName);
    }

    public void DisplayEntries() {
        
        Journal journal = new Journal();
        journal.DisplayEntries();
    }

    public void Quit() {

    }
}