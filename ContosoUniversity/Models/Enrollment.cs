using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //Can be null = ?
        public Grade? Grade { get; set; }


        //Navigation Property from the FK's Course and Student
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}