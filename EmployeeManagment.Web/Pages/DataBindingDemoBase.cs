using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Web.Pages
{
    public class DataBindingDemoBase : ComponentBase
    {
        protected string Name { get; set; } = "Tom";
        protected string Gender { get; set; } = "Male";
        protected string color { get; set; } = "background-color:white";

        [StringLength(50,ErrorMessage = "max length is 50 charaters")]
        protected string Description { get; set; } = string.Empty;

    }
}
