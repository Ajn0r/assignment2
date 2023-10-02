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

            // Start method
            //PredictMyDay();
            //CalculateStrengthLength();
            //repeat = RunAgain();
        }
        private bool RunAgain()
        {
            // Method to decide if the code should run again or not
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
