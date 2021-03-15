using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.App05;

using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Student Name 24/12/2020
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BmiCalculator calculator = new BmiCalculator();

        private static StudentGrades grades = new StudentGrades();

        private static NetworkApp app04 = new NetworkApp();

        private static GameView app05 = new GameView();

        public static BmiCalculator BMI
        {
            get => default;
        }

        public static DistanceConverter DistanceConverter
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputHeading("BNU CO453 2020-2021!");

            string[] choices = { "Distance Converter", "BMI Calculator",
                                 "Student Marks", "Social Network",
                                 "Rock-Paper-Scissors Game"};

            int choiceNo = ConsoleHelper.SelectChoice(choices);


            if (choiceNo == 1)
            {
                converter.ConvertDistance();
            }
            else if (choiceNo == 2)
            {
                calculator.CalculateIndex();
            }
            else if (choiceNo == 3)
            {
                grades.DisplayMenu();
            }
            else if(choiceNo == 4)
            {
                app04.DisplayMenu();
            }
            else if (choiceNo == 5)
            {
                app05.Play();
            }
            else Console.WriteLine("Invalid Choice !");

        }
    }
}
