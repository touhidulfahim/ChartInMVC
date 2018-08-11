using ChartInMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChartInMVC.Repository
{
    public class ChartCon 
    {
        //public void ProductWiseSales(out string MobileCountList, out string ProductList)
        //{
        //    using (ApplicationDbContext con = new ApplicationDbContext()
        //    {
        //        var productdata = con.Query<ProductViewModel>("Usp_GetTotalsalesProductwise", null, null, true, 0, CommandType.StoredProcedure).ToList();

        //        var MobileSalesCounts = (from temp in con.Product
        //                                 select temp.MobileSalesCount).ToList();

        //        var ProductNames = (from temp in con.Product
        //                            select temp.ProductName).ToList();

        //        MobileCountList = string.Join(",", MobileSalesCounts);
        //        ProductList = string.Join(",", ProductNames);
        //    }
        //}

        //public void StateWiseSales(out string MobileCountList, out string StateNameList)
        //{
            
        //}
    }
}