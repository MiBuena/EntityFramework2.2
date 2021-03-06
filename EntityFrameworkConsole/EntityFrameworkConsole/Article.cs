﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkConsole
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public List<ArticleEditor> ArticlesEditors { get; set; } = new List<ArticleEditor>();
    }
}
