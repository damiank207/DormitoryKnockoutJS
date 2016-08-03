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
    }
}