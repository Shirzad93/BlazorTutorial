using EmployeeManagemet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Api.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Shiroo1",
                LastName = "Bakoo1",
                Email = "Shiroo1@mail.com",
                DateOfBirth = new DateTime(1993, 2, 16),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "Images/e1.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Shiroo2",
                LastName = "Bakoo2",
                Email = "Shiroo2@mail.com",
                DateOfBirth = new DateTime(1993, 2, 16),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "Images/e2.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Shiroo3",
                LastName = "Bakoo3",
                Email = "Shiroo3@mail.com",
                DateOfBirth = new DateTime(1993, 2, 16),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "Images/e3.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Shiroo4",
                LastName = "Bakoo4",
                Email = "Shiroo4@mail.com",
                DateOfBirth = new DateTime(1993, 2, 16),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "Images/e4.jpg"
            });
        }

    }
}
