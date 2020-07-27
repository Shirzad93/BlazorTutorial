using AutoMapper;
using EmployeeManagemet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Web.Models
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            //in part 39
            CreateMap<Employee, EditEmployeeModel>().ForMember(dest => dest.ConfirmEmail, opt => opt.MapFrom(src => src.Email));
            CreateMap<EditEmployeeModel, Employee>();
        }
    }
}
