using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// 
    /// </summary>
    public class StudentGrades
    {
        // Constants (Grade Boundaries)

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        // Properties
        public string [] Students { get; set; }
        
        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        // Attributes

        /// <summary>
        /// 
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
                    {
                "Daniel","Dylan", "Eric",
                "Georgia", "Hasan","Hamza",
                "Jack", "Liam", "Shan",
                "Shamial"
                    };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// 
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else return Grades.D;

        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateGradeProfile()
        {
            throw new NotImplementedException();
        }
    }

}
