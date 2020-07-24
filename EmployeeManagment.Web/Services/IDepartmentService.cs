using EmployeeManagemet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagment.Web.Services
{
    public interface IDepartmentService
    {
        Task<Department> GetDepartment(int id);
        Task<IEnumerable<Department>> GetDepartments();
    }
}