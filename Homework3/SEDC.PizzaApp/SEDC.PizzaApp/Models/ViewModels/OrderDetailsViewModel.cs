using SEDC.PizzaApp.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public string PizzaName { get; set; } 

        public string UserFullName { get; set; } 

        public PaymentMethod PaymentMethod { get; set; }

        public double PizzaPrice { get; set; }

        public string Address { get; set; }
    }
}
