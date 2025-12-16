using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using HR.Core.DTO;
using HR.Core.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace HR.Core.Mapping
{
    public class Mapping : Profile
    {
        public Mapping()
        {

          

            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Department, DepartmentDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<EmploymentContract, EmploymentContractDTO>().ReverseMap();
            CreateMap<GroupRol, GroupRolDTO>().ReverseMap();
            CreateMap<Job, JobDTO>().ReverseMap();
            CreateMap<LeaveBalance, LeaveBalanceDTO>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDTO>().ReverseMap();
            CreateMap<PayRollDeduction, PayRollDeductionDTO>().ReverseMap();
            

                    }
                }


                public class Mapping<T, X> : Profile
        {
            public Mapping()
            {
                CreateMap<T, X>();
                /*CreateMap<T, X>()
                    .ForMember(dest => dest.Orderdetails, opt => opt.MapFrom(src => src.Orderdetails));

                CreateMap<OrderDetails, orderDetailsDTO>()
                    .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId.ToString())); // Assuming ProductId should be a string in DTO*/
            }
            ///


        }
    }
