using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Derek's version 0.6
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");

            FromUnit = SelectUnit(" Select the from distance unit > ");
            ToUnit   = SelectUnit(" Select the to distance unit > ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            FromDistance = ConsoleHelper.InputNumber($" Enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateDistance()
        {
            if(FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if(FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string[] choices =
            {
                FEET,
                METRES,
                MILES
            };

            Console.WriteLine(prompt);
            Console.WriteLine();

            int choiceNo = ConsoleHelper.SelectChoice(choices);

            string unit = choices[choiceNo - 1];
            return unit;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance}  {FromUnit}" +
                $" is {ToDistance} {ToUnit}!\n");
        }
    }
}
