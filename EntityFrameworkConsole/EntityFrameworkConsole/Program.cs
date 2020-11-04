using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var context = new EfDbContext())
            {

                var a = context.Articles.Find(2);

                a.Author = new Author()
                {
                    Name = "mmmm"
                };


                context.SaveChanges();
            }
        }
    }
}
