using IFoodOrderingSystem;
using FoodOrderingSystem.Model;
using FoodOrderingSystemBusLogic;

Console.WriteLine("Hello World");

FoodOrderingSystemModel menuItem = new();
IMenuManager menuManager = new MenuManager();

Console.Write("Enter Food Name: ");
string foodNameInput = Console.ReadLine();

Console.Write("Enter Price: ");
int priceInput = Convert.ToInt32(Console.ReadLine());

menuItem.FoodName = foodNameInput;
menuItem.Price = priceInput;

menuManager.SetMenu();
