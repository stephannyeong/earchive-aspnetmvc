using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eArchive.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = " ")]
        [Required(ErrorMessage = "Field should not be blank.")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Author")]
        [Required(ErrorMessage = "Field should not be blank.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters long.")]
        public string AuthorName { get; set; }

        [Display(Name = "Affiliation")]
        [Required(ErrorMessage = "Field should not be blank.")]
        public string Affiliation { get; set; }

        //Relationships
        public List<Authors_Researches> Authors_Researches { get; set; }
    }
}
