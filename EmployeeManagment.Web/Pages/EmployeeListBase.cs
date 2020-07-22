using EmployeeManagemet.Models;
using EmployeeManagment.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService{ get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        //private void LoadEmployees()
        //{
        //    System.Threading.Thread.Sleep(3000);

        //    Employee e1 = new Employee
        //    {
        //        EmployeeId = 1,
        //        FirstName = "Shiroo1",
        //        LastName = "Bakoo1",
        //        Email = "Shiroo1@mail.com",
        //        DateOfBirth = new DateTime(1993, 2, 16),
        //        Gender = Gender.Male,
        //        DepartmentId = 1,
        //        PhotoPath = "Images/e1.jpg"
        //    };

        //    Employee e2 = new Employee
        //    {
        //        EmployeeId = 2,
        //        FirstName = "Shiroo2",
        //        LastName = "Bakoo2",
        //        Email = "Shiroo2@mail.com",
        //        DateOfBirth = new DateTime(1993, 2, 16),
        //        Gender = Gender.Male,
        //        DepartmentId = 2,
        //        PhotoPath = "Images/e2.jpg"
        //    };

        //    Employee e3 = new Employee
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Shiroo3",
        //        LastName = "Bakoo3",
        //        Email = "Shiroo3@mail.com",
        //        DateOfBirth = new DateTime(1993, 2, 16),
        //        Gender = Gender.Male,
        //        DepartmentId = 3,
        //        PhotoPath = "Images/e3.jpg"
        //    };

        //    Employee e4 = new Employee
        //    {
        //        EmployeeId = 4,
        //        FirstName = "Shiroo4",
        //        LastName = "Bakoo4",
        //        Email = "Shiroo4@mail.com",
        //        DateOfBirth = new DateTime(1993, 2, 16),
        //        Gender = Gender.Male,
        //        DepartmentId = 4,
        //        PhotoPath = "Images/e4.jpg"
        //    };

        //    Employees = new List<Employee> { e1, e2, e3, e4 };
        //}

    }
}
