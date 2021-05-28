using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTransaction.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(
                e =>
                {
                    e.HasKey(e => new { e.EmpId });
                    e.Property(e => e.EmpName).IsRequired();
                });
                
            modelBuilder.Entity<Salary>(
                s =>
                {
                    s.Property(s => s.GrossSalary).HasColumnType("decimal(18,2");
                    s.HasKey(s => new { s.SalaryId });
                });
                
        }

    }
}
