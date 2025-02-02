using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine();
        Menu choice = new Menu();
        string userChoice = "0";

        while (userChoice != "6") {
            
            // Display Menu
            menu.DisplayMenu();
            userChoice = choice.PromptUserChoice();

            if (userChoice == "1") {
                // New entry
                menu.Write();
            }
            else if (userChoice == "2") {
                // Save journal
                menu.DisplayEntries();
            }
            else if (userChoice == "3") {
                // Save journal
                menu.Save();
            }
            else if (userChoice == "4") {
                // Load journal
                menu.Load();
            }
            else if (userChoice == "5") {
                // Display journal
                menu.Display();
            }
            else if (userChoice == "6") {
                // Quit program
                menu.Quit();
            }
            else {
                // Invalid choice
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}