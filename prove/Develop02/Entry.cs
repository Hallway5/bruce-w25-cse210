public class Entry {

    public string _prompt;
    public string _userInput;

    public string GetDate() {
    
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();

        return dateText;
    }

    public void CreateEntry(string prompt, string input) {

            string date = GetDate();
            string entry = date + ", Prompt: '" + prompt + ",' Input:'" + input + "'";

            Journal journal = new Journal();
            journal._entries.Add(entry);
    }
}