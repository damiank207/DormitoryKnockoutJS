using A_Dormitory.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_Dormitory.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        private DormitoryContext db = new DormitoryContext();

        public JsonResult Citizenship()
        {
            return Json(db.CitizenshipDict, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Course()
        {
            return Json(db.CourseDict, JsonRequestBehavior.AllowGet);
        }
        public JsonResult CourseYear()
        {
            return Json(db.CourseYearDict, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Gender()
        {
            return Json(db.GenderDict, JsonRequestBehavior.AllowGet);
        }
        public JsonResult NumberOfBed()
        {
            return Json(db.NumberOfBedDict, JsonRequestBehavior.AllowGet);
        }
    }
}