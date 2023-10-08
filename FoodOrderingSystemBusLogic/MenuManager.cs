using FoodOrderingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFoodOrderingSystem;
using FoodOrderingSystemBusLogic.Context;
using FoodOrderingSystemBusLogic.Context.DBModel;

namespace FoodOrderingSystemBusLogic
{
    public class MenuManager : IMenuManager
    {
        private readonly FoodOrderingSystemDBContext _context;

        public MenuManager()
        {
            _context = new FoodOrderingSystemDBContext();
        }

        public void AddMenu(FoodOrderingSystemModel menuItem)
        {
                MenuDetails _menu = new();

                _menu.FoodName = menuItem.FoodName;
                _menu.Price = menuItem.Price;

                _context.MenuDetails.Add(_menu);
                _context.SaveChanges();
        }
        public void RemoveMenu(FoodOrderingSystemModel menuItem)
        {
            Console.WriteLine("Removed");
        }

        public void GetOrder(FoodOrderingSystemModel menuItem)
        {

        }

    }
}