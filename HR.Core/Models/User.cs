using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class User : Common
    {
        public string Name { set; get; }
        public string Password { set; get; }
        public string? Rights { set; get; }
        public int EmployeeId { set; get; }
        public Employee  Employee {set; get;}
        public int GroupRolId { set; get; }
        public GroupRol GroupRol { set; get; }
    }
}
