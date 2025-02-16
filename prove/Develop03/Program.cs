using System;
using System.Security.Cryptography.X509Certificates;

class Program {
    static void Main(string[] args) {

        string _scriptures = "Proverbs 3:5-6+Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        string[] scriptures = _scriptures.Split("+");

        string reference = scriptures[0];
        string verses = scriptures[1];
        Scripture scripture1 = new Scripture(reference, verses);
        scripture1.Display();

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string quitter = Console.ReadLine();

        Verse quitCheck = new Verse();

        while (quitter != "quit") {

            Console.Clear();
            scripture1.HideWord();

            scripture1.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            quitter = Console.ReadLine();

            bool quitBoolMain = IsFinished();
            if (quitBoolMain == true) {quitter = "quit";}
        }
    }

    // static void HideWords() {

    //     Scripture scripture = new Scripture();
    //     scripture.HideWord();
    // }

    static bool IsFinished() {

        Verse quitCheck = new Verse();
        bool quitBool = quitCheck.IsFinished();
        if (quitBool == true) {
            
            return true;
        }
        else {

            return false;
        }
    }
}
