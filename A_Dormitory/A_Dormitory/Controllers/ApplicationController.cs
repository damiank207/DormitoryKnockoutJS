using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using A_Dormitory.DAL;
using A_Dormitory.Models;

namespace A_Dormitory.Controllers
{
    public class ApplicationController : Controller
    {
        private DormitoryContext db = new DormitoryContext();

        // GET: ApplicationModels
        public ActionResult Index()
        {
            //var application = db.Application.Include(a => a.CitizenshipDictModel).Include(a => a.CourseDictModel).Include(a => a.CourseYearDictModel).Include(a => a.GenderDictModel);
            return View();
        }
        // GET: ApplicationModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public void Create(ApplicationJsonModel jsonData)
        {
            var application = new ApplicationModel(jsonData);
            //if (ModelState.IsValid)
            //{
            //    applicationModel.Id = Guid.NewGuid();
            //    db.Application.Add(applicationModel);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}


            return;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
