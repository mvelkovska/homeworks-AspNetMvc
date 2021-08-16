using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Enum;



namespace SEDC.PizzaApp.Models.ViewModels
{
    public class PizzaViewModel
    {
        public int Id { get; set; }

        public string PizzaName { get; set; }

        public double PizzaPrice { get; set; }

        public PizzaSize PizzaSize { get; set; }

        public bool HasExtras { get; set; }

    }
}
