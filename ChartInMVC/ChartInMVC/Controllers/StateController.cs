using ChartInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartInMVC.Controllers
{
    public class StateController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult ViewState()
        {
            return View(db.State.OrderBy(a=>a.StateName).ToList());
        }

        [HttpGet]
        public ActionResult AddState()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddState(State state)
        {
            if (ModelState.IsValid)
            {
                db.State.Add(state);
                db.SaveChanges();
                return RedirectToAction("ViewState");
            }
            return View(state);
        }
    }
}