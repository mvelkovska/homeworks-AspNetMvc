using SEDC.PizzaApp.Models.ViewModels;
using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel TheUserViewModel(this User user)
        {
            return new UserViewModel
            {
                FirstName=user.FirstName,
                LastName=user.LastName
            };
        }
    }
}
