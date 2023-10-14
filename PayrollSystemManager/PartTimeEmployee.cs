using System;
using EmployeeModel;

namespace PayrollSystemManager
{
	public class PartTimeEmployee : Employee
	{
		public PartTimeEmployee()
		{
		}

        public override int ComputeSalary(PayrollSystemModel model)
        {
            return model.HoursWorked * model.PartTimeRate;
        }
    }
}

