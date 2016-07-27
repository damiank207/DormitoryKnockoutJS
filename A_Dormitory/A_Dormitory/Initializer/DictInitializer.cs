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

            var citizenships = Data.Citizenships();
            citizenships.ForEach(c => context.CitizenshipDict.Add(c));
            context.SaveChanges();
        }
    }
}