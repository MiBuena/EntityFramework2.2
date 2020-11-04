using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkConsole
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
