using System;
using EmployeeManager.PayrollSystemBusLogic.Context;
using EmployeeManager.PayrollSystemBusLogic.Context.DBModel;
using PayrollSystemManager;
using EmployeeModel;

namespace PayrollSystemBusLogic
{
	public class PayrollManager
	{

        private readonly PayrollSystemDBContext _context;

        public PayrollManager()
		{
			_context = new PayrollSystemDBContext();

        }


        public int GetGrossIncome(PayrollSystemModel model)
		{
			RegularEmployee regularEmployee = new RegularEmployee();
			int regularIncome = regularEmployee.ComputeSalary(model);

			PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
			int partTimeIncome = partTimeEmployee.ComputeSalary(model);

            ContractualEmployee contractualEmployee = new ContractualEmployee();
			int contractualIncome = contractualEmployee.ComputeSalary(model);

			return partTimeIncome + regularIncome + contractualIncome;
        }


		public PayrollSystemModel GetData(int id)
		{
			EmployeeDetails deets = new EmployeeDetails();
			deets = _context.EmployeeDetails.Where(emp => emp.employeeID == id).First();

			PayrollSystemModel model = new PayrollSystemModel();
            model.RegularRate = deets.RegularRate;
            model.PartTimeRate = deets.PartTimeRate;
            model.ContractPrice = deets.ContractPrice;
            model.ContractDuration = deets.ContractDuration;
            model.DaysWorked = 0;
            model.HoursWorked = 0;

			return model;
        }

	}
}

