using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class Employee : Common
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public LeaveBalance LeaveBalance { get; set; }
        public string Certificates { get; set; }
        public Job Job { get; set; }
        public int JobId { get; set; }
        public EmploymentContract Employment { get; set; }
        public int EmploymentId { get; set; }
        
    }
}
