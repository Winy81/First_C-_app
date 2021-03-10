using System;
using Microsoft.EntityFrameworkCore;
namespace first_project.Gateways.Context
{
    public class StreakDbContext : DbContext
    {
        //DB referenc
        //public DbSet<BankingServiceRegister> BankingServiceRegisters { get; set; }

        //Table name
        public DbSet<Accounts> Accounts { get; set; }

        public StreakDbContext()
        {
        }


        public StreakDbContext(DbContextOptions<StreakDbContext> options) : base(options)
        {
        }

    }
}
