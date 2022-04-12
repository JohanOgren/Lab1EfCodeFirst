using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lab1EfCodeFirst.Models
{
    public class EmployeeRegister:DbContext
    {
        public DbSet<Employee> Employess { get; set; }
        public DbSet<LeaveForm> LeaveForms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=EmployeeForm; Integrated Security=SSPI;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                 .ToTable("Employee");
            modelBuilder.Entity<Employee>()
                .Property(s => s.FirstName)
                .IsRequired(false);
            modelBuilder.Entity<Employee>()
                .Property(s => s.LastName)
                .HasDefaultValue(true);


            modelBuilder.Entity<Employee>()
                .HasData(
                new Employee
                {
                    EmployeeID = 1,
                    FirstName = "Tony",
                    LastName = "Stark"

                },
                new Employee
                {
                    EmployeeID = 2,
                    FirstName = "Steven",
                    LastName = "Rogers"

                },
                new Employee
                {
                    EmployeeID = 3,
                    FirstName = "Clinton",
                    LastName = "Barton"

                },
                new Employee
                {
                    EmployeeID = 4,
                    FirstName = "Wanda",
                    LastName = "Maximoff"

                }
                );
        }
    }
}
