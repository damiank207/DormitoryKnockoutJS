using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using A_Dormitory.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_Dormitory.DAL
{
    public class DormitoryContext : System.Data.Entity.DbContext
    {
        public DormitoryContext() : base("DormitoryContext")
        {

        }
        public static DormitoryContext Create()
        {
            return new DormitoryContext();
        }
        public DbSet<ApplicationModel> Application { get; set; }
        public DbSet<CitizenshipDictModel> CitizenshipDict { get; set; }
        public DbSet<CourseDictModel> CourseDict { get; set; }
        public DbSet<CourseYearDictModel> CourseYearDict { get; set; }
        public DbSet<GenderDictModel> GenderDict { get; set; }
        public DbSet<NumberOfBedDictModel> NumberOfBedDict { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationModel>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CitizenshipDictModel>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CourseDictModel>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CourseYearDictModel>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<GenderDictModel>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<NumberOfBedDictModel>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}