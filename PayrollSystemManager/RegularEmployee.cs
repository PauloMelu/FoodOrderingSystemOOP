using System;
using EmployeeModel;

namespace PayrollSystemManager
{
    public class RegularEmployee : Employee
	{
        public RegularEmployee()
		{
		}

		public override int ComputeSalary(PayrollSystemModel model)
		{
			return ( model.RegularRate / 20 ) * model.DaysWorked;
		}
    }
}

