using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace EntityFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var context = new EfDbContext())
            {

                //We add a new editor to an article

                var newEditor = context.Articles.Find(2);

                var editor1 = new Editor()
                {
                    Name = "aaaa"
                };

                newEditor.ArticlesEditors.Add(new ArticleEditor()
                {
                    Editor = editor1
                });

                var editor2 = new Editor()
                {
                    Name = "aaaa"
                };


                newEditor.ArticlesEditors.Add(new ArticleEditor()
                {
                    Editor = editor2
                });

                context.SaveChanges();



                //We include related entities

                //var m = context.Articles
                //    .Include(x => x.ArticlesEditors)
                //    .ThenInclude(x => x.Editor);


                //Remove all relationships

                //var a = context.Articles
                //    .Include(x => x.ArticlesEditors)
                //    .FirstOrDefault();

                //a.ArticlesEditors.Clear();


                //context.SaveChanges();


                //Remove specific relationship

                var relationshipToRemove = context
                    .ArticleEditor
                    .FirstOrDefault(x => x.EditorId == 5 && x.ArticleId == 2);

                context.ArticleEditor.Remove(relationshipToRemove);

                context.SaveChanges();

            }
        }
    }
}
