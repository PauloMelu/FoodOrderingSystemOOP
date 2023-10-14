using System;
using EmployeeModel;
namespace PayrollSystemManager
{
	public abstract class Employee
	{
		public abstract int ComputeSalary(PayrollSystemModel model);
	}
}

