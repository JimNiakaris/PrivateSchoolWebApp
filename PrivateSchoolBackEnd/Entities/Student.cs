namespace PrivateSchoolBackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    { 
        public Student()
        {
            Courses = new HashSet<Course>();
        }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        public decimal? Tuitions { get; set; }
        public int StudentID { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

    }
}
