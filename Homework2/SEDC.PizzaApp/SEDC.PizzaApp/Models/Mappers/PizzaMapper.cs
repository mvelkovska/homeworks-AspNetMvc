using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enum;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel PizzaToPizzaViewModel(Pizza pizza)
        {
            return new PizzaViewModel
            {
                PizzaName = pizza.Name,
                PizzaPrice = pizza.HasExtras ? pizza.Price+=10 : pizza.Price,
                PizzaSize = pizza.PizzaSize,
                HasExtras=pizza.HasExtras
                
            };
        }
    }
}
