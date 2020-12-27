using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in miles and it will calculate and
    /// output the equivalant distance in feet.
    /// </summary>
    /// <author>
    /// Derek's version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        /// <summary>
        /// Output a short description of the application
        /// and the name of the author.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("      Convert Miles to Feet          ");
            Console.WriteLine("          by Derek Peacock           ");
            Console.WriteLine("-------------------------------------\n");
        }
    }
}
