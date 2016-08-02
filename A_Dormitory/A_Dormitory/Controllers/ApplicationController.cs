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

        // GET: ApplicationModels/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationModel applicationModel = db.Application.Find(id);
            if (applicationModel == null)
            {
                return HttpNotFound();
            }
            return View(applicationModel);
        }

        // GET: ApplicationModels/Create
        public ActionResult Create()
        {
            ViewBag.CitizenshipDictModelId = new SelectList(db.CitizenshipDict, "Id", "Name");
            ViewBag.CourseDictModelId = new SelectList(db.CourseDict, "Id", "Name");
            ViewBag.CourseYearDictModelId = new SelectList(db.CourseYearDict, "Id", "Name");
            ViewBag.GenderDictModelId = new SelectList(db.GenderDict, "Id", "Name");
            return View();
        }

        // POST: ApplicationModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,Surname,AcademicYearOfStudies,CitizenshipDictModelId,DateOfBirth,CourseDictModelId,GenderDictModelId,EmailAdress,CollegeId,IndexNumber,CourseYearDictModelId,DateCreate")] ApplicationModel applicationModel)
        {
            if (ModelState.IsValid)
            {
                applicationModel.Id = Guid.NewGuid();
                db.Application.Add(applicationModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CitizenshipDictModelId = new SelectList(db.CitizenshipDict, "Id", "Name", applicationModel.CitizenshipDictModelId);
            ViewBag.CourseDictModelId = new SelectList(db.CourseDict, "Id", "Name", applicationModel.CourseDictModelId);
            ViewBag.CourseYearDictModelId = new SelectList(db.CourseYearDict, "Id", "Name", applicationModel.CourseYearDictModelId);
            ViewBag.GenderDictModelId = new SelectList(db.GenderDict, "Id", "Name", applicationModel.GenderDictModelId);
            return View(applicationModel);
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
