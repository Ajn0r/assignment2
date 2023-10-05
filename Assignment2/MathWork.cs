using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MathWork
    {
        public void Start()
        {
            PrintMultiplicationTable();
            Calculate();
        }

        private void PrintMultiplicationTable()
        {
            Console.WriteLine("\t******** Multiplication Table ********");
            // Looping trough rows one at a time, 12 times starting at 1
            for (int row = 1; row <= 12; row++)
            {   // Looping trough columns one at a time, 12 times starting at 1
                for (int col = 1; col <= 12; col++)
                {
                    // Format and print the multiplication of row * col
                    Console.Write(string.Format("{0,5}", row * col));
                }
                // A new line for every row iteration
                Console.WriteLine();
            }
        }

        private void Calculate()
        {
            int startNum;
            int endNum;
            bool done = false;

            while (!done)
            {
                bool numCheck1 = false;
                bool numCheck2 = false;
                Console.WriteLine("Select any two positive numbers");
                // A do while loop to validate the number input
                do
                {
                    Console.Write("Write the first number: ");
                    // Reads the first number, and checks if it is valid with TryParse, if it is
                    // save it to startNum var and numCheck1 will be true
                    numCheck1 = int.TryParse(Console.ReadLine(), out startNum);
                    // ask for second number
                    Console.Write("Write the second number: ");
                    // Read second number and do the same check.
                    numCheck2 = int.TryParse(Console.ReadLine(), out endNum);
                    if (!numCheck1 && !numCheck2)
                        Console.WriteLine("Invalid input, please enter two postive integers");
                } while (!numCheck1 && !numCheck2);

                // checking is startNum is higher than endNum, and switching places if it is.
                if (startNum > endNum)
                {
                    int tempNum = endNum;
                    endNum = startNum;
                    startNum = tempNum;
                }

                int sum = SumNumbers(startNum, endNum);
                Console.WriteLine(string.Format("The sum of the numbers between {0} and {1} is {2}", startNum, endNum, sum));

                // Call to print all even numbers
                PrintEvenNumbers(startNum, endNum);

                // Call to print all odd numbers
                PrintOddNumbers(startNum, endNum);

                // Call to calculate and print the sqaure root of all numbers between start and endNum
                CalculateSquareRoots(startNum, endNum);
  
                // Set done to the return value of ExitCalculations method.
                done = ExitCalculation();
            }
        }

        private void CalculateSquareRoots(int startNum, int endNum)
        {
            Console.WriteLine("\n\t******** Square Roots ********");
            // loop trough all numbers once
            for (int i = startNum; i <= endNum; i++)
            {
                // for each round in the loop, print a line with the numbers that square root is calculated for
                Console.Write("Sqt({0,3} to {1,3})", i, endNum);
                // j will be which number i is in the loop, and for each number until endNum, loop trough and calculate sqrt.
                for (int j = i; j <= endNum; j++)
                {
                    // print the sqrt
                    Console.Write(string.Format("{0,6:f2}", Math.Sqrt(j)));
                }
                // new line for every row(i)
                Console.WriteLine();
            }
        }

        private void PrintOddNumbers(int startNum, int endNum)
        {
            Console.WriteLine(string.Format("\n **** Odd numbers between {0} and {1} ****", startNum, endNum));
            // loop through from the start to end num
            for (int i = startNum; i <= endNum; i++)
            {
                // if not devisable by 2, it is an odd number and will be printed to console.
                if (!(i % 2 == 0))
                {
                    Console.Write(string.Format("{0,4}", i));
                }
            }
            Console.WriteLine();
        }

        private void PrintEvenNumbers(int startNum, int endNum)
        {
            Console.WriteLine(string.Format(" **** Even numbers between {0} and {1} ****", startNum, endNum));
            // loop through from the start to end num
            for (int i = startNum; i <= endNum; i++)
            {
                // if devisable by 2, it is an even number and is printed to console.
                if (i % 2 == 0)
                {
                    Console.Write(string.Format("{0,4}", i));
                }
            }
            Console.WriteLine();
        }

        private int SumNumbers(int startNum, int endNum)
        {
            // variables to hold the total sum and the current number for each loop round
            int sum = 0;
            int num;

            // loop from the startNum until endNum, adding each number to sum variable 
            for (num = startNum; num <= endNum; num++)
            {
                sum += num;
            }
            // return the total sum once done iterating over the numbers
            return sum;
        }

        private bool ExitCalculation()
        {
            bool done = false;
            bool validInput = false;
            // Ask and read if the user wants to exit the program
            Console.WriteLine("Exit Math Work? (y/n)");
            do
            {
                // read the answer and transform to lower case
                string answer = Console.ReadLine().ToLower();
                // if the answer is y or yes, both validInput and done is true
                if (answer.Equals("y") || answer.Equals("yes"))
                {
                    validInput = true;
                    done = true;
                } // if answer is n or no, validInput is true but done is false
                else if (answer.Equals("n") || answer.Equals("no"))
                {
                    validInput = true;
                    done = false;
                }
                else // invalid input will be false and the do while loop will do another round
                {
                    Console.WriteLine("Invalid input, enter 'y' to exit or 'n' to play again");
                    validInput = false;
                }
            } while (!validInput);
            // return the value of done
            return done;
        }
    }
}
