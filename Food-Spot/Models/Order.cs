using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_Spot.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string PizzaName { get; set; }
        public string SaladName { get; set; }
        public string PastaName { get; set; }


        public Pizza Pizza { get; set; }
        public Salad Salad { get; set; }
        public Pasta Pasta { get; set; }
    }
}