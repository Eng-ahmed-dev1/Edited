using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmed.Model
{
    public class std_Man_sys : DbContext
    {
        public std_Man_sys() { }
        public std_Man_sys(DbContextOptions<std_Man_sys> options) : base (options){ }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Std_Crs_Deg> Std_Crs_Deg { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=COM172-LAB3\\SQLEXPRESS;Initial Catalog=std_Man_sys;Integrated Security=True;Trust Server Certificate=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Std_Crs_Deg>().HasKey(t => new { t.Std_id, t.Crs_id });
        }
    }
    
}
