using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A_Dormitory.Models
{
    public class ApplicationJsonModel
    {
        public string FirstName { get; set; }
        public string  Surname { get; set; }
        public int AcademicYearOfStudies { get; set; }
        public string  CitizenshipDictCode { get; set; }
        public string DateOfBirth { get; set; }
        public string CourseDictKey { get; set; }
        public string GenderDictKey { get; set; }
        public string EmailAdress { get; set; }
        public string CollegeId { get; set; }
        public string IndexNumber { get; set; }
        public string CourseYearDictKey { get; set; }
        public string NumberOfBedDictKey { get; set; }
    }
}