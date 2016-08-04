using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;

namespace A_Dormitory.Models
{
    public class ApplicationJsonModel
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int AcademicYearOfStudies { get; set; }
        public string CitizenshipDictCode { get; set; }
        public string DateOfBirth { get; set; }
        public string CourseDictKey { get; set; }
        public string GenderDictKey { get; set; }
        public string EmailAdress { get; set; }
        public string CollegeId { get; set; }
        public string IndexNumber { get; set; }
        public string CourseYearDictKey { get; set; }
        public string NumberOfBedDictKey { get; set; }
        private bool IsValidEmail()
        {
            return Regex.IsMatch(EmailAdress,@"/\S+@\S+\.\S+/");

        }
        public bool Validate()
        {
            if (String.IsNullOrEmpty(FirstName) || 
                String.IsNullOrEmpty(Surname) ||
                AcademicYearOfStudies <=0 || 
                String.IsNullOrEmpty(CitizenshipDictCode) || 
                String.IsNullOrEmpty(DateOfBirth) ||
                DateOfBirth.Split('-').ToArray().Count() != 3 ||
                String.IsNullOrEmpty(CourseDictKey)||
                String.IsNullOrEmpty(GenderDictKey)||
                String.IsNullOrEmpty(EmailAdress)||
                IsValidEmail() ||
                String.IsNullOrEmpty(CollegeId)||
                String.IsNullOrEmpty(IndexNumber)||
                String.IsNullOrEmpty(CourseYearDictKey)||
                String.IsNullOrEmpty(NumberOfBedDictKey))
            {
                return false;
            }
            return true;
        }
    }
}