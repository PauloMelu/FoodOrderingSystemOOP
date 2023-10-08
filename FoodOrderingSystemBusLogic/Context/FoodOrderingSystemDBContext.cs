using System;
using FoodOrderingSystemBusLogic.Context.DBModel;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingSystemBusLogic.Context
{
	public class FoodOrderingSystemDBContext:DbContext
	{
        public DbSet<MenuDetails> MenuDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User Id=postgres;Password=PuDorder5yst;Server=db.hcpvfrlmvwkbrsrumhks.supabase.co;Port=5432;Database=postgres");
        }
	}
}

