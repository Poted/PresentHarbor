using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PresentHarbor.Models;

namespace PresentHarbor.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Present> Present { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Category>()
            //.Property(c => c.Presents)
            //.HasConversion(
            //    v => JsonConvert.SerializeObject(v),
            //    v => JsonConvert.DeserializeObject<List<Present>>(v)
            //);


            //modelBuilder.Entity<Present>()
            //    .HasKey(p => new { p.ID, p.CategoryID });

            //modelBuilder.Entity<Category>()
            //    .HasKey(c => new { c.Presents, c.CategoryID });

            //modelBuilder.Entity<Photo>()
            //    .HasKey(p => new { p.Presents, p.PhotoID });

        }

    }
}
