// See https://aka.ms/new-console-template for more information

using PayrollSystemBusLogic;
using EmployeeModel;
Console.WriteLine("Hello, World!");

Console.Write("Enter Employee ID: ");
int id = Convert.ToInt32(Console.ReadLine());

PayrollManager manager = new PayrollManager();
PayrollSystemModel model = new PayrollSystemModel();
model = manager.GetData(id);



if (model.ContractPrice != 0)
{

}


if(model.RegularRate != 0)
{
    Console.Write("How many days worked: ");
    model.DaysWorked = Convert.ToInt32(Console.ReadLine());
}


if(model.PartTimeRate != 0)
{
    Console.Write("How many hours worked: ");
    model.HoursWorked = Convert.ToInt32(Console.ReadLine());
}


Console.Write("Total Gross Income: ");

int grossIncome = manager.GetGrossIncome(model);
Console.WriteLine(grossIncome);
Console.Read();