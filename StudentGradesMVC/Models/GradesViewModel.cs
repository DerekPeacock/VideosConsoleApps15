using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGradesMVC.Models
{
    public class GradesViewModel
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public double Average { get; set; }

        public int[] GradeProfile { get; set; }
    }
}
