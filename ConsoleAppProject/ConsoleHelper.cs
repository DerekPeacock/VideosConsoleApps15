using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{

    public static class ConsoleHelper
    {

        /// <summary>
        /// This method displays a list of numbered choices to the
        /// user, and they can select and the choice number is
        /// returned.
        /// </summary>
        public static int SelectChoice(string[] choices)
        {
            // Display all the choices

            DisplayChoices(choices);

            // Get the user's choice

            int choiceNo = (int)InputNumber("\n Please enter your choice > ");
            return choiceNo;
        }

        /// <summary>
        /// 
        /// </summary>
        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"    {choiceNo}.  {choice}");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public static double InputNumber(string prompt)
        {

            Console.Write(prompt);
            string value = Console.ReadLine();
            double number = Convert.ToDouble(value);

            return number;
        }


        /// <summary>
        /// Output a short description of the application
        /// and the name of the author and a prompt to
        /// inform the use which units are being converted
        /// </summary>
        public static void OutputHeading(string title)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine($"         {title}          ");
            Console.WriteLine("          by Derek Peacock           ");
            Console.WriteLine("-------------------------------------\n");
        }
    }
}
