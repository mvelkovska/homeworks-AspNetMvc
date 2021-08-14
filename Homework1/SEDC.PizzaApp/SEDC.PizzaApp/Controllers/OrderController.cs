using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        
       [Route("Orders")] // /orders
        public IActionResult Index() //list of orders
        {
            List<Order> orders = StaticDB.orders;
            return View(orders); //prakjame lista od naracki
        }
        //===============================

        [Route("[Controller]/[Action]/{id?}")] // OR [Route("Order/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            Order foundOrder = StaticDB.orders.FirstOrDefault(x => x.Id == id);

            if (foundOrder == null)
            {
                return new EmptyResult();
            }

            else
            {
                return View(foundOrder);
            }
        }

        //===============================

       [Route("[Controller]/jsonData")] //[Route("Order/jsonData")]
        public IActionResult ReturnJson()
        {
            Order order = new Order()
            {
                Id = 1,
                Customer = "Jane",
                Address = "Some address",
                typeOfPizza = TypeOfPizzas.Capri

            };
            return new JsonResult(order);
        }

        //===============================
        public IActionResult RedirectToHome()
        {
            return RedirectToAction("Index", "Home");
        }






    }
}
