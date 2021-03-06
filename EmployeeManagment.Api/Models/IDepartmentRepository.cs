﻿using EmployeeManagemet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagment.Api.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
        
    }
}