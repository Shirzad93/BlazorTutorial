using EmployeeManagemet.Models;
using EmployeeManagemet.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Web.Models
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [MinLength(2, ErrorMessage = "must be atlease 2 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [MinLength(2, ErrorMessage = "Must be atleast 2 letters")]
        public String LastName { get; set; }

        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "bako.com")]
        public string Email { get; set; }
        [CompareProperty("Email",ErrorMessage = "Email and compare email does not match")]
        public string ConfirmEmail { get; set; }

        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        [ValidateComplexType]
        public Department Department { get; set; } = new Department();
    }
}
