using Assignment_REST_API.Data.Configurations;
using Assignment_REST_API.Model.REST;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_REST_API.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
          
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9KTAG16\SQLEXPRESS;Database=AssignmentDb;User Id=sa;Password=1qaz2wsx@;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AmountConfiguration());
            modelBuilder.ApplyConfiguration(new SapConfiguration());
            //modelBuilder.ApplyConfiguration(new SiteConfiguration());
        }

       // public DbSet<Amount> Amounts { get; set; }
        public DbSet<SAP> Saps { get; set; }
        //public DbSet<Site> Sites { get; set; }
    }
}
