using System;
using EmployeeManager.PayrollSystemBusLogic.Context.DBModel;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.PayrollSystemBusLogic.Context
{
	public class PayrollSystemDBContext:DbContext
	{
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User Id=postgres;Password=PuDorder5yst;Server=db.hcpvfrlmvwkbrsrumhks.supabase.co;Port=5432;Database=postgres");
        }
    }
}

