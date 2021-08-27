using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enum;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class OrderMapper
    {
        public static OrderListViewModel OrderToOrderListViewModels(Order order)
        {
            return new OrderListViewModel
            {
                FullName = $"{order.User.FirstName} {order.User.LastName}",
                PizzaName = $"{order.Pizza.Name}"
            };
        }

        public static OrderDetailsViewModel OrderToOrderDetailsViewModels(Order order)
        {
            
            return new OrderDetailsViewModel
            {
                Address=$"{order.User.Address}",
                PizzaName = $"{order.Pizza.Name}",
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                PizzaPrice = order.Pizza.IsOnPromotion ? 300 : order.Pizza.Price // discount calculation
                
            };
        }
    }
}
