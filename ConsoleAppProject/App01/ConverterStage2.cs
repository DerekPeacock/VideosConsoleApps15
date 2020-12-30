using System;

namespace ConsoleAppProject.App01
{
    class ConverterStage2
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading();
            InputMiles();
            CalculateMetres();
            OutputMetres();
        }
        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number.
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void InputMetres()
        {
            Console.Write("Please enter the number of metres > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        { 
            feet = miles* FEET_IN_MILES;
        }


        /// <summary>
        /// 
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }


        /// <summary>
        /// 
        /// </summary>
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine(miles + " miles is " + feet + " feet!");
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine();
            Console.WriteLine(feet + " feet is " + miles + " miles!");
            Console.WriteLine();
        }


        /// <summary>
        /// 
        /// </summary>
        private void OutputMetres()
        {
            Console.WriteLine();
            Console.WriteLine(miles + " miles is " + metres + " metres!");
            Console.WriteLine();
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
