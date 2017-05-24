using Microsoft.EntityFrameworkCore;
using NewReviewWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewReviewWebsite.Data
{
    public class ReviewContext:DbContext 
    {
        public ReviewContext(DbContextOptions<ReviewContext> options) : base(options) {

        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Album>().ToTable("Album");
            builder.Entity<Genre>().ToTable("Genre");
            builder.Entity<Artist>().ToTable("Artist");
        }
    }
}
