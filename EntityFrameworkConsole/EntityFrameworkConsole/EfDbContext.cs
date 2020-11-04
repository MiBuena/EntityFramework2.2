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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Article>()
                .HasOne(x => x.Author)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.AuthorId);

            modelBuilder
                .Entity<ArticleEditor>()
                .HasKey(x => new { x.ArticleId, x.EditorId });

            modelBuilder
                .Entity<ArticleEditor>()
                .HasOne(x => x.Article)
                .WithMany(x => x.ArticlesEditors)
                .HasForeignKey(x => x.ArticleId);

            modelBuilder
                .Entity<ArticleEditor>()
                .HasOne(x => x.Editor)
                .WithMany(x => x.ArticlesEditors)
                .HasForeignKey(x => x.EditorId);
        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}
