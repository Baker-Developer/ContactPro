using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ContactPro.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(50, ErrorMessage = "The {0} Must Be Atleast {2} And A Max Of {1} Character Long. ", MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} Must Be Atleast {2} And A Max Of {1} Character Long. ", MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [NotMapped]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }

        public virtual ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    }
}
