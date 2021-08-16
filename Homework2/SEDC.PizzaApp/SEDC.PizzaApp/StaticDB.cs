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
                Name="Capri",
                Price = 350,
                IsOnPromotion = true,
                PizzaSize=PizzaSize.Normal,
                HasExtras=true
            },

             new Pizza
            {
                Id = 2,
                Name="Margarita",
                Price = 380,
                IsOnPromotion = false,
                PizzaSize=PizzaSize.Small,
                HasExtras=false
            },
              new Pizza
            {
                 Id = 3,
                Name="Vegetarian",
                Price = 390,
                IsOnPromotion = true,
                PizzaSize=PizzaSize.Normal,
                HasExtras=true
            },

               new Pizza
            {
                 Id = 4,
                Name="Pepperoni",
                Price = 200,
                IsOnPromotion = false,
                PizzaSize=PizzaSize.Small,
                HasExtras=false
            }
        };


        public static List<User> users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "Andrej",
                LastName = "Angelov",
                Address = "Adresa1"
            },
            new User
            {
                Id = 2,
                FirstName = "Ana",
                LastName = "Aneva",
                Address = "Adresa2"
            }
        };




        public static List<Order> orders = new List<Order>
        {
            new Order
            {
                 Id = 1,
                 User=users.First(),
                 Address="Address1",
                 Pizza=pizzas.First(),
                 PaymentMethod=PaymentMethod.Card


    },
             new Order
            {
                 Id = 2,
                  User=users.Last(),
                 Address="Address2",
                 Pizza=pizzas.Last(),
                 PaymentMethod=PaymentMethod.Card

                // ListOfPizzas = new List<Pizza>() { pizzas[0], pizzas[2] }

    }
        };




    /*    static StaticDB() //the constructor
        {
            orders[0].ListOfPizzas = new List<Pizza>() { pizzas[0], pizzas[2] };
        }*/


    } //static class zagrada
}//namespace zagrada
