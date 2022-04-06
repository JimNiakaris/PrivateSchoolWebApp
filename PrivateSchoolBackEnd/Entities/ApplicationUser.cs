using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PrivateSchoolBackEnd.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy" , ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }



    }
}
