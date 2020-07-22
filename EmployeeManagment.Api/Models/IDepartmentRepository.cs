using EmployeeManagemet.Models;
using System.Collections.Generic;

namespace EmployeeManagment.Api.Models
{
    public interface IDepartmentRepository
    {
        Department GetDepartment(int departmentId);
        IEnumerable<Department> GetDepartments();
    }
}