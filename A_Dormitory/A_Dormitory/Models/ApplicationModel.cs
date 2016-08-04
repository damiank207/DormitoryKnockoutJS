using A_Dormitory.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A_Dormitory.Models
{
    public class ApplicationModel : MyBaseModel
    {

        public ApplicationModel(ApplicationJsonModel jsonData)
        {
            DormitoryContext db = new DormitoryContext();
            Id = Guid.NewGuid();
            var dateArray = jsonData.DateOfBirth.Split('-').Select(x => Convert.ToInt32(x)).ToArray();
            DateOfBirth = new DateTime(dateArray[0], dateArray[1], dateArray[2]);
            FirstName = jsonData.FirstName;
            Surname = jsonData.Surname;
            AcademicYearOfStudies = Convert.ToUInt32(jsonData.AcademicYearOfStudies);
            CitizenshipDictModelId = db.CitizenshipDict.First(x => x.Code == jsonData.CitizenshipDictCode).Id;

            CourseDictModelId = db.CourseDict.First(x => x.Code == jsonData.CourseDictKey).Id;
            GenderDictModelId = db.GenderDict.First(x => x.Code == jsonData.GenderDictKey).Id;
            EmailAdress = jsonData.EmailAdress;
            CollegeId = jsonData.CollegeId;
            IndexNumber = jsonData.IndexNumber;
            CourseYearDictModelId = db.CourseYearDict.First(x => x.Code == jsonData.CourseYearDictKey).Id;
            NumberOfBedDictModelId = db.NumberOfBedDict.First(x => x.Code == jsonData.NumberOfBedDictKey).Id;
            db.Application.Add(this);
            db.SaveChanges();
            db.Dispose();
        }

        

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
