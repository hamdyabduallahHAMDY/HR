using HR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.DTO
{
    public class UserDTO : Common
    {
        public string internalId {  get; set; }
        public string Name { set; get; }
        public string Password { set; get; }
        public string? Rights { set; get; }
        public int EmployeeId { set; get; }
        public int GroupRolId { set; get; }
    }
}
