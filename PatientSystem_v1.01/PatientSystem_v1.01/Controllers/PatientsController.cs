using PatientSystem_v1._01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatientSystem_v1._01.Controllers
{
    public class PatientsController : Controller
    {
        PatientBussiness Pb = new PatientBussiness();
        public ActionResult Index()
        {
            return View(Pb.View());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Patient patient)
        {
            Pb.Add(patient);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int Id)
        {
            return View(Pb.Find(Id));
        }
        public ActionResult Edit(int Id)
        {
            return View(Pb.Find(Id));
        }
        [HttpPost]
        public ActionResult Edit(Patient patient)
        {
            Pb.Edit(patient);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? Id)
        {
            return View(Pb.Find(Id));
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            Patient patient = Pb.Find(Id);
            Pb.Delete(patient);
            return RedirectToAction("Index");
        }
    }
}