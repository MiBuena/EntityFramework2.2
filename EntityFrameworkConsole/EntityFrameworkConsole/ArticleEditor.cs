using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkConsole
{
    public class ArticleEditor
    {
        public int ArticleId { get; set; }

        public Article Article { get; set; }

        public int EditorId { get; set; }

        public Editor Editor { get; set; }
    }
}
