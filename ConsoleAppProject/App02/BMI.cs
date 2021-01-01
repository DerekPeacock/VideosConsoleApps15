using System;

namespace ConsoleAppProject.App02
{



    /// <summary>
    /// This class contains methods for calculating 
    /// the user's BMI (Body Mass Index) using 
    /// imperial or metric units.
    /// </summary>
    /// <Author>
    /// Derek Peacock App02: Version 1.0
    /// </Author>
    public class BMI
    {
        public const double Underweight = 18.5;
        public const double NormalRange = 24.9;
        public const double Overweight = 29.9;

        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        private double index;

        // Metric Details

        private double kilograms;
        private double metres;

        // Imperial Details

        private double pounds;
        private int inches;

        public UnitSystems UnitSystems
        {
            get => default;
            set
            {
            }
        }

        ///<summary>
        /// Prompt the user to select Imperial or Metric
        /// units.  Input the user's height and weight and
        /// then calculate their BMI value.  Output which
        /// weight category they fall into.
        ///</summary>
        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");

            UnitSystems unitSystem = SelectUnits();

            if (unitSystem == UnitSystems.Metric)
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }
            else
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }

            OutputHealthMessage();

        }

        public void CalculateMetricBMI()
        {
            index = kilograms / (metres * metres);
        }

        public void CalculateImperialBMI()
        {
            index = pounds * 703 / (inches * inches);
        }

        /// <summary>
        /// Prompt the user to select imperial or metric
        /// units for entering their weight and height
        /// </summary>
        private UnitSystems SelectUnits()
        {

            Console.WriteLine(" 1. Metric Units");
            Console.WriteLine(" 2. Imperial Units");

            Console.Write("\n Please enter your choice of units > ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                return UnitSystems.Metric;
            }
            else return UnitSystems.Imperial;
        }

        /// <summary>
        /// Input the users height in feet and inches and
        /// their weight in stones and pounds
        /// </summary>
        private void InputImperialDetails()
        {
            Console.WriteLine(" Enter your height in feet and inches ");
            Console.WriteLine();

            double feet = InputNumber("\n Enter your height in feet > ");
            inches = (int)InputNumber(" Enter your height in inches > ");

            inches += (int)feet * InchesInFeet;

            Console.WriteLine();
            Console.Write(" Enter your weight in stones and pounds");
            Console.WriteLine();

            double stones = InputNumber(" Enter your weight in stones > ");
            pounds = InputNumber(" Enter your weight in pounds > ");

            pounds += stones * PoundsInStones;
        }

        /// <summary>
        /// Input the users height in metres and
        /// their weight in kilograms
        /// </summary>
        private void InputMetricDetails()
        {
            metres = InputNumber(
                " \n Enter your height in metres > ");

            kilograms = InputNumber(
                " Enter your weight in kilograms > ");
        }

        /// <summary>
        /// Output the users BMI and their weight
        /// category from underweight to obese.
        /// </summary>
        private void OutputHealthMessage()
        {
            Console.WriteLine();

            if (index < Underweight)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are underweight! ");
            }
            else if (index <= NormalRange)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are in the normal range! ");

            }
            else if (index <= Overweight)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are overweight! ");

            }
            else if (index <= ObeseLevel1)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are obese class I ");

            }
            else if (index <= ObeseLevel2)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are obese class II ");

            }
            else if (index <= ObeseLevel3)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are obese class III ");

            }

            OutputBameMessage();
        }

        /// <summary>
        /// Output a message for BAME users who are
        /// at higher risk
        /// </summary>
        private void OutputBameMessage()
        {
            Console.WriteLine();
            Console.WriteLine(" If you are Black, Asian or other minority");
            Console.WriteLine(" ethnic groups, you have a higher risk");
            Console.WriteLine();
            Console.WriteLine("\t Adults 23.0 or more are at increased risk");
            Console.WriteLine("\t Adults 27.5 or more are at high risk");
            Console.WriteLine();
        }

        public double InputNumber(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            double number = Convert.ToDouble(value);

            return number;
        }

    }
}

