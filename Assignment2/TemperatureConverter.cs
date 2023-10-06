using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class TemperatureConverter
    {
        public void Start()
        {
            // bool to control do/while loop
            bool done = false;
            // do while loop to display the menu again once the temp has been displayed
            // loop breaks by done being true if player enters 0
            do
            {
                ShowMenu();
                // store the return value from ReadMenuChoise as an int to use in switch
                int choice = ReadMenuChoice();
                switch (choice)
                {
                    case 1:
                        // Shot celsius to farenheit convertion
                        ShowTableCelsiusToFarenheit();
                        break;
                    case 2:
                        // show farenheit to celsius convertion
                        ShowTableFarenheitToCelsius();
                        break;
                    case 0:
                        // exit the coverter
                        done = true;
                        break;
                }
            } while (!done); 
        }

        private int ReadMenuChoice()
        {
            // local var to hold the option from the user
            int option;
            Console.Write("{0,14}", "Your choice: ");
            // while loop that executes if the input from the user cannot parse to an int, or if it is anything other than 1, 2 or 0
            while((!int.TryParse(Console.ReadLine(), out option)) || (option != 1 && option != 2 && option != 0))
            {
                // prints that the input is invalid and to try again
                Console.WriteLine("Invalid input, please try again");
                // Show the menu again with valid options
                ShowMenu();
            }
            // returns the valid input from the user
            return option;
        }

        private void ShowMenu()
        {
            // prints the menu
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n\t Temperature Converter");
            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("{0, -28} {1}", " Celsius to Fahrenheit", ": 1");
            Console.WriteLine("{0, -28} {1}", " Fahrenheit to Celsius", ": 2");
            Console.WriteLine("{0, -28} {1}", " Exit", ": 0");
            Console.WriteLine("\n------------------------------------------\n");
        }

        private void ShowTableFarenheitToCelsius()
        {
            // sets a const with max farenheit to be calculated to 212
            const int maxF = 212;
            // loops the length of the maxF with 10 interval
            for (int i = 0; i <= maxF; i += 10)
            {
                // calls the method to calculate celsius with the index of i
                double celsius = FarenheitToCelsius(i);
                // prints out the conversion for each value
                Console.WriteLine(string.Format("{0,6} F = {1,7:0.00} C", i, celsius));
            }
        }

        private double FarenheitToCelsius(double farenheit)
        {
            // calculates celsius and stores in a variable that is returned
            double celsius = 5.0 / 9 * (farenheit - 32);
            return celsius;
        }

        private void ShowTableCelsiusToFarenheit()
        {
            // sets a const with max celsius to be calculated to 100
            const int maxC = 100;
            // loops the length of the maxC with 4 interval
            for (int i = 0; i <= maxC; i += 4)
            {
                // calls the method to calculate farenheit with the index of i
                double farenheit = CelsiusToFarenheit(i);
                // prints out the conversion for each value
                Console.WriteLine(string.Format("{0,6} C = {1,7:0.00} F", i, farenheit));
            }
        }

        private double CelsiusToFarenheit(double celsius)
        {
            // calculates farenheit and stores in a variable that is returned
            double farenheit = 9 / 5.0 * celsius + 32;
            return farenheit;
        }
    }
}
