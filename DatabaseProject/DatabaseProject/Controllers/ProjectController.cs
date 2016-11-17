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
            return View("FindReSultEm"); //ยังไม่ได้ทำ
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
            return View("EditDetialRes");//ยัง
        }
        public ActionResult Timetable_em()
        {
            return View("Timetable_em");//ยัง
        }
        public ActionResult AddLeaveOnEm()
        {
            return View("AddLeaveOnEm");//ยัง
        }
        public ActionResult LeaveOn()
        {
            return View("LeaveOn");//ยัง
        }
        public ActionResult AllowLeaveOn()
        {
            return View("AllowLeaveOn");//ยัง
        }
        public ActionResult FitnessAmount()
        {
            return View("FitnessAmount");//ยัง
        }
        public ActionResult CarID()
        {
            return View("CarID");//ยัง
        }
        public ActionResult AddCarID()
        {
            return View("AddCarID");//ยัง
        }
        public ActionResult LateEm()
        {
            return View("LateEm");//ยัง
        }
       
    }
}