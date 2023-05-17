using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eArchive.Models
{
    public class Authors_Researches
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int ResearchId { get; set; }
        public Research Research { get; set; }
    }
}
