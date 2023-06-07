﻿using HomeTaskPustokReletion.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeTaskPustokReletion.DAL
{
    public class PustokDbContext:DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext>options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<BookTag> BookTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookTag>().HasKey(x => new { x.TagId, x.BookId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
