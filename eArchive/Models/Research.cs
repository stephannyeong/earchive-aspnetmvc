using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eArchive.Models
{
    public class Research
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Abstract")]
        public string Abstract { get; set; }

        [Display(Name = "Keywords")]
        public string Keywords { get; set; }

        [Display(Name = "Publish Date")]
        public string PublishYear { get; set; }

        //Relationships
       public List<Authors_Researches> Authors_Researches { get; set; }
    }
}
