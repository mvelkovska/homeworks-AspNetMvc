using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Enum;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        public TypeOfPizzas typeOfPizza { get; set; }
        public double Price { get; set; }
        public bool IsOnPromotion { get; set; }
    }
}
