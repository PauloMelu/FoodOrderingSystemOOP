using FoodOrderingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFoodOrderingSystem
{
    public interface IMenuManager
    {
        public void AddMenu(FoodOrderingSystemModel menuItem);
        public void RemoveMenu(FoodOrderingSystemModel menuItem);
    }
}