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
    public class PizzaController : Controller
    {
        public IActionResult Index() 
        {
            ViewData["Title"] = "Pizzas list";
            List<Pizza> pizzas = StaticDB.pizzas;

            List<PizzaViewModel> PizzaListViewModels = pizzas.Select(x => PizzaMapper.PizzaToPizzaViewModel(x)).ToList();

            return View(PizzaListViewModels); 
        }

        [Route("seePizzas")] 
        public IActionResult RedirectToPizzas() 
        {
            return RedirectToAction("Index"); 
        }

        public IActionResult Details(int? id) 
        
        {
            ViewData["Title"] = "Pizza details";

            Pizza foundPizza = StaticDB.pizzas.FirstOrDefault(x => x.Id == id);

            if (foundPizza == null)
            {
                //return new EmptyResult();
                return View("ResourceNotFound");
            }

            else
            {
                // ViewBag.Pizza = foundPizza; WITH VIEWBAG
            PizzaViewModel pizzaDetailsViewModels = PizzaMapper.PizzaToPizzaViewModel(foundPizza);
                return View(pizzaDetailsViewModels); //return View() WITH VIEWBAG
            }
        }

    }
}
