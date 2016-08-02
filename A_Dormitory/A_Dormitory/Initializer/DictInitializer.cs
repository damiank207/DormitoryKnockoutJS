using A_Dormitory.DAL;
using A_Dormitory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace A_Dormitory.Initializer
{
    public class DictInitializer : DropCreateDatabaseIfModelChanges<DormitoryContext>
    {
        protected override void Seed(DormitoryContext context)
        {
            var courses = Data.Courses();
            var courseYear = Data.CourseYear();
            var gender = Data.Gender();
            var numberOfBed = Data.NumberOfBed();
            var citizenships = Data.Citizenships();
            citizenships.ForEach(c => context.CitizenshipDict.Add(c));
            courses.ForEach(c => context.CourseDict.Add(c));
            courseYear.ForEach(c => context.CourseYearDict.Add(c));
            gender.ForEach(c => context.GenderDict.Add(c));
            numberOfBed.ForEach(c => context.NumberOfBedDict.Add(c));
            context.SaveChanges();
        }
    }
}