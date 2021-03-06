﻿using System;
using System.Text;

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
    public class BmiCalculator
    {
        public const double Underweight = 18.5;
        public const double NormalRange = 24.9;
        public const double Overweight = 29.9;

        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        public double Index { get; set; }

        // Metric Details

        public double Kilograms { get; set; }
        public int Centimetres { get; set; }

        // Imperial Details
        public int Stones { get; set; }
        public int Pounds { get; set; }
        
        public int Feet { get; set; }
        public int Inches { get; set; }

        public UnitSystems UnitSystems
        {
            get => default;
        }


        private double metres;

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

            Console.WriteLine(GetHealthMessage());
            Console.WriteLine(GetBameMessage());

        }

        public void CalculateMetricBMI()
        {
            Index = Kilograms / (metres * metres);
        }

        public void CalculateImperialBMI()
        {
            Inches += Feet * InchesInFeet;
            Pounds += Stones * PoundsInStones;

            Index = (double)Pounds * 703 / (Inches * Inches);
        }

        /// <summary>
        /// Prompt the user to select imperial or metric
        /// units for entering their weight and height
        /// </summary>
        private UnitSystems SelectUnits()
        {
            string[] choices = new string[]
            {
                "Metric Units",
                "Imperial Units"
            };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
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
            Console.WriteLine(" Enter your height to the nearest feet and inches ");
            Console.WriteLine();

            Feet = (int)ConsoleHelper.InputNumber("\n Enter your height in feet > ");
            Inches = (int)ConsoleHelper.InputNumber(" Enter your height in inches > ");

            Console.WriteLine();
            Console.Write(" Enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            Stones = (int)ConsoleHelper.InputNumber(" Enter your weight in stones > ");
            Pounds = (int)ConsoleHelper.InputNumber(" Enter your weight in pounds > ");
        }

        /// <summary>
        /// Input the users height in metres and
        /// their weight in kilograms
        /// </summary>
        private void InputMetricDetails()
        {
            Centimetres = (int)ConsoleHelper.InputNumber(
                " \n Enter your height in centimetres > ");

            metres = (double)Centimetres / 100;

            Kilograms = ConsoleHelper.InputNumber(
                " Enter your weight in kilograms > ");
        }

        /// <summary>
        /// Output the users BMI and their weight
        /// category from underweight to obese.
        /// </summary>
        public string GetHealthMessage()
        {
            StringBuilder message = new StringBuilder("\n");

            if (Index < Underweight)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are underweight! ");
            }
            else if (Index <= NormalRange)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are in the normal range! ");

            }
            else if (Index <= Overweight)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are overweight! ");

            }
            else if (Index <= ObeseLevel1)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are obese class I ");

            }
            else if (Index <= ObeseLevel2)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are obese class II ");

            }
            else if (Index <= ObeseLevel3)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $"You are obese class III ");

            }

            return message.ToString();
        }

        /// <summary>
        /// Output a message for BAME users who are
        /// at higher risk
        /// </summary>
        public string GetBameMessage()
        {
            StringBuilder message = new StringBuilder("\n");
            message.Append(" If you are Black, Asian or other minority");
            message.Append("\n ethnic groups, you have a higher risk");
            message.Append("\n");
            message.Append("\n Adults 23.0 or more are at increased risk");
            message.Append("\n Adults 27.5 or more are at high risk");
            message.Append("\n");

            return message.ToString();
        }

    }
}

