using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.PayrollSystemBusLogic.Context.DBModel
{
	public class EmployeeDetails
	{
		[Key]
		public int employeeID { get; set; }
        public int RegularRate { get; set; }
        public int PartTimeRate { get; set; }
        public int ContractPrice { get; set; }
        public int ContractDuration { get; set; }
    }
}

