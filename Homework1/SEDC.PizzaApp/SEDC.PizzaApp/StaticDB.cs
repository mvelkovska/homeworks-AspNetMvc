using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp
{
    public static class StaticDB
    {


        public static List<Pizza> pizzas = new List<Pizza>
        {
             new Pizza
            {
                Id = 1,
                typeOfPizza=TypeOfPizzas.Capri,
                Price = 350,
                IsOnPromotion = true
            },

             new Pizza
            {
                Id = 2,
               typeOfPizza=TypeOfPizzas.Margarita,
                Price = 380,
                IsOnPromotion = false
            },
              new Pizza
            {
                 Id = 3,
                typeOfPizza=TypeOfPizzas.Pepperoni,
                Price = 390,
                IsOnPromotion = true
            },

               new Pizza
            {
                 Id = 4,
                typeOfPizza=TypeOfPizzas.Vegetarian,
                Price = 200,
                IsOnPromotion = true
            }
        }; 


        public static List<Order> orders = new List<Order>
        {
            new Order
            {
                 Id = 1,
                 Customer="Jane Doe",
                 Address="Address1",
                 typeOfPizza=TypeOfPizzas.Capri


    },
             new Order
            {
                 Id = 2,
                 Customer="Jana Aneva",
                 Address="Address2",
                 typeOfPizza=TypeOfPizzas.Vegetarian
                // ListOfPizzas = new List<Pizza>() { pizzas[0], pizzas[2] }

    }
        };




    /*    static StaticDB() //the constructor
        {
            orders[0].ListOfPizzas = new List<Pizza>() { pizzas[0], pizzas[2] };
        }*/


    } //static class zagrada
}//namespace zagrada
