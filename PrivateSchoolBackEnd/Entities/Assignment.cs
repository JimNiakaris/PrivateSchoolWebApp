namespace PrivateSchoolBackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Assignment
    {
        public Assignment()
        {
            Courses = new HashSet<Course>();
        }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SubmitDate { get; set; }
        public int? OralMark { get; set; }
        public int? TotalMark { get; set; }
        public int AssignmentID { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        
    }


}
