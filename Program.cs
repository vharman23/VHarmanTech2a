using System;
using System.Xml;

namespace VHarmanTech2a

    //ISM 4300 Tech PRoject #2a by Victoria Harman
    // This program demostrates an interative statement
{

    class Program
    {
        static void Main(string[] args)
        {
            //Asking user to input integer
            Console.WriteLine("Input an integer between 1 and 20 to execute an interative statement: ");

            //Using try catch loop to prevent crashing
            try
            {
                //This variable gathers the user inputed data
                string input = Console.ReadLine();
                //converts string input to an integer
                int input_value = int.Parse(input);

                if ((input_value > 0) && (input_value <= 20))
                {
                    Console.WriteLine("Executing a While Loop!");
                    Console.WriteLine("The While Loop will iterate " + input_value.ToString() + " times.");

                    //While Loop
                    while (input_value > 0)
                    {
                        Console.WriteLine("The value of the interative variable is: " + input_value.ToString());
                        input_value--;
                    }
                    Console.WriteLine("Press any key to exit the program . . .");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again . . .");
                Console.WriteLine("Press any key to exit the program . . .");
                Console.ReadKey(true);               
            }
        }
    }
}
