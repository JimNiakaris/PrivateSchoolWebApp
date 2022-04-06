namespace PrivateSchoolBackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Courses")]
    public class Course

    {
        public Course()
        {
            Assignments = new HashSet<Assignment>();
            Students = new HashSet<Student>();
            Trainers = new HashSet<Trainer>();
        }

        private DateTime _EndDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime EndDate { get { return _EndDate; } set { if (value > StartDate) { _EndDate = value; } else _EndDate = StartDate.AddMonths(2); } }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID { get; set; }
        public string CreatedBy { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }

    }


}
