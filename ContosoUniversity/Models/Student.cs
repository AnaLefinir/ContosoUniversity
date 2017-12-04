using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //EF va a determinar como PK al campo que tenga nombre ID o <classname>ID
        public int ID { get; set; }

        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        //Navigation Property: Forma de referencial la relacion 1-N de Student y Enrollment.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}