using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class FunFeatures
    {
        private string email;
        private string name;

        public void Start()
        {
            // Welcome the player and get some user information
            Introduce();

            // do/while loop to continue playing until RunAgain method returns false
            do
            {
                // Call the day prediction method
                PredictMyDay();

                // Start the string length calculating method
                CalculateStrengthLength();

            } while (RunAgain());
        }
        private bool RunAgain()
        {
            Console.Write("\nContinue with another round? (y/n): ");
            // Method to decide if the code should run again or not
            string answer = Console.ReadLine().ToLower();
            if (answer.Equals("y") || answer.Equals("yes"))
                return true;
            else 
                return false;
        }
        private void Introduce()
        {
            // Welcome the player and get some user information
            Console.WriteLine("Hello! My name is Ronja and I am a student of the 2023 autumn semester\n");
            Console.WriteLine("Let me know about yourself!");
            ReadName();
            ReadEmail();
            Console.WriteLine("\nNice to meet you " + name);
            Console.WriteLine("Your email is " + email);
        }
        private void ReadEmail()
        {
            // Read the email from the user
            Console.Write("Your email please: ");
            email = Console.ReadLine();
        }
        private void ReadName()
        {
            // Read the name from the user
            Console.Write("Your first name please: ");
            string firstName = Console.ReadLine();
            Console.Write("Your last name please: ");
            string lastName = Console.ReadLine().ToUpper();
            name = lastName + ", " + firstName;
        }
        private void PredictMyDay()
        {
            Console.WriteLine("\n\n ****** FORTUNE TELLER ****** ");
            Console.Write("Select a number between 1 and 7: ");
            string selectedDay = Console.ReadLine();
            // switch selection based on the number that the user enters.
            switch(selectedDay)
            {
                case "1":
                    Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                    break;
                case "2":
                case "3":
                    Console.WriteLine("Tuesdays and Wednesdays break your heart");
                    break;
                case "4":
                    Console.WriteLine("Thursday is your lucky day, don't wait for Friday");
                    break;
                case "5":
                    Console.WriteLine("Friday, you are in love");
                    break;
                case "6":
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case "7":
                    Console.WriteLine("And Sunday always comes too soon");
                    break;
                default:
                    Console.WriteLine("No day? is a good day but it doesn't exist!");
                    break;
            }
        }
        private void CalculateStrengthLength()
        {
            Console.WriteLine("\n\n ---- STRENGHT LENGTH ---- ");
            Console.WriteLine("Write a text with any number of characters and press Enter.\n" +
                "You can even copy a text from a file and paste it here!");
            // reads the text from the user and transform it to uppercase
            string textInput = Console.ReadLine().ToUpper();
            Console.WriteLine("\n" + textInput);
            // prints the number of characters in the text with .Length.
            Console.WriteLine("Number of characters: " + textInput.Length);
        }
    }
}
