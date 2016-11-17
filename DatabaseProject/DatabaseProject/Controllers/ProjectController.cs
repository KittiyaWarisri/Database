using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DetailEm()
        {
            return View("DetailEm");
        }
        public ActionResult FindReSultEm()
        {
            return View("FindReSultEm");
        }
        public ActionResult DelEm()
        {
            return View("DelEm");
        }
        public ActionResult AddEm()
        {
            return View("AddEm");
        }
        public ActionResult DetialRes_Own()
        {
            return View("DetialRes_Own");
        }
        public ActionResult AddRes()
        {
            return View("AddRes");
        }
        public ActionResult DelRes()
        {
            return View("DelRes");
        }
        public ActionResult DetialRes_Rcp()
        {
            return View("DetialRes_Rcp");
        }
        public ActionResult EditDetialRes()
        {
            return View("EditDetialRes");
        }
        public ActionResult Timetable_em()
        {
            return View("Timetable_em");
        }
        public ActionResult AddLeaveOnEm()
        {
            return View("AddLeaveOnEm");
        }
        public ActionResult LeaveOn()
        {
            return View("LeaveOn");
        }
        public ActionResult AllowLeaveOn()
        {
            return View("AllowLeaveOn");
        }
        public ActionResult FitnessAmount()
        {
            return View("FitnessAmount");
        }
        public ActionResult CarID()
        {
            return View("CarID");
        }
        public ActionResult AddCarID()
        {
            return View("AddCarID");
        }
        public ActionResult LateEm()
        {
            return View("LateEm");
        }

    }
}