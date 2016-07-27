using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A_Dormitory.Models
{
    public class ApplicationModel : MyBaseModel
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int AcademicYearOfStudies { get; set; }
        public Guid CitizenshipDictModelId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid CourseDictModelId { get; set; }
        public Guid GenderDictModelId { get; set; }
        public string EmailAdress { get; set; }
        public string CollegeId { get; set; }
        public string IndexNumber { get; set; }
        public Guid CourseYearDictModelId { get; set; }

        public virtual CitizenshipDictModel CitizenshipDictModel { get; set; }
        public virtual CourseDictModel CourseDictModel { get; set; }
        public virtual GenderDictModel GenderDictModel { get; set; }
        public CourseYearDictModel CourseYearDictModel { get; set; }

    }
}