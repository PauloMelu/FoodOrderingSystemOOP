using System;
using EmployeeModel;
namespace PayrollSystemManager
{
	public class ContractualEmployee : Employee
	{
		public ContractualEmployee()
		{
		}

        public override int ComputeSalary(PayrollSystemModel model)
        {
            return model.ContractPrice/model.ContractDuration;
        }
    }
}

