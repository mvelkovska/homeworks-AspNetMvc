using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enum;
using SEDC.PizzaApp.Models.ViewModels;
using SEDC.PizzaApp.Models.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {

        [Route("Orders")]
        public IActionResult Index()
        {
            List<Order> ordersDB = StaticDB.orders;

            ViewData["SomeMessage"] = $"The number of orders is: {ordersDB.Count()}";
            ViewData["Title"] = "Orders list";  
            ViewData["Date"] = DateTime.Now.ToShortDateString();


            List<OrderListViewModel> ordersListViewModels = ordersDB.Select(x => OrderMapper.OrderToOrderListViewModels(x)).ToList();
            return View(ordersListViewModels);
        }
        //===============================

        [Route("[Controller]/[Action]/{id?}")] // OR [Route("Order/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            ViewData["Title"] = "Order details";
            ViewBag.Message = "You are on order details page";
            ViewBag.TheUser = StaticDB.users.First();
            Order foundOrder = StaticDB.orders.FirstOrDefault(x => x.Id == id);

            OrderDetailsViewModel ordersDetailsViewModels = OrderMapper.OrderToOrderDetailsViewModels(foundOrder);

            if (foundOrder == null)
            {
                return new EmptyResult();
            }

            else
            {
                return View(ordersDetailsViewModels);
            }
        }

        //===============================

        [Route("[Controller]/jsonData")] //[Route("Order/jsonData")]
        public IActionResult ReturnJson()
        {
            Order order = new Order()
            {
                Id = 1,
                User = StaticDB.users.First(),
                Address = "Some address",
                Pizza = StaticDB.pizzas.Last(),
                PaymentMethod = PaymentMethod.Cash
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
