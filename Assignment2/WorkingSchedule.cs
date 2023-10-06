using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class WorkingSchedule
    {
        const int weeks = 52;

        public void Start()
        {
            Console.WriteLine("\n\tYour work schedule");
            // bool to control do/while loop
            bool done = false;
            // do while loop to display the menu again once the chosen schedule has been displayed
            // loop breaks by done being true if player enters 0
            do
            {
                ShowMenu();
                // store the return value from ReadMenuChoise as an int to use in switch
                int choice = ReadMenuChoice();
                switch (choice)
                {
                    case 1:
                        // Show weekends to work by calling PrintSchedule with the interval of 2 as parameter
                        PrintSchedule(2);
                        break;
                    case 2:
                        // show nights to work by calling PrintSchedule with the interval of 4 as parameter (every 4th week)
                        PrintSchedule(4);
                        break;
                    case 0:
                        // exit the schedule
                        done = true;
                        break;
                }
            } while (!done);
        }

        private int ReadMenuChoice()
        {
            // local var to hold the option from the user
            int option;
            Console.Write("Your choice: ");
            // while loop that executes if the input from the user cannot parse to an int, or if it is anything other than 1, 2 or 0
            while ((!int.TryParse(Console.ReadLine(), out option)) || (option != 1 && option != 2 && option != 0))
            {
                // prints that the input is invalid and to try again
                Console.WriteLine("\nInvalid input, please try again");
                // Show the menu again with valid options
                ShowMenu();
                Console.Write("Your choice: ");
            }
            // print a new line and return the valid input from the user
            Console.WriteLine();
            return option;
        }

        private void ShowMenu()
        {
            // prints the menu
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("1 - Show a list of the weekends to work.");
            Console.WriteLine("2 - Show a list of the nights to work.");
            Console.WriteLine("0 - Exit\n");
        }

        private void PrintSchedule(int interval)
        {
            // variable to control column sizes
            int col = 0;
            /* 
             * loop to print which weeks to work, weeks is set as a const to 52 instead of a endWeek var.
             * since start week is always 1, i did not make a startWeek variable, and interval is sent as an 
             * parameter when calling the method to control the number of weeks to skip for each of the schedules.
            */
            for (int i = 1; i <= weeks; i += interval)
            {
                Console.Write("Week {0, -5}", i);
                // increase the col variable for each loop
                col++;
                // check is col is devisable by 4, then print a new line 
                if (col % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }

}
