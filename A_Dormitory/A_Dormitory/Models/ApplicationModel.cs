using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A_Dormitory.Models
{
    public class ApplicationModel : MyBaseModel
    {
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Academic year of studies")]
        public uint AcademicYearOfStudies { get; set; }
        [Required]
        [Display(Name = "Citizenship")]
        public Guid CitizenshipDictModelId { get; set; }
        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Display(Name = "Course")]
        public Guid CourseDictModelId { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public Guid GenderDictModelId { get; set; }
        [Required]
        [Display(Name = "Email adress")]
        public string EmailAdress { get; set; }
        [Required]
        [Display(Name = "College ID")]
        public string CollegeId { get; set; }
        [Required]
        [Display(Name = "Index number")]
        public string IndexNumber { get; set; }
        [Required]
        [Display(Name = "Course year")]
        public Guid CourseYearDictModelId { get; set; }
        [Required]
        [Display(Name = "Course year")]
        public Guid NumberOfBedDictModelId { get; set; }

        public virtual CitizenshipDictModel CitizenshipDictModel { get; set; }
        public virtual CourseDictModel CourseDictModel { get; set; }
        public virtual GenderDictModel GenderDictModel { get; set; }
        public virtual CourseYearDictModel CourseYearDictModel { get; set; }
        public virtual NumberOfBedDictModel NumberOfBedDictModel { get; set; }

    }
}