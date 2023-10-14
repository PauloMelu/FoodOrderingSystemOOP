using System;
namespace EmployeeModel
{
	public class PayrollSystemModel
	{
		public int RegularRate { get; set; }
		public int PartTimeRate { get; set; }
		public int ContractPrice { get; set; }
        public int ContractDuration { get; set; }
        public int DaysWorked { get; set; }
        public int HoursWorked { get; set; }
    }
}

