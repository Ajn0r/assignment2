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
            bool repeat = false;
            // Welcome the player and get some user information
            Introduce();
            do
            {
                PredictMyDay();

                //CalculateStrengthLength();
                
                // Check if user want to play again
                repeat = RunAgain();
            } while (repeat);
        }
        private bool RunAgain()
        {
            Console.Write("Continue with another round? (y/n): ");
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
        private void PredictMyDay()
        {
            Console.WriteLine("\n\n ****** FORTUNE TELLER ****** ");
            Console.Write("Select a number between 1 and 7: ");
            string answer = Console.ReadLine();
            switch(answer)
            {
                case "1":
                    Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                    break;
                case "2":
                    Console.WriteLine("Tuesdays and Wednesdays break your heart");
                    break;
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
    }
}
