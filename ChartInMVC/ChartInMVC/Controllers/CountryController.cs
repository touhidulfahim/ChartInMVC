using ChartInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartInMVC.Controllers
{
    public class CountryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult ViewCountry()
        {
            return View(db.Country.OrderBy(d => d.CountryName).ToList());
        }

        [HttpGet]
        public ActionResult AddCountry()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCountry(Country country)
        {
            if (ModelState.IsValid)
            {
                db.Country.Add(country);
                db.SaveChanges();
                return RedirectToAction("ViewCountry");
            }

            return View(country);
        }
    }
}