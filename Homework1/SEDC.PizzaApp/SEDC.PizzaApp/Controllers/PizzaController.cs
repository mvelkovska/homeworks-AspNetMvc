using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index() // /pizza/index OR /pizza
        {
            List<Pizza> pizzas = StaticDB.pizzas;
            return View(pizzas); //prakjame lista od pici
        }

        [Route("seePizzas")] //seepizzas
        public IActionResult RedirectToPizzas() 
        {
            return RedirectToAction("Index"); //vo istiot kontroler
        }

        public IActionResult Details(int? id)
        {
            Pizza foundPizza = StaticDB.pizzas.FirstOrDefault(x => x.Id == id);//da ja najdeme picata so soodvetnoto ID

            if (foundPizza == null)
            {
                return new EmptyResult();
            }

            else
            {
                return View(foundPizza);
            }
        }

    }
}
