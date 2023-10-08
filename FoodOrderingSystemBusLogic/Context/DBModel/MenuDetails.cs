using System;
using System.ComponentModel.DataAnnotations;

namespace FoodOrderingSystemBusLogic.Context.DBModel
{
	public class MenuDetails
	{
		[Key]
        public string FoodName { get; internal set; }
		public int Price { get; internal set; }

    }
}

