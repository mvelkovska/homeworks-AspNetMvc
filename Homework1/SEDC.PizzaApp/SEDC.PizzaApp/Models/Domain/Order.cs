using SEDC.PizzaApp.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }

        //  public List<Pizza> ListOfPizzas { get; set; } //one or more pizzas

        public TypeOfPizzas typeOfPizza { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }

        
    }
}
