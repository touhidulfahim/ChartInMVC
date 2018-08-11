using ChartInMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartInMVC.Controllers
{
    public class DashbordController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult Index()
        {
            //var getStateWiseSale = db.Sale.Aggregate();
                    
            return View();           
        }

        
        public ContentResult GetData()
        {

            List<SaleViewModel> SL = new List<SaleViewModel>();
            var res = db.Sale.ToList();

            foreach (Sale sales in res)
            {
                SaleViewModel sl = new SaleViewModel();
                sl.Name = sales.Product.ProductName;
                //sl.QTY = sales.Quantity;                
                SL.Add(sl);
                
            }

            return Content(JsonConvert.SerializeObject(SL), "application/json");
        }
        
    }
}