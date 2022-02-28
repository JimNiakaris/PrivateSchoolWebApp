namespace PrivateSchoolBackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Trainer
    {
        public Trainer()
        {
            Courses = new HashSet<Course>();
        }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        public int TrainerID { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}
