using EmployeeManagemet.Models;
using EmployeeManagment.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IDepartmentService departmentService { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();

        //public string DepartmenId { get; set; }


        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            Departments = (await departmentService.GetDepartments()).ToList();
            //DepartmenId = Employee.DepartmentId.ToString();
            //DepartmenId = Guid.NewGuid(); // add this 



        }

    }
}
