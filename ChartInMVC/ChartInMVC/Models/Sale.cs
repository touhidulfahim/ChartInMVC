using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChartInMVC.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }

        
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        [ForeignKey("StateId")]
        public virtual State State { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}