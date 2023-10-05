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
            ShowMenu();
            int choice = ReadMenuChoice();
            switch (choice)
            {
                case 1:
                    ShowTableCelsiusToFarenheit();
                    break;
                case 2:
                    break;
                case 0:
                    break;

            }

        }

        private void ShowTableCelsiusToFarenheit()
        {
            const int maxF = 212;
            for (int i = 0; i <= maxF; i += 10)
            {
                double celsius = CelsiusToFarenheit(i);
                Console.WriteLine(string.Format("{0,6} F = {1,7:0.00} C", i, celsius));
            }
        }

        private double CelsiusToFarenheit(double farenheit)
        {
            
            double celsius;
            celsius = 5.0 / 9 * (farenheit - 32);
            return celsius;
        }


        private int ReadMenuChoice()
        {
            int option;
            Console.Write("Your choice: ");
            while((!int.TryParse(Console.ReadLine(), out option)) || (option != 1 && option != 2 && option != 0))
            {
                Console.WriteLine("Invalid input, please try again");
                ShowMenu();
            }
            return option;
        }

        private void ShowMenu()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\n\t Temperature Converter");
            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("{0, -28} {1}", " Celsius to Fahrenheit", ": 1");
            Console.WriteLine("{0, -28} {1}", " Fahrenheit to Celsius", ": 2");
            Console.WriteLine("{0, -28} {1}", " Exit", ": 0");
            Console.WriteLine("\n------------------------------------------");
        }
    }
}
