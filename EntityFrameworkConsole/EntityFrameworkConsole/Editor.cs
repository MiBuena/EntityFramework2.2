using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkConsole
{
    public class Editor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<ArticleEditor> ArticlesEditors { get; set; } = new List<ArticleEditor>();
    }
}
