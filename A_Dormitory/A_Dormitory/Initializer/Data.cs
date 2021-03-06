﻿using A_Dormitory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A_Dormitory.Initializer
{
    public static class Data
    {
        public static List<NumberOfBedDictModel> NumberOfBed()
        {
            var list = new List<NumberOfBedDictModel>()
            {
                new NumberOfBedDictModel() {Name ="Single room",Code="single" },
                new NumberOfBedDictModel() {Name ="Double room",Code="double" }
            };
            return list;
        }
        public static List<GenderDictModel> Gender()
        {
            var gender = new List<GenderDictModel>()
            {
                new GenderDictModel() {Name = "Male",Code="sex_m" },
                new GenderDictModel() {Name = "Female",Code="sex_f" }
            };
            return gender;
        }
        public static List<CourseYearDictModel> CourseYear()
        {
            var courseYear = new List<CourseYearDictModel>()
            {
                new CourseYearDictModel() {Name = "2014/2015", Code = "2014/2015" },
                new CourseYearDictModel() {Name = "2015/2016", Code = "2016/2015" },
                new CourseYearDictModel() {Name = "2016/2017", Code = "2016/2017" }
            };
            return courseYear;
        }
        public static List<CourseDictModel> Courses()
        {
            var courses = new List<CourseDictModel>()
            {
                new CourseDictModel() {Name = "4 years",Code="4year" },
                new CourseDictModel() {Name = "5 years",Code="5year" },
                new CourseDictModel() {Name = "6 years",Code="6year" }
            };
            return courses;
        }
        public static List<CitizenshipDictModel> Citizenships()
        {
            var citizenships = new List<CitizenshipDictModel>()
            {
                new CitizenshipDictModel { Name = "Afghanistan", Code="AFG"},
                new CitizenshipDictModel { Name = "Albania", Code="ALB"},
                new CitizenshipDictModel { Name = "Algeria", Code="DZA"},
                new CitizenshipDictModel { Name = "Andorra", Code="AND"},
                new CitizenshipDictModel { Name = "Angola", Code="AGO"},
                new CitizenshipDictModel { Name = "Antigua and Barbuda", Code="ATG"},
                new CitizenshipDictModel { Name = "Argentina", Code="ARG"},
                new CitizenshipDictModel { Name = "Armenia", Code="ARM"},
                new CitizenshipDictModel { Name = "Australia", Code="AUS"},
                new CitizenshipDictModel { Name = "Austria", Code="AUT"},
                new CitizenshipDictModel { Name = "Azerbaijan", Code="AZE"},
                new CitizenshipDictModel { Name = "Bahamas", Code="BHS"},
                new CitizenshipDictModel { Name = "Bahrain", Code="BHR"},
                new CitizenshipDictModel { Name = "Bangladesh", Code="BGD"},
                new CitizenshipDictModel { Name = "Barbados", Code="BRB"},
                new CitizenshipDictModel { Name = "Belarus", Code="BLR"},
                new CitizenshipDictModel { Name = "Belgium", Code="BEL"},
                new CitizenshipDictModel { Name = "Belize", Code="BLZ"},
                new CitizenshipDictModel { Name = "Benin", Code="BEN"},
                new CitizenshipDictModel { Name = "Bhutan", Code="BTN"},
                new CitizenshipDictModel { Name = "Bolivia, Plurinational State of", Code="BOL"},
                new CitizenshipDictModel { Name = "Bosnia and Herzegovina", Code="BIH"},
                new CitizenshipDictModel { Name = "Botswana", Code="BWA"},
                new CitizenshipDictModel { Name = "Brazil", Code="BRA"},
                new CitizenshipDictModel { Name = "Brunei Darussalam", Code="BRN"},
                new CitizenshipDictModel { Name = "Bulgaria", Code="BGR"},
                new CitizenshipDictModel { Name = "Burkina Faso", Code="BFA"},
                new CitizenshipDictModel { Name = "Burundi", Code="BDI"},
                new CitizenshipDictModel { Name = "Cambodia", Code="KHM"},
                new CitizenshipDictModel { Name = "Cameroon", Code="CMR"},
                new CitizenshipDictModel { Name = "Canada", Code="CAN"},
                new CitizenshipDictModel { Name = "Cabo Verde", Code="CPV"},
                new CitizenshipDictModel { Name = "Central African Republic", Code="CAF"},
                new CitizenshipDictModel { Name = "Chad", Code="TCD"},
                new CitizenshipDictModel { Name = "Chile", Code="CHL"},
                new CitizenshipDictModel { Name = "China", Code="CHN"},
                new CitizenshipDictModel { Name = "Colombia", Code="COL"},
                new CitizenshipDictModel { Name = "Comoros", Code="COM"},
                new CitizenshipDictModel { Name = "Congo", Code="COG"},
                new CitizenshipDictModel { Name = "Congo, the Democratic Republic of the", Code="COD"},
                new CitizenshipDictModel { Name = "Costa Rica", Code="CRI"},
                new CitizenshipDictModel { Name = "Côte d'Ivoire", Code="CIV"},
                new CitizenshipDictModel { Name = "Croatia", Code="HRV"},
                new CitizenshipDictModel { Name = "Cuba", Code="CUB"},
                new CitizenshipDictModel { Name = "Cyprus", Code="CYP"},
                new CitizenshipDictModel { Name = "Czech Republic", Code="CZE"},
                new CitizenshipDictModel { Name = "Denmark", Code="DNK"},
                new CitizenshipDictModel { Name = "Djibouti", Code="DJI"},
                new CitizenshipDictModel { Name = "Dominica", Code="DMA"},
                new CitizenshipDictModel { Name = "Dominican Republic", Code="DOM"},
                new CitizenshipDictModel { Name = "Ecuador", Code="ECU"},
                new CitizenshipDictModel { Name = "Egypt", Code="EGY"},
                new CitizenshipDictModel { Name = "El Salvador", Code="SLV"},
                new CitizenshipDictModel { Name = "Equatorial Guinea", Code="GNQ"},
                new CitizenshipDictModel { Name = "Eritrea", Code="ERI"},
                new CitizenshipDictModel { Name = "Estonia", Code="EST"},
                new CitizenshipDictModel { Name = "Ethiopia", Code="ETH"},
                new CitizenshipDictModel { Name = "Fiji", Code="FJI"},
                new CitizenshipDictModel { Name = "Finland", Code="FIN"},
                new CitizenshipDictModel { Name = "France", Code="FRA"},
                new CitizenshipDictModel { Name = "Gabon", Code="GAB"},
                new CitizenshipDictModel { Name = "Gambia", Code="GMB"},
                new CitizenshipDictModel { Name = "Georgia", Code="GEO"},
                new CitizenshipDictModel { Name = "Germany", Code="DEU"},
                new CitizenshipDictModel { Name = "Ghana", Code="GHA"},
                new CitizenshipDictModel { Name = "Greece", Code="GRC"},
                new CitizenshipDictModel { Name = "Grenada", Code="GRD"},
                new CitizenshipDictModel { Name = "Guatemala", Code="GTM"},
                new CitizenshipDictModel { Name = "Guinea", Code="GIN"},
                new CitizenshipDictModel { Name = "Guinea-Bissau", Code="GNB"},
                new CitizenshipDictModel { Name = "Guyana", Code="GUY"},
                new CitizenshipDictModel { Name = "Haiti", Code="HTI"},
                new CitizenshipDictModel { Name = "Holy See (Vatican City State)", Code="VAT"},
                new CitizenshipDictModel { Name = "Honduras", Code="HND"},
                new CitizenshipDictModel { Name = "Hungary", Code="HUN"},
                new CitizenshipDictModel { Name = "Iceland", Code="ISL"},
                new CitizenshipDictModel { Name = "India", Code="IND"},
                new CitizenshipDictModel { Name = "Indonesia", Code="IDN"},
                new CitizenshipDictModel { Name = "Iran, Islamic Republic of", Code="IRN"},
                new CitizenshipDictModel { Name = "Iraq", Code="IRQ"},
                new CitizenshipDictModel { Name = "Ireland", Code="IRL"},
                new CitizenshipDictModel { Name = "Israel", Code="ISR"},
                new CitizenshipDictModel { Name = "Italy", Code="ITA"},
                new CitizenshipDictModel { Name = "Jamaica", Code="JAM"},
                new CitizenshipDictModel { Name = "Japan", Code="JPN"},
                new CitizenshipDictModel { Name = "Jordan", Code="JOR"},
                new CitizenshipDictModel { Name = "Kazakhstan", Code="KAZ"},
                new CitizenshipDictModel { Name = "Kenya", Code="KEN"},
                new CitizenshipDictModel { Name = "Kiribati", Code="KIR"},
                new CitizenshipDictModel { Name = "Korea, Republic of", Code="KOR"},
                new CitizenshipDictModel { Name = "Kuwait", Code="KWT"},
                new CitizenshipDictModel { Name = "Kyrgyzstan", Code="KGZ"},
                new CitizenshipDictModel { Name = "Lao People's Democratic Republic", Code="LAO"},
                new CitizenshipDictModel { Name = "Latvia", Code="LVA"},
                new CitizenshipDictModel { Name = "Lebanon", Code="LBN"},
                new CitizenshipDictModel { Name = "Lesotho", Code="LSO"},
                new CitizenshipDictModel { Name = "Liberia", Code="LBR"},
                new CitizenshipDictModel { Name = "Libya", Code="LBY"},
                new CitizenshipDictModel { Name = "Liechtenstein", Code="LIE"},
                new CitizenshipDictModel { Name = "Lithuania", Code="LTU"},
                new CitizenshipDictModel { Name = "Luxembourg", Code="LUX"},
                new CitizenshipDictModel { Name = "Macedonia, The Former Yugoslav Republic of", Code="MKD"},
                new CitizenshipDictModel { Name = "Madagascar", Code="MDG"},
                new CitizenshipDictModel { Name = "Malawi", Code="MWI"},
                new CitizenshipDictModel { Name = "Malaysia", Code="MYS"},
                new CitizenshipDictModel { Name = "Maldives", Code="MDV"},
                new CitizenshipDictModel { Name = "Mali", Code="MLI"},
                new CitizenshipDictModel { Name = "Malta", Code="MLT"},
                new CitizenshipDictModel { Name = "Marshall Islands", Code="MHL"},
                new CitizenshipDictModel { Name = "Mauritania", Code="MRT"},
                new CitizenshipDictModel { Name = "Mauritius", Code="MUS"},
                new CitizenshipDictModel { Name = "Mexico", Code="MEX"},
                new CitizenshipDictModel { Name = "Micronesia, Federated States of", Code="FSM"},
                new CitizenshipDictModel { Name = "Moldova, Republic of", Code="MDA"},
                new CitizenshipDictModel { Name = "Monaco", Code="MCO"},
                new CitizenshipDictModel { Name = "Mongolia", Code="MNG"},
                new CitizenshipDictModel { Name = "Montenegro", Code="MNE"},
                new CitizenshipDictModel { Name = "Morocco", Code="MAR"},
                new CitizenshipDictModel { Name = "Mozambique", Code="MOZ"},
                new CitizenshipDictModel { Name = "Myanmar", Code="MMR"},
                new CitizenshipDictModel { Name = "Namibia", Code="NAM"},
                new CitizenshipDictModel { Name = "Nauru", Code="NRU"},
                new CitizenshipDictModel { Name = "Nepal", Code="NPL"},
                new CitizenshipDictModel { Name = "Netherlands", Code="NLD"},
                new CitizenshipDictModel { Name = "New Zealand", Code="NZL"},
                new CitizenshipDictModel { Name = "Nicaragua", Code="NIC"},
                new CitizenshipDictModel { Name = "Niger", Code="NER"},
                new CitizenshipDictModel { Name = "Nigeria", Code="NGA"},
                new CitizenshipDictModel { Name = "Norway", Code="NOR"},
                new CitizenshipDictModel { Name = "Oman", Code="OMN"},
                new CitizenshipDictModel { Name = "Pakistan", Code="PAK"},
                new CitizenshipDictModel { Name = "Palau", Code="PLW"},
                new CitizenshipDictModel { Name = "Palestine, State of", Code="PSE"},
                new CitizenshipDictModel { Name = "Panama", Code="PAN"},
                new CitizenshipDictModel { Name = "Papua New Guinea", Code="PNG"},
                new CitizenshipDictModel { Name = "Paraguay", Code="PRY"},
                new CitizenshipDictModel { Name = "Peru", Code="PER"},
                new CitizenshipDictModel { Name = "Philippines", Code="PHL"},
                new CitizenshipDictModel { Name = "Poland", Code="POL"},
                new CitizenshipDictModel { Name = "Portugal", Code="PRT"},
                new CitizenshipDictModel { Name = "Qatar", Code="QAT"},
                new CitizenshipDictModel { Name = "Romania", Code="ROU"},
                new CitizenshipDictModel { Name = "Russian Federation", Code="RUS"},
                new CitizenshipDictModel { Name = "Rwanda", Code="RWA"},
                new CitizenshipDictModel { Name = "Saint Kitts and Nevis", Code="KNA"},
                new CitizenshipDictModel { Name = "Saint Lucia", Code="LCA"},
                new CitizenshipDictModel { Name = "Saint Vincent and the Grenadines", Code="VCT"},
                new CitizenshipDictModel { Name = "Samoa", Code="WSM"},
                new CitizenshipDictModel { Name = "San Marino", Code="SMR"},
                new CitizenshipDictModel { Name = "Sao Tome and Principe", Code="STP"},
                new CitizenshipDictModel { Name = "Saudi Arabia", Code="SAU"},
                new CitizenshipDictModel { Name = "Senegal", Code="SEN"},
                new CitizenshipDictModel { Name = "Serbia", Code="SRB"},
                new CitizenshipDictModel { Name = "Seychelles", Code="SYC"},
                new CitizenshipDictModel { Name = "Sierra Leone", Code="SLE"},
                new CitizenshipDictModel { Name = "Singapore", Code="SGP"},
                new CitizenshipDictModel { Name = "Slovakia", Code="SVK"},
                new CitizenshipDictModel { Name = "Slovenia", Code="SVN"},
                new CitizenshipDictModel { Name = "Solomon Islands", Code="SLB"},
                new CitizenshipDictModel { Name = "Somalia", Code="SOM"},
                new CitizenshipDictModel { Name = "South Africa", Code="ZAF"},
                new CitizenshipDictModel { Name = "South Sudan", Code="SSD"},
                new CitizenshipDictModel { Name = "Spain", Code="ESP"},
                new CitizenshipDictModel { Name = "Sri Lanka", Code="LKA"},
                new CitizenshipDictModel { Name = "Sudan", Code="SDN"},
                new CitizenshipDictModel { Name = "Suriname", Code="SUR"},
                new CitizenshipDictModel { Name = "Swaziland", Code="SWZ"},
                new CitizenshipDictModel { Name = "Sweden", Code="SWE"},
                new CitizenshipDictModel { Name = "Switzerland", Code="CHE"},
                new CitizenshipDictModel { Name = "Syrian Arab Republic", Code="SYR"},
                new CitizenshipDictModel { Name = "Taiwan, Province of China", Code="TWN"},
                new CitizenshipDictModel { Name = "Tajikistan", Code="TJK"},
                new CitizenshipDictModel { Name = "Tanzania, United Republic of", Code="TZA"},
                new CitizenshipDictModel { Name = "Thailand", Code="THA"},
                new CitizenshipDictModel { Name = "Timor-Leste", Code="TLS"},
                new CitizenshipDictModel { Name = "Togo", Code="TGO"},
                new CitizenshipDictModel { Name = "Tonga", Code="TON"},
                new CitizenshipDictModel { Name = "Trinidad and Tobago", Code="TTO"},
                new CitizenshipDictModel { Name = "Tunisia", Code="TUN"},
                new CitizenshipDictModel { Name = "Turkey", Code="TUR"},
                new CitizenshipDictModel { Name = "Turkmenistan", Code="TKM"},
                new CitizenshipDictModel { Name = "Tuvalu", Code="TUV"},
                new CitizenshipDictModel { Name = "Uganda", Code="UGA"},
                new CitizenshipDictModel { Name = "Ukraine", Code="UKR"},
                new CitizenshipDictModel { Name = "United Arab Emirates", Code="ARE"},
                new CitizenshipDictModel { Name = "United Kingdom", Code="GBR"},
                new CitizenshipDictModel { Name = "United States", Code="USA"},
                new CitizenshipDictModel { Name = "Uruguay", Code="URY"},
                new CitizenshipDictModel { Name = "Uzbekistan", Code="UZB"},
                new CitizenshipDictModel { Name = "Vanuatu", Code="VUT"},
                new CitizenshipDictModel { Name = "Venezuela, Bolivarian Republic of", Code="VEN"},
                new CitizenshipDictModel { Name = "Viet Nam", Code="VNM"},
                new CitizenshipDictModel { Name = "Western Sahara", Code="ESH"},
                new CitizenshipDictModel { Name = "Yemen", Code="YEM"},
                new CitizenshipDictModel { Name = "Zambia", Code="ZMB"},
                new CitizenshipDictModel { Name = "Zimbabwe", Code="ZWE"}
            };
            return citizenships;
        }
    }
}