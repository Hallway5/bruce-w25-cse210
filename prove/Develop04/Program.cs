using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        int userChoice = 0;

        while (userChoice != 4) {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start Breathing Activity");
            Console.WriteLine("   2. Start Reflection Activity");
            Console.WriteLine("   3. Start Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) {

                Console.Clear();
                // Breathing Activity
                //Console.WriteLine("Breathing Activity");

                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                breathingActivity.DoActivity();
            }
            else if (userChoice == 2) {

                Console.Clear();
                // Reflection Activity
                // Console.WriteLine("Reflection Activity");

                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                reflectionActivity.DoActivity();
            }
            else if (userChoice == 3) {

                Console.Clear();
                // Listing Activity
                // Console.WriteLine("Listing Activity");
                
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                listingActivity.DoActivity();
            }
            else if (userChoice == 4) {

                Console.Clear();
                // Quit
                // Console.WriteLine("Quit");
            }
            else {

                Console.Clear();
                Console.WriteLine("Invalid Choice. Please try again.");
            }
        }
    }
}