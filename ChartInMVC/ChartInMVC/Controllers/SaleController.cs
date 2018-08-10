using ChartInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace ChartInMVC.Controllers
{
    public class SaleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult ViewSale()
        {                       
            var sale = db.Sale.Include(s => s.Product).Include(s => s.State).Include(s => s.Country);
            return View(sale.ToList());
        }

        [HttpGet]
        public ActionResult SaleProduct()
        {
            ViewBag.ProductId = new SelectList(db.Product, "ProductId", "ProductName");
            ViewBag.StateId = new SelectList(db.State, "StateId", "StateName");
            ViewBag.CountryId = new SelectList(db.Country, "CountryId", "CountryName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaleProduct(Sale sales)
        {
            if (ModelState.IsValid)
            {
                db.Sale.Add(sales);
                db.SaveChanges();
                return RedirectToAction("ViewSale");
            }
            ViewBag.ProductId = new SelectList(db.Product, "ProductId", "ProductName", sales.ProductId);
            ViewBag.StateId = new SelectList(db.State, "StateId", "StateName", sales.StateId);
            ViewBag.CountryId = new SelectList(db.Country, "CountryId", "CountryName", sales.CountryId);
            return View(sales);
        }

    }
}