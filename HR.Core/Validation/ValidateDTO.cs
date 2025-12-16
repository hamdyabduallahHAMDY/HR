using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.Core.DTO;
using HR.Core.Global;
using HR.Core.HTTP;
using HR.Core.Models;
using HR.Core.Services;
namespace HR.Core.Validation
{
    public static class ValidateDTO
    {
       

        public async static Task<MainResponse<EmployeeDTO>> EmployeeDTO(List<EmployeeDTO> insertDTO, bool isupdate = false)
        {
            MainResponse<EmployeeDTO> response = new MainResponse<EmployeeDTO>();
            Errors<EmployeeDTO> err = new Errors<EmployeeDTO>();
            bool hasError = false;
            foreach (var employee in insertDTO)
            {
                var DBemployee = await ADO.GetExecuteQueryMySql<Models.Employee>($"select * from Employees  where InternalId = {employee.Name}");
                if (DBemployee.Count() > 0 && !isupdate)
                {
                    response.errors.Add(err.ObjectErrorInvExist(employee.Name.ToString()));
                    response.rejectedObjects.Add(employee);
                    hasError = true;
                    continue;
                }

                if (hasError)
                {
                    continue;
                }
                response.acceptedObjects.Add(employee);
            }
            return response;
        }

   
        public async static Task<MainResponse<UserDTO>> UserDTO(List<UserDTO> insertDTO, bool isupdate = false)
        {
            MainResponse<UserDTO> response = new MainResponse<UserDTO>();
            Errors<UserDTO> err = new Errors<UserDTO>();
            bool hasError = false;
            foreach (var user in insertDTO)
            {
                var DBuser = await ADO.GetExecuteQueryMySql<Models.User>($"select * from Users  where Name = '{user.Name}'");
                if (DBuser.Count() > 0 && !isupdate)
                {
                    response.errors.Add(err.ObjectErrorInvExist(user.Name));
                    response.rejectedObjects.Add(user);
                    hasError = true;
                    continue;
                }

                if (hasError)
                {
                    continue;
                }
                response.acceptedObjects.Add(user);
            }
            return response;
        }
    }

}
