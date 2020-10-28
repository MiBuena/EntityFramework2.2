using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkConsole
{
    public class EfDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EFGPD5V\\SQLEXPRESS;Database=EfDbContext;Integrated Security=True;");

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Article> Articles { get; set; }

    }
}
