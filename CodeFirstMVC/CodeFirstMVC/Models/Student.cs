using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstMVC.Models
{
    public class Student
    {
        [Key]
        public int ID{ get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}